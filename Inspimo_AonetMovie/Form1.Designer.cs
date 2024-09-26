namespace Inspimo_AonetMovie
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
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCategoryEkle = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.dtgMovie = new System.Windows.Forms.DataGridView();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.txtMovieImdb = new System.Windows.Forms.TextBox();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategoriCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMovieCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTopOneFilmName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAverageImdb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategory
            // 
            this.dtgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(12, 12);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.RowHeadersWidth = 51;
            this.dtgCategory.RowTemplate.Height = 24;
            this.dtgCategory.Size = new System.Drawing.Size(460, 244);
            this.dtgCategory.TabIndex = 0;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(166, 286);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(219, 32);
            this.txtCategoryID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori ID:";
            // 
            // txtCategoryAdi
            // 
            this.txtCategoryAdi.Location = new System.Drawing.Point(166, 340);
            this.txtCategoryAdi.Name = "txtCategoryAdi";
            this.txtCategoryAdi.Size = new System.Drawing.Size(219, 32);
            this.txtCategoryAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Adı:";
            // 
            // btnCategoryEkle
            // 
            this.btnCategoryEkle.Location = new System.Drawing.Point(164, 388);
            this.btnCategoryEkle.Name = "btnCategoryEkle";
            this.btnCategoryEkle.Size = new System.Drawing.Size(221, 38);
            this.btnCategoryEkle.TabIndex = 3;
            this.btnCategoryEkle.Text = "Ekle";
            this.btnCategoryEkle.UseVisualStyleBackColor = true;
            this.btnCategoryEkle.Click += new System.EventHandler(this.btnCategoryEkle_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(164, 436);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(101, 38);
            this.btnCategoryDelete.TabIndex = 3;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(271, 436);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(114, 38);
            this.btnCategoryUpdate.TabIndex = 3;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // dtgMovie
            // 
            this.dtgMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovie.Location = new System.Drawing.Point(478, 12);
            this.dtgMovie.Name = "dtgMovie";
            this.dtgMovie.RowHeadersWidth = 51;
            this.dtgMovie.RowTemplate.Height = 24;
            this.dtgMovie.Size = new System.Drawing.Size(820, 244);
            this.dtgMovie.TabIndex = 0;
            this.dtgMovie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMovie_CellDoubleClick);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(843, 286);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(250, 32);
            this.txtMovieID.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(843, 337);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(250, 32);
            this.txtMovieName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Film Adı:";
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.Location = new System.Drawing.Point(843, 533);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(250, 38);
            this.btnMovieSave.TabIndex = 3;
            this.btnMovieSave.Text = "Ekle";
            this.btnMovieSave.UseVisualStyleBackColor = true;
            this.btnMovieSave.Click += new System.EventHandler(this.btnMovieSave_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.Location = new System.Drawing.Point(843, 577);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(123, 38);
            this.btnMovieDelete.TabIndex = 3;
            this.btnMovieDelete.Text = "Sil";
            this.btnMovieDelete.UseVisualStyleBackColor = true;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(972, 577);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(121, 38);
            this.btnMovieUpdate.TabIndex = 3;
            this.btnMovieUpdate.Text = "Güncelle";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // txtMovieImdb
            // 
            this.txtMovieImdb.Location = new System.Drawing.Point(843, 388);
            this.txtMovieImdb.Name = "txtMovieImdb";
            this.txtMovieImdb.Size = new System.Drawing.Size(250, 32);
            this.txtMovieImdb.TabIndex = 1;
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.Location = new System.Drawing.Point(843, 442);
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(250, 32);
            this.txtMovieDuration.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Puan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Süre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kategori";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKategoriCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1323, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 165);
            this.panel1.TabIndex = 4;
            // 
            // lblKategoriCount
            // 
            this.lblKategoriCount.AutoSize = true;
            this.lblKategoriCount.Location = new System.Drawing.Point(94, 65);
            this.lblKategoriCount.Name = "lblKategoriCount";
            this.lblKategoriCount.Size = new System.Drawing.Size(24, 26);
            this.lblKategoriCount.TabIndex = 3;
            this.lblKategoriCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kategori Sayısı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMovieCount);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(1323, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 165);
            this.panel2.TabIndex = 5;
            // 
            // lblMovieCount
            // 
            this.lblMovieCount.AutoSize = true;
            this.lblMovieCount.Location = new System.Drawing.Point(104, 91);
            this.lblMovieCount.Name = "lblMovieCount";
            this.lblMovieCount.Size = new System.Drawing.Size(24, 26);
            this.lblMovieCount.TabIndex = 4;
            this.lblMovieCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "Film Sayısı:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTopOneFilmName);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(1323, 558);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 165);
            this.panel3.TabIndex = 7;
            // 
            // lblTopOneFilmName
            // 
            this.lblTopOneFilmName.AutoSize = true;
            this.lblTopOneFilmName.Location = new System.Drawing.Point(54, 84);
            this.lblTopOneFilmName.Name = "lblTopOneFilmName";
            this.lblTopOneFilmName.Size = new System.Drawing.Size(24, 26);
            this.lblTopOneFilmName.TabIndex = 4;
            this.lblTopOneFilmName.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 26);
            this.label15.TabIndex = 5;
            this.label15.Text = "En Çok İzlenen Film";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblAverageImdb);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(1323, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 165);
            this.panel4.TabIndex = 6;
            // 
            // lblAverageImdb
            // 
            this.lblAverageImdb.AutoSize = true;
            this.lblAverageImdb.Location = new System.Drawing.Point(104, 87);
            this.lblAverageImdb.Name = "lblAverageImdb";
            this.lblAverageImdb.Size = new System.Drawing.Size(24, 26);
            this.lblAverageImdb.TabIndex = 4;
            this.lblAverageImdb.Text = "0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(40, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 60);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tüm Filmlerin Ortalama Puanı:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(843, 493);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(250, 34);
            this.cmbKategori.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1586, 739);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.btnCategoryEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovieDuration);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.txtMovieImdb);
            this.Controls.Add(this.txtCategoryAdi);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.dtgMovie);
            this.Controls.Add(this.dtgCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCategoryEkle;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.DataGridView dtgMovie;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.TextBox txtMovieImdb;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblKategoriCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMovieCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTopOneFilmName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAverageImdb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}

