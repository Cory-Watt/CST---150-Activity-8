using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateFatCarb_Click(object sender, EventArgs e)
        {
            int fatG = FatCalories(int.Parse(fatGrams.Text));
            int carbG = CarbCalories(int.Parse(carbGrams.Text));

            calFromFat.Text = fatG.ToString();
            calFromCarb.Text = carbG.ToString();
        }

        public static int FatCalories(int fatGrams)
        {
            return fatGrams * 4;
        }
        public static int CarbCalories(int carbGrams)
        {
            return carbGrams * 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fatGrams.Clear();
            carbGrams.Clear();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}