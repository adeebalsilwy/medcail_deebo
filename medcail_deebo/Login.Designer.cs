namespace medcail_deebo
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.com_clinc_name = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.com_pass = new DevExpress.XtraEditors.TextEdit();
            this.com_user_name = new System.Windows.Forms.ComboBox();
            this.com_type = new System.Windows.Forms.ComboBox();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.com_clinc_name);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.com_pass);
            this.groupControl1.Controls.Add(this.com_user_name);
            this.groupControl1.Controls.Add(this.com_type);
            this.groupControl1.Controls.Add(this.btn_login);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(657, 324);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات تسجيل الدخول ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(5, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(39, 36);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Mj_Najm Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(243, 250);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(206, 30);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "برنامج اداره العيادات الطبيه ";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // com_clinc_name
            // 
            this.com_clinc_name.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.com_clinc_name.FormattingEnabled = true;
            this.com_clinc_name.Location = new System.Drawing.Point(229, 54);
            this.com_clinc_name.Name = "com_clinc_name";
            this.com_clinc_name.Size = new System.Drawing.Size(255, 34);
            this.com_clinc_name.TabIndex = 13;
            this.com_clinc_name.SelectedIndexChanged += new System.EventHandler(this.com_clinc_name_SelectedIndexChanged);
            this.com_clinc_name.SelectionChangeCommitted += new System.EventHandler(this.com_clinc_name_SelectionChangeCommitted);
            this.com_clinc_name.SelectedValueChanged += new System.EventHandler(this.com_clinc_name_SelectedValueChanged);
            this.com_clinc_name.TextChanged += new System.EventHandler(this.com_clinc_name_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(520, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 26);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "اسم العياده";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // com_pass
            // 
            this.com_pass.Location = new System.Drawing.Point(229, 155);
            this.com_pass.Name = "com_pass";
            this.com_pass.Properties.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.com_pass.Properties.Appearance.Options.UseFont = true;
            this.com_pass.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.com_pass.Properties.AppearanceDisabled.Options.UseFont = true;
            this.com_pass.Properties.UseSystemPasswordChar = true;
            this.com_pass.Size = new System.Drawing.Size(255, 32);
            this.com_pass.TabIndex = 11;
            this.com_pass.EditValueChanged += new System.EventHandler(this.com_pass_EditValueChanged);
            // 
            // com_user_name
            // 
            this.com_user_name.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.com_user_name.FormattingEnabled = true;
            this.com_user_name.Location = new System.Drawing.Point(229, 101);
            this.com_user_name.Name = "com_user_name";
            this.com_user_name.Size = new System.Drawing.Size(255, 34);
            this.com_user_name.TabIndex = 10;
            this.com_user_name.SelectedIndexChanged += new System.EventHandler(this.com_user_name_SelectedIndexChanged);
            // 
            // com_type
            // 
            this.com_type.Enabled = false;
            this.com_type.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.com_type.FormattingEnabled = true;
            this.com_type.Location = new System.Drawing.Point(229, 210);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(255, 34);
            this.com_type.TabIndex = 8;
            this.com_type.SelectedIndexChanged += new System.EventHandler(this.com_type_SelectedIndexChanged);
            // 
            // btn_login
            // 
            this.btn_login.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_login.Appearance.Options.UseFont = true;
            this.btn_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.ImageOptions.Image")));
            this.btn_login.Location = new System.Drawing.Point(23, 220);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_login.Size = new System.Drawing.Size(168, 34);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "تسجيل الدخول ";
            this.btn_login.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::medcail_deebo.Properties.Resources.icons8_man_with_beard_in_suit_50px;
            this.pictureEdit1.Location = new System.Drawing.Point(23, 54);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 300D;
            this.pictureEdit1.Size = new System.Drawing.Size(168, 153);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(503, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 26);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "نوع المستخدم";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(536, 168);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 26);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "كلمه السر";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sultan  koufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(503, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المستخدم";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 291);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox com_type;
        private System.Windows.Forms.ComboBox com_user_name;
        private DevExpress.XtraEditors.TextEdit com_pass;
        private System.Windows.Forms.ComboBox com_clinc_name;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

