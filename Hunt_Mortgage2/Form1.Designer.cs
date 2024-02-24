namespace Hunt_Mortgage2
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
            this.PrincipalLabel = new System.Windows.Forms.Label();
            this.sPErr = new System.Windows.Forms.Label();
            this.TIYLabel = new System.Windows.Forms.Label();
            this.stiyErr = new System.Windows.Forms.Label();
            this.b15rb = new System.Windows.Forms.RadioButton();
            this.b30rb = new System.Windows.Forms.RadioButton();
            this.bOrb = new System.Windows.Forms.RadioButton();
            this.sOrbErr = new System.Windows.Forms.Label();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.sIntrCb = new System.Windows.Forms.ComboBox();
            this.sOrbTxtb = new System.Windows.Forms.TextBox();
            this.sPTxtb = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.RstBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.sintrErr = new System.Windows.Forms.Label();
            this.mptxt = new System.Windows.Forms.Label();
            this.finumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrincipalLabel
            // 
            this.PrincipalLabel.AutoSize = true;
            this.PrincipalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrincipalLabel.Location = new System.Drawing.Point(12, 9);
            this.PrincipalLabel.Name = "PrincipalLabel";
            this.PrincipalLabel.Size = new System.Drawing.Size(82, 20);
            this.PrincipalLabel.TabIndex = 1;
            this.PrincipalLabel.Text = "Principal:";
            // 
            // sPErr
            // 
            this.sPErr.AutoSize = true;
            this.sPErr.Location = new System.Drawing.Point(13, 29);
            this.sPErr.Name = "sPErr";
            this.sPErr.Size = new System.Drawing.Size(114, 13);
            this.sPErr.TabIndex = 3;
            this.sPErr.Text = "Please only input digits";
            this.sPErr.Visible = false;
            // 
            // TIYLabel
            // 
            this.TIYLabel.AutoSize = true;
            this.TIYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIYLabel.Location = new System.Drawing.Point(12, 42);
            this.TIYLabel.Name = "TIYLabel";
            this.TIYLabel.Size = new System.Drawing.Size(122, 20);
            this.TIYLabel.TabIndex = 4;
            this.TIYLabel.Text = "Term In Years";
            // 
            // stiyErr
            // 
            this.stiyErr.AutoSize = true;
            this.stiyErr.Location = new System.Drawing.Point(13, 62);
            this.stiyErr.Name = "stiyErr";
            this.stiyErr.Size = new System.Drawing.Size(102, 13);
            this.stiyErr.TabIndex = 5;
            this.stiyErr.Text = "Please select a term";
            this.stiyErr.Visible = false;
            // 
            // b15rb
            // 
            this.b15rb.AutoSize = true;
            this.b15rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b15rb.Location = new System.Drawing.Point(16, 79);
            this.b15rb.Name = "b15rb";
            this.b15rb.Size = new System.Drawing.Size(99, 24);
            this.b15rb.TabIndex = 6;
            this.b15rb.TabStop = true;
            this.b15rb.Text = "15 Years";
            this.b15rb.UseVisualStyleBackColor = true;
            // 
            // b30rb
            // 
            this.b30rb.AutoSize = true;
            this.b30rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b30rb.Location = new System.Drawing.Point(16, 109);
            this.b30rb.Name = "b30rb";
            this.b30rb.Size = new System.Drawing.Size(99, 24);
            this.b30rb.TabIndex = 7;
            this.b30rb.TabStop = true;
            this.b30rb.Text = "30 Years";
            this.b30rb.UseVisualStyleBackColor = true;
            // 
            // bOrb
            // 
            this.bOrb.AutoSize = true;
            this.bOrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrb.Location = new System.Drawing.Point(16, 139);
            this.bOrb.Name = "bOrb";
            this.bOrb.Size = new System.Drawing.Size(87, 24);
            this.bOrb.TabIndex = 8;
            this.bOrb.TabStop = true;
            this.bOrb.Text = "Other...";
            this.bOrb.UseVisualStyleBackColor = true;
            this.bOrb.CheckedChanged += new System.EventHandler(this.bOrb_CheckedChanged);
            // 
            // sOrbErr
            // 
            this.sOrbErr.AutoSize = true;
            this.sOrbErr.Location = new System.Drawing.Point(13, 166);
            this.sOrbErr.Name = "sOrbErr";
            this.sOrbErr.Size = new System.Drawing.Size(115, 13);
            this.sOrbErr.TabIndex = 9;
            this.sOrbErr.Text = "Please only enter digits";
            this.sOrbErr.Visible = false;
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestLabel.Location = new System.Drawing.Point(12, 184);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(72, 20);
            this.InterestLabel.TabIndex = 10;
            this.InterestLabel.Text = "Interest";
            // 
            // sIntrCb
            // 
            this.sIntrCb.FormattingEnabled = true;
            this.sIntrCb.Location = new System.Drawing.Point(91, 183);
            this.sIntrCb.Name = "sIntrCb";
            this.sIntrCb.Size = new System.Drawing.Size(91, 21);
            this.sIntrCb.TabIndex = 11;
            // 
            // sOrbTxtb
            // 
            this.sOrbTxtb.Location = new System.Drawing.Point(109, 143);
            this.sOrbTxtb.Name = "sOrbTxtb";
            this.sOrbTxtb.Size = new System.Drawing.Size(73, 20);
            this.sOrbTxtb.TabIndex = 12;
            this.sOrbTxtb.Visible = false;
            // 
            // sPTxtb
            // 
            this.sPTxtb.Location = new System.Drawing.Point(100, 9);
            this.sPTxtb.Name = "sPTxtb";
            this.sPTxtb.Size = new System.Drawing.Size(82, 20);
            this.sPTxtb.TabIndex = 13;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtn.Location = new System.Drawing.Point(16, 225);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(166, 42);
            this.CalcBtn.TabIndex = 14;
            this.CalcBtn.Text = "Calculate Payment";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // RstBtn
            // 
            this.RstBtn.Enabled = false;
            this.RstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RstBtn.Location = new System.Drawing.Point(16, 274);
            this.RstBtn.Name = "RstBtn";
            this.RstBtn.Size = new System.Drawing.Size(68, 39);
            this.RstBtn.TabIndex = 15;
            this.RstBtn.Text = "Reset";
            this.RstBtn.UseVisualStyleBackColor = true;
            this.RstBtn.Click += new System.EventHandler(this.RstBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(99, 274);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(83, 39);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // sintrErr
            // 
            this.sintrErr.AutoSize = true;
            this.sintrErr.Location = new System.Drawing.Point(13, 207);
            this.sintrErr.Name = "sintrErr";
            this.sintrErr.Size = new System.Drawing.Size(143, 13);
            this.sintrErr.TabIndex = 17;
            this.sintrErr.Text = "Please select an interest rate";
            this.sintrErr.Visible = false;
            // 
            // mptxt
            // 
            this.mptxt.AutoSize = true;
            this.mptxt.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mptxt.Location = new System.Drawing.Point(13, 316);
            this.mptxt.Name = "mptxt";
            this.mptxt.Size = new System.Drawing.Size(169, 17);
            this.mptxt.TabIndex = 18;
            this.mptxt.Text = "Your monthly payment is:";
            this.mptxt.Visible = false;
            this.mptxt.Click += new System.EventHandler(this.finumTxt_Click);
            // 
            // finumLabel
            // 
            this.finumLabel.AutoSize = true;
            this.finumLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finumLabel.Location = new System.Drawing.Point(13, 333);
            this.finumLabel.Name = "finumLabel";
            this.finumLabel.Size = new System.Drawing.Size(15, 17);
            this.finumLabel.TabIndex = 19;
            this.finumLabel.Text = "0";
            this.finumLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 353);
            this.Controls.Add(this.finumLabel);
            this.Controls.Add(this.mptxt);
            this.Controls.Add(this.sintrErr);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RstBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.sPTxtb);
            this.Controls.Add(this.sOrbTxtb);
            this.Controls.Add(this.sIntrCb);
            this.Controls.Add(this.InterestLabel);
            this.Controls.Add(this.sOrbErr);
            this.Controls.Add(this.bOrb);
            this.Controls.Add(this.b30rb);
            this.Controls.Add(this.b15rb);
            this.Controls.Add(this.stiyErr);
            this.Controls.Add(this.TIYLabel);
            this.Controls.Add(this.sPErr);
            this.Controls.Add(this.PrincipalLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PrincipalLabel;
        private System.Windows.Forms.Label sPErr;
        private System.Windows.Forms.Label TIYLabel;
        private System.Windows.Forms.RadioButton b15rb;
        private System.Windows.Forms.RadioButton b30rb;
        private System.Windows.Forms.RadioButton bOrb;
        private System.Windows.Forms.Label sOrbErr;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.ComboBox sIntrCb;
        private System.Windows.Forms.TextBox sOrbTxtb;
        private System.Windows.Forms.TextBox sPTxtb;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button RstBtn;
        private System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.Label stiyErr;
        private System.Windows.Forms.Label sintrErr;
        private System.Windows.Forms.Label mptxt;
        private System.Windows.Forms.Label finumLabel;
    }
}

