namespace DRIAttendance.Forms
{
    partial class ProfileForm
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
            this.txt_oldPas = new System.Windows.Forms.TextBox();
            this.groubBox = new System.Windows.Forms.GroupBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rePas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newPas = new System.Windows.Forms.TextBox();
            this.groubBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mövcud Parol";
            // 
            // txt_oldPas
            // 
            this.txt_oldPas.Location = new System.Drawing.Point(22, 41);
            this.txt_oldPas.Name = "txt_oldPas";
            this.txt_oldPas.PasswordChar = '*';
            this.txt_oldPas.Size = new System.Drawing.Size(135, 20);
            this.txt_oldPas.TabIndex = 1;
            // 
            // groubBox
            // 
            this.groubBox.Controls.Add(this.btn_Ok);
            this.groubBox.Controls.Add(this.label3);
            this.groubBox.Controls.Add(this.txt_rePas);
            this.groubBox.Controls.Add(this.label2);
            this.groubBox.Controls.Add(this.txt_newPas);
            this.groubBox.Controls.Add(this.label1);
            this.groubBox.Controls.Add(this.txt_oldPas);
            this.groubBox.Location = new System.Drawing.Point(27, 38);
            this.groubBox.Name = "groubBox";
            this.groubBox.Size = new System.Drawing.Size(185, 238);
            this.groubBox.TabIndex = 2;
            this.groubBox.TabStop = false;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(22, 188);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(135, 23);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Təsdiqlə";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parolu Təkrarla";
            // 
            // txt_rePas
            // 
            this.txt_rePas.Location = new System.Drawing.Point(22, 148);
            this.txt_rePas.Name = "txt_rePas";
            this.txt_rePas.PasswordChar = '*';
            this.txt_rePas.Size = new System.Drawing.Size(135, 20);
            this.txt_rePas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Parol";
            // 
            // txt_newPas
            // 
            this.txt_newPas.Location = new System.Drawing.Point(22, 98);
            this.txt_newPas.Name = "txt_newPas";
            this.txt_newPas.PasswordChar = '*';
            this.txt_newPas.Size = new System.Drawing.Size(135, 20);
            this.txt_newPas.TabIndex = 3;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 313);
            this.Controls.Add(this.groubBox);
            this.Name = "ProfileForm";
            this.Text = "Mənim Profilim";
            this.groubBox.ResumeLayout(false);
            this.groubBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_oldPas;
        private System.Windows.Forms.GroupBox groubBox;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rePas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newPas;
    }
}