namespace InterestCalculator
{
    partial class mainForm
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
            this.tbox_pricipal = new System.Windows.Forms.TextBox();
            this.tbox_rate = new System.Windows.Forms.TextBox();
            this.tbox_time = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_pricipal
            // 
            this.tbox_pricipal.Location = new System.Drawing.Point(118, 52);
            this.tbox_pricipal.Name = "tbox_pricipal";
            this.tbox_pricipal.Size = new System.Drawing.Size(164, 20);
            this.tbox_pricipal.TabIndex = 0;
            this.tbox_pricipal.TextChanged += new System.EventHandler(this.tbox_pricipal_TextChanged);
            // 
            // tbox_rate
            // 
            this.tbox_rate.Location = new System.Drawing.Point(118, 153);
            this.tbox_rate.Name = "tbox_rate";
            this.tbox_rate.Size = new System.Drawing.Size(164, 20);
            this.tbox_rate.TabIndex = 1;
            this.tbox_rate.TextChanged += new System.EventHandler(this.tbox_rate_TextChanged);
            // 
            // tbox_time
            // 
            this.tbox_time.Location = new System.Drawing.Point(118, 102);
            this.tbox_time.Name = "tbox_time";
            this.tbox_time.Size = new System.Drawing.Size(164, 20);
            this.tbox_time.TabIndex = 2;
            this.tbox_time.TextChanged += new System.EventHandler(this.tbox_time_TextChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(207, 201);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate Interest";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Location = new System.Drawing.Point(62, 55);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(47, 13);
            this.lbl_principal.TabIndex = 4;
            this.lbl_principal.Text = "Principal";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(62, 105);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.Text = "Time";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(62, 156);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(30, 13);
            this.lbl_rate.TabIndex = 6;
            this.lbl_rate.Text = "Rate";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(282, 52);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 7;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(118, 201);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(551, 201);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 9;
            this.btn_quit.Text = "&Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 291);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_principal);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.tbox_time);
            this.Controls.Add(this.tbox_rate);
            this.Controls.Add(this.tbox_pricipal);
            this.Name = "mainForm";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_pricipal;
        private System.Windows.Forms.TextBox tbox_rate;
        private System.Windows.Forms.TextBox tbox_time;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_quit;
    }
}

