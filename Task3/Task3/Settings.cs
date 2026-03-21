using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Settings : Form
    {
        SolidBrush brush = new SolidBrush(Color.Red); // кисть
        Rectangle rc;
        int objForm = 1;


        public Settings()
        {
            InitializeComponent();
        }

        public Color MyColor
        {
            get
            {
                return brush.Color;
            }
            set
            {
                brush.Color = value;
            }
        }

        public int ObjectForm
        {
            get
            {
                return objForm;
            }
            set
            {
                objForm = value;
            }
        }

        public int Speed
        {
            get
            {
                return trackBar1.Value;
            }
            set
            {
                trackBar1.Value = value;
            }
        }


        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            if (objForm == 1)
            {
                e.Graphics.FillEllipse(brush, rc);
            }
            else
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            rc = new Rectangle(130, 340, 50, 50);
            this.Invalidate(rc, true);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rc = new Rectangle(130, 340, 50, 50);
            this.Invalidate(rc, true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rc = new Rectangle(130, 340, 50, 50);
            this.Invalidate(rc, true);
            objForm = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rc = new Rectangle(130, 340, 50, 50);
            this.Invalidate(rc, true);
            objForm = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog1.Color;
                rc = new Rectangle(130, 340, 50, 50);
                this.Invalidate(rc, true);
            }

        }
    }
}
