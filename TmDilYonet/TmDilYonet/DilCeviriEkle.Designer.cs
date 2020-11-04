namespace TmDilYonet
{
    partial class DilCeviriEkle
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
            this.txtUygulamaDilId = new System.Windows.Forms.TextBox();
            this.lblUygulamaDilId = new System.Windows.Forms.Label();
            this.lblResourceKey = new System.Windows.Forms.Label();
            this.txtResourceKey = new System.Windows.Forms.TextBox();
            this.lblResourceValue = new System.Windows.Forms.Label();
            this.txtResourceValue = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblHiddenDilCeviriId = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUygulamaDilId
            // 
            this.txtUygulamaDilId.Location = new System.Drawing.Point(108, 40);
            this.txtUygulamaDilId.Name = "txtUygulamaDilId";
            this.txtUygulamaDilId.Size = new System.Drawing.Size(223, 20);
            this.txtUygulamaDilId.TabIndex = 0;
            // 
            // lblUygulamaDilId
            // 
            this.lblUygulamaDilId.AutoSize = true;
            this.lblUygulamaDilId.Location = new System.Drawing.Point(12, 43);
            this.lblUygulamaDilId.Name = "lblUygulamaDilId";
            this.lblUygulamaDilId.Size = new System.Drawing.Size(90, 13);
            this.lblUygulamaDilId.TabIndex = 1;
            this.lblUygulamaDilId.Text = "Uygulama Dil Id : ";
            // 
            // lblResourceKey
            // 
            this.lblResourceKey.AutoSize = true;
            this.lblResourceKey.Location = new System.Drawing.Point(12, 69);
            this.lblResourceKey.Name = "lblResourceKey";
            this.lblResourceKey.Size = new System.Drawing.Size(80, 13);
            this.lblResourceKey.TabIndex = 3;
            this.lblResourceKey.Text = "ResourceKey : ";
            // 
            // txtResourceKey
            // 
            this.txtResourceKey.Location = new System.Drawing.Point(108, 66);
            this.txtResourceKey.Name = "txtResourceKey";
            this.txtResourceKey.Size = new System.Drawing.Size(223, 20);
            this.txtResourceKey.TabIndex = 2;
            // 
            // lblResourceValue
            // 
            this.lblResourceValue.AutoSize = true;
            this.lblResourceValue.Location = new System.Drawing.Point(12, 95);
            this.lblResourceValue.Name = "lblResourceValue";
            this.lblResourceValue.Size = new System.Drawing.Size(89, 13);
            this.lblResourceValue.TabIndex = 5;
            this.lblResourceValue.Text = "ResourceValue : ";
            // 
            // txtResourceValue
            // 
            this.txtResourceValue.Location = new System.Drawing.Point(108, 92);
            this.txtResourceValue.Name = "txtResourceValue";
            this.txtResourceValue.Size = new System.Drawing.Size(223, 20);
            this.txtResourceValue.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 125);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet / Düzenle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblHiddenDilCeviriId
            // 
            this.lblHiddenDilCeviriId.AutoSize = true;
            this.lblHiddenDilCeviriId.Location = new System.Drawing.Point(260, 152);
            this.lblHiddenDilCeviriId.Name = "lblHiddenDilCeviriId";
            this.lblHiddenDilCeviriId.Size = new System.Drawing.Size(35, 13);
            this.lblHiddenDilCeviriId.TabIndex = 7;
            this.lblHiddenDilCeviriId.Text = "label1";
            this.lblHiddenDilCeviriId.Visible = false;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(169, 125);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(148, 23);
            this.btnGeriDon.TabIndex = 8;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // DilCeviriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 190);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblHiddenDilCeviriId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblResourceValue);
            this.Controls.Add(this.txtResourceValue);
            this.Controls.Add(this.lblResourceKey);
            this.Controls.Add(this.txtResourceKey);
            this.Controls.Add(this.lblUygulamaDilId);
            this.Controls.Add(this.txtUygulamaDilId);
            this.Name = "DilCeviriEkle";
            this.Text = "Temizmama Dil çeviri Ekle / Düzenle";
            this.Load += new System.EventHandler(this.DilCeviriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUygulamaDilId;
        private System.Windows.Forms.Label lblUygulamaDilId;
        private System.Windows.Forms.Label lblResourceKey;
        private System.Windows.Forms.TextBox txtResourceKey;
        private System.Windows.Forms.Label lblResourceValue;
        private System.Windows.Forms.TextBox txtResourceValue;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblHiddenDilCeviriId;
        private System.Windows.Forms.Button btnGeriDon;
    }
}