using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            calculate = new Calculate();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("سلام. به علی حساب خوش آمدید!!!!!");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show(calculate.Plus((int)numberOne.Value, (int)numberTwo.Value).ToString());
            }
        }

        bool IsValid()
        {
            bool isValid = true;

            if (numberOne.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید!!!");
            }

            else
            {
                if (numberTwo.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید!!!");
                }
            }

            return isValid;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show(calculate.Minus((int)numberOne.Value, (int)numberTwo.Value).ToString());
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show(calculate.Division((int)numberOne.Value, (int)numberTwo.Value).ToString());
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show(calculate.Multiple((int)numberOne.Value, (int)numberTwo.Value).ToString());
            }
        }
    }
}
