
namespace Tıcarıotomasyonuygulama
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mskTARIH = new System.Windows.Forms.MaskedTextBox();
            this.btnSIL = new DevExpress.XtraEditors.SimpleButton();
            this.btnGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.btnKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.richDETAY = new System.Windows.Forms.RichTextBox();
            this.textHITAP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.mskSAAT = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textOLUS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textıd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTEMIZLE = new DevExpress.XtraEditors.SimpleButton();
            this.textBASLIK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHITAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOLUS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBASLIK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(28, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1529, 737);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mskTARIH
            // 
            this.mskTARIH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTARIH.Location = new System.Drawing.Point(132, 132);
            this.mskTARIH.Mask = "00/00/0000";
            this.mskTARIH.Name = "mskTARIH";
            this.mskTARIH.Size = new System.Drawing.Size(150, 30);
            this.mskTARIH.TabIndex = 23;
            this.mskTARIH.ValidatingType = typeof(System.DateTime);
            // 
            // btnSIL
            // 
            this.btnSIL.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSIL.Appearance.Options.UseFont = true;
            this.btnSIL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSIL.ImageOptions.Image")));
            this.btnSIL.Location = new System.Drawing.Point(132, 576);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(151, 32);
            this.btnSIL.TabIndex = 20;
            this.btnSIL.Text = "SİL";
            this.btnSIL.Click += new System.EventHandler(this.btnSIL_Click);
            // 
            // btnGUNCELLE
            // 
            this.btnGUNCELLE.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGUNCELLE.Appearance.Options.UseFont = true;
            this.btnGUNCELLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGUNCELLE.ImageOptions.Image")));
            this.btnGUNCELLE.Location = new System.Drawing.Point(134, 614);
            this.btnGUNCELLE.Name = "btnGUNCELLE";
            this.btnGUNCELLE.Size = new System.Drawing.Size(151, 32);
            this.btnGUNCELLE.TabIndex = 19;
            this.btnGUNCELLE.Text = "GÜNCELLE";
            this.btnGUNCELLE.Click += new System.EventHandler(this.btnGUNCELLE_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKAYDET.Appearance.Options.UseFont = true;
            this.btnKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKAYDET.ImageOptions.Image")));
            this.btnKAYDET.Location = new System.Drawing.Point(132, 538);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(151, 32);
            this.btnKAYDET.TabIndex = 18;
            this.btnKAYDET.Text = "KAYDET";
            this.btnKAYDET.Click += new System.EventHandler(this.btnKAYDET_Click);
            // 
            // richDETAY
            // 
            this.richDETAY.Location = new System.Drawing.Point(132, 390);
            this.richDETAY.Name = "richDETAY";
            this.richDETAY.Size = new System.Drawing.Size(152, 131);
            this.richDETAY.TabIndex = 17;
            this.richDETAY.Text = "";
            // 
            // textHITAP
            // 
            this.textHITAP.Location = new System.Drawing.Point(133, 336);
            this.textHITAP.Name = "textHITAP";
            this.textHITAP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textHITAP.Properties.Appearance.Options.UseFont = true;
            this.textHITAP.Size = new System.Drawing.Size(149, 30);
            this.textHITAP.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(67, 390);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "DETAY :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(72, 343);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "HITAP :";
            // 
            // mskSAAT
            // 
            this.mskSAAT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskSAAT.Location = new System.Drawing.Point(133, 178);
            this.mskSAAT.Mask = "00:00";
            this.mskSAAT.Name = "mskSAAT";
            this.mskSAAT.Size = new System.Drawing.Size(150, 30);
            this.mskSAAT.TabIndex = 9;
            this.mskSAAT.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(31, 295);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "OLUŞTURAN :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(67, 238);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "BAŞLIK :";
            // 
            // textOLUS
            // 
            this.textOLUS.Location = new System.Drawing.Point(132, 283);
            this.textOLUS.Name = "textOLUS";
            this.textOLUS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOLUS.Properties.Appearance.Options.UseFont = true;
            this.textOLUS.Size = new System.Drawing.Size(151, 30);
            this.textOLUS.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(79, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "SAAT :";
            // 
            // textıd
            // 
            this.textıd.Location = new System.Drawing.Point(132, 79);
            this.textıd.Name = "textıd";
            this.textıd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textıd.Properties.Appearance.Options.UseFont = true;
            this.textıd.Size = new System.Drawing.Size(151, 30);
            this.textıd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(104, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnTEMIZLE);
            this.groupControl1.Controls.Add(this.mskTARIH);
            this.groupControl1.Controls.Add(this.btnSIL);
            this.groupControl1.Controls.Add(this.btnGUNCELLE);
            this.groupControl1.Controls.Add(this.btnKAYDET);
            this.groupControl1.Controls.Add(this.richDETAY);
            this.groupControl1.Controls.Add(this.textHITAP);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.mskSAAT);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textOLUS);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textBASLIK);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textıd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1589, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 737);
            this.groupControl1.TabIndex = 9;
            // 
            // btnTEMIZLE
            // 
            this.btnTEMIZLE.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTEMIZLE.Appearance.Options.UseFont = true;
            this.btnTEMIZLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTEMIZLE.ImageOptions.Image")));
            this.btnTEMIZLE.Location = new System.Drawing.Point(134, 652);
            this.btnTEMIZLE.Name = "btnTEMIZLE";
            this.btnTEMIZLE.Size = new System.Drawing.Size(151, 37);
            this.btnTEMIZLE.TabIndex = 24;
            this.btnTEMIZLE.Text = "TEMİZLE";
            this.btnTEMIZLE.Click += new System.EventHandler(this.btnTEMIZLE_Click);
            // 
            // textBASLIK
            // 
            this.textBASLIK.Location = new System.Drawing.Point(133, 231);
            this.textBASLIK.Name = "textBASLIK";
            this.textBASLIK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBASLIK.Properties.Appearance.Options.UseFont = true;
            this.textBASLIK.Size = new System.Drawing.Size(151, 30);
            this.textBASLIK.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(71, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "TARİH :";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1924, 768);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHITAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOLUS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBASLIK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox mskTARIH;
        private DevExpress.XtraEditors.SimpleButton btnSIL;
        private DevExpress.XtraEditors.SimpleButton btnGUNCELLE;
        private DevExpress.XtraEditors.SimpleButton btnKAYDET;
        private System.Windows.Forms.RichTextBox richDETAY;
        private DevExpress.XtraEditors.TextEdit textHITAP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox mskSAAT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textOLUS;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textıd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTEMIZLE;
        private DevExpress.XtraEditors.TextEdit textBASLIK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}