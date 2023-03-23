namespace medcail_deebo.form.frm_list
{
    partial class frm_medcheak_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medcheak_list));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_form_name = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new DevExpress.XtraEditors.SearchControl();
            this.grb_dag = new System.Windows.Forms.GroupBox();
            this.dgv_medc = new DevExpress.XtraGrid.GridControl();
            this.grid_all_medcin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).BeginInit();
            this.grb_dag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_medcin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_form_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 37);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_form_name
            // 
            this.lbl_form_name.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_name.Appearance.Options.UseFont = true;
            this.lbl_form_name.Location = new System.Drawing.Point(301, 6);
            this.lbl_form_name.Name = "lbl_form_name";
            this.lbl_form_name.Size = new System.Drawing.Size(160, 24);
            this.lbl_form_name.TabIndex = 44;
            this.lbl_form_name.Text = "قائمه بطاقات التامين  ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(612, 59);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureEdit1.Properties.Appearance.Options.UseFont = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(59, 43);
            this.pictureEdit1.TabIndex = 47;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(448, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 24);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "اسم البطاقه او الكود";
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(27, 59);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 35);
            this.btn_clear.TabIndex = 48;
            this.btn_clear.Text = "مسح";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(109, 60);
            this.txt_search.Name = "txt_search";
            this.txt_search.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_search.Properties.AdvancedModeOptions.Label = "ابحث بالاسم او التخصص";
            this.txt_search.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Properties.Appearance.Options.UseFont = true;
            this.txt_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton("", -1, true, true, editorButtonImageOptions2, false, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "ابحث بالاسم او التخصص", null, null, true)});
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(323, 34);
            this.txt_search.TabIndex = 46;
            // 
            // grb_dag
            // 
            this.grb_dag.Controls.Add(this.dgv_medc);
            this.grb_dag.Location = new System.Drawing.Point(24, 100);
            this.grb_dag.Name = "grb_dag";
            this.grb_dag.Size = new System.Drawing.Size(644, 343);
            this.grb_dag.TabIndex = 50;
            this.grb_dag.TabStop = false;
            this.grb_dag.Text = "قائمه العلاجات ";
            // 
            // dgv_medc
            // 
            this.dgv_medc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_medc.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_medc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_medc.Location = new System.Drawing.Point(3, 17);
            this.dgv_medc.MainView = this.grid_all_medcin;
            this.dgv_medc.Name = "dgv_medc";
            this.dgv_medc.Size = new System.Drawing.Size(638, 323);
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
            this.grid_all_medcin.DoubleClick += new System.EventHandler(this.grid_all_medcin_DoubleClick);
            // 
            // frm_medcheak_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 454);
            this.Controls.Add(this.grb_dag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_search);
            this.Name = "frm_medcheak_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_medcheak_list";
            this.Load += new System.EventHandler(this.frm_medcheak_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).EndInit();
            this.grb_dag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_medcin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lbl_form_name;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SearchControl txt_search;
        private System.Windows.Forms.GroupBox grb_dag;
        private DevExpress.XtraGrid.GridControl dgv_medc;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_all_medcin;
    }
}