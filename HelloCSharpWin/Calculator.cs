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
    public enum Operators { SUM, SUB, MUL, DIV }

    public partial class Calculator : Form
    {
        public float Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.SUM;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button NumButton = (Button)sender;
            InputNum(NumButton.Text);
        }

        public void InputNum(string num)
        {
            if (isNewNum)
            {
                ResultScreen.Text = num;
                isNewNum = false;
            }
            else if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = num;
            }
            else
            {
                ResultScreen.Text += num;
            }
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

        public float SubNum(float Number1, float Number2)
        {
            float sub = Number1 - Number2;
            return sub;
        }

        public int MulNum(int Number1, int Number2)
        {
            int sub = Number1 * Number2;
            return sub;
        }

        public float MulNum(float Number1, float Number2)
        {
            float sub = Number1 * Number2;
            return sub;
        }

        public int DivNum(int Number1, int Number2)
        {
            int sub = Number1 / Number2;
            return sub;
        }

        public float DivNum(float Number1, float Number2)
        {
            float sub = Number1 / Number2;
            return sub;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                float num = float.Parse(ResultScreen.Text);
                if (Opt == Operators.SUM)
                {
                    Result = AddNum(Result, num);
                }
                else if (Opt == Operators.SUB)
                {
                    Result = SubNum(Result, num);
                }
                else if (Opt == Operators.MUL)
                {
                    Result = MulNum(Result, num);
                }
                else if (Opt == Operators.DIV)
                {
                    Result = DivNum(Result, num);
                }

                ResultScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
            {
                Opt = Operators.SUM;
            }
            else if (optButton.Text == "-")
            {
                Opt = Operators.SUB;
            }
            else if (optButton.Text == "X")
            {
                Opt = Operators.MUL;
            }
            else if (optButton.Text == "/")
            {
                Opt = Operators.DIV;
            }
        }

        private void CelarButton_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.SUM;

            ResultScreen.Text = "0";
        }
    }
}
