namespace medcail_deebo.form.fm_med
{
    partial class frm_medcin_menucs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medcin_menucs));
            this.lbl_total = new DevExpress.XtraEditors.LabelControl();
            this.lbl_coust_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grb_dag = new System.Windows.Forms.GroupBox();
            this.dgv_medc = new DevExpress.XtraGrid.GridControl();
            this.grid_all_medcin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.grb_vist = new System.Windows.Forms.GroupBox();
            this.dgv_vist_med_req = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_mor_using = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new_dagno = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.com_doc_time = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.com_doc_count = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_doc_gend = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.com_doc_larg = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grb_dag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_medcin)).BeginInit();
            this.grb_vist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_med_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Appearance.Options.UseFont = true;
            this.lbl_total.LineVisible = true;
            this.lbl_total.Location = new System.Drawing.Point(160, 13);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(52, 22);
            this.lbl_total.TabIndex = 42;
            this.lbl_total.Text = "المريض";
            // 
            // lbl_coust_name
            // 
            this.lbl_coust_name.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coust_name.Appearance.Options.UseFont = true;
            this.lbl_coust_name.LineVisible = true;
            this.lbl_coust_name.Location = new System.Drawing.Point(520, 13);
            this.lbl_coust_name.Name = "lbl_coust_name";
            this.lbl_coust_name.Size = new System.Drawing.Size(52, 22);
            this.lbl_coust_name.TabIndex = 41;
            this.lbl_coust_name.Text = "المريض";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(713, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(117, 22);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "الادويه  الخاص ب ";
            // 
            // grb_dag
            // 
            this.grb_dag.Controls.Add(this.dgv_medc);
            this.grb_dag.Location = new System.Drawing.Point(12, 110);
            this.grb_dag.Name = "grb_dag";
            this.grb_dag.Size = new System.Drawing.Size(594, 324);
            this.grb_dag.TabIndex = 16;
            this.grb_dag.TabStop = false;
            this.grb_dag.Text = "قائمه الادويه ";
            // 
            // dgv_medc
            // 
            this.dgv_medc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_medc.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_medc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_medc.Location = new System.Drawing.Point(3, 17);
            this.dgv_medc.MainView = this.grid_all_medcin;
            this.dgv_medc.Name = "dgv_medc";
            this.dgv_medc.Size = new System.Drawing.Size(588, 304);
            this.dgv_medc.TabIndex = 5;
            this.dgv_medc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_all_medcin});
            // 
            // grid_all_medcin
            // 
            this.grid_all_medcin.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grid_all_medcin.Appearance.OddRow.Options.UseBackColor = true;
            this.grid_all_medcin.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.grid_all_medcin.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grid_all_medcin.Appearance.TopNewRow.BackColor = System.Drawing.Color.Lime;
            this.grid_all_medcin.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grid_all_medcin.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.grid_all_medcin.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grid_all_medcin.GridControl = this.dgv_medc;
            this.grid_all_medcin.Name = "grid_all_medcin";
            this.grid_all_medcin.OptionsView.EnableAppearanceOddRow = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(266, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(126, 37);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "الفحص الحالي";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(398, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(141, 37);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "فحوصات سابقه ";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(6, 8);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(130, 37);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "حذف الكل ";
            // 
            // grb_vist
            // 
            this.grb_vist.Controls.Add(this.dgv_vist_med_req);
            this.grb_vist.Location = new System.Drawing.Point(626, 201);
            this.grb_vist.Name = "grb_vist";
            this.grb_vist.Size = new System.Drawing.Size(554, 233);
            this.grb_vist.TabIndex = 17;
            this.grb_vist.TabStop = false;
            this.grb_vist.Text = "الفحوصات في الزياره ";
            // 
            // dgv_vist_med_req
            // 
            this.dgv_vist_med_req.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vist_med_req.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_vist_med_req.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_vist_med_req.Location = new System.Drawing.Point(3, 17);
            this.dgv_vist_med_req.MainView = this.gridView1;
            this.dgv_vist_med_req.Name = "dgv_vist_med_req";
            this.dgv_vist_med_req.Size = new System.Drawing.Size(548, 213);
            this.dgv_vist_med_req.TabIndex = 5;
            this.dgv_vist_med_req.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_vist_med_req;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(142, 10);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(87, 37);
            this.simpleButton5.TabIndex = 7;
            this.simpleButton5.Text = "حذف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton4);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton5);
            this.groupBox2.Location = new System.Drawing.Point(635, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 55);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.lbl_coust_name);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 41);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(6, 14);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(130, 37);
            this.simpleButton6.TabIndex = 8;
            this.simpleButton6.Text = "طباعه ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(301, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 37);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "قائمه الفحوصات ";
            // 
            // btn_mor_using
            // 
            this.btn_mor_using.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mor_using.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_mor_using.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mor_using.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_mor_using.Appearance.Options.UseBackColor = true;
            this.btn_mor_using.Appearance.Options.UseFont = true;
            this.btn_mor_using.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_mor_using.ImageOptions.Image")));
            this.btn_mor_using.Location = new System.Drawing.Point(165, 14);
            this.btn_mor_using.Name = "btn_mor_using";
            this.btn_mor_using.Size = new System.Drawing.Size(130, 37);
            this.btn_mor_using.TabIndex = 6;
            this.btn_mor_using.Text = "الاكثر استخداما ";
            this.btn_mor_using.Click += new System.EventHandler(this.btn_mor_using_Click);
            // 
            // btn_new_dagno
            // 
            this.btn_new_dagno.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_new_dagno.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_new_dagno.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_dagno.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_new_dagno.Appearance.Options.UseBackColor = true;
            this.btn_new_dagno.Appearance.Options.UseFont = true;
            this.btn_new_dagno.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_dagno.ImageOptions.Image")));
            this.btn_new_dagno.Location = new System.Drawing.Point(454, 14);
            this.btn_new_dagno.Name = "btn_new_dagno";
            this.btn_new_dagno.Size = new System.Drawing.Size(130, 37);
            this.btn_new_dagno.TabIndex = 4;
            this.btn_new_dagno.Text = "دواء جديد ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton6);
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Controls.Add(this.btn_mor_using);
            this.groupBox3.Controls.Add(this.btn_new_dagno);
            this.groupBox3.Location = new System.Drawing.Point(15, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 55);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.simpleButton7);
            this.groupBox4.Controls.Add(this.com_doc_time);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.com_doc_count);
            this.groupBox4.Controls.Add(this.labelControl2);
            this.groupBox4.Controls.Add(this.com_doc_gend);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Controls.Add(this.com_doc_larg);
            this.groupBox4.Controls.Add(this.labelControl8);
            this.groupBox4.Location = new System.Drawing.Point(632, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 89);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الجرعه ";
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(50, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 32);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "تعديل";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(50, 52);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(83, 32);
            this.simpleButton7.TabIndex = 10;
            this.simpleButton7.Text = "حذف";
            // 
            // com_doc_time
            // 
            this.com_doc_time.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_time.FormattingEnabled = true;
            this.com_doc_time.Location = new System.Drawing.Point(161, 53);
            this.com_doc_time.Name = "com_doc_time";
            this.com_doc_time.Size = new System.Drawing.Size(111, 30);
            this.com_doc_time.TabIndex = 23;
            this.com_doc_time.Tag = "الوقت ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(278, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 22);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "الوقت ";
            // 
            // com_doc_count
            // 
            this.com_doc_count.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_count.FormattingEnabled = true;
            this.com_doc_count.Location = new System.Drawing.Point(347, 53);
            this.com_doc_count.Name = "com_doc_count";
            this.com_doc_count.Size = new System.Drawing.Size(127, 30);
            this.com_doc_count.TabIndex = 21;
            this.com_doc_count.Tag = "العدد";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(480, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 22);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "العدد";
            // 
            // com_doc_gend
            // 
            this.com_doc_gend.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_gend.FormattingEnabled = true;
            this.com_doc_gend.Location = new System.Drawing.Point(161, 17);
            this.com_doc_gend.Name = "com_doc_gend";
            this.com_doc_gend.Size = new System.Drawing.Size(111, 30);
            this.com_doc_gend.TabIndex = 19;
            this.com_doc_gend.Tag = "النوع ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(278, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 22);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "النوع ";
            // 
            // com_doc_larg
            // 
            this.com_doc_larg.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_larg.FormattingEnabled = true;
            this.com_doc_larg.Location = new System.Drawing.Point(347, 17);
            this.com_doc_larg.Name = "com_doc_larg";
            this.com_doc_larg.Size = new System.Drawing.Size(127, 30);
            this.com_doc_larg.TabIndex = 17;
            this.com_doc_larg.Tag = "الكميه ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(480, 20);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 22);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "الكميه ";
            // 
            // frm_medcin_menucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 438);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grb_dag);
            this.Controls.Add(this.grb_vist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_medcin_menucs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمه صرف الادويه ";
            this.Load += new System.EventHandler(this.frm_medcin_menucs_Load);
            this.grb_dag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_medcin)).EndInit();
            this.grb_vist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_med_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_total;
        private DevExpress.XtraEditors.LabelControl lbl_coust_name;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.GroupBox grb_dag;
        private DevExpress.XtraGrid.GridControl dgv_medc;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_all_medcin;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox grb_vist;
        private DevExpress.XtraGrid.GridControl dgv_vist_med_req;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_mor_using;
        private DevExpress.XtraEditors.SimpleButton btn_new_dagno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.ComboBox com_doc_time;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox com_doc_count;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox com_doc_gend;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox com_doc_larg;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_update;
    }
}