using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GraphBuilder
{
    public partial class EdgesResize : Form
    {
        public EdgesResize() => InitializeComponent();

        public static int Sized { get; set; }
        public static Point Shift { get; set; }

        private void EdgesResize_Load(object sender, EventArgs e)
        { TB_Resize.Text = $"{Sized:000000}"; if (Shift.X < 0) TB_X.Text = $"-{Shift.X:00000}"; else TB_X.Text = $"+{Shift.X:00000}"; if (Shift.Y < 0) TB_Y.Text = $"-{Shift.Y:00000}"; else TB_Y.Text = $"+{Shift.Y:00000}"; }

        private void Fix_Click(object sender, EventArgs e)
        {
            bool T = true;

            foreach (char Simvol in TB_Resize.Text) if (!("0123456789".Contains(Simvol.ToString()))) T = false;

            if (!("+-".Contains(TB_X.Text[0].ToString()))) T = false; if (!("+-".Contains(TB_Y.Text[0].ToString()))) T = false;

            for (int I1 = 1; I1 < TB_X.Text.Length; I1++) if (!("0123456789".Contains(TB_X.Text[I1].ToString()))) T = false;
            for (int I1 = 1; I1 < TB_Y.Text.Length; I1++) if (!("0123456789".Contains(TB_Y.Text[I1].ToString()))) T = false;

            if (T) { Sized = Convert.ToInt32(TB_Resize.Text); Shift = new Point(Convert.ToInt32(TB_X.Text), Convert.ToInt32(TB_Y.Text)); Close(); }
            else MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}