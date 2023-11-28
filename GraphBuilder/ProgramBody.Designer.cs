namespace GraphBuilder
{
    partial class ProgramBody
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramBody));
            this.Tool1 = new System.Windows.Forms.Panel();
            this.Tool2 = new System.Windows.Forms.Panel();
            this.Tool4 = new System.Windows.Forms.Panel();
            this.Tool5 = new System.Windows.Forms.Panel();
            this.Tool3 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.PictureBox();
            this.Matrix_Adjacencies = new System.Windows.Forms.Label();
            this.Matrix_Weights = new System.Windows.Forms.Label();
            this.OutputWindow = new System.Windows.Forms.ListBox();
            this.Path = new System.Windows.Forms.Panel();
            this.Cycle = new System.Windows.Forms.Panel();
            this.Load_Button = new System.Windows.Forms.Panel();
            this.Save_Button = new System.Windows.Forms.Panel();
            this.Tool6 = new System.Windows.Forms.Panel();
            this.Tool7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.SuspendLayout();
            // 
            // Tool1
            // 
            this.Tool1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Tool1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool1.BackgroundImage")));
            this.Tool1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool1.Location = new System.Drawing.Point(14, 14);
            this.Tool1.Margin = new System.Windows.Forms.Padding(5);
            this.Tool1.Name = "Tool1";
            this.Tool1.Size = new System.Drawing.Size(60, 60);
            this.Tool1.TabIndex = 0;
            this.Tool1.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Tool2
            // 
            this.Tool2.BackColor = System.Drawing.SystemColors.Control;
            this.Tool2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool2.BackgroundImage")));
            this.Tool2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool2.Location = new System.Drawing.Point(14, 84);
            this.Tool2.Margin = new System.Windows.Forms.Padding(5);
            this.Tool2.Name = "Tool2";
            this.Tool2.Size = new System.Drawing.Size(60, 60);
            this.Tool2.TabIndex = 1;
            this.Tool2.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Tool4
            // 
            this.Tool4.BackColor = System.Drawing.SystemColors.Control;
            this.Tool4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool4.BackgroundImage")));
            this.Tool4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool4.Location = new System.Drawing.Point(14, 224);
            this.Tool4.Margin = new System.Windows.Forms.Padding(5);
            this.Tool4.Name = "Tool4";
            this.Tool4.Size = new System.Drawing.Size(60, 60);
            this.Tool4.TabIndex = 1;
            this.Tool4.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Tool5
            // 
            this.Tool5.BackColor = System.Drawing.SystemColors.Control;
            this.Tool5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool5.BackgroundImage")));
            this.Tool5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool5.Location = new System.Drawing.Point(14, 294);
            this.Tool5.Margin = new System.Windows.Forms.Padding(5);
            this.Tool5.Name = "Tool5";
            this.Tool5.Size = new System.Drawing.Size(60, 60);
            this.Tool5.TabIndex = 1;
            this.Tool5.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Tool3
            // 
            this.Tool3.BackColor = System.Drawing.SystemColors.Control;
            this.Tool3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool3.BackgroundImage")));
            this.Tool3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool3.Location = new System.Drawing.Point(14, 154);
            this.Tool3.Margin = new System.Windows.Forms.Padding(5);
            this.Tool3.Name = "Tool3";
            this.Tool3.Size = new System.Drawing.Size(60, 60);
            this.Tool3.TabIndex = 2;
            this.Tool3.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.Control;
            this.Main.Location = new System.Drawing.Point(99, 14);
            this.Main.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(937, 663);
            this.Main.TabIndex = 3;
            this.Main.TabStop = false;
            this.Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // Matrix_Adjacencies
            // 
            this.Matrix_Adjacencies.BackColor = System.Drawing.SystemColors.Control;
            this.Matrix_Adjacencies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Matrix_Adjacencies.Location = new System.Drawing.Point(1064, 14);
            this.Matrix_Adjacencies.Name = "Matrix_Adjacencies";
            this.Matrix_Adjacencies.Size = new System.Drawing.Size(352, 48);
            this.Matrix_Adjacencies.TabIndex = 4;
            this.Matrix_Adjacencies.Text = "Построение матрицы смежности ребер";
            this.Matrix_Adjacencies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Matrix_Adjacencies.Click += new System.EventHandler(this.Matrix_Adjacencies_Click);
            // 
            // Matrix_Weights
            // 
            this.Matrix_Weights.BackColor = System.Drawing.SystemColors.Control;
            this.Matrix_Weights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Matrix_Weights.Location = new System.Drawing.Point(1064, 84);
            this.Matrix_Weights.Name = "Matrix_Weights";
            this.Matrix_Weights.Size = new System.Drawing.Size(352, 48);
            this.Matrix_Weights.TabIndex = 5;
            this.Matrix_Weights.Text = "Построение матрицы весов";
            this.Matrix_Weights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Matrix_Weights.Click += new System.EventHandler(this.Matrix_Weights_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.FormattingEnabled = true;
            this.OutputWindow.ItemHeight = 21;
            this.OutputWindow.Location = new System.Drawing.Point(1064, 154);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(352, 424);
            this.OutputWindow.TabIndex = 6;
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.SystemColors.Control;
            this.Path.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Path.BackgroundImage")));
            this.Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Path.Location = new System.Drawing.Point(1064, 603);
            this.Path.Margin = new System.Windows.Forms.Padding(5);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(164, 74);
            this.Path.TabIndex = 1;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // Cycle
            // 
            this.Cycle.BackColor = System.Drawing.SystemColors.Control;
            this.Cycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cycle.BackgroundImage")));
            this.Cycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cycle.Location = new System.Drawing.Point(1252, 603);
            this.Cycle.Margin = new System.Windows.Forms.Padding(5);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(164, 74);
            this.Cycle.TabIndex = 2;
            this.Cycle.Click += new System.EventHandler(this.Cycle_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Load_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Load_Button.BackgroundImage")));
            this.Load_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load_Button.Location = new System.Drawing.Point(14, 617);
            this.Load_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(60, 60);
            this.Load_Button.TabIndex = 2;
            this.Load_Button.Paint += new System.Windows.Forms.PaintEventHandler(this.Load_Button_Paint);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Save_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_Button.BackgroundImage")));
            this.Save_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Button.Location = new System.Drawing.Point(14, 547);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(60, 60);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Paint += new System.Windows.Forms.PaintEventHandler(this.Save_Button_Paint);
            // 
            // Tool6
            // 
            this.Tool6.BackColor = System.Drawing.SystemColors.Control;
            this.Tool6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool6.BackgroundImage")));
            this.Tool6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool6.Location = new System.Drawing.Point(14, 364);
            this.Tool6.Margin = new System.Windows.Forms.Padding(5);
            this.Tool6.Name = "Tool6";
            this.Tool6.Size = new System.Drawing.Size(60, 60);
            this.Tool6.TabIndex = 2;
            this.Tool6.Click += new System.EventHandler(this.SelectTools_Click);
            // 
            // Tool7
            // 
            this.Tool7.BackColor = System.Drawing.SystemColors.Control;
            this.Tool7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tool7.BackgroundImage")));
            this.Tool7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tool7.Location = new System.Drawing.Point(14, 434);
            this.Tool7.Margin = new System.Windows.Forms.Padding(5);
            this.Tool7.Name = "Tool7";
            this.Tool7.Size = new System.Drawing.Size(60, 60);
            this.Tool7.TabIndex = 3;
            this.Tool7.Click += new System.EventHandler(this.Tool7_Click);
            // 
            // ProgramBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1430, 693);
            this.Controls.Add(this.Tool7);
            this.Controls.Add(this.Tool6);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.Matrix_Weights);
            this.Controls.Add(this.Matrix_Adjacencies);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Tool3);
            this.Controls.Add(this.Tool5);
            this.Controls.Add(this.Tool4);
            this.Controls.Add(this.Tool2);
            this.Controls.Add(this.Tool1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProgramBody";
            this.Text = "Графопостроитель";
            this.Load += new System.EventHandler(this.ProgramBody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tool1;
        private System.Windows.Forms.Panel Tool2;
        private System.Windows.Forms.Panel Tool4;
        private System.Windows.Forms.Panel Tool5;
        private System.Windows.Forms.Panel Tool3;
        private System.Windows.Forms.PictureBox Main;
        private System.Windows.Forms.Label Matrix_Adjacencies;
        private System.Windows.Forms.Label Matrix_Weights;
        private System.Windows.Forms.ListBox OutputWindow;
        private System.Windows.Forms.Panel Path;
        private System.Windows.Forms.Panel Cycle;
        private System.Windows.Forms.Panel Load_Button;
        private System.Windows.Forms.Panel Save_Button;
        private System.Windows.Forms.Panel Tool6;
        private System.Windows.Forms.Panel Tool7;
    }
}

