using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VisualTrack.Properties;


namespace VisualTrack
{
    public partial class Form1 : Form
    {
        public double zeta_value = 0;
        public double zetaErr_value = 0;

        public double durango_test_res = 0;
        public double durango_test_std = 0;

        public double conv_factor = 0;

        private double previous_U_dimensions = 1;
        private double previous_Ca_dimensions = 1;
        private double previous_S_dimensions = 1;
        private double previous_Tracks_dimensions = 1;

        options option_window;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            UCaChart.Series["UCaError"].Points.Clear();
            UCaChart.Series["UCaSeries"].Points.Clear();

            UCaChart.Series["UCaFlatError"].Points.Clear();
            UCaChart.Series["UCaFlat"].Points.Clear();

            UCaChart.Series["FittingLine"].Points.Clear();

            //UCaChart.Series["UCaFlatError"].MarkerColor = UCaChart.Series["UCaError"].MarkerColor;
            //UCaChart.Series["UCaFlat"].MarkerColor = UCaChart.Series["UCaSeries"].MarkerColor;
            //UCaChart.Series["UCaFlat"].MarkerImage = UCaChart.Series["UCaSeries"].MarkerImage;

            UCaChart.Series["FittingLine"].Color = Color.Red;           

            UCaChart.Series["UCaSeries"].Color = Color.Blue;
            UCaChart.Series["UCaError"].Color = Color.Orange;

            UCaChart.Series["UCaFlat"].MarkerStyle = MarkerStyle.Square;
            UCaChart.Series["UCaFlat"].Color = Color.Blue;
            UCaChart.Series["UCaFlatError"].Color = Color.Orange;

            

            UCaChart.ChartAreas[0].AxisX.Minimum = 0;
            UCaChart.ChartAreas[0].AxisY.Minimum = 0;
            //UCaChart.ChartAreas[0].AxisY.Title = "U/Ca";

            UCaChart.ChartAreas[1].AxisX.Minimum = 0;
            UCaChart.ChartAreas[1].AxisY.Minimum = 0;
            //UCaChart.ChartAreas[1].AxisY.Title = "U/Ca Flattened";

            option_window = new options(this);

            Settings.Default.S = 1;
            Settings.Default.Tracks = 1;

            Settings.Default.Ca_dimension = 1;
            Settings.Default.U_dimension = 1;
        }

        private double Calc_UCa_std(double U, double Ca, double U_std, double Ca_std)
        {
             return Math.Sqrt((U_std/Ca)* (U_std / Ca) + (U*Ca_std/(Ca*Ca))* (U * Ca_std / (Ca * Ca)));
            //return (U / Ca) * Math.Sqrt((Ca_std / Ca) * (Ca_std / Ca) + (U_std / U) * (U_std / U));
        }

        private void DrawUCa(int N, double UCa,double UCa_std)
        {
            UCaChart.Series["UCaError"].Points.AddXY(N, UCa, UCa - UCa_std, UCa + UCa_std);
            UCaChart.Series["UCaSeries"].Points.AddXY(N,UCa);
        }

        private void DrawUCaFlatt(int N, double UCaFlat, double UCa_Flat_std)
        {
            UCaChart.Series["UCaFlatError"].Points.AddXY(N, UCaFlat, UCaFlat - UCa_Flat_std, UCaFlat + UCa_Flat_std);
            UCaChart.Series["UCaFlat"].Points.AddXY(N, UCaFlat);

        }

        private double MSE_b()
        {
            double xy_sum = 0;
            double x_sum = 0;
            double y_sum = 0;
            double xsq_sum = 0;
            int N = 1;

            foreach (DataGridViewRow row in zetaTable.Rows)
            {
                x_sum += N;
                y_sum += Double.Parse(row.Cells["UCa"].Value.ToString());
                xsq_sum += N*N;
                xy_sum += Double.Parse(row.Cells["UCa"].Value.ToString()) * N;
                N += 1;
            }

            return (N*xy_sum-y_sum*x_sum)/(N*xsq_sum-x_sum*x_sum);
        }

        private double MSE_a()
        {
            double xy_sum = 0;
            double x_sum = 0;
            double y_sum = 0;
            double xsq_sum = 0;
            int N = 1;

            foreach (DataGridViewRow row in zetaTable.Rows)
            {
                x_sum += N;
                y_sum += Double.Parse(row.Cells["UCa"].Value.ToString());
                xsq_sum += N * N;
                xy_sum += Double.Parse(row.Cells["UCa"].Value.ToString()) * N;
                N += 1;
            }

            return (xsq_sum*y_sum-xy_sum*x_sum) / (N * xsq_sum - x_sum * x_sum);
        }

        //Flattering UCA chart
        private void FlattUCa()


