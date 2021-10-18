using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private EquilateralTriangle equilateralTriangle;
        private void button1_Click(object sender, EventArgs e)
        {
            if (equilateralTriangle != null)
            {
                OutPut.Text = "Perimetr         " + equilateralTriangle.PerimeterEquilateralTriangle() + " Square           " +
                equilateralTriangle.SquareEquilateralTriangle();
            }
            else
            {
                OutPut.Text = "Input not right";
            }
           
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                equilateralTriangle = new EquilateralTriangle(Convert.ToInt32(Input.Text));
            }
            catch (Exception ex)
            {
                OutPut.Text = ex.ToString();
            }
        }
    }
}
