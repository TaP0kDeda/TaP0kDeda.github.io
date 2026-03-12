using System.Numerics;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double exp, x, res, prev = 1, sum;
            int del = 2, count = 0;
            exp = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);
            res = Math.Pow(x, del) / Factorial(del);
            sum = 1 - res;
            del += 2;
            count++;
            if(exp == 0)
            {
                try
                {
                    throw new AccessViolationException();
                }
                catch (AccessViolationException ave)
                {
                    label4.Text = "Экспонента не может быть равна 0\n" + ave.Message;

                }
            }
            else
            {
                while ((prev - res) > exp)
                {
                    prev = res;
                    res = Math.Pow(x, del) / Factorial(del);
                    del += 2;
                    if (count % 2 == 0)
                    {
                        sum -= res;
                    }
                    else
                    {
                        sum += res;
                    }
                    count++;
                }
                label4.Text = "Cos(x) = " + Math.Cos(x).ToString() + "\nСумма ряда = " + sum.ToString() + "\nКол-во членов ряда = " + count.ToString();
            }
                

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tx = ((Control)sender).Text;
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && tx.Length > 0)
                return;
            if ((e.KeyChar == '0'))
                return;
            if (e.KeyChar == ',' && tx.Length > 0)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tx = ((Control)sender).Text;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == ',' && tx.Length > 0)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
