namespace medcail_deebo.form.frm_list
{
    partial class frm_service_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_service_list));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgv_ser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_form_name = new DevExpress.XtraEditors.LabelControl();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ser
            // 
            this.dgv_ser.Location = new System.Drawing.Point(24, 75);
            this.dgv_ser.MainView = this.gridView1;
            this.dgv_ser.Name = "dgv_ser";
            this.dgv_ser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_ser.ShowOnlyPredefinedDetails = true;
            this.dgv_ser.Size = new System.Drawing.Size(646, 381);
            this.dgv_ser.TabIndex = 42;
            this.dgv_ser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_ser;
            this.gridView1.Name = "gridView1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(628, 30);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureEdit1.Properties.Appearance.Options.UseFont = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(42, 43);
            this.pictureEdit1.TabIndex = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(464, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 24);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "اسم الاجراء او نوعه ";
            // 
            // lbl_form_name
            // 
            this.lbl_form_name.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_name.Appearance.Options.UseFont = true;
            this.lbl_form_name.Location = new System.Drawing.Point(248, -3);
            this.lbl_form_name.Name = "lbl_form_name";
            this.lbl_form_name.Size = new System.Drawing.Size(109, 24);
            this.lbl_form_name.TabIndex = 43;
            this.lbl_form_name.Text = "قائمه الاجرائات ";
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(24, 26);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(78, 35);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "مسح";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(125, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_search.Properties.AdvancedModeOptions.Label = "ابحث بالاسم او التخصص";
            this.txt_search.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Properties.Appearance.Options.UseFont = true;
            this.txt_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton("", -1, true, true, editorButtonImageOptions1, false, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "ابحث بالاسم او التخصص", null, null, true)});
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(306, 34);
            this.txt_search.TabIndex = 39;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // frm_service_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 510);
            this.Controls.Add(this.dgv_ser);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbl_form_name);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_search);
            this.Name = "frm_service_list";
            this.Text = "frm_service_list";
            this.Load += new System.EventHandler(this.frm_service_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_ser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_form_name;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SearchControl txt_search;
    }
}