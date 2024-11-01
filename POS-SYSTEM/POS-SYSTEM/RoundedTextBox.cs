using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public class RoundedTextBox : UserControl
    {
        private TextBox innerTextBox;
        private int borderRadius = 15;
        private Color borderColor = Color.Gray;

        public RoundedTextBox()
        {
            innerTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Location = new Point(10, 7), // Adjust for padding
                Width = this.Width - 20,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            this.Controls.Add(innerTextBox);
            this.Padding = new Padding(10);
            this.Size = new Size(200, 30);
            this.BackColor = Color.White;
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public override string Text
        {
            get => innerTextBox.Text;
            set => innerTextBox.Text = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            innerTextBox.Width = this.Width - 20;
            this.Invalidate();
        }
    }
}
