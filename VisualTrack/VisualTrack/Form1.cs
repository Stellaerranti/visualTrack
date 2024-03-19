using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VisualTrack
{
    public partial class Form1 : Form
    {
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

            UCaChart.ChartAreas[0].AxisX.Minimum = 0;
            UCaChart.ChartAreas[1].AxisX.Minimum = 0;
        }
        private double Calc_UCa_std(double U, double Ca, double U_std, double Ca_std)
        {
            // return (Ca*U_std+U*Ca_std)/(Ca*Ca);
            return (U / Ca) * Math.Sqrt((Ca_std / Ca) * (Ca_std / Ca) + (U_std / U) * (U_std / U));
        }

        private void DrawUCa(int N, double UCa,double UCa_std)
        {
            UCaChart.Series["UCaError"].Points.AddXY(N, UCa, UCa - UCa_std, UCa + UCa_std);
            UCaChart.Series["UCaSeries"].Points.AddXY(N,UCa);
            
        }

        private void readFile()
        {
            if (ImportZeta.ShowDialog() == DialogResult.Cancel) { return; }

            string filename = ImportZeta.FileName;
            int ni = 0;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);

                double UCa = 0;
                double UCa_std = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    ni = i;

                    if (lines[i].Length > 2)
                    {
                        while (lines[i].Contains("  ")) { lines[i] = lines[i].Replace("  ", " "); }
                        while (lines[i].Contains("\t\t")) { lines[i] = lines[i].Replace("\t\t", "\t"); }
                        while (lines[i].Contains("\t ")) { lines[i] = lines[i].Replace("\t ", "\t"); }
                        while (lines[i].Contains(" \t")) { lines[i] = lines[i].Replace(" \t", "\t"); }
                        while (lines[i].Contains(".")) { lines[i] = lines[i].Replace(".", ","); }

                        string[] line = lines[i].Split(new[] { ' ', '\t' });

                        UCa = Convert.ToDouble(line[1]) / Convert.ToDouble(line[3]);

                        UCa_std = Calc_UCa_std(Convert.ToDouble(line[1]), Convert.ToDouble(line[3]),
                            Convert.ToDouble(line[2]), Convert.ToDouble(line[4]));

                        //Name, U, U std, Ca, Ca std, Trcs, S, U/Ca, U/Ca std
                        zetaTable.Rows.Add(line[0], line[1], line[2], line[3],
                            line[4], line[5], line[6], UCa.ToString(), UCa_std.ToString());

                        DrawUCa(i+1,UCa,UCa_std);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error while reading file at line " + (ni + 1).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readFile();
        }
    }
}
