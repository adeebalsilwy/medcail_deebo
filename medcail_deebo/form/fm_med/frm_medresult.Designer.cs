namespace medcail_deebo.form.frm_opration
{
    partial class frm_medresult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medresult));
            this.grb_dag = new System.Windows.Forms.GroupBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.txt_medreq_note = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_medcreq_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_medreq_id = new DevExpress.XtraEditors.TextEdit();
            this.txt_medreq_result = new DevExpress.XtraEditors.MemoEdit();
            this.grb_dag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medcreq_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_result.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_dag
            // 
            this.grb_dag.Controls.Add(this.btn_save);
            this.grb_dag.Controls.Add(this.btn_delete);
            this.grb_dag.Controls.Add(this.txt_medreq_note);
            this.grb_dag.Controls.Add(this.labelControl2);
            this.grb_dag.Controls.Add(this.labelControl8);
            this.grb_dag.Controls.Add(this.txt_medcreq_name);
            this.grb_dag.Controls.Add(this.labelControl3);
            this.grb_dag.Controls.Add(this.labelControl1);
            this.grb_dag.Controls.Add(this.txt_medreq_id);
            this.grb_dag.Controls.Add(this.txt_medreq_result);
            this.grb_dag.Location = new System.Drawing.Point(28, 3);
            this.grb_dag.Name = "grb_dag";
            this.grb_dag.Size = new System.Drawing.Size(408, 492);
            this.grb_dag.TabIndex = 46;
            this.grb_dag.TabStop = false;
            this.grb_dag.Text = "بيانات الفحص";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(174, 429);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(191, 43);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "حفظ نتيجه الفحص ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(20, 429);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 43);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "خروج";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_medreq_note
            // 
            this.txt_medreq_note.Location = new System.Drawing.Point(20, 278);
            this.txt_medreq_note.Name = "txt_medreq_note";
            this.txt_medreq_note.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medreq_note.Properties.Appearance.Options.UseFont = true;
            this.txt_medreq_note.Size = new System.Drawing.Size(247, 116);
            this.txt_medreq_note.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(294, 322);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 22);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "ملاحضات  ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(294, 160);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 22);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "نتيجه  الفحص ";
            // 
            // txt_medcreq_name
            // 
            this.txt_medcreq_name.Enabled = false;
            this.txt_medcreq_name.Location = new System.Drawing.Point(20, 57);
            this.txt_medcreq_name.Name = "txt_medcreq_name";
            this.txt_medcreq_name.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medcreq_name.Properties.Appearance.Options.UseFont = true;
            this.txt_medcreq_name.Size = new System.Drawing.Size(247, 28);
            this.txt_medcreq_name.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(294, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 22);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "اسم الفحص ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(306, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 22);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "الفحص ";
            // 
            // txt_medreq_id
            // 
            this.txt_medreq_id.Enabled = false;
            this.txt_medreq_id.Location = new System.Drawing.Point(20, 20);
            this.txt_medreq_id.Name = "txt_medreq_id";
            this.txt_medreq_id.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medreq_id.Properties.Appearance.Options.UseFont = true;
            this.txt_medreq_id.Size = new System.Drawing.Size(247, 28);
            this.txt_medreq_id.TabIndex = 40;
            // 
            // txt_medreq_result
            // 
            this.txt_medreq_result.Location = new System.Drawing.Point(20, 104);
            this.txt_medreq_result.Name = "txt_medreq_result";
            this.txt_medreq_result.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medreq_result.Properties.Appearance.Options.UseFont = true;
            this.txt_medreq_result.Size = new System.Drawing.Size(247, 168);
            this.txt_medreq_result.TabIndex = 46;
            // 
            // frm_medresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 517);
            this.Controls.Add(this.grb_dag);
            this.Name = "frm_medresult";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_medresult";
            this.grb_dag.ResumeLayout(false);
            this.grb_dag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medcreq_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medreq_result.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_dag;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.MemoEdit txt_medreq_note;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txt_medreq_result;
        public DevExpress.XtraEditors.TextEdit txt_medcreq_name;
        public DevExpress.XtraEditors.TextEdit txt_medreq_id;
    }
}