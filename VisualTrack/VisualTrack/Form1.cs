﻿using System;
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

namespace VisualTrack
{
    public partial class Form1 : Form
    {
        public double zeta_value = 0;
        public double zetaErr_value = 0;

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

            UCaChart.Series["UCaFlatError"].MarkerColor = UCaChart.Series["UCaError"].MarkerColor;
            UCaChart.Series["UCaFlat"].MarkerColor = UCaChart.Series["UCaSeries"].MarkerColor;
            UCaChart.Series["UCaFlat"].MarkerImage = UCaChart.Series["UCaSeries"].MarkerImage;

            UCaChart.Series["FittingLine"].MarkerColor = Color.Red;

            UCaChart.ChartAreas[0].AxisX.Minimum = 0;
            UCaChart.ChartAreas[0].AxisY.Minimum = 0;
            //UCaChart.ChartAreas[0].AxisY.Title = "U/Ca";

            UCaChart.ChartAreas[1].AxisX.Minimum = 0;
            UCaChart.ChartAreas[1].AxisY.Minimum = 0;
            //UCaChart.ChartAreas[1].AxisY.Title = "U/Ca Flattened";
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

        private void FlattUCa()


        {
            double b = MSE_b();
            double a = MSE_a();
            int N = zetaTable.Rows.Count;
            int i = 1;

            SlopeLabel.Text = b.ToString("E3");
            InterseptLabel.Text = a.ToString("E3");

            UCaChart.Series["FittingLine"].Points.AddXY(0, a);
            UCaChart.Series["FittingLine"].Points.AddXY(N, a+b*N);

            foreach (DataGridViewRow row in zetaTable.Rows)
            {
                row.Cells["UCaFlat"].Value = (Double.Parse(row.Cells["UCa"].Value.ToString()) + ((N/2)-i+0.5)*b).ToString("E3");
                //UCaFlatStd
                row.Cells["UCaFlatStd"].Value = (Double.Parse(row.Cells["UCastd"].Value.ToString()) / Double.Parse(row.Cells["UCa"].Value.ToString())*Double.Parse(row.Cells["UCaFlat"].Value.ToString())).ToString("E3");
                DrawUCaFlatt(i, Double.Parse(row.Cells["UCaFlat"].Value.ToString()), 0);
                i++;
            }
        }

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

                        UCa_std = Calc_UCa_std(U,Ca,U_std,Ca_std);

                        //Name, U, U std, Ca, Ca std, Trcs, S, U/Ca, U/Ca std
                        zetaTable.Rows.Add(line[0], U.ToString("E3"), U_std.ToString("E3"), Ca.ToString("E3"), Ca_std.ToString("E3"),   
                            Convert.ToDouble(line[5], provider).ToString("E3"), Convert.ToDouble(line[6], provider).ToString("E3"),
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

        private double FindZeta(double UCa, double yr1,double DurAgeMa, double PW, double Tracks)
        {
            return PW * Math.Exp(yr1*DurAgeMa-1)/(Tracks*yr1);
        }

        private void ZetaCalc()
        {

        }

        //import file
        private void button1_Click(object sender, EventArgs e)
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
    }
}
