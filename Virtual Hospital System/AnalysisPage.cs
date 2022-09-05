using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class AnalysisPage : Form
    {
        public Button backPageButton = new Button();
        public AnalysisPage()
        {
            InitializeComponent();
        }

        private void backPic_Click(object sender, EventArgs e)
        {
            backPageButton.PerformClick();
        }

        private void AnalysisPage_Load(object sender, EventArgs e)
        {
            graphic();
            graphic2();
            graphic3();
        }
        //grafikleri cizdirir
        public void graphic()//euro ve dolar graifklerini ciziyor
        {

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 10, 20, 2, 16, 45 },
                ScalesYAt = 0
            });
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 1, 55, 63, 66, 70, 78 },
                ScalesYAt = 1
            });
            //now we add the 3 axes

            cartesianChart1.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Title = "BUYİNG"
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.IndianRed,
                Title = "SELLİNG",
                Position = AxisPosition.RightTop
            });
        }
        private void graphic2()
        {
            pieChart1.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 50},
                ScalesYAt = 0
            });
            pieChart1.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 120},
                ScalesYAt = 0
            });
            pieChart1.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 20 },
                ScalesYAt = 0
            });
            //now we add the 3 axes

            pieChart1.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Title = "Erkek"
            });
            pieChart1.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.IndianRed,
                Title = "Kadın",
                Position = AxisPosition.LeftBottom
            });
            pieChart1.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Aqua,
                Title = "Diğer",
                Position = AxisPosition.RightTop
            });
        }
        private void graphic3()
        {
            pieChart2.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 80 },
                ScalesYAt = 0
            });
            pieChart2.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 20 },
                ScalesYAt = 0
            });
            pieChart2.Series.Add(new PieSeries
            {
                Values = new ChartValues<double> { 130 },
                ScalesYAt = 0
            });
            //now we add the 3 axes

            pieChart2.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Title = "Erkek"
            });
            pieChart2.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.IndianRed,
                Title = "Kadın",
                Position = AxisPosition.LeftBottom
            });
            pieChart2.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Aqua,
                Title = "Diğer",
                Position = AxisPosition.RightTop
            });
        }
    }
}
