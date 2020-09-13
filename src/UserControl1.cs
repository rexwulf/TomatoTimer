using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWinforms
{
    public partial class UserControl1: UserControl
    {
        public UserControl1(CSDeskBand.CSDeskBandWin w)
        {
            InitializeComponent();
            textBox1.GotFocus += (o, e) => w.UpdateFocus(true);
            //this.AutoSize = false;
            //this.Anchor = AnchorStyles.Right;
            //this.Width = 30;
            //this.Height = 30;
            //this.ResizeRedraw = false;
            //this.AutoScaleMode = AutoScaleMode.None;
            //this.AutoScroll = false;
            //this.AutoSize = false;
            // this.Hide();
        }
    }
}
