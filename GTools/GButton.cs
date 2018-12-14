using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GTools
{
    [DefaultEvent("Click")]
    public class GButton : Control
    {
        public GButton()
            : base()
        {
          //  this.BackColor = Color.Transparent;
            ButtonStyle = ButtonStyles.Green;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            hfc = ForeColor;
        }
        public enum ButtonStyles
        {
            Green,
            Red,
            Blue,
            Orange
        }
        int rad;
        public int Radius {
            get { return rad; }
            set { rad = value; Invalidate(); }
        }
        ButtonStyles sty;
        public ButtonStyles ButtonStyle
        {
            get
            {
                return sty;
            }
            set
            {
                sty = value;
                switch (sty)
                {
                    case ButtonStyles.Blue:
                        c1 = bColor1;
                        c2 = bColor2;
                        break;
                    case ButtonStyles.Red:
                        c1 = rColor1;
                        c2 = rColor2;
                        break;
                    case ButtonStyles.Green:
                        c1 = gColor1;
                        c2 = gColor2;
                        break;
                    case ButtonStyles.Orange:
                        c1 = yColor1;
                        c2 = yColor2;
                        break;
                }
                Invalidate();
            }
        }
        private new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }
        private Color gColor1 = ColorTranslator.FromHtml("#99b927");
        private Color gColor2 = ColorTranslator.FromHtml("#58630e");
        private Color gHoverColor1 = Color.FromArgb(220, ColorTranslator.FromHtml("#99b927"));
        private Color gHoverColor2 = Color.FromArgb(220, ColorTranslator.FromHtml("#58630e"));

        private Color bColor1 = ColorTranslator.FromHtml("#3171ca");
        private Color bColor2 = ColorTranslator.FromHtml("#15396f");
        private Color bHoverColor1 = Color.FromArgb(220, ColorTranslator.FromHtml("#3171ca"));
        private Color bHoverColor2 = Color.FromArgb(220, ColorTranslator.FromHtml("#15396f"));

        private Color rColor1 = ColorTranslator.FromHtml("#b51423");
        private Color rColor2 = ColorTranslator.FromHtml("#5b0509");
        private Color rHoverColor1 = Color.FromArgb(220, ColorTranslator.FromHtml("#b51423"));
        private Color rHoverColor2 = Color.FromArgb(220, ColorTranslator.FromHtml("#5b0509"));

        private Color yColor1 = ColorTranslator.FromHtml("#faa71c");
        private Color yColor2 = ColorTranslator.FromHtml("#e36d11");
        private Color yHoverColor1 = Color.FromArgb(220, ColorTranslator.FromHtml("#faa71c"));
        private Color yHoverColor2 = Color.FromArgb(220, ColorTranslator.FromHtml("#e36d11"));

        private Color c1, c2;
        bool mouseIn = false;
        private Color hfc;
        public Color HoverTextColor
        {
            get
            {
                return hfc;
            }
            set
            {
                hfc = value;
                Invalidate();
            }
        }
        
        /*RectAngles ang;
        public RectAngles Corners
        {
            get { return ang; }
            set
            {
                ang = value;
                Invalidate();
            }
        }*/
        
        protected override void OnPaint(PaintEventArgs pevent)
        {

            base.OnPaint(pevent);
            Graphics gf = pevent.Graphics;
            gf.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Rectangle r = this.ClientRectangle;
            r.Inflate(-2, -2);
            var eg = new ExtendedGraphics(gf);

            if (Enabled)
            {
                var br = new LinearGradientBrush(r, c1, c2, LinearGradientMode.Vertical);
                eg.FillRoundRectangle(br, r.X, r.Y, r.Width, r.Height, rad);

                StringFormat stringFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                SizeF s = gf.MeasureString(Text, this.Font);
                float fontScale = Math.Max(s.Width / r.Width, s.Height / r.Height);
                using (Font font = new Font(this.Font.FontFamily, this.Font.SizeInPoints, GraphicsUnit.Point))
                {
                    var fb = new SolidBrush(this.ForeColor);
                    if (mouseIn)
                        fb = new SolidBrush(this.hfc);
                    gf.DrawString(Text, font, fb, r, stringFormat);
                }
            }
            else
            {
                eg.FillRoundRectangle(Brushes.Gainsboro, r.X, r.Y, r.Width, r.Height, rad);
                eg.DrawRoundRectangle(Pens.White, r.X, r.Y, r.Width, r.Height, rad);

                StringFormat stringFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                SizeF s = gf.MeasureString(Text, this.Font);
                float fontScale = Math.Max(s.Width / r.Width, s.Height / r.Height);
                using (Font font = new Font(this.Font.FontFamily, this.Font.SizeInPoints, GraphicsUnit.Point))
                {
                    gf.DrawString(Text, font, Brushes.Gray, r, stringFormat);
                }
            }
            if (this.Focused)
            {
                Rectangle fr = r;
                fr.Inflate(-1, -1);
                ControlPaint.DrawFocusRectangle(pevent.Graphics, fr);
                //gf.DrawRectangle(Pens.DarkGray, fr);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                Invalidate();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            mouseIn = true;
            base.OnMouseEnter(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bHoverColor1;
                    c2 = bHoverColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rHoverColor1;
                    c2 = rHoverColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gHoverColor1;
                    c2 = gHoverColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yHoverColor1;
                    c2 = yHoverColor2;
                    break;
            }
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            mouseIn = false;
            base.OnMouseLeave(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bColor1;
                    c2 = bColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rColor1;
                    c2 = rColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gColor1;
                    c2 = gColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yColor1;
                    c2 = yColor2;
                    break;
            }
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bColor2;
                    c2 = bColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rColor2;
                    c2 = rColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gColor2;
                    c2 = gColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yColor2;
                    c2 = yColor2;
                    break;
            }
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bHoverColor1;
                    c2 = bHoverColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rHoverColor1;
                    c2 = rHoverColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gHoverColor1;
                    c2 = gHoverColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yHoverColor1;
                    c2 = yHoverColor2;
                    break;
            }
            Invalidate();
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space || e.KeyCode==Keys.Enter)
            {
                switch (sty)
                {
                    case ButtonStyles.Blue:
                        c1 = bColor2;
                        c2 = bColor2;
                        break;
                    case ButtonStyles.Red:
                        c1 = rColor2;
                        c2 = rColor2;
                        break;
                    case ButtonStyles.Green:
                        c1 = gColor2;
                        c2 = gColor2;
                        break;
                    case ButtonStyles.Orange:
                        c1 = yColor2;
                        c2 = yColor2;
                        break;
                }
                Invalidate();
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                base.OnClick(null);
                switch (sty)
                {
                    case ButtonStyles.Blue:
                        c1 = bHoverColor1;
                        c2 = bHoverColor2;
                        break;
                    case ButtonStyles.Red:
                        c1 = rHoverColor1;
                        c2 = rHoverColor2;
                        break;
                    case ButtonStyles.Green:
                        c1 = gHoverColor1;
                        c2 = gHoverColor2;
                        break;
                    case ButtonStyles.Orange:
                        c1 = yHoverColor1;
                        c2 = yHoverColor2;
                        break;
                }
                Invalidate();
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bHoverColor1;
                    c2 = bHoverColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rHoverColor1;
                    c2 = rHoverColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gHoverColor1;
                    c2 = gHoverColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yHoverColor1;
                    c2 = yHoverColor2;
                    break;
            }
            Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            switch (sty)
            {
                case ButtonStyles.Blue:
                    c1 = bColor1;
                    c2 = bColor2;
                    break;
                case ButtonStyles.Red:
                    c1 = rColor1;
                    c2 = rColor2;
                    break;
                case ButtonStyles.Green:
                    c1 = gColor1;
                    c2 = gColor2;
                    break;
                case ButtonStyles.Orange:
                    c1 = yColor1;
                    c2 = yColor2;
                    break;
            }
            Invalidate();
        }
    }
}
