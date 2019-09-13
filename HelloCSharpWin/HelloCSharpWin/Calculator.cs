using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int sum = 3;
            HelloLabel.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButon_Click(object sender, EventArgs e)
        {
            int Number1 = 0;
            int Number2 = 0;
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Input number in Sum1.");
                Sum1.Focus();
                return;
            }

            else if (int.TryParse(Sum1.Text, out Number1) == false)
            {
                MessageBox.Show("Do not input char.Input number in Sum1. ");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }

            else if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Input number in Sum2.");
                Sum2.Focus();
                return;
            }

            else if (int.TryParse(Sum1.Text, out Number2) == false)
            {
                MessageBox.Show("Do not input char.Input number in Sum2. ");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }
            
            /*
            Number1 = Convert.ToInt32(Sum1.Text);
            Number2 = Convert.ToInt32(Sum2.Text);
            */

            int sum = AddNum(Number1, Number2);
            SumResult.Text = sum.ToString();

            
        }

        public int AddNum(int Number1, int Number2)
        {
            int sum = Number1 + Number2;

            return sum;
        }

        public float AddNum(float Number1, float Number2)
        {
            float sum = Number1 + Number2;
            return sum;
        }

        public int SubNum(int Number1, int Number2)
        {
            int sub = Number1 - Number2;
            return sub;
        }

    }
}
