using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphBuilder
{
    public partial class EdgesResize : Form
    {
        public EdgesResize() => InitializeComponent();

        public static int Sized { get; set; }
        public static Point Shift { get; set; }

        private void Fix_Click(object sender, EventArgs e) { Sized = Convert.ToInt32(TB_Resize.Text); Shift = new Point(Convert.ToInt32(TB_X.Text), Convert.ToInt32(TB_Y.Text)); Close(); }

        private void EdgesResize_Load(object sender, EventArgs e) { TB_Resize.Text = Size.ToString(); TB_X.Text = Shift.X.ToString(); TB_Y.Text = Shift.Y.ToString(); }
    }
}