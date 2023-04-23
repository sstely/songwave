namespace MuzicaOnline
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.bdDataSet = new MuzicaOnline.bdDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MuzicaOnline.bdDataSetTableAdapters.usersTableAdapter();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new MuzicaOnline.bdDataSetTableAdapters.albumsTableAdapter();
            this.cbSort2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSeller = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.ptbAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bdDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "albums";
            this.albumsBindingSource.DataSource = this.bdDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // cbSort2
            // 
            this.cbSort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cbSort2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSort2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cbSort2.FormattingEnabled = true;
            this.cbSort2.Location = new System.Drawing.Point(189, 78);
            this.cbSort2.Name = "cbSort2";
            this.cbSort2.Size = new System.Drawing.Size(141, 25);
            this.cbSort2.TabIndex = 18;
            this.cbSort2.Text = "Sortare dupa...";
            this.cbSort2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Acasa";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClear.FlatAppearance.BorderSize = 0;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSearchClear.Location = new System.Drawing.Point(714, 16);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(25, 25);
            this.btnSearchClear.TabIndex = 17;
            this.btnSearchClear.Text = "X";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            // 
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cbSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(26, 78);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(141, 25);
            this.cbSort.TabIndex = 15;
            this.cbSort.Text = "Sortare dupa...";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(413, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 27);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Cauta...";
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
            this.lbAlbum.Location = new System.Drawing.Point(26, 118);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(712, 520);
            this.lbAlbum.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pnlPrice);
            this.panel1.Controls.Add(this.lbSeller);
            this.panel1.Controls.Add(this.txtSeller);
            this.panel1.Controls.Add(this.txtAlbum);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnReadMore);
            this.panel1.Controls.Add(this.ptbAlbum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(765, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 664);
            this.panel1.TabIndex = 5;
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
            // lbSeller
            // 
            this.lbSeller.AutoSize = true;
            this.lbSeller.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lbSeller.Location = new System.Drawing.Point(41, 311);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(61, 13);
            this.lbSeller.TabIndex = 17;
            this.lbSeller.Text = "Vanzator : ";
            this.lbSeller.Visible = false;
            // 
            // txtSeller
            // 
            this.txtSeller.AutoSize = true;
            this.txtSeller.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.txtSeller.Location = new System.Drawing.Point(101, 311);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(50, 13);
            this.txtSeller.TabIndex = 16;
            this.txtSeller.Text = "<seller>";
            this.txtSeller.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtSeller.Visible = false;
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
            this.btnReadMore.Text = "Vezi Detalii";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Visible = false;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.cbSort2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAlbum);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1059, 664);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bdDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private bdDataSetTableAdapters.albumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.ComboBox cbSort2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSeller;
        private System.Windows.Forms.Label txtSeller;
        private System.Windows.Forms.RichTextBox txtAlbum;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.PictureBox ptbAlbum;
    }
}
