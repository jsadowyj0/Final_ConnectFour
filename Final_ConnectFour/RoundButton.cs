﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Final_ConnectFour
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }

        public void ResetButton()
        {
            this.BackgroundImage = null;
        }

        public void SetRed()
        {
            this.BackgroundImage = Properties.Resources.red_piece;
        }

        public void SetYellow()
        {
            this.BackgroundImage = Properties.Resources.yellow_piece;
        }
    }

}