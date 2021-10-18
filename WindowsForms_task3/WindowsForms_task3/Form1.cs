using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IsoscelesTriangle eIsoscelesTriangle;
        private void button1_Click(object sender, EventArgs e)
        {
            if (eIsoscelesTriangle != null)
            {
                OUTPUT1.Text = "Perimetr: " + eIsoscelesTriangle.Perimeter() + " Square: " +
                eIsoscelesTriangle.Area();
            }
            else
            {
                OUTPUT1.Text = "Input correct side";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eIsoscelesTriangle = new IsoscelesTriangle( Convert.ToInt32(Input1.Text), Convert.ToInt32(Input1.Text));
            }
            catch (Exception ex)
            {
                OUTPUT1.Text = ex.ToString();
            }
        }
        private RectangularTriangle eRectangularTriangle;
        private void button2_Click(object sender, EventArgs e)
        {
            if (eRectangularTriangle != null)
            {
                OUTPUT2.Text = "Perimetr: " + eRectangularTriangle.Perimeter() + " Square: " +
                eRectangularTriangle.Area();
            }
            else
            {
                OUTPUT2.Text = "Input correct side";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eRectangularTriangle = new RectangularTriangle( Convert.ToInt32(Input2.Text), Convert.ToInt32(Input2.Text));
            }
            catch (Exception ex)
            {
                OUTPUT2.Text = ex.ToString();
            }
        }
    }
}
