﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphBuilder
{
    public partial class EdgesResize : Form
    {
        public EdgesResize() => InitializeComponent();

        public static int Size { get; set; }

        private void Fix_Click(object sender, EventArgs e) { Size = Convert.ToInt32(TB_Resize.Text); Close(); }

        private void EdgesResize_Load(object sender, EventArgs e) { TB_Resize.Text = Size.ToString(); }
    }
}