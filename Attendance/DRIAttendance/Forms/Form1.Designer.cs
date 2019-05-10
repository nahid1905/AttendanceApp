namespace DRIAttendance
{
    partial class Dashboard
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
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbAttendance = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Davamiyyət = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_position = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad, Soyad";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(24, 126);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(180, 21);
            this.cmbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vəzifə";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(24, 70);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(180, 21);
            this.cmbPosition.TabIndex = 2;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // cmbAttendance
            // 
            this.cmbAttendance.FormattingEnabled = true;
            this.cmbAttendance.Items.AddRange(new object[] {
            "Bəli",
            "Xeyr"});
            this.cmbAttendance.Location = new System.Drawing.Point(24, 183);
            this.cmbAttendance.Name = "cmbAttendance";
            this.cmbAttendance.Size = new System.Drawing.Size(180, 21);
            this.cmbAttendance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşə gəlib?";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(24, 222);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Təsdiq Et";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "İşçi əlavə et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Davamiyyət
            // 
            this.Davamiyyət.FormattingEnabled = true;
            this.Davamiyyət.Location = new System.Drawing.Point(228, 63);
            this.Davamiyyət.Name = "Davamiyyət";
            this.Davamiyyət.Size = new System.Drawing.Size(277, 329);
            this.Davamiyyət.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(378, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Göndər";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(114, 398);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(90, 23);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "Ayarlar";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Location = new System.Drawing.Point(24, 356);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(180, 23);
            this.btn_profile.TabIndex = 11;
            this.btn_profile.Text = "Parolu Yenilə";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(24, 317);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "İşçi sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_position
            // 
            this.btn_position.Location = new System.Drawing.Point(24, 398);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(84, 23);
            this.btn_position.TabIndex = 14;
            this.btn_position.Text = "Vəzifələr";
            this.btn_position.UseVisualStyleBackColor = true;
            this.btn_position.Click += new System.EventHandler(this.btn_position_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 465);
            this.Controls.Add(this.btn_position);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Davamiyyət);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbAttendance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Əsas səhifə";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbAttendance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox Davamiyyət;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_position;
    }
}

