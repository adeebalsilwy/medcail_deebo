namespace medcail_deebo.form.frm_opration
{
    partial class frm_customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_customer));
            this.dgv_customer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_search_coust = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_coust_state = new System.Windows.Forms.ComboBox();
            this.com_card_id = new System.Windows.Forms.ComboBox();
            this.txt_coust_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_coust_age = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_phone1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_coust_code = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.com_card_name = new System.Windows.Forms.ComboBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_card = new DevExpress.XtraEditors.LabelControl();
            this.txt_coust_note = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_fname = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_sname = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_tname = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_phone2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_coust_lname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_coust.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_phone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_fname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_sname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_tname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_phone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_lname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_customer.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.dgv_customer.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgv_customer.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgv_customer.GridControl = this.GridControl1;
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgv_customer_RowClick);
            this.dgv_customer.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgv_customer_RowCellClick);
            this.dgv_customer.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.dgv_customer_SelectionChanged);
            this.dgv_customer.DoubleClick += new System.EventHandler(this.dgv_customer_DoubleClick);
            // 
            // GridControl1
            // 
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1.Location = new System.Drawing.Point(2, 2);
            this.GridControl1.MainView = this.dgv_customer;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(638, 504);
            this.GridControl1.TabIndex = 30;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_customer});
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_clear);
            this.groupControl3.Controls.Add(this.btn_save);
            this.groupControl3.Controls.Add(this.btn_update);
            this.groupControl3.Controls.Add(this.btn_delete);
            this.groupControl3.Location = new System.Drawing.Point(60, 403);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(429, 78);
            this.groupControl3.TabIndex = 30;
            this.groupControl3.Text = "groupControl3";
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(17, 20);
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
            this.btn_save.Location = new System.Drawing.Point(321, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 43);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(222, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 43);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(110, 20);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 43);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.pictureEdit1);
            this.groupControl2.Controls.Add(this.txt_search_coust);
            this.groupControl2.Controls.Add(this.GridControl1);
            this.groupControl2.Location = new System.Drawing.Point(566, 32);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(642, 508);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "جدول الاطباء ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(608, 8);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 22);
            this.labelControl10.TabIndex = 33;
            this.labelControl10.Text = "بحث";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(650, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(68, 33);
            this.pictureEdit1.TabIndex = 32;
            // 
            // txt_search_coust
            // 
            this.txt_search_coust.Location = new System.Drawing.Point(306, 5);
            this.txt_search_coust.Name = "txt_search_coust";
            this.txt_search_coust.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_coust.Properties.Appearance.Options.UseFont = true;
            this.txt_search_coust.Size = new System.Drawing.Size(296, 28);
            this.txt_search_coust.TabIndex = 31;
            this.txt_search_coust.EditValueChanged += new System.EventHandler(this.txt_search_coust_EditValueChanged);
            this.txt_search_coust.TextChanged += new System.EventHandler(this.txt_search_coust_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(387, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(153, 22);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "اضافه وتعديل المرضى ";
            // 
            // txt_coust_state
            // 
            this.txt_coust_state.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_state.FormattingEnabled = true;
            this.txt_coust_state.Items.AddRange(new object[] {
            "مؤمن",
            "غير مؤمن "});
            this.txt_coust_state.Location = new System.Drawing.Point(102, 261);
            this.txt_coust_state.Name = "txt_coust_state";
            this.txt_coust_state.Size = new System.Drawing.Size(264, 30);
            this.txt_coust_state.TabIndex = 25;
            this.txt_coust_state.SelectedValueChanged += new System.EventHandler(this.txt_coust_state_SelectedValueChanged);
            // 
            // com_card_id
            // 
            this.com_card_id.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_card_id.FormattingEnabled = true;
            this.com_card_id.Location = new System.Drawing.Point(286, 341);
            this.com_card_id.Name = "com_card_id";
            this.com_card_id.Size = new System.Drawing.Size(80, 30);
            this.com_card_id.TabIndex = 24;
            // 
            // txt_coust_birth
            // 
            this.txt_coust_birth.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_birth.Location = new System.Drawing.Point(102, 157);
            this.txt_coust_birth.Name = "txt_coust_birth";
            this.txt_coust_birth.Size = new System.Drawing.Size(264, 30);
            this.txt_coust_birth.TabIndex = 23;
            // 
            // txt_coust_age
            // 
            this.txt_coust_age.Location = new System.Drawing.Point(102, 114);
            this.txt_coust_age.Name = "txt_coust_age";
            this.txt_coust_age.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_age.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_age.Size = new System.Drawing.Size(264, 28);
            this.txt_coust_age.TabIndex = 21;
            // 
            // txt_coust_address
            // 
            this.txt_coust_address.Location = new System.Drawing.Point(102, 227);
            this.txt_coust_address.Name = "txt_coust_address";
            this.txt_coust_address.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_address.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_address.Size = new System.Drawing.Size(264, 28);
            this.txt_coust_address.TabIndex = 19;
            // 
            // txt_coust_phone1
            // 
            this.txt_coust_phone1.Location = new System.Drawing.Point(192, 193);
            this.txt_coust_phone1.Name = "txt_coust_phone1";
            this.txt_coust_phone1.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_phone1.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_phone1.Size = new System.Drawing.Size(174, 28);
            this.txt_coust_phone1.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(403, 269);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 22);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "حاله التامين ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(433, 227);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 22);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "العنوان";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(410, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 22);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "رقم الهاتف";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(403, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 22);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "تاريخ الميلاد ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(420, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 22);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "العمر";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(403, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 22);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "اسم المريض";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(407, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "كود المريض ";
            // 
            // txt_coust_code
            // 
            this.txt_coust_code.Enabled = false;
            this.txt_coust_code.Location = new System.Drawing.Point(102, 43);
            this.txt_coust_code.Name = "txt_coust_code";
            this.txt_coust_code.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_code.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_code.Size = new System.Drawing.Size(264, 28);
            this.txt_coust_code.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("gulf", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.com_card_name);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.lbl_card);
            this.groupControl1.Controls.Add(this.txt_coust_note);
            this.groupControl1.Controls.Add(this.txt_coust_fname);
            this.groupControl1.Controls.Add(this.txt_coust_sname);
            this.groupControl1.Controls.Add(this.txt_coust_tname);
            this.groupControl1.Controls.Add(this.com_card_id);
            this.groupControl1.Controls.Add(this.txt_coust_phone2);
            this.groupControl1.Controls.Add(this.txt_coust_lname);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.txt_coust_state);
            this.groupControl1.Controls.Add(this.txt_coust_birth);
            this.groupControl1.Controls.Add(this.txt_coust_age);
            this.groupControl1.Controls.Add(this.txt_coust_address);
            this.groupControl1.Controls.Add(this.txt_coust_phone1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_coust_code);
            this.groupControl1.Location = new System.Drawing.Point(14, 32);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(526, 508);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "بيانات المريض";
            // 
            // com_card_name
            // 
            this.com_card_name.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_card_name.FormattingEnabled = true;
            this.com_card_name.Location = new System.Drawing.Point(102, 341);
            this.com_card_name.Name = "com_card_name";
            this.com_card_name.Size = new System.Drawing.Size(170, 30);
            this.com_card_name.TabIndex = 42;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(394, 303);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(67, 22);
            this.labelControl13.TabIndex = 41;
            this.labelControl13.Text = "ملاحضات ";
            // 
            // lbl_card
            // 
            this.lbl_card.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card.Appearance.Options.UseFont = true;
            this.lbl_card.Location = new System.Drawing.Point(394, 349);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(95, 22);
            this.lbl_card.TabIndex = 40;
            this.lbl_card.Text = "بطاقه التامين ";
            this.lbl_card.Click += new System.EventHandler(this.labelControl12_Click);
            // 
            // txt_coust_note
            // 
            this.txt_coust_note.Location = new System.Drawing.Point(102, 297);
            this.txt_coust_note.Name = "txt_coust_note";
            this.txt_coust_note.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_note.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_note.Size = new System.Drawing.Size(264, 28);
            this.txt_coust_note.TabIndex = 38;
            // 
            // txt_coust_fname
            // 
            this.txt_coust_fname.Location = new System.Drawing.Point(282, 80);
            this.txt_coust_fname.Name = "txt_coust_fname";
            this.txt_coust_fname.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_fname.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_fname.Size = new System.Drawing.Size(84, 28);
            this.txt_coust_fname.TabIndex = 37;
            this.txt_coust_fname.EditValueChanged += new System.EventHandler(this.txt_coust_fname_EditValueChanged);
            this.txt_coust_fname.TextChanged += new System.EventHandler(this.txt_coust_fname_TextChanged);
            // 
            // txt_coust_sname
            // 
            this.txt_coust_sname.Location = new System.Drawing.Point(192, 80);
            this.txt_coust_sname.Name = "txt_coust_sname";
            this.txt_coust_sname.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_sname.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_sname.Size = new System.Drawing.Size(84, 28);
            this.txt_coust_sname.TabIndex = 36;
            this.txt_coust_sname.TextChanged += new System.EventHandler(this.txt_coust_sname_TextChanged);
            // 
            // txt_coust_tname
            // 
            this.txt_coust_tname.Location = new System.Drawing.Point(102, 80);
            this.txt_coust_tname.Name = "txt_coust_tname";
            this.txt_coust_tname.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_tname.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_tname.Size = new System.Drawing.Size(84, 28);
            this.txt_coust_tname.TabIndex = 35;
            this.txt_coust_tname.EditValueChanged += new System.EventHandler(this.txt_coust_tname_EditValueChanged);
            // 
            // txt_coust_phone2
            // 
            this.txt_coust_phone2.Location = new System.Drawing.Point(5, 193);
            this.txt_coust_phone2.Name = "txt_coust_phone2";
            this.txt_coust_phone2.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_phone2.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_phone2.Size = new System.Drawing.Size(181, 28);
            this.txt_coust_phone2.TabIndex = 34;
            // 
            // txt_coust_lname
            // 
            this.txt_coust_lname.Location = new System.Drawing.Point(5, 78);
            this.txt_coust_lname.Name = "txt_coust_lname";
            this.txt_coust_lname.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coust_lname.Properties.Appearance.Options.UseFont = true;
            this.txt_coust_lname.Size = new System.Drawing.Size(84, 28);
            this.txt_coust_lname.TabIndex = 33;
            this.txt_coust_lname.EditValueChanged += new System.EventHandler(this.txt_coust_lname_EditValueChanged);
            // 
            // frm_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 568);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_customer";
            this.Load += new System.EventHandler(this.frm_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_coust.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_phone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_fname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_sname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_tname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_phone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_coust_lname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView dgv_customer;
        private DevExpress.XtraGrid.GridControl GridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox txt_coust_state;
        private System.Windows.Forms.ComboBox com_card_id;
        private System.Windows.Forms.DateTimePicker txt_coust_birth;
        private DevExpress.XtraEditors.TextEdit txt_coust_age;
        private DevExpress.XtraEditors.TextEdit txt_coust_address;
        private DevExpress.XtraEditors.TextEdit txt_coust_phone1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_coust_code;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txt_search_coust;
        private System.Windows.Forms.ComboBox com_card_name;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lbl_card;
        private DevExpress.XtraEditors.TextEdit txt_coust_note;
        private DevExpress.XtraEditors.TextEdit txt_coust_fname;
        private DevExpress.XtraEditors.TextEdit txt_coust_sname;
        private DevExpress.XtraEditors.TextEdit txt_coust_tname;
        private DevExpress.XtraEditors.TextEdit txt_coust_phone2;
        private DevExpress.XtraEditors.TextEdit txt_coust_lname;
    }
}