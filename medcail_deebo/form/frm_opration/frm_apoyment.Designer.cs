namespace medcail_deebo.form.frm_opration
{
    partial class frm_apoyment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_apoyment));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_apoy = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.com_doc_name = new System.Windows.Forms.ComboBox();
            this.com_doc_id = new System.Windows.Forms.ComboBox();
            this.lbl_doc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_date = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_name = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_note = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_coust_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_code = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_apoy_time = new System.Windows.Forms.MaskedTextBox();
            this.com_coust_name = new System.Windows.Forms.ComboBox();
            this.com_coust_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_apoy_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_apoy_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_apoy);
            this.groupControl2.Location = new System.Drawing.Point(487, 45);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(719, 427);
            this.groupControl2.TabIndex = 48;
            this.groupControl2.Text = "جدول الاطباء ";
            // 
            // dgv_apoy
            // 
            this.dgv_apoy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_apoy.Location = new System.Drawing.Point(2, 2);
            this.dgv_apoy.MainView = this.gridView1;
            this.dgv_apoy.Name = "dgv_apoy";
            this.dgv_apoy.Size = new System.Drawing.Size(715, 423);
            this.dgv_apoy.TabIndex = 0;
            this.dgv_apoy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_apoy;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // com_doc_name
            // 
            this.com_doc_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_doc_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_doc_name.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_name.FormattingEnabled = true;
            this.com_doc_name.Items.AddRange(new object[] {
            "فعاله",
            "غير فعاله",
            "غير فعاله موقتا"});
            this.com_doc_name.Location = new System.Drawing.Point(34, 303);
            this.com_doc_name.Name = "com_doc_name";
            this.com_doc_name.Size = new System.Drawing.Size(186, 32);
            this.com_doc_name.TabIndex = 42;
            // 
            // com_doc_id
            // 
            this.com_doc_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_doc_id.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_id.FormattingEnabled = true;
            this.com_doc_id.Items.AddRange(new object[] {
            "فعاله",
            "غير فعاله",
            "غير فعاله موقتا"});
            this.com_doc_id.Location = new System.Drawing.Point(226, 303);
            this.com_doc_id.Name = "com_doc_id";
            this.com_doc_id.Size = new System.Drawing.Size(55, 32);
            this.com_doc_id.TabIndex = 41;
            // 
            // lbl_doc
            // 
            this.lbl_doc.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc.Appearance.Options.UseFont = true;
            this.lbl_doc.Location = new System.Drawing.Point(315, 303);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(54, 22);
            this.lbl_doc.TabIndex = 40;
            this.lbl_doc.Text = "الطبيب ";
            this.lbl_doc.Click += new System.EventHandler(this.lbl_doc_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(319, 219);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 22);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "وقت الموعد";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(320, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 22);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "تاريخ الموعد";
            // 
            // txt_apoy_date
            // 
            this.txt_apoy_date.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_date.Location = new System.Drawing.Point(34, 166);
            this.txt_apoy_date.Name = "txt_apoy_date";
            this.txt_apoy_date.Size = new System.Drawing.Size(247, 30);
            this.txt_apoy_date.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(315, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 22);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "اسم الموعد ";
            // 
            // txt_apoy_name
            // 
            this.txt_apoy_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_apoy_name.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_name.FormattingEnabled = true;
            this.txt_apoy_name.Location = new System.Drawing.Point(34, 123);
            this.txt_apoy_name.Name = "txt_apoy_name";
            this.txt_apoy_name.Size = new System.Drawing.Size(247, 32);
            this.txt_apoy_name.TabIndex = 34;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(325, 260);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 22);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "ملاحضات ";
            // 
            // txt_apoy_note
            // 
            this.txt_apoy_note.Location = new System.Drawing.Point(34, 257);
            this.txt_apoy_note.Name = "txt_apoy_note";
            this.txt_apoy_note.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_note.Properties.Appearance.Options.UseFont = true;
            this.txt_apoy_note.Size = new System.Drawing.Size(247, 28);
            this.txt_apoy_note.TabIndex = 32;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(631, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(154, 22);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "اضافه وتعديل المواعيد";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(1218, 39);
            this.groupControl4.TabIndex = 49;
            this.groupControl4.Text = "groupControl4";
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_clear);
            this.groupControl3.Controls.Add(this.btn_save);
            this.groupControl3.Controls.Add(this.btn_update);
            this.groupControl3.Controls.Add(this.btn_delete);
            this.groupControl3.Location = new System.Drawing.Point(17, 344);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(408, 78);
            this.groupControl3.TabIndex = 30;
            this.groupControl3.Text = "groupControl3";
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
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(288, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 43);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(191, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 43);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_coust_name
            // 
            this.lbl_coust_name.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coust_name.Appearance.Options.UseFont = true;
            this.lbl_coust_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbl_coust_name.LineVisible = true;
            this.lbl_coust_name.Location = new System.Drawing.Point(312, 49);
            this.lbl_coust_name.Name = "lbl_coust_name";
            this.lbl_coust_name.Size = new System.Drawing.Size(86, 22);
            this.lbl_coust_name.TabIndex = 11;
            this.lbl_coust_name.Text = "اسم المريض";
            this.lbl_coust_name.Click += new System.EventHandler(this.lbl_coust_name_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(317, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "كود الموعد ";
            // 
            // txt_apoy_code
            // 
            this.txt_apoy_code.Enabled = false;
            this.txt_apoy_code.Location = new System.Drawing.Point(34, 87);
            this.txt_apoy_code.Name = "txt_apoy_code";
            this.txt_apoy_code.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_code.Properties.Appearance.Options.UseFont = true;
            this.txt_apoy_code.Size = new System.Drawing.Size(247, 28);
            this.txt_apoy_code.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("gulf", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txt_apoy_time);
            this.groupControl1.Controls.Add(this.com_coust_name);
            this.groupControl1.Controls.Add(this.com_coust_id);
            this.groupControl1.Controls.Add(this.com_doc_name);
            this.groupControl1.Controls.Add(this.com_doc_id);
            this.groupControl1.Controls.Add(this.lbl_doc);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_apoy_date);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_apoy_name);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_apoy_note);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.lbl_coust_name);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_apoy_code);
            this.groupControl1.Location = new System.Drawing.Point(14, 46);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 427);
            this.groupControl1.TabIndex = 47;
            this.groupControl1.Text = "بيانات الموعد ";
            // 
            // txt_apoy_time
            // 
            this.txt_apoy_time.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.txt_apoy_time.Location = new System.Drawing.Point(34, 210);
            this.txt_apoy_time.Mask = "90:00";
            this.txt_apoy_time.Name = "txt_apoy_time";
            this.txt_apoy_time.Size = new System.Drawing.Size(247, 31);
            this.txt_apoy_time.TabIndex = 45;
            this.txt_apoy_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apoy_time.ValidatingType = typeof(System.DateTime);
            // 
            // com_coust_name
            // 
            this.com_coust_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_coust_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_coust_name.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_coust_name.FormattingEnabled = true;
            this.com_coust_name.Items.AddRange(new object[] {
            "فعاله",
            "غير فعاله",
            "غير فعاله موقتا"});
            this.com_coust_name.Location = new System.Drawing.Point(34, 49);
            this.com_coust_name.Name = "com_coust_name";
            this.com_coust_name.Size = new System.Drawing.Size(186, 32);
            this.com_coust_name.TabIndex = 44;
            // 
            // com_coust_id
            // 
            this.com_coust_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_coust_id.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_coust_id.FormattingEnabled = true;
            this.com_coust_id.Items.AddRange(new object[] {
            "فعاله",
            "غير فعاله",
            "غير فعاله موقتا"});
            this.com_coust_id.Location = new System.Drawing.Point(226, 49);
            this.com_coust_id.Name = "com_coust_id";
            this.com_coust_id.Size = new System.Drawing.Size(55, 32);
            this.com_coust_id.TabIndex = 43;
            // 
            // frm_apoyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 489);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_apoyment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_apoyment";
            this.Load += new System.EventHandler(this.frm_apoyment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_apoy_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_apoy_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox com_doc_name;
        private System.Windows.Forms.ComboBox com_doc_id;
        private DevExpress.XtraEditors.LabelControl lbl_doc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker txt_apoy_date;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox txt_apoy_name;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_apoy_note;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.LabelControl lbl_coust_name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_apoy_code;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox com_coust_name;
        private System.Windows.Forms.ComboBox com_coust_id;
        private System.Windows.Forms.MaskedTextBox txt_apoy_time;
        private DevExpress.XtraGrid.GridControl dgv_apoy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}