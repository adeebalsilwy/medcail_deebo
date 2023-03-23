namespace medcail_deebo.form
{
    partial class frm_doctoer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doctoer));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.com_user_name = new System.Windows.Forms.ComboBox();
            this.com_user_id = new System.Windows.Forms.ComboBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_doc_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_doc_mag = new DevExpress.XtraEditors.TextEdit();
            this.txt_doc_exp = new DevExpress.XtraEditors.TextEdit();
            this.txt_doc_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_doc_phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_doc_cod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_doc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_mag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_exp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_cod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("gulf", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.com_user_name);
            this.groupControl1.Controls.Add(this.com_user_id);
            this.groupControl1.Controls.Add(this.dtp_birth);
            this.groupControl1.Controls.Add(this.txt_doc_name);
            this.groupControl1.Controls.Add(this.txt_doc_mag);
            this.groupControl1.Controls.Add(this.txt_doc_exp);
            this.groupControl1.Controls.Add(this.txt_doc_address);
            this.groupControl1.Controls.Add(this.txt_doc_phone);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_doc_cod);
            this.groupControl1.Location = new System.Drawing.Point(14, 29);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 431);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الطبيب";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(198, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 43);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(5, 20);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 43);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "مسح";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(96, 20);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 43);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(299, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 43);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // com_user_name
            // 
            this.com_user_name.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_user_name.FormattingEnabled = true;
            this.com_user_name.Location = new System.Drawing.Point(34, 302);
            this.com_user_name.Name = "com_user_name";
            this.com_user_name.Size = new System.Drawing.Size(161, 30);
            this.com_user_name.TabIndex = 25;
            // 
            // com_user_id
            // 
            this.com_user_id.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_user_id.FormattingEnabled = true;
            this.com_user_id.Location = new System.Drawing.Point(201, 302);
            this.com_user_id.Name = "com_user_id";
            this.com_user_id.Size = new System.Drawing.Size(80, 30);
            this.com_user_id.TabIndex = 24;
            // 
            // dtp_birth
            // 
            this.dtp_birth.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birth.Location = new System.Drawing.Point(34, 174);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(247, 30);
            this.dtp_birth.TabIndex = 23;
            // 
            // txt_doc_name
            // 
            this.txt_doc_name.Location = new System.Drawing.Point(34, 78);
            this.txt_doc_name.Name = "txt_doc_name";
            this.txt_doc_name.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_name.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_name.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_name.TabIndex = 22;
            // 
            // txt_doc_mag
            // 
            this.txt_doc_mag.Location = new System.Drawing.Point(34, 110);
            this.txt_doc_mag.Name = "txt_doc_mag";
            this.txt_doc_mag.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_mag.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_mag.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_mag.TabIndex = 21;
            // 
            // txt_doc_exp
            // 
            this.txt_doc_exp.Location = new System.Drawing.Point(34, 142);
            this.txt_doc_exp.Name = "txt_doc_exp";
            this.txt_doc_exp.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_exp.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_exp.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_exp.TabIndex = 20;
            // 
            // txt_doc_address
            // 
            this.txt_doc_address.Location = new System.Drawing.Point(34, 256);
            this.txt_doc_address.Name = "txt_doc_address";
            this.txt_doc_address.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_address.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_address.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_address.TabIndex = 19;
            // 
            // txt_doc_phone
            // 
            this.txt_doc_phone.Location = new System.Drawing.Point(34, 217);
            this.txt_doc_phone.Name = "txt_doc_phone";
            this.txt_doc_phone.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_phone.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_phone.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_phone.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(287, 310);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 22);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "اسم المستخدم";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(334, 255);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 22);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "العنوان";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(314, 216);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 22);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "رقم الهاتف";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(305, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 22);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "تاريخ الميلاد ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(345, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 22);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "الخبره";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(322, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 22);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "التخصص";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(305, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 22);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "اسم الطبيب";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(309, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "كود الطبيب ";
            // 
            // txt_doc_cod
            // 
            this.txt_doc_cod.Enabled = false;
            this.txt_doc_cod.Location = new System.Drawing.Point(34, 46);
            this.txt_doc_cod.Name = "txt_doc_cod";
            this.txt_doc_cod.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_cod.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_cod.Size = new System.Drawing.Size(247, 28);
            this.txt_doc_cod.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(436, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(192, 22);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "شاشة اضافه وتعديل الاطباء";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_doc);
            this.groupControl2.Location = new System.Drawing.Point(479, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(608, 432);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "جدول الاطباء ";
            // 
            // dgv_doc
            // 
            this.dgv_doc.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_doc.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_doc.Location = new System.Drawing.Point(2, 2);
            this.dgv_doc.MainView = this.gridView1;
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.Size = new System.Drawing.Size(604, 428);
            this.dgv_doc.TabIndex = 30;
            this.dgv_doc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_doc.Click += new System.EventHandler(this.dgv_doc_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.dgv_doc;
            this.gridView1.Name = "gridView1";
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_clear);
            this.groupControl3.Controls.Add(this.btn_save);
            this.groupControl3.Controls.Add(this.btn_update);
            this.groupControl3.Controls.Add(this.btn_delete);
            this.groupControl3.Location = new System.Drawing.Point(23, 338);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(408, 78);
            this.groupControl3.TabIndex = 30;
            this.groupControl3.Text = "groupControl3";
            // 
            // frm_doctoer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 467);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("gulf", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frm_doctoer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهه الاطباء";
            this.Load += new System.EventHandler(this.frm_doctoer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_mag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_exp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_cod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox com_user_name;
        private System.Windows.Forms.ComboBox com_user_id;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private DevExpress.XtraEditors.TextEdit txt_doc_name;
        private DevExpress.XtraEditors.TextEdit txt_doc_mag;
        private DevExpress.XtraEditors.TextEdit txt_doc_exp;
        private DevExpress.XtraEditors.TextEdit txt_doc_address;
        private DevExpress.XtraEditors.TextEdit txt_doc_phone;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_doc_cod;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_doc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}