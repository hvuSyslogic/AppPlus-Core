namespace HisPlus.UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtPasswrod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOK);
            this.groupBox1.Controls.Add(this.TxtPasswrod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUserId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 263);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnOK.Location = new System.Drawing.Point(227, 163);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(65, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtPasswrod
            // 
            this.TxtPasswrod.Location = new System.Drawing.Point(192, 113);
            this.TxtPasswrod.Name = "TxtPasswrod";
            this.TxtPasswrod.PasswordChar = '*';
            this.TxtPasswrod.Size = new System.Drawing.Size(100, 20);
            this.TxtPasswrod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Location = new System.Drawing.Point(192, 87);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(100, 20);
            this.TxtUserId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Id:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.Location = new System.Drawing.Point(133, 163);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(65, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 279);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtPasswrod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;

    }
}

