namespace MuzicaOnline
{
    partial class Ads
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAds = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbAlbum = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAds
            // 
            this.lbAds.AutoSize = true;
            this.lbAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbAds.Location = new System.Drawing.Point(20, 16);
            this.lbAds.Name = "lbAds";
            this.lbAds.Size = new System.Drawing.Size(229, 32);
            this.lbAds.TabIndex = 18;
            this.lbAds.Text = "Anunturile Mele";
            // 
            // lbAlbum
            // 
            this.lbAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAlbum.Font = new System.Drawing.Font("Myriad Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.ItemHeight = 26;
            this.lbAlbum.Location = new System.Drawing.Point(26, 66);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(712, 572);
            this.lbAlbum.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pnlPrice);
            this.panel1.Controls.Add(this.txtAlbum);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnReadMore);
            this.panel1.Controls.Add(this.ptbAlbum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(765, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 664);
            this.panel1.TabIndex = 20;
            // 
            // pnlPrice
            // 
            this.pnlPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnlPrice.Controls.Add(this.lbPrice);
            this.pnlPrice.Location = new System.Drawing.Point(76, 347);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(148, 41);
            this.pnlPrice.TabIndex = 18;
            this.pnlPrice.Visible = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.lbPrice.Location = new System.Drawing.Point(3, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(116, 32);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "<price>";
            this.lbPrice.Visible = false;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.txtAlbum.Location = new System.Drawing.Point(27, 277);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(240, 31);
            this.txtAlbum.TabIndex = 15;
            this.txtAlbum.Text = "<title>";
            this.txtAlbum.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescription.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtDescription.Location = new System.Drawing.Point(27, 417);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(240, 139);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "Description...";
            this.txtDescription.Visible = false;
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnReadMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnReadMore.Location = new System.Drawing.Point(27, 588);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(240, 50);
            this.btnReadMore.TabIndex = 14;
            this.btnReadMore.Text = "Modifica";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.button1.Location = new System.Drawing.Point(697, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ptbAlbum
            // 
            this.ptbAlbum.Location = new System.Drawing.Point(27, 26);
            this.ptbAlbum.Name = "ptbAlbum";
            this.ptbAlbum.Size = new System.Drawing.Size(240, 240);
            this.ptbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAlbum.TabIndex = 12;
            this.ptbAlbum.TabStop = false;
            this.ptbAlbum.Visible = false;
            // 
            // Ads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbAds);
            this.Name = "Ads";
            this.Size = new System.Drawing.Size(1059, 664);
            this.panel1.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAds;
        private System.Windows.Forms.ListBox lbAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.RichTextBox txtAlbum;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.PictureBox ptbAlbum;
        private System.Windows.Forms.Button button1;
    }
}