        {
            double b = MSE_b();
            double a = MSE_a();
            int N = zetaTable.Rows.Count +1 ;
            int i = 1;

            SlopeLabel.Text = b.ToString("E3");
            InterseptLabel.Text = a.ToString("E3");

            UCaChart.Series["FittingLine"].Points.AddXY(0, a);
            UCaChart.Series["FittingLine"].Points.AddXY(N, a+b*N);

            foreach (DataGridViewRow row in zetaTable.Rows)
            {
                row.Cells["UCaFlat"].Value = (Double.Parse(row.Cells["UCa"].Value.ToString()) + ((N/2)-(i+1)+0.5)*b).ToString("E3");
                //UCaFlatStd
                row.Cells["UCaFlatStd"].Value = (Double.Parse(row.Cells["UCastd"].Value.ToString()) / Double.Parse(row.Cells["UCa"].Value.ToString())*Double.Parse(row.Cells["UCaFlat"].Value.ToString())).ToString("E3");
                DrawUCaFlatt(i, Double.Parse(row.Cells["UCaFlat"].Value.ToString()), Double.Parse(row.Cells["UCaFlatStd"].Value.ToString()));
                i++;
            }

        }

        //Reading files
        private void readFile()
        {
            if (ImportZeta.ShowDialog() == DialogResult.Cancel) { return; }

            string filename = ImportZeta.FileName;
            int ni = 0;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);

                fileLabel.Text = Path.GetFileName(filename);

                double U = 0;
                double Ca = 0;
                double U_std = 0;
                double Ca_std = 0;

                double UCa = 0;
                double UCa_std = 0;

                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                //Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

