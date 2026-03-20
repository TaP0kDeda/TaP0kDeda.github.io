namespace Task3
{
    public partial class Circle : Form
    {
        int w = 80, h = 80;
        int x = 1, y = 200;
        int dx = 1;
        bool Mode = false;
        bool Rotation = false;

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
            timer1.Interval = 1;
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
                else if (x >= this.ClientSize.Width/2 - w/2 & flag !=  STATUS.Bottom)
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
            e.Graphics.FillEllipse(brush, rc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Mode)
            {
                Mode = true;
                button1.Text = "ÑÒÎÏ";
                timer1.Start();

            }
            else
            {
                Mode = false;
                button1.Text = "ÑÒÀÐÒ";
                timer1.Stop();
            }
        }
    }
}
