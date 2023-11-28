using System;
using System.Windows.Forms;

namespace GraphBuilder
{
    public partial class EdgesResize : Form
    {
        public EdgesResize() => InitializeComponent();

        public static int Sized { get; set; }

        private void Fix_Click(object sender, EventArgs e) { Sized = Convert.ToInt32(TB_Resize.Text); Close(); }

        private void EdgesResize_Load(object sender, EventArgs e) { TB_Resize.Text = Size.ToString(); }
    }
}