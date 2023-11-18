using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Grading ID:R2235
//Lab number:2
//Due Date: 2/6/2022
// Course: CIS 199-02
//Tip calucaltor, enter your price of meal and the calculator will display tips at 15%,18%, and 20%
namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double TIPRATE1 = 0.15;//Tiprate 1 is a constant double of 0.15 because it stays the same
            const double TIPRATE2 = 0.18;//Tiprate 2 is a constant double of 0.18 because it stays the same
            const double TIPRATE3 = 0.20;//Tiprate 2 is a constant double of 0.20 because it stays the same
            double enterPriceofMeal;//Variable for the price of the meal
           

            enterPriceofMeal = double.Parse(textBox1.Text);//price of meal (double) comes from the text box (string) which is converted to a Parse in order to store the variable
            
            textBox2.Text =(TIPRATE1* enterPriceofMeal).ToString("c");//Price of meal with 15% tip
            textBox3.Text = (TIPRATE2 * enterPriceofMeal).ToString("c");// Price of meal with 18% tip
            textBox4.Text = (TIPRATE3 * enterPriceofMeal).ToString("c");// Price of meal with 20% tip

        }
    }
}
