using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocTransAdmin
{
    public enum PNOptions
    {
        Custom = 0,
        Positive = 1,
        Normal = 2,
        Negative = 3
    }
    public partial class MsgLabel : UserControl
    {
        public MsgLabel()
        {
            InitializeComponent();
            StyleMode = PNOptions.Normal;
        }
        private bool multiLine;

        public bool MultiLine
        {
            get { return multiLine; }
            set 
            {
                multiLine = value;
                lbl.AutoSize = !value;
                Invalidate();
            }
        }
        private bool fntBold;

        public bool FontBold
        {
            get { return fntBold; }
            set 
            {
                fntBold = value;
                this.lbl.Font = new Font(lbl.Font.Name, lbl.Font.Size, (value) ? FontStyle.Bold : FontStyle.Regular);
                Invalidate();

            }
        }

        private PNOptions md;
        public PNOptions StyleMode
        {
            get
            {
                return md;
            }
            set
            {
                md = value;
                switch (md)
                {
                    case PNOptions.Custom:
                        BorderColor = BorderColorCustom;
                        BackColor = BackColorCustom;
                        break;
                    case PNOptions.Positive:
                        BorderColor = Color.DarkOliveGreen;
                        BackColor = Color.FromArgb(192, 255, 192);
                        break;
                    case PNOptions.Normal:
                        BorderColor = Color.DarkOrange;
                        BackColor = Color.LightYellow;
                        break;
                    case PNOptions.Negative:
                        BorderColor = Color.OrangeRed;
                        BackColor = Color.LightSalmon;
                        break;
                    default:
                        break;
                }
                Invalidate();
            }
        }
        private Color brColor = Color.Silver;

        public Color BorderColor
        {
            get
            {
                return brColor;
            }
            set
            {
                brColor = value;
                Invalidate();
            }
        }
        private Color custBrClr;

        public Color BorderColorCustom
        {
            get { return custBrClr; }
            set
            {
                custBrClr = value;
                if (StyleMode == PNOptions.Custom)
                {
                    BorderColor = value;
                }
                Invalidate();
            }
        }
        private Color Bkclrcustom;

        public Color BackColorCustom
        {
            get { return Bkclrcustom; }
            set
            {
                Bkclrcustom = value;
                if (StyleMode == PNOptions.Custom)
                    BackColor = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(BorderColor), e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }
        public string Message
        {
            get { return lbl.Text; }
            set 
            {
                lbl.Text = value;
                this.Width = lbl.Width + 6;
                Invalidate();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            if (!multiLine)
            {
                this.Height = 22;
                this.Width = this.lbl.Width + 6;
            }
            else
            {
                lbl.Width = Width - 10;
                lbl.Height = Height - 10;                
            }
            Invalidate();
        }

        private void MsgLabel_ForeColorChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = this.ForeColor;
            Invalidate();
        }
    }
}
