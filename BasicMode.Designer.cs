namespace WinCalcImitation
{
    partial class Form1
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
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_allclear = new System.Windows.Forms.Button();
            this.btn_curclear = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_nega = new System.Windows.Forms.Button();
            this.btn_flip = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_res = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.btn_mr = new System.Windows.Forms.Button();
            this.btn_ms = new System.Windows.Forms.Button();
            this.btn_mplus = new System.Windows.Forms.Button();
            this.btn_mminus = new System.Windows.Forms.Button();
            this.textcurval = new System.Windows.Forms.TextBox();
            this.textallops = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(22, 611);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(158, 76);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_point.Location = new System.Drawing.Point(186, 611);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(76, 76);
            this.btn_point.TabIndex = 1;
            this.btn_point.Text = ",";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(268, 611);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(76, 76);
            this.btn_plus.TabIndex = 5;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(186, 529);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(76, 76);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(268, 529);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(76, 76);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(104, 529);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(76, 76);
            this.btn_2.TabIndex = 8;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(22, 529);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(76, 76);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(186, 365);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(76, 76);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(104, 365);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(76, 76);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(22, 365);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(76, 76);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(186, 447);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(76, 76);
            this.btn_6.TabIndex = 13;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(104, 447);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(76, 76);
            this.btn_5.TabIndex = 14;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(22, 447);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(76, 76);
            this.btn_4.TabIndex = 15;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_allclear
            // 
            this.btn_allclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_allclear.Location = new System.Drawing.Point(186, 283);
            this.btn_allclear.Name = "btn_allclear";
            this.btn_allclear.Size = new System.Drawing.Size(76, 76);
            this.btn_allclear.TabIndex = 16;
            this.btn_allclear.Text = "C";
            this.btn_allclear.UseVisualStyleBackColor = false;
            this.btn_allclear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_curclear
            // 
            this.btn_curclear.Location = new System.Drawing.Point(104, 283);
            this.btn_curclear.Name = "btn_curclear";
            this.btn_curclear.Size = new System.Drawing.Size(76, 76);
            this.btn_curclear.TabIndex = 17;
            this.btn_curclear.Text = "CE";
            this.btn_curclear.UseVisualStyleBackColor = true;
            this.btn_curclear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_backspace.Location = new System.Drawing.Point(22, 283);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(76, 76);
            this.btn_backspace.TabIndex = 18;
            this.btn_backspace.Text = "←";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(268, 365);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(76, 76);
            this.btn_div.TabIndex = 19;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(268, 447);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(76, 76);
            this.btn_mul.TabIndex = 20;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_nega
            // 
            this.btn_nega.Location = new System.Drawing.Point(268, 283);
            this.btn_nega.Name = "btn_nega";
            this.btn_nega.Size = new System.Drawing.Size(76, 76);
            this.btn_nega.TabIndex = 21;
            this.btn_nega.Text = "±";
            this.btn_nega.UseVisualStyleBackColor = true;
            this.btn_nega.Click += new System.EventHandler(this.btn_adop_Click);
            // 
            // btn_flip
            // 
            this.btn_flip.Location = new System.Drawing.Point(350, 447);
            this.btn_flip.Name = "btn_flip";
            this.btn_flip.Size = new System.Drawing.Size(76, 76);
            this.btn_flip.TabIndex = 23;
            this.btn_flip.Text = "1/x";
            this.btn_flip.UseVisualStyleBackColor = true;
            this.btn_flip.Click += new System.EventHandler(this.btn_adop_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.Location = new System.Drawing.Point(350, 365);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(76, 76);
            this.btn_percent.TabIndex = 24;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            this.btn_percent.Click += new System.EventHandler(this.btn_adop_Click);
            // 
            // btn_res
            // 
            this.btn_res.Location = new System.Drawing.Point(350, 529);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(76, 158);
            this.btn_res.TabIndex = 25;
            this.btn_res.Text = "=";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sqrt.Location = new System.Drawing.Point(350, 283);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(76, 76);
            this.btn_sqrt.TabIndex = 26;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_adop_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.Location = new System.Drawing.Point(22, 201);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(76, 76);
            this.btn_mc.TabIndex = 28;
            this.btn_mc.Text = "MC";
            this.btn_mc.UseVisualStyleBackColor = true;
            // 
            // btn_mr
            // 
            this.btn_mr.Location = new System.Drawing.Point(104, 201);
            this.btn_mr.Name = "btn_mr";
            this.btn_mr.Size = new System.Drawing.Size(76, 76);
            this.btn_mr.TabIndex = 29;
            this.btn_mr.Text = "MR";
            this.btn_mr.UseVisualStyleBackColor = true;
            // 
            // btn_ms
            // 
            this.btn_ms.Location = new System.Drawing.Point(186, 201);
            this.btn_ms.Name = "btn_ms";
            this.btn_ms.Size = new System.Drawing.Size(76, 76);
            this.btn_ms.TabIndex = 30;
            this.btn_ms.Text = "MS";
            this.btn_ms.UseVisualStyleBackColor = true;
            // 
            // btn_mplus
            // 
            this.btn_mplus.Location = new System.Drawing.Point(268, 201);
            this.btn_mplus.Name = "btn_mplus";
            this.btn_mplus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_mplus.Size = new System.Drawing.Size(76, 76);
            this.btn_mplus.TabIndex = 31;
            this.btn_mplus.Text = "M+";
            this.btn_mplus.UseVisualStyleBackColor = true;
            // 
            // btn_mminus
            // 
            this.btn_mminus.Location = new System.Drawing.Point(350, 201);
            this.btn_mminus.Name = "btn_mminus";
            this.btn_mminus.Size = new System.Drawing.Size(76, 76);
            this.btn_mminus.TabIndex = 32;
            this.btn_mminus.Text = "M-";
            this.btn_mminus.UseVisualStyleBackColor = true;
            // 
            // textcurval
            // 
            this.textcurval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcurval.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textcurval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textcurval.Location = new System.Drawing.Point(0, 35);
            this.textcurval.Name = "textcurval";
            this.textcurval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textcurval.Size = new System.Drawing.Size(404, 88);
            this.textcurval.TabIndex = 0;
            this.textcurval.Text = "0";
            this.textcurval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textallops
            // 
            this.textallops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textallops.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textallops.Location = new System.Drawing.Point(0, -1);
            this.textallops.Name = "textallops";
            this.textallops.Size = new System.Drawing.Size(404, 40);
            this.textallops.TabIndex = 1;
            this.textallops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textallops);
            this.panel1.Controls.Add(this.textcurval);
            this.panel1.Location = new System.Drawing.Point(22, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 124);
            this.panel1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_mminus);
            this.Controls.Add(this.btn_mplus);
            this.Controls.Add(this.btn_ms);
            this.Controls.Add(this.btn_mr);
            this.Controls.Add(this.btn_mc);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_flip);
            this.Controls.Add(this.btn_nega);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_curclear);
            this.Controls.Add(this.btn_allclear);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_mr;

        private System.Windows.Forms.Button btn_ms;

        private System.Windows.Forms.Button btn_mc;

        private System.Windows.Forms.Button btn_sqrt;

        private System.Windows.Forms.Button btn_nega;

        private System.Windows.Forms.Button btn_div;

        private System.Windows.Forms.Button btn_backspace;

        private System.Windows.Forms.Button btn_8;

        private System.Windows.Forms.Button btn_7;

        private System.Windows.Forms.Button btn_9;

        private System.Windows.Forms.Button btn_mplus;
        private System.Windows.Forms.Button btn_mminus;

        private System.Windows.Forms.TextBox textcurval;
        private System.Windows.Forms.TextBox textallops;

        private System.Windows.Forms.Button btn_allclear;

        private System.Windows.Forms.Button btn_curclear;

        private System.Windows.Forms.Panel panel1;


        private System.Windows.Forms.Button btn_flip;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_res;


        private System.Windows.Forms.Button btn_mul;

        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;

        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_minus;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button btn_point;

        private System.Windows.Forms.Button btn_0;

        #endregion
    }
}