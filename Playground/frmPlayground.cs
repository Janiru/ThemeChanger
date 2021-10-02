using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class frmPlayground : Form
    {
        private Point centerPoint;
        private int AnimatorRadius;
        private Bitmap bmpBefore;
        private Bitmap bmpAfter;

        private int _step = 0;

        public int step { get { return _step; }
            set { _step = value; label1.Text = $"{value}"; }
        }

        public frmPlayground()
        {
            InitializeComponent();

            centerPoint = new Point(btnTheme.Location.X + btnTheme.Size.Width / 2, btnTheme.Location.Y + btnTheme.Size.Height / 2);

        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_EaseInEaseOut(2000));
            t.add(this, "step", 1000);
            t.run();

            btnTheme.Checked = !btnTheme.Checked;
            bmpBefore = new Bitmap(pnlContainer.Width, pnlContainer.Height);
            bmpAfter = new Bitmap(pnlContainer.Width, pnlContainer.Height);

            bool darkMode = btnTheme.Checked;
            AnimatorRadius = (int)Math.Sqrt(Math.Pow(Math.Abs(Width - centerPoint.X), 2.0) + Math.Pow(Math.Abs(Height - centerPoint.Y), 2.0));

            if (darkMode)
            {
                changeTheme(btnTheme.Checked);
                pnlContainer.DrawToBitmap(bmpBefore, new Rectangle(0, 0, bmpBefore.Width, bmpBefore.Height));

                btnTheme.Checked = !btnTheme.Checked;
                changeTheme(btnTheme.Checked);

                animator.BringToFront();
                btnTheme.BringToFront();

                animatorTimer.Start();
            }
            else
            {
                pnlContainer.DrawToBitmap(bmpAfter, new Rectangle(0, 0, bmpAfter.Width, bmpAfter.Height));

                animator.BringToFront();

                animator.Width = animator.Height = AnimatorRadius * 2;
                animator.Location = new Point(centerPoint.X - animator.Width / 2, centerPoint.Y - animator.Height / 2);
                //btnTheme.Checked = !btnTheme.Checked;
                changeTheme(btnTheme.Checked);


                animatorShrinkTimer.Start();
            }
        }

        private void changeTheme(bool darkMode)
        {
            if (darkMode)
            {
                pnlContainer.BackColor
                = SampleElement1.FillColor = SampleElement2.FillColor = SampleElement3.FillColor = SampleElement4.FillColor
                = Color.FromArgb(40, 40, 40);

                SampleElement1.CustomBorderColor = SampleElement2.CustomBorderColor = SampleElement3.CustomBorderColor = SampleElement4.CustomBorderColor
                = SampleElement1.BorderColor = SampleElement2.BorderColor = SampleElement3.BorderColor = SampleElement4.BorderColor
                = Color.FromArgb(80, 80, 80);

                SampleElement1.ForeColor = SampleElement2.ForeColor = SampleElement3.ForeColor = SampleElement4.ForeColor
                = Color.Silver;
            }
            else
            {
                pnlContainer.BackColor = Color.White;
                
                SampleElement1.FillColor = SampleElement2.FillColor = SampleElement3.FillColor = SampleElement4.FillColor 
                = Color.LightBlue;

                SampleElement1.CustomBorderColor = SampleElement2.CustomBorderColor = SampleElement3.CustomBorderColor = SampleElement4.CustomBorderColor
                = SampleElement1.BorderColor = SampleElement2.BorderColor = SampleElement3.BorderColor = SampleElement4.BorderColor
                = Color.FromArgb(213, 218, 223);

                SampleElement1.ForeColor = SampleElement2.ForeColor = SampleElement3.ForeColor = SampleElement4.ForeColor
                = Color.FromArgb(125, 137, 149);
            }
        }


        private void animatorTimer_Tick(object sender, EventArgs e)
        {
            if(animator.Width / 2 < AnimatorRadius) 
            {
                animator.Size = new Size(animator.Size.Width + 100, animator.Size.Height + 100);
                animator.Location = new Point(animator.Location.X - 50, animator.Location.Y - 50);

                Bitmap dynImage = new Bitmap(animator.Width, animator.Height);
                Point dynPoint = new Point(dynImage.Width / 2 - centerPoint.X, dynImage.Height / 2 - centerPoint.Y);
                Graphics dynGraphics = Graphics.FromImage(dynImage);

                dynGraphics.DrawImage(bmpBefore, dynPoint);

                animator.Image = dynImage;
            }
            else 
            {
                animatorTimer.Stop();

                animator.Image = null;

                animator.Size = btnTheme.Size; 
                animator.Location = btnTheme.Location;
                animator.SendToBack();

                btnTheme.Checked = !btnTheme.Checked;
                changeTheme(btnTheme.Checked);

                btnTheme.FillColor = Color.Transparent;
            }
        }

        private void animatorShrinkTimer_Tick(object sender, EventArgs e)
        {
            if (animator.Width - 100 > btnTheme.Size.Width)
            {
                animator.Size = new Size(animator.Size.Width - 100, animator.Size.Height - 100);
                animator.Location = new Point(animator.Location.X + 50, animator.Location.Y + 50);

                Bitmap dynImage = new Bitmap(animator.Width, animator.Height);
                Point dynPoint = new Point(dynImage.Width / 2 - centerPoint.X, dynImage.Height / 2 - centerPoint.Y);
                Graphics dynGraphics = Graphics.FromImage(dynImage);
                dynGraphics.DrawImage(bmpAfter, dynPoint);

                animator.Image = dynImage;
            }
            else
            {
                animatorShrinkTimer.Stop();

                animator.Image = null;

                animator.Size = btnTheme.Size;
                animator.Location = btnTheme.Location;
                animator.SendToBack();

                btnTheme.FillColor = Color.Transparent;
            }
        }

        private Random _random = new Random();

        private void frmPlayground_Load(object sender, EventArgs e)
        {
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}