                for (int i = 0; i < lines.Length; i++)
                {
                    ni = i;

                    if (lines[i].Length > 2)
                    {
                        while (lines[i].Contains("  ")) { lines[i] = lines[i].Replace("  ", " "); }
                        while (lines[i].Contains("\t\t")) { lines[i] = lines[i].Replace("\t\t", "\t"); }
                        while (lines[i].Contains("\t ")) { lines[i] = lines[i].Replace("\t ", "\t"); }
                        while (lines[i].Contains(" \t")) { lines[i] = lines[i].Replace(" \t", "\t"); }
                        while (lines[i].Contains(",") ) { lines[i] = lines[i].Replace(",", "."); }                        

                        string[] line = lines[i].Split(new[] { ' ', '\t' });

                        U = Convert.ToDouble(line[1], provider);
                        Ca = Convert.ToDouble(line[3], provider);

                        U_std = Convert.ToDouble(line[2], provider);
                        Ca_std = Convert.ToDouble(line[4], provider);

                        UCa = U / Ca;

                        //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
                        UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std); 
                        //UCa = UCa * 1000000;

                        //Name, U, U std, Ca, Ca std, Trcs, S, U/Ca, U/Ca std
                        zetaTable.Rows.Add(line[0], U.ToString("F4"), U_std.ToString("F4"), Ca.ToString("E3"), Ca_std.ToString("E3"),   
                            (Convert.ToDouble(line[5], provider)).ToString(),
                            (Convert.ToDouble(line[6], provider)).ToString("E3"),
                            UCa.ToString("E3"), UCa_std.ToString("E3"), 0, 0, 0, 0);

                        DrawUCa(i+1,UCa,UCa_std);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error while reading file at line " + (ni + 1).ToString());
            }
        }

        private void readSampleFile()
        {
            if (ImportSample.ShowDialog() == DialogResult.Cancel) { return; }

            string filename = ImportSample.FileName;
            int ni = 0;
            try 
            {

                string[] lines = System.IO.File.ReadAllLines(filename);
                //fileLabel.Text = Path.GetFileName(filename);
                FileSampleLabel.Text = Path.GetFileName(filename);

                double U = 0;
                double Ca = 0;
                double U_std = 0;
                double Ca_std = 0;

                double UCa = 0;
                double UCa_std = 0;

                double N_sum = 0;

                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";

                for (int i = 0; i < lines.Length; i++)
                {
                    ni = i;

                    if (lines[i].Length > 2)
                    {
                        while (lines[i].Contains("  ")) { lines[i] = lines[i].Replace("  ", " "); }
                        while (lines[i].Contains("\t\t")) { lines[i] = lines[i].Replace("\t\t", "\t"); }
                        while (lines[i].Contains("\t ")) { lines[i] = lines[i].Replace("\t ", "\t"); }
                        while (lines[i].Contains(" \t")) { lines[i] = lines[i].Replace(" \t", "\t"); }
                        while (lines[i].Contains(",")) { lines[i] = lines[i].Replace(",", "."); }

                        string[] line = lines[i].Split(new[] { ' ', '\t' });

                        U = Convert.ToDouble(line[1], provider);
                        Ca = Convert.ToDouble(line[3], provider);

                        U_std = Convert.ToDouble(line[2], provider);
                        Ca_std = Convert.ToDouble(line[4], provider);

                        UCa = U / Ca;

                        //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
                        UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);
                        //UCa = UCa * 1000000;

                        N_sum = N_sum + Convert.ToDouble(line[5], provider);

                        AgeGrid.Rows.Add(line[0], (Convert.ToDouble(line[5], provider)).ToString(), (Convert.ToDouble(line[6], provider)).ToString("E3")
                            , U.ToString("F4"), U_std.ToString("F4"), Ca.ToString("E3"), Ca_std.ToString("E3"), UCa.ToString("E3"), UCa_std.ToString("E3"),0,0,0,0);


                    }
                    
                }
                GrainsLabel.Text = (ni).ToString();
                NsLabel.Text = (N_sum).ToString();


            } 
            catch 
            {
                MessageBox.Show("Error while reading file at line " + (ni + 1).ToString());
            }
        }

        private void readTestFile()
        {
            if (ImportTest.ShowDialog() == DialogResult.Cancel) { return; }

            string filename = ImportTest.FileName;
            int ni = 0;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);

                TestFileLabel.Text = Path.GetFileName(filename);
                double U = 0;
                double Ca = 0;
                double U_std = 0;
                double Ca_std = 0;

                double UCa = 0;
                double UCa_std = 0;

                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";

                for (int i = 0; i < lines.Length; i++)
                {
                    ni = i;

                    if (lines[i].Length > 2)
                    {
                        while (lines[i].Contains("  ")) { lines[i] = lines[i].Replace("  ", " "); }
                        while (lines[i].Contains("\t\t")) { lines[i] = lines[i].Replace("\t\t", "\t"); }
                        while (lines[i].Contains("\t ")) { lines[i] = lines[i].Replace("\t ", "\t"); }
                        while (lines[i].Contains(" \t")) { lines[i] = lines[i].Replace(" \t", "\t"); }
                        while (lines[i].Contains(",")) { lines[i] = lines[i].Replace(",", "."); }

                        string[] line = lines[i].Split(new[] { ' ', '\t' });

                        U = Convert.ToDouble(line[1], provider);
                        Ca = Convert.ToDouble(line[3], provider);

                        U_std = Convert.ToDouble(line[2], provider);
                        Ca_std = Convert.ToDouble(line[4], provider);

                        UCa = U / Ca;

                        //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
                        UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);

                        TestGrid.Rows.Add((i+1).ToString("F0"), 0,U.ToString("F4"), U_std.ToString("F4"),Ca.ToString("E3"),Ca_std.ToString("E3"),UCa.ToString("E3"),UCa_std.ToString("E3"),0,0);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error while reading file at line " + (ni + 1).ToString());
            }


        }
        

        //Main age calculation

        private void getWeighted()
        {
           
            foreach(DataGridViewRow row in AgeGrid.Rows)
            {
                row.Cells["Weighted"].Value = (conv_factor * Double.Parse(row.Cells["UCaDur"].Value.ToString())).ToString("E3");

                 row.Cells["Weightedstd"].Value = (conv_factor * Double.Parse(row.Cells["UCaDur"].Value.ToString()) * (
                    (Double.Parse(row.Cells["UCastdDur"].Value.ToString())/ Double.Parse(row.Cells["UCaDur"].Value.ToString()))+ durango_test_std)).ToString("E3");


            }
        }

        private double getPW()
        {
            double PW = 0;
           

            double PW_sum = 0;

            foreach (DataGridViewRow row in AgeGrid.Rows)
            {
                //part for PW
                PW = Double.Parse(row.Cells["Weighted"].Value.ToString()) * Double.Parse(row.Cells["SAge"].Value.ToString());

                PW_sum = PW_sum + PW;

            }



            PWLabel.Text = PW_sum.ToString("E3");

            return PW_sum;
        }

        private double getPWSTD()
        {
            double PW_std = 0;
            double PW_std_sum = 0;

            foreach (DataGridViewRow row in AgeGrid.Rows)
            {

                // PW_std = Math.Sqrt(Double.Parse(row.Cells["Weighted"].Value.ToString()) * Double.Parse(row.Cells["SAge"].Value.ToString())
                //   * Double.Parse(row.Cells["Weighted"].Value.ToString()) * Double.Parse(row.Cells["SAge"].Value.ToString()));
                PW_std = Double.Parse(row.Cells["Weightedstd"].Value.ToString()) * Double.Parse(row.Cells["SAge"].Value.ToString());
                PW_std_sum = PW_std_sum + PW_std * PW_std;
            }


            PW_std_sum = Math.Sqrt(PW_std_sum);
            PWStdLabel.Text = PW_std_sum.ToString("E3");

            return PW_std_sum;
        }

        private void getFTage()
        {
            try
            {

                double Ns = 0;
                double S = 0;
                double Weighted = 0;
                double Weighted_std = 0;

                double FT = 0;
                double FT_std = 0;

                double yr1 = Double.Parse(yr1Text.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

                foreach (DataGridViewRow row in AgeGrid.Rows)
                {
                    //part for FT

                    Ns = Double.Parse(row.Cells["NAge"].Value.ToString());
                    S = Double.Parse(row.Cells["SAge"].Value.ToString());
                    Weighted = Double.Parse(row.Cells["Weighted"].Value.ToString());
                    Weighted_std = Double.Parse(row.Cells["Weightedstd"].Value.ToString());

                    if (Ns == 0)
                    {
                        FT = (1 / yr1)*Math.Log(1+(1 / yr1)*zeta_value*(Weighted/(S*Weighted_std*Weighted_std))*(0.5/((Weighted/Weighted_std)* (Weighted / Weighted_std) + 0.5))) / 1000000;

                        FT_std = FT*Math.Sqrt(8+1/((Weighted / Weighted_std)* (Weighted / Weighted_std) + 0.5)+(zetaErr_value/zeta_value)* (zetaErr_value / zeta_value));
                    }
                    else
                    {
                        FT = (1 / yr1) * Math.Log(1+(yr1*zeta_value*(Ns/S)/Weighted))/ 1000000;

                        FT_std = FT*Math.Sqrt(4/Ns+(Weighted_std/Weighted)* (Weighted_std / Weighted) + (zetaErr_value / zeta_value) * (zetaErr_value / zeta_value));
                    }

                    row.Cells["FT"].Value = FT.ToString("F4");
                    row.Cells["sigma"].Value=FT_std.ToString("F4");

                }
            }
            catch { }

        }

        private void poolAge(double PW, double PW_std)
        {
            double yr1 = Double.Parse(yr1Text.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            //double PW = Double.Parse(PWLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            //double PW_std = Double.Parse(PWStdLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            double Ns = Double.Parse(NsLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

            double age = (1 / yr1) * Math.Log(1 + (yr1 * zeta_value * Ns / PW)) / 1000000;
            //double age = (1 / 1.55) * Math.Log(1 + (yr1 * zeta_value * Ns / PW)) * 10000;
            double age_std = age * Math.Sqrt((4 / Ns) + Math.Pow((PW_std / PW),2) + Math.Pow((zetaErr_value / zeta_value),2));

            PooledAgeLabel.Text = age.ToString();
            AgeStdLabel.Text = (age_std).ToString();
        }

        private void AgeCalcutation()
        {
            if ((AgeGrid.Rows.Count>1) && (CheckZetaInput()) && (TestGrid.Rows.Count > 1)
                && (zetaTable.Rows.Count > 1) && (Double.TryParse(ZetaAgeLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err)))
            {
                getWeighted();
                double PW = getPW();
                double PW_std = getPWSTD();
                getFTage();
                poolAge(PW, PW_std);
                chiSq();
            }
        }


        //Chi square calculation

        private void chiSq()
        {
            double br_sq = 0;
            double br_sq_sum = 0;

            double ratio = 0;
            double ratio_sum = 0;

            double sigm = 0; ;
            double sigm_sum = 0;

            double Ns = 0;
            double S = 0;

            double FT = 0;
            double FT_std = 0;

            double UCa = 0;
            double UCa_std = 0;

            double Chi = 0;

            foreach (DataGridViewRow row in AgeGrid.Rows)
            {
                Ns = Double.Parse(row.Cells["NAge"].Value.ToString());
                S = Double.Parse(row.Cells["SAge"].Value.ToString());

                FT = Double.Parse(row.Cells["FT"].Value.ToString());
                FT_std = Double.Parse(row.Cells["sigma"].Value.ToString());

                UCa = Double.Parse(row.Cells["UCaDur"].Value.ToString());
                UCa_std = Double.Parse(row.Cells["UCastdDur"].Value.ToString());

                if (Ns == 0) 
                {
                    br_sq = (Math.Sqrt(FT)/(FT_std/(2*Math.Sqrt(FT)))) * (Math.Sqrt(FT) / (FT_std / (2 * Math.Sqrt(FT))));

                    ratio = Math.Sqrt(FT) / Math.Pow(FT_std / (2 * Math.Sqrt(FT)), 2);

                    sigm = 1 / Math.Pow(FT_std / (2 * Math.Sqrt(FT)), 2);
                }
                else
                {
                    br_sq = Math.Pow(Math.Log(FT)/Math.Sqrt((1/Ns) + Math.Pow(UCa_std/UCa/2,2)), 2);

                    ratio = Math.Log(FT)/Math.Pow(Math.Sqrt((1 / Ns) + Math.Pow(UCa_std / UCa/2, 2)), 2);

                    sigm = 1 / Math.Pow(Math.Sqrt((1 / Ns) + Math.Pow(UCa_std / UCa / 2, 2)), 2);
                }

                br_sq_sum = br_sq_sum + br_sq;

                ratio_sum = ratio_sum + ratio;  

                sigm_sum = sigm_sum + sigm;

            }

            Chi = br_sq_sum - Math.Pow(ratio_sum, 2)/ sigm_sum;

            ChiLabel.Text = Chi.ToString(); 

            PLabel.Text = Pchisq(Chi,AgeGrid.Rows.Count-1).ToString();

        }

        //Number of functions for P of chisq. NOT MY CODE

        private double Pchisq(double Cv,int Dof)
        {
            if (Cv < 0 || Dof < 1)
            {
                return 0.0;
            }
            double K = ((double)Dof) * 0.5;
            double X = Cv * 0.5;
            if (Dof == 2)
            {
                return Math.Exp(-1.0 * X);
            }

            double PValue = igf(K, X);
            if (Double.IsNaN(PValue) || Double.IsInfinity (PValue) || PValue <= 1e-8 || 1 - PValue < 0)
            {
                return 1e-14;
            }

            PValue /= approx_gamma(K);
            //PValue /= tgamma(K); 

           /* if (1.0 - PValue < 0)
            {
                return 0;
            }*/

            return (1.0 - PValue);
        }

        private double igf(double S, double Z)
        {
            if (Z < 0.0)
            {
                return 0.0;
            }
            double Sc = (1.0 / S);
            Sc *= Math.Pow(Z, S);
            Sc *= Math.Exp(-Z);

            double Sum = 1.0;
            double Nom = 1.0;
            double Denom = 1.0;

            for (int I = 0; I < 200; I++)
            {
                Nom *= Z;
                S++;
                Denom *= S;
                Sum += (Nom / Denom);
            }

            return Sum * Sc;
        }

        private double approx_gamma(double Z)
        {
            const double RECIP_E = 0.36787944117144232159552377016147;  // RECIP_E = (E^-1) = (1.0 / E)
            const double TWOPI = 6.283185307179586476925286766559;  // TWOPI = 2.0 * PI

            double D = 1.0 / (10.0 * Z);
            D = 1.0 / ((12 * Z) - D);
            D = (D + Z) * RECIP_E;
            D = Math.Pow(D, Z);
            D *= Math.Sqrt(TWOPI / Z);

            return D;
        }

        /*
        private double  gamma(double N)
        {
             double SQRT2PI = 2.5066282746310005024157652848110452530069867406099383;

             double Z = ( double)N;
             double Sc = powl((Z + A), (Z + 0.5));
            Sc *= expl(-1.0 * (Z + A));
            Sc /= Z;

             double F = 1.0;
             double Ck;
             double Sum = SQRT2PI;


            for (int K = 1; K < A; K++)
            {
                Z++;
                Ck = powl(A - K, K - 0.5);
                Ck *= expl(A - K);
                Ck /= F;

                Sum += (Ck / Z);

                F *= (-1.0 * K);
            }

            return (double)(Sum * Sc);
        }*/

        //This 4 functions for durango testing

        private void getRaw()
        {
            try {
                int i = 0;
               foreach (DataGridViewRow row in TestGrid.Rows) 
                {
                    if (Double.TryParse(zetaTable.Rows[i].Cells["UCaFlat"].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err))
                    {
                        row.Cells["rawUCaTest"].Value = (Double.Parse(zetaTable.Rows[i].Cells["UCaFlat"].Value.ToString())* 132.704).ToString("E4");
                        i++;
                    }
                    else
                    {
                        break;
                    }             
                }
            }
            catch { }
        }

        private void getConvFactor()
        {
            try
            {
                double raw_mean = 0;
                double mean = 0;

                foreach(DataGridViewRow row in TestGrid.Rows)
                {
                    raw_mean = raw_mean + Double.Parse(row.Cells["rawUCaTest"].Value.ToString());
                    mean = mean + Double.Parse(row.Cells["UCaTest"].Value.ToString());
                }

                raw_mean = raw_mean/TestGrid.Rows.Count;
                mean = mean/TestGrid.Rows.Count;

                RawTestLabel.Text = raw_mean.ToString();
                UCaTestLabel.Text = mean.ToString();

                conv_factor = raw_mean / mean;

                ConvFactorLabel.Text = (conv_factor).ToString();
            }
            catch { }
        }

        private void conductTest()
        {

            try
            {
                double test = 0;
                double test_mean = 0;
                double convUCa = 0;

                foreach (DataGridViewRow row in TestGrid.Rows)
                {
                    convUCa = Double.Parse(row.Cells["UCaTest"].Value.ToString()) * Double.Parse(ConvFactorLabel.Text);

                    test = convUCa / Double.Parse(row.Cells["rawUCaTest"].Value.ToString());

                    row.Cells["ConvUCaTest"].Value = convUCa.ToString();

                    row.Cells["TestDur"].Value = test.ToString();

                    test_mean = test_mean + test;
                }
                durango_test_res = test_mean / TestGrid.Rows.Count;
                TestLabel.Text = durango_test_res.ToString();

                double s = 0;

                foreach (DataGridViewRow row in TestGrid.Rows)
                {
                    s = (Double.Parse(row.Cells["TestDur"].Value.ToString()) - durango_test_res) * (Double.Parse(row.Cells["TestDur"].Value.ToString()) - durango_test_res);
                }

                durango_test_std = Math.Sqrt(s/(TestGrid.Rows.Count-1));

                TestStdLabel.Text = durango_test_std.ToString();

                ConvStdLabel.Text = (Double.Parse(ConvFactorLabel.Text)* durango_test_std).ToString();
            }
            catch { }
        }

        private void testDurango()
        {
            if ((TestGrid.Rows.Count > 1) && (zetaTable.Rows.Count > 1))
            {
                getRaw();
                getConvFactor();
                conductTest();
            }
        }

        //reading from Data grid and plotting charts

        private void update()
        {
            

            foreach (DataGridViewRow row in zetaTable.Rows)
            {
                DrawUCa(row.Index + 1, Double.Parse(row.Cells["UCa"].Value.ToString()), Double.Parse(row.Cells["UCastd"].Value.ToString()));

            }
        }

        private bool CheckZetaInput()
        {
            if (!Double.TryParse(DurangoAgeText.Text, NumberStyles.Any,  CultureInfo.InvariantCulture, out double check_age))
            {
                return false;
            }
            else if (!Double.TryParse(DurangoErrText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err))
            {
                return false;
            }
            else if (!Double.TryParse(yr1Text.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_yr1))
            {
                return false;
            }

            else
            {
               return true;
            }
        }

        private double FindZeta(double yr1,double DurAgeMa, double PW, double Tracks)
        {
            return PW * (Math.Exp(yr1* 1000000 * DurAgeMa)-1)/(Tracks*yr1);
        }
        
        private double ZetaSTD(double zeta, double yr1, double DurAgeMa, double DurAge_std, double PW, double PW_std, double Tracks)
        {
            double first_bracket = zeta * zeta * 4 / Tracks;
            double second_bracket = (zeta * PW_std / PW);
            double third_bracket = ((DurAge_std/ DurAgeMa * Math.Exp(DurAgeMa*yr1-1))/(Tracks/PW));

            return Math.Sqrt(first_bracket + Math.Pow(second_bracket, 2)+Math.Pow(third_bracket,2));
        }

        private void ZetaCalc()
        {
            double PW = 0;
            double PW_sum = 0;

            double PW_std = 0;
            double PW_std_sum = 0;

            double Track = 0;
            double Track_sum = 0;

            double DurangoAge = Double.Parse(DurangoAgeText.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            double DurangoErr = Double.Parse(DurangoErrText.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            double yr1 = Double.Parse(yr1Text.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

            double S_sum = 0;
            
            if((yr1 == 0) || (DurangoAge == 0) || (DurangoErr == 0))
            {
                return;
            }
          
            foreach (DataGridViewRow row in zetaTable.Rows)
            {

                //row.Cells["UCaFlat"].Value
                
                PW = Double.Parse(row.Cells["UCaFlat"].Value.ToString())*132.704 * Double.Parse(row.Cells["S"].Value.ToString());
                Track = Double.Parse(row.Cells["Trs"].Value.ToString());

                PW_std = PW*Double.Parse(row.Cells["UCaFlatStd"].Value.ToString())/ Double.Parse(row.Cells["UCaFlat"].Value.ToString());

                row.Cells["Zeta_Col"].Value = FindZeta(yr1,DurangoAge,PW, Track);

                row.Cells["Zeta_col_std"].Value = ZetaSTD(FindZeta(yr1, DurangoAge, PW, Track),
                    yr1, DurangoAge, DurangoErr, PW, PW_std, Track);

                S_sum += Double.Parse(row.Cells["S"].Value.ToString());
                Track_sum += Track;
                PW_sum += PW;
                PW_std_sum += PW_std * PW_std;
            }

            PW_std_sum = Math.Sqrt(PW_std_sum);

            zeta_value = FindZeta(yr1, DurangoAge, PW_sum, Track_sum);
            zetaErr_value = ZetaSTD(zeta_value,yr1,DurangoAge,DurangoErr,PW_sum,PW_std_sum,Track_sum);

            zetaLabel.Text = zeta_value.ToString();
            zetaErrLabel.Text = zetaErr_value.ToString();


            ZetaAgeLabel.Text = zeta_value.ToString();
            ZetaStdAgeLAbel.Text = zetaErr_value.ToString();

            AgeCalcutation();

        }

        //Dead function
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void DurangoAgeText_TextChanged(object sender, EventArgs e)
        {
            if(CheckZetaInput())
            {
                ZetaCalc();
            }
        }

        private void DurangoErrText_TextChanged(object sender, EventArgs e)
        {
            if (CheckZetaInput())
            {
                ZetaCalc();
            }
        }

        private void yr1Text_TextChanged(object sender, EventArgs e)
        {
            if (CheckZetaInput())
            {
                ZetaCalc();
            }
        }


        private void optiondButton_Click(object sender, EventArgs e)
        {            
            option_window.Show();
        }

        //Currently offline
        public void optionsChanged()
        {
            try
            {
                double U = 0;
                double Ca = 0;
                double U_std = 0;
                double Ca_std = 0;

                double UCa = 0;
                double UCa_std = 0;

                int i = 0;

                UCaChart.Series["UCaError"].Points.Clear();
                UCaChart.Series["UCaSeries"].Points.Clear();

                UCaChart.Series["UCaFlatError"].Points.Clear();
                UCaChart.Series["UCaFlat"].Points.Clear();

                UCaChart.Series["FittingLine"].Points.Clear();

                foreach (DataGridViewRow row in zetaTable.Rows)
                {              

                    U = Convert.ToDouble(row.Cells["U"].Value);
                    Ca = Convert.ToDouble(row.Cells["Ca"].Value);

                    U_std = Convert.ToDouble(row.Cells["U_std"].Value);
                    Ca_std = Convert.ToDouble(row.Cells["Ca_std"].Value);

                    if (previous_U_dimensions != Settings.Default.U_dimension)
                    {
                        U = U * Settings.Default.U_dimension;
                        U_std = U_std * Settings.Default.U_dimension;
                        row.Cells["U"].Value = U;
                        row.Cells["U_std"].Value = U_std;                        
                    }
                    if(previous_Ca_dimensions != Settings.Default.Ca_dimension)
                    {
                        Ca = Ca * Settings.Default.Ca_dimension;
                        Ca_std = Ca_std * Settings.Default.Ca_dimension;

                        row.Cells["Ca"].Value = Ca;
                        row.Cells["Ca_std"].Value = Ca_std;                       
                    }
                    if(previous_S_dimensions != Settings.Default.S)
                    {
                        row.Cells["S"].Value = Double.Parse(row.Cells["S"].Value.ToString()) * Settings.Default.S;
                    }
                    if(previous_Tracks_dimensions !=  Settings.Default.Tracks) 
                    {
                        row.Cells["Trs"].Value = Double.Parse(row.Cells["Trs"].Value.ToString()) * Settings.Default.Tracks;

                    }                    

                    UCa = U / Ca;

                    UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);

                    row.Cells["UCa"].Value = UCa;
                    row.Cells["UCastd"].Value = UCa_std;

                    DrawUCa(i + 1, UCa, UCa_std);
                    i++;
                }

                FlattUCa();

                if (previous_U_dimensions != Settings.Default.U_dimension)
                {previous_U_dimensions = Settings.Default.U_dimension;}
                if (previous_Ca_dimensions != Settings.Default.Ca_dimension)
                {previous_Ca_dimensions = Settings.Default.Ca_dimension;}
                if (previous_S_dimensions != Settings.Default.S)
                { previous_S_dimensions = Settings.Default.S; }
                if (previous_Tracks_dimensions != Settings.Default.Tracks)
                { previous_Tracks_dimensions = Settings.Default.Tracks; }

                DurangoAgeText_TextChanged(new object(), new EventArgs());
                DurangoErrText_TextChanged(new object(), new EventArgs());
                yr1Text_TextChanged(new object(), new EventArgs());

            }
            catch { }
        }

        private void calculateZeta_Click(object sender, EventArgs e)
        {
            if (CheckZetaInput())
            {
                ZetaCalc();
            }
        }


        //Import file for Zeta session
        private void importZetaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zetaTable.Rows.Clear();
            UCaChart.Series["UCaError"].Points.Clear();
            UCaChart.Series["UCaSeries"].Points.Clear();

            UCaChart.Series["UCaFlatError"].Points.Clear();
            UCaChart.Series["UCaFlat"].Points.Clear();

            UCaChart.Series["FittingLine"].Points.Clear();
            readFile();
            FlattUCa();
            testDurango();
            AgeCalcutation();

            if (CheckZetaInput())
            {
                ZetaCalc();
            }
        }


        //Import files for durango calculations

        private void importTestFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGrid.Rows.Clear();

            readTestFile();
            testDurango();
            AgeCalcutation();


        }
        //Import file for Age session
        private void importSampleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgeGrid.Rows.Clear();
            readSampleFile();
            AgeCalcutation();
        }

        //Get conv factor
        private void conductTestButton_Click(object sender, EventArgs e)
        {
            testDurango();
            AgeCalcutation();
        }
        //Get age
        private void poolAgeButton_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(ZetaAgeLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err))
                { MessageBox.Show("No Zeta"); }
            else if(!Double.TryParse(ConvFactorLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err_2))
            { MessageBox.Show("No conversion factor"); }
            else if (AgeGrid.Rows.Count < 1)
            { MessageBox.Show("No sample data"); }
            else { AgeCalcutation(); }
            
        }


        //Deleting rows
        private void DeleteRowTestGrid_Click(object sender, EventArgs e)
        {
            TestGrid.Rows.RemoveAt(TestGrid.CurrentCell.RowIndex);
            testDurango();
            AgeCalcutation();
        }
        private void deleteRow_Click(object sender, EventArgs e)
        {
            try
            {

                zetaTable.Rows.RemoveAt(zetaTable.CurrentCell.RowIndex);

                UCaChart.Series["UCaError"].Points.Clear();
                UCaChart.Series["UCaSeries"].Points.Clear();

                UCaChart.Series["UCaFlatError"].Points.Clear();
                UCaChart.Series["UCaFlat"].Points.Clear();

                UCaChart.Series["FittingLine"].Points.Clear();

                update();

                FlattUCa();

                if (CheckZetaInput())
                {
                    ZetaCalc();
                }
            }
            catch { }
        }

        private void DeleteRowAgeGrid_Click(object sender, EventArgs e)
        {
            AgeGrid.Rows.RemoveAt(AgeGrid.CurrentCell.RowIndex);

            AgeCalcutation();
        }
        
        //Updating rows

        private void ZetaGridRowUpdate()
        {
            double U = Double.Parse(zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["U"].Value.ToString());

            double Ca = Double.Parse(zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["Ca"].Value.ToString());
            double U_std = Double.Parse(zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["U_std"].Value.ToString()); 
            double Ca_std = Double.Parse(zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["Ca_std"].Value.ToString()); 

            double UCa = U / Ca; ;
            double UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);

            //row.Cells["UCaFlat"].Value = (Double.Parse(row.Cells["UCa"].Value.ToString()) + ((N/2)-(i+1)+0.5)*b).ToString("E3");


            zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["UCa"].Value = UCa.ToString("E3");
            zetaTable.Rows[zetaTable.CurrentRow.Index].Cells["UCastd"].Value = UCa_std.ToString("E3");

        }

        private void ZetaGridUpdate()
        {
            try
            {

                UCaChart.Series["UCaError"].Points.Clear();
                UCaChart.Series["UCaSeries"].Points.Clear();

                UCaChart.Series["UCaFlatError"].Points.Clear();
                UCaChart.Series["UCaFlat"].Points.Clear();

                UCaChart.Series["FittingLine"].Points.Clear();

                update();

                FlattUCa();

                if (CheckZetaInput())
                {
                    ZetaCalc();
                }
            }
            catch { }
        }

        //Изменение данных в таблице теста
        private void TestGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Изменение данных в таблице возраста
        private void AgeGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Изменение данных в таблице зета
        private void zetaTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void zetaTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((zetaTable.CurrentCell.ColumnIndex > 6) && (zetaTable.CurrentCell.ColumnIndex < 9))
            {
                ZetaGridUpdate();
            }
            else if ((zetaTable.CurrentCell.ColumnIndex < 9))
            {
                ZetaGridRowUpdate();
                ZetaGridUpdate();
            }
            else
            {

                double b = MSE_b();
                double a = MSE_a();
                int N = zetaTable.Rows.Count + 1;
                int i = 1;

                UCaChart.Series["UCaError"].Points.Clear();
                UCaChart.Series["UCaSeries"].Points.Clear();

                UCaChart.Series["UCaFlatError"].Points.Clear();
                UCaChart.Series["UCaFlat"].Points.Clear();

                UCaChart.Series["FittingLine"].Points.Clear();

                UCaChart.Series["FittingLine"].Points.AddXY(0, a);
                UCaChart.Series["FittingLine"].Points.AddXY(N, a + b * N);

                update();

                foreach (DataGridViewRow row in zetaTable.Rows)
                {
                    DrawUCaFlatt(i, Double.Parse(row.Cells["UCaFlat"].Value.ToString()), Double.Parse(row.Cells["UCaFlatStd"].Value.ToString()));
                    i++;
                }

                if (CheckZetaInput())
                {
                    ZetaCalc();
                }
            }
        }

        private void TestGridRowUpdate()
        {
            double U = Double.Parse(TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[1].Value.ToString());
            double U_std = Double.Parse(TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[2].Value.ToString());
            double Ca = Double.Parse(TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[3].Value.ToString());
            double Ca_std = Double.Parse(TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[4].Value.ToString());

            double  UCa = U / Ca;

            //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
            double UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);

            TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[5].Value = UCa.ToString("E3");
            TestGrid.Rows[TestGrid.CurrentRow.Index].Cells[6].Value = UCa_std.ToString("E3");
        }

        private void TestGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(TestGrid.CurrentCell.ColumnIndex == 1)
            {
                if ((TestGrid.Rows.Count > 1) && (zetaTable.Rows.Count > 1))
                {                   
                    getConvFactor();
                    conductTest();
                }
                AgeCalcutation();
            }
            else if(TestGrid.CurrentCell.ColumnIndex > 1 && TestGrid.CurrentCell.ColumnIndex < 6)
            {
                TestGridRowUpdate();
                if ((TestGrid.Rows.Count > 1) && (zetaTable.Rows.Count > 1))
                {
                    getConvFactor();
                    conductTest();
                }
                AgeCalcutation();
            }
            else
            {
                if ((TestGrid.Rows.Count > 1) && (zetaTable.Rows.Count > 1))
                {
                    getConvFactor();
                    conductTest();
                }
                AgeCalcutation();
            }
            
        }

        private void AgeGridRowUpdate()
        {
            double U = Double.Parse(AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[3].Value.ToString());
            double U_std = Double.Parse(AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[4].Value.ToString());
            double Ca = Double.Parse(AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[5].Value.ToString());
            double Ca_std = Double.Parse(AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[6].Value.ToString());

            double UCa = U / Ca;

            //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
            double UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std);

            AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[7].Value = UCa.ToString("E3");
            AgeGrid.Rows[AgeGrid.CurrentRow.Index].Cells[8].Value = UCa_std.ToString("E3");

        }

        private void AgeGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (AgeGrid.CurrentCell.ColumnIndex < 3)
            {
                AgeCalcutation();
            }
            else if (AgeGrid.CurrentCell.ColumnIndex < 7)
            {
                AgeGridRowUpdate();
                AgeCalcutation();
            }
            else
            {
                if ((AgeGrid.Rows.Count > 1) && (CheckZetaInput()) && (TestGrid.Rows.Count > 1)
                        && (zetaTable.Rows.Count > 1) && (Double.TryParse(ZetaAgeLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_err)))
                {
                    //getWeighted();
                    double PW = getPW();
                    double PW_std = getPWSTD();
                    getFTage();
                    poolAge(PW, PW_std);
                    chiSq();
                }
            }
            
        }
    }
}
