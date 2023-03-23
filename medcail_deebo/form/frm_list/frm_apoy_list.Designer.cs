namespace medcail_deebo.form.frm_list
{
    partial class frm_apoy_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_apoy_list));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_to_date = new System.Windows.Forms.DateTimePicker();
            this.com_coust_name = new System.Windows.Forms.ComboBox();
            this.com_coust_id = new System.Windows.Forms.ComboBox();
            this.com_doc_name = new System.Windows.Forms.ComboBox();
            this.com_doc_id = new System.Windows.Forms.ComboBox();
            this.lbl_doc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_apoy_s_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_coust_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgv_apoy = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("gulf", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_search);
            this.groupControl1.Controls.Add(this.btn_print);
            this.groupControl1.Controls.Add(this.btn_clear);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_apoy_to_date);
            this.groupControl1.Controls.Add(this.com_coust_name);
            this.groupControl1.Controls.Add(this.com_coust_id);
            this.groupControl1.Controls.Add(this.com_doc_name);
            this.groupControl1.Controls.Add(this.com_doc_id);
            this.groupControl1.Controls.Add(this.lbl_doc);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_apoy_s_date);
            this.groupControl1.Controls.Add(this.lbl_coust_name);
            this.groupControl1.Location = new System.Drawing.Point(14, 64);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 133);
            this.groupControl1.TabIndex = 48;
            this.groupControl1.Text = "بيانات الموعد ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(447, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 22);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "الى تاريخ ";
            // 
            // txt_apoy_to_date
            // 
            this.txt_apoy_to_date.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_to_date.Location = new System.Drawing.Point(194, 88);
            this.txt_apoy_to_date.Name = "txt_apoy_to_date";
            this.txt_apoy_to_date.Size = new System.Drawing.Size(247, 30);
            this.txt_apoy_to_date.TabIndex = 45;
            this.txt_apoy_to_date.ValueChanged += new System.EventHandler(this.txt_apoy_to_date_ValueChanged);
            // 
            // com_coust_name
            // 
            this.com_coust_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_coust_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_coust_name.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_coust_name.FormattingEnabled = true;
            this.com_coust_name.Location = new System.Drawing.Point(521, 45);
            this.com_coust_name.Name = "com_coust_name";
            this.com_coust_name.Size = new System.Drawing.Size(186, 32);
            this.com_coust_name.TabIndex = 44;
            this.com_coust_name.SelectedIndexChanged += new System.EventHandler(this.com_coust_name_SelectedIndexChanged);
            this.com_coust_name.TextChanged += new System.EventHandler(this.com_coust_name_TextChanged);
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
            this.com_coust_id.Location = new System.Drawing.Point(713, 45);
            this.com_coust_id.Name = "com_coust_id";
            this.com_coust_id.Size = new System.Drawing.Size(55, 32);
            this.com_coust_id.TabIndex = 43;
            // 
            // com_doc_name
            // 
            this.com_doc_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_doc_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_doc_name.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_name.FormattingEnabled = true;
            this.com_doc_name.Location = new System.Drawing.Point(521, 93);
            this.com_doc_name.Name = "com_doc_name";
            this.com_doc_name.Size = new System.Drawing.Size(186, 32);
            this.com_doc_name.TabIndex = 42;
            this.com_doc_name.SelectedIndexChanged += new System.EventHandler(this.com_doc_name_SelectedIndexChanged);
            this.com_doc_name.TextChanged += new System.EventHandler(this.com_doc_name_TextChanged);
            // 
            // com_doc_id
            // 
            this.com_doc_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_doc_id.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_doc_id.FormattingEnabled = true;
            this.com_doc_id.Location = new System.Drawing.Point(713, 93);
            this.com_doc_id.Name = "com_doc_id";
            this.com_doc_id.Size = new System.Drawing.Size(55, 32);
            this.com_doc_id.TabIndex = 41;
            // 
            // lbl_doc
            // 
            this.lbl_doc.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc.Appearance.Options.UseFont = true;
            this.lbl_doc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_doc.Location = new System.Drawing.Point(790, 91);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(56, 24);
            this.lbl_doc.TabIndex = 40;
            this.lbl_doc.Text = "الطبيب ";
            this.lbl_doc.Click += new System.EventHandler(this.lbl_doc_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(456, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 22);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "من تاريخ ";
            // 
            // txt_apoy_s_date
            // 
            this.txt_apoy_s_date.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apoy_s_date.Location = new System.Drawing.Point(194, 44);
            this.txt_apoy_s_date.Name = "txt_apoy_s_date";
            this.txt_apoy_s_date.Size = new System.Drawing.Size(247, 30);
            this.txt_apoy_s_date.TabIndex = 36;
            this.txt_apoy_s_date.ValueChanged += new System.EventHandler(this.txt_apoy_s_date_ValueChanged);
            // 
            // lbl_coust_name
            // 
            this.lbl_coust_name.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coust_name.Appearance.Options.UseFont = true;
            this.lbl_coust_name.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_coust_name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_coust_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbl_coust_name.LineVisible = true;
            this.lbl_coust_name.Location = new System.Drawing.Point(774, 44);
            this.lbl_coust_name.Name = "lbl_coust_name";
            this.lbl_coust_name.Size = new System.Drawing.Size(88, 24);
            this.lbl_coust_name.TabIndex = 11;
            this.lbl_coust_name.Text = "اسم المريض";
            this.lbl_coust_name.Click += new System.EventHandler(this.lbl_coust_name_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("AD-STOOR", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(376, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 32);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "قائمه المواعيد ";
            // 
            // dgv_apoy
            // 
            this.dgv_apoy.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_apoy.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_apoy.Location = new System.Drawing.Point(14, 204);
            this.dgv_apoy.MainView = this.gridView1;
            this.dgv_apoy.Name = "dgv_apoy";
            this.dgv_apoy.Size = new System.Drawing.Size(882, 343);
            this.dgv_apoy.TabIndex = 49;
            this.dgv_apoy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.dgv_apoy;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(112, 88);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 33);
            this.btn_clear.TabIndex = 47;
            this.btn_clear.Text = "مسح";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_print.Location = new System.Drawing.Point(16, 88);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(76, 33);
            this.btn_print.TabIndex = 48;
            this.btn_print.Text = "طباعه";
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_search.Location = new System.Drawing.Point(16, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(161, 33);
            this.btn_search.TabIndex = 49;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_apoy_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 559);
            this.Controls.Add(this.dgv_apoy);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_apoy_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_apoy_list";
            this.Activated += new System.EventHandler(this.frm_apoy_list_Activated);
            this.Load += new System.EventHandler(this.frm_apoy_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox com_coust_name;
        private System.Windows.Forms.ComboBox com_coust_id;
        private System.Windows.Forms.ComboBox com_doc_name;
        private System.Windows.Forms.ComboBox com_doc_id;
        private DevExpress.XtraEditors.LabelControl lbl_doc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker txt_apoy_s_date;
        private DevExpress.XtraEditors.LabelControl lbl_coust_name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker txt_apoy_to_date;
        private DevExpress.XtraGrid.GridControl dgv_apoy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
    }
}