
namespace Tıcarıotomasyonuygulama
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txtmail = new DevExpress.XtraEditors.TextEdit();
            this.Txtkonu = new DevExpress.XtraEditors.TextEdit();
            this.richmesaj = new System.Windows.Forms.RichTextBox();
            this.BtnGönder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtkonu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(64, 184);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mail Adresi :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 273);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mesaj :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(111, 225);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 23);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Konu :";
            // 
            // Txtmail
            // 
            this.Txtmail.Location = new System.Drawing.Point(173, 181);
            this.Txtmail.Name = "Txtmail";
            this.Txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmail.Properties.Appearance.Options.UseFont = true;
            this.Txtmail.Size = new System.Drawing.Size(259, 30);
            this.Txtmail.TabIndex = 4;
            // 
            // Txtkonu
            // 
            this.Txtkonu.Location = new System.Drawing.Point(173, 222);
            this.Txtkonu.Name = "Txtkonu";
            this.Txtkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtkonu.Properties.Appearance.Options.UseFont = true;
            this.Txtkonu.Size = new System.Drawing.Size(259, 30);
            this.Txtkonu.TabIndex = 5;
            // 
            // richmesaj
            // 
            this.richmesaj.Location = new System.Drawing.Point(173, 273);
            this.richmesaj.Name = "richmesaj";
            this.richmesaj.Size = new System.Drawing.Size(259, 180);
            this.richmesaj.TabIndex = 6;
            this.richmesaj.Text = "";
            // 
            // BtnGönder
            // 
            this.BtnGönder.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGönder.Appearance.Options.UseFont = true;
            this.BtnGönder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnGönder.Location = new System.Drawing.Point(207, 459);
            this.BtnGönder.Name = "BtnGönder";
            this.BtnGönder.Size = new System.Drawing.Size(187, 38);
            this.BtnGönder.TabIndex = 7;
            this.BtnGönder.Text = "Gönder";
            this.BtnGönder.Click += new System.EventHandler(this.BtnGönder_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 117);
            this.panel1.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(170, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(326, 35);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "MAİL GÖNDERME PANELİ";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGönder);
            this.Controls.Add(this.richmesaj);
            this.Controls.Add(this.Txtkonu);
            this.Controls.Add(this.Txtmail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMail";
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtkonu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txtmail;
        private DevExpress.XtraEditors.TextEdit Txtkonu;
        private System.Windows.Forms.RichTextBox richmesaj;
        private DevExpress.XtraEditors.SimpleButton BtnGönder;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}