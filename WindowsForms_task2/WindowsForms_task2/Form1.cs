using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private Triangle eTriangle;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eTriangle = new Triangle(Convert.ToInt32(Input1.Text), Convert.ToInt32(Input1.Text), Convert.ToInt32(Input1.Text));
            }
            catch (Exception ex)
            {
                OUTPUT1.Text = ex.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (eTriangle != null)
            {
                OUTPUT1.Text = "Perimetr: " + eTriangle.Perimeter() + " Square: " +
                eTriangle.Area();
            }
            else
            {
                OUTPUT1.Text = "Input correct side";
            } 
        }
        private Circle eCircle;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eCircle = new Circle(Convert.ToInt32(Input2.Text));
            }
            catch (Exception ex)
            {
                OUTPUT2.Text = ex.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (eCircle != null)
            {
                OUTPUT2.Text = "Perimetr: " + eCircle.Perimeter() + " Square: " +
                eCircle.Area();
            }
            else
            {
                OUTPUT2.Text = "Input correct side";
            } 
        }
        private Rectangle eRectangle;
        private void Input3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eRectangle = new Rectangle(Convert.ToInt32(Input3.Text),Convert.ToInt32(Input3.Text));
            }
            catch (Exception ex)
            {
                OUTPUT3.Text = ex.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (eRectangle != null)
            {
                OUTPUT3.Text = "Perimetr: " + eRectangle.Perimeter() + " Square: " +
               eRectangle.Area();
            }
            else
            {
                OUTPUT3.Text = "Input correct side";
            }
        }
        private Square eSquare;
        private void Input4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eSquare = new Square(Convert.ToInt32(Input4.Text));
            }
            catch (Exception ex)
            {
                OUTPUT4.Text = ex.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (eSquare != null)
            {
                OUTPUT4.Text = "Perimetr: " + eSquare.Perimeter() + " Square: " +
                         eSquare.Area();
            }
            else
            {
                OUTPUT4.Text = "Input correct side";
            }
        }
        private Rhombus eRhombus;
        private void Input5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eRhombus = new Rhombus(Convert.ToInt32(Input5.Text), Convert.ToInt32(Input5.Text));
            }
            catch (Exception ex)
            {
                OUTPUT5.Text = ex.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (eRhombus != null)
            {
                OUTPUT5.Text = "Perimetr: " + eRhombus.Perimeter() + " Square: " +
                eRhombus.Area();
            }
            else
            {
                OUTPUT5.Text = "Input correct side";
            } 
        }
    }
}
