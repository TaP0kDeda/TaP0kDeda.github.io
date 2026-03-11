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
            int del=2, count = 0;
            exp = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);
            res = Math.Pow(x, del) / Factorial(del);
            sum = 1 - res;
            del += 2;
            count++;
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
}
