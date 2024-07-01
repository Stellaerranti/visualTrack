using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
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

        //Reading file
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

                        U = Convert.ToDouble(line[1], provider)*Settings.Default.U_dimension;
                        Ca = Convert.ToDouble(line[3], provider) * Settings.Default.Ca_dimension;

                        U_std = Convert.ToDouble(line[2], provider) * Settings.Default.U_dimension;
                        Ca_std = Convert.ToDouble(line[4], provider) * Settings.Default.Ca_dimension;

                        UCa = U / Ca;

                        //UCa_std = (Calc_UCa_std(U,Ca,U_std,Ca_std)/UCa)*(UCa* 1000000);
                        UCa_std = Calc_UCa_std(U, Ca, U_std, Ca_std); 
                        //UCa = UCa * 1000000;

                        //Name, U, U std, Ca, Ca std, Trcs, S, U/Ca, U/Ca std
                        zetaTable.Rows.Add(line[0], U.ToString("E3"), U_std.ToString("E3"), Ca.ToString("E3"), Ca_std.ToString("E3"),   
                            (Convert.ToDouble(line[5], provider) * Settings.Default.Tracks).ToString("E3"),
                            (Convert.ToDouble(line[6], provider) * Settings.Default.S).ToString("E3"),
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
            double third_bracket = ((DurAge_std*Math.Exp(DurAgeMa*yr1-1))/(DurAgeMa*Tracks/PW));

            return Math.Sqrt(Math.Pow(first_bracket, 2)+Math.Pow(second_bracket, 2)+Math.Pow(third_bracket,2));
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

        private void toolStripImport_Click(object sender, EventArgs e)
        {
            zetaTable.Rows.Clear();
            UCaChart.Series["UCaError"].Points.Clear();
            UCaChart.Series["UCaSeries"].Points.Clear();

            UCaChart.Series["UCaFlatError"].Points.Clear();
            UCaChart.Series["UCaFlat"].Points.Clear();

            UCaChart.Series["FittingLine"].Points.Clear();
            readFile();
            FlattUCa();
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

        private void ageImport_Click(object sender, EventArgs e)
        {
            
            
                 
        }
    }
}
