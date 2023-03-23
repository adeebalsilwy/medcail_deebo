namespace medcail_deebo.form.frm_opration
{
    partial class frm_dos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dos));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dgv_doc = new DevExpress.XtraGrid.GridControl();
            this.grid_all_doc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_doc_code = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_doc_type = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_doc_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_code.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_name.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(718, 34);
            this.groupControl4.TabIndex = 54;
            this.groupControl4.Text = "groupControl4";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(273, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 22);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "جرعات الادويه ";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // dgv_doc
            // 
            this.dgv_doc.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_doc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_doc.Location = new System.Drawing.Point(12, 136);
            this.dgv_doc.MainView = this.grid_all_doc;
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.Size = new System.Drawing.Size(694, 310);
            this.dgv_doc.TabIndex = 50;
            this.dgv_doc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_all_doc});
            this.dgv_doc.DockChanged += new System.EventHandler(this.dgv_doc_DockChanged);
            // 
            // grid_all_doc
            // 
            this.grid_all_doc.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grid_all_doc.Appearance.OddRow.Options.UseBackColor = true;
            this.grid_all_doc.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.grid_all_doc.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grid_all_doc.Appearance.TopNewRow.BackColor = System.Drawing.Color.Lime;
            this.grid_all_doc.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grid_all_doc.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.grid_all_doc.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grid_all_doc.GridControl = this.dgv_doc;
            this.grid_all_doc.Name = "grid_all_doc";
            this.grid_all_doc.OptionsView.EnableAppearanceOddRow = true;
            this.grid_all_doc.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grid_all_doc_RowCellClick);
            this.grid_all_doc.DoubleClick += new System.EventHandler(this.grid_all_doc_DoubleClick);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(605, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(77, 22);
            this.labelControl11.TabIndex = 51;
            this.labelControl11.Text = "كود الجرعه  ";
            // 
            // txt_doc_code
            // 
            this.txt_doc_code.Enabled = false;
            this.txt_doc_code.Location = new System.Drawing.Point(503, 23);
            this.txt_doc_code.Name = "txt_doc_code";
            this.txt_doc_code.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_code.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_code.Size = new System.Drawing.Size(95, 28);
            this.txt_doc_code.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_doc_type);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txt_doc_name);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txt_doc_code);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 84);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الادويه ";
            // 
            // txt_doc_type
            // 
            this.txt_doc_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_doc_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_doc_type.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_type.FormattingEnabled = true;
            this.txt_doc_type.Items.AddRange(new object[] {
            "الكميه ",
            "العدد",
            "الوقت ",
            "النوع "});
            this.txt_doc_type.Location = new System.Drawing.Point(6, 22);
            this.txt_doc_type.Name = "txt_doc_type";
            this.txt_doc_type.Size = new System.Drawing.Size(161, 32);
            this.txt_doc_type.TabIndex = 56;
            this.txt_doc_type.TextChanged += new System.EventHandler(this.txt_doc_type_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(174, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 22);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "نوع الجرعه";
            // 
            // txt_doc_name
            // 
            this.txt_doc_name.Location = new System.Drawing.Point(251, 23);
            this.txt_doc_name.Name = "txt_doc_name";
            this.txt_doc_name.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_name.Properties.Appearance.Options.UseFont = true;
            this.txt_doc_name.Size = new System.Drawing.Size(158, 28);
            this.txt_doc_name.TabIndex = 53;
            this.txt_doc_name.TextChanged += new System.EventHandler(this.txt_doc_name_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(415, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 22);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "اسم الجرعه ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Location = new System.Drawing.Point(12, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 84);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "التحكم ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(162, 21);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 43);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "مسح";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(445, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 43);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(348, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 43);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(253, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 43);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_dos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.dgv_doc);
            this.Name = "frm_dos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dos";
            this.Load += new System.EventHandler(this.frm_dos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_code.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_name.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl dgv_doc;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_all_doc;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_doc_code;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_doc_name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox txt_doc_type;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
    }
}