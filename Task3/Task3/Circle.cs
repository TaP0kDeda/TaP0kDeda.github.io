namespace Task3
{
    public partial class Circle : Form
    {
        int w = 80, h = 80;
        int x = 1, y = 200;
        int dx = 1;
        bool Mode = false;
        bool Rotation = false;
        int ObjectForm;
        int Speed = 1;

        enum STATUS { Bottom, Left, Right };
        STATUS flag;
        SolidBrush brush = new SolidBrush(Color.Red);
        Rectangle rc;

        public Circle()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Speed;
            rc = new Rectangle(x, y, w, h);
            this.Invalidate(rc, true);
            if (!Rotation)
            {
                if (flag == STATUS.Left)
                {
                    x += dx;
                    y -= dx;
                }
                if (flag == STATUS.Right)
                {
                    x += dx;
                    y += dx;
                }
                if (flag == STATUS.Bottom)
                {
                    x -= dx;
                }
                if (x >= (this.ClientSize.Width - w) || y >= (this.ClientSize.Height - h))
                    flag = STATUS.Bottom;
                else if (x >= this.ClientSize.Width / 2 - w / 2 & flag != STATUS.Bottom)
                {
                    flag = STATUS.Right;
                }
                else if (x <= 1)
                    flag = STATUS.Left;
            }
            else
            {
                if (flag == STATUS.Left)
                {
                    x -= dx;
                    y -= dx;
                }
                if (flag == STATUS.Right)
                {
                    x -= dx;
                    y -= dx;
                }
                if (flag == STATUS.Bottom)
                {
                    x -= dx;
                }
            }


            rc = new Rectangle(x, y, w, h);
            this.Invalidate(rc, true);

        }

        private void Circle_Paint(object sender, PaintEventArgs e)
        {
            if (ObjectForm == 1)
            {
                e.Graphics.FillEllipse(brush, rc);
            }
            else
            {
                e.Graphics.FillRectangle(brush, rc);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Mode)
            {
                Mode = true;
                button1.Text = "СТОП";
                timer1.Start();

            }
            else
            {
                Mode = false;
                button1.Text = "СТАРТ";
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings form2 = new Settings();  // создание экземпляра второй формы
            form2.Owner = this;     // родительской для формы 2 будет текущая форма
            form2.ShowDialog();     // показать окно второй формы в модальном режиме        
            brush.Color = form2.MyColor;
            ObjectForm = form2.ObjectForm;
            Speed = 11 - form2.Speed;

        }
    }
}
