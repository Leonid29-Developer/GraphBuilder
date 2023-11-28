namespace GraphBuilder
{
    partial class EdgesResize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Resize = new System.Windows.Forms.MaskedTextBox();
            this.Fix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_X = new System.Windows.Forms.MaskedTextBox();
            this.TB_Y = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите новую размерность ребра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Resize
            // 
            this.TB_Resize.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Resize.Location = new System.Drawing.Point(109, 133);
            this.TB_Resize.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.TB_Resize.Mask = "00000";
            this.TB_Resize.Name = "TB_Resize";
            this.TB_Resize.Size = new System.Drawing.Size(226, 41);
            this.TB_Resize.TabIndex = 1;
            this.TB_Resize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fix
            // 
            this.Fix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fix.Location = new System.Drawing.Point(89, 462);
            this.Fix.Margin = new System.Windows.Forms.Padding(80, 23, 80, 23);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(266, 61);
            this.Fix.TabIndex = 2;
            this.Fix.Text = "Зафиксировать";
            this.Fix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fix.Click += new System.EventHandler(this.Fix_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите новый сдвиг ребра";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 75);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_X
            // 
            this.TB_X.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_X.Location = new System.Drawing.Point(109, 357);
            this.TB_X.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.TB_X.Mask = "0000";
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(82, 41);
            this.TB_X.TabIndex = 5;
            this.TB_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Y
            // 
            this.TB_Y.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Y.Location = new System.Drawing.Point(318, 357);
            this.TB_Y.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.TB_Y.Mask = "0000";
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Size = new System.Drawing.Size(82, 41);
            this.TB_Y.TabIndex = 7;
            this.TB_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(240, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 75);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdgesResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 573);
            this.Controls.Add(this.TB_Y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fix);
            this.Controls.Add(this.TB_Resize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EdgesResize";
            this.Load += new System.EventHandler(this.EdgesResize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TB_Resize;
        private System.Windows.Forms.Label Fix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TB_X;
        private System.Windows.Forms.MaskedTextBox TB_Y;
        private System.Windows.Forms.Label label4;
    }
}