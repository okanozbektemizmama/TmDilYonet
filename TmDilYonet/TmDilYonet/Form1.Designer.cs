namespace TmDilYonet
{
    partial class Form1
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
            this.dtViewDiller = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.lblResourceKey = new System.Windows.Forms.Label();
            this.lblResourceValue = new System.Windows.Forms.Label();
            this.txtResourceValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDiller)).BeginInit();
            this.SuspendLayout();
            // 
            // dtViewDiller
            // 
            this.dtViewDiller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtViewDiller.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtViewDiller.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtViewDiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewDiller.Location = new System.Drawing.Point(12, 41);
            this.dtViewDiller.Name = "dtViewDiller";
            this.dtViewDiller.RowHeadersVisible = false;
            this.dtViewDiller.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtViewDiller.Size = new System.Drawing.Size(791, 444);
            this.dtViewDiller.TabIndex = 4;
            this.dtViewDiller.DoubleClick += new System.EventHandler(this.dtViewDiller_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dil Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArama
            // 
            this.txtArama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtArama.Location = new System.Drawing.Point(101, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(207, 20);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyDown);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(631, 9);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(91, 23);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "Arama Yap";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // lblResourceKey
            // 
            this.lblResourceKey.AutoSize = true;
            this.lblResourceKey.Location = new System.Drawing.Point(9, 15);
            this.lblResourceKey.Name = "lblResourceKey";
            this.lblResourceKey.Size = new System.Drawing.Size(83, 13);
            this.lblResourceKey.TabIndex = 2;
            this.lblResourceKey.Text = "Resource Key : ";
            // 
            // lblResourceValue
            // 
            this.lblResourceValue.AutoSize = true;
            this.lblResourceValue.Location = new System.Drawing.Point(314, 15);
            this.lblResourceValue.Name = "lblResourceValue";
            this.lblResourceValue.Size = new System.Drawing.Size(92, 13);
            this.lblResourceValue.TabIndex = 6;
            this.lblResourceValue.Text = "Resource Value : ";
            // 
            // txtResourceValue
            // 
            this.txtResourceValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtResourceValue.Location = new System.Drawing.Point(406, 12);
            this.txtResourceValue.Name = "txtResourceValue";
            this.txtResourceValue.Size = new System.Drawing.Size(207, 20);
            this.txtResourceValue.TabIndex = 1;
            this.txtResourceValue.TextChanged += new System.EventHandler(this.txtResourceValue_TextChanged);
            this.txtResourceValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResourceValue_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 544);
            this.Controls.Add(this.lblResourceValue);
            this.Controls.Add(this.txtResourceValue);
            this.Controls.Add(this.lblResourceKey);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtViewDiller);
            this.Name = "Form1";
            this.Text = "Temizmama.com / Dil Veri Kaynakları Listeleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtViewDiller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label lblResourceKey;
        private System.Windows.Forms.Label lblResourceValue;
        private System.Windows.Forms.TextBox txtResourceValue;
    }
}

