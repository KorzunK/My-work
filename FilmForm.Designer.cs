namespace CWork
{
    partial class FilmForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilmGridView = new System.Windows.Forms.DataGridView();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quality = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.Xml_save_button = new System.Windows.Forms.Button();
            this.Xml_load_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilmGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmGridView
            // 
            this.FilmGridView.AllowUserToAddRows = false;
            this.FilmGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.FilmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmName,
            this.ReleaseYear,
            this.Genre,
            this.Director,
            this.Company,
            this.Format,
            this.Quality});
            this.FilmGridView.Location = new System.Drawing.Point(1, 2);
            this.FilmGridView.Name = "FilmGridView";
            this.FilmGridView.Size = new System.Drawing.Size(744, 273);
            this.FilmGridView.TabIndex = 0;
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Film Name";
            this.FilmName.Name = "FilmName";
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.HeaderText = "Release Year";
            this.ReleaseYear.Name = "ReleaseYear";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.Genre.Name = "Genre";
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Items.AddRange(new object[] {
            "Dolby Digital (AC3)",
            "Dolby Digital Plus (EAC3)",
            "MP4",
            "MOV",
            "M4V",
            "AVI",
            "WMV",
            "MKV",
            "1080P",
            "720P"});
            this.Format.Name = "Format";
            this.Format.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Format.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quality
            // 
            this.Quality.HeaderText = "Quality";
            this.Quality.Items.AddRange(new object[] {
            "CAM-Rip(CAMRip)",
            "Telesync (TS)",
            "DVD-Rip (DVDRip)",
            "TV-Rip (TVRip)",
            "DVD5 (DVD-5)",
            "DVD9 (DVD-9)",
            "HDTV-Rip (HDTVRip)",
            "BD-Rip (BDRip)",
            "HD-DVD-Rip (HDDVDRip)"});
            this.Quality.Name = "Quality";
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(438, 299);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 48);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete Row";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.Location = new System.Drawing.Point(574, 299);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(96, 48);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_button.Location = new System.Drawing.Point(764, 164);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(177, 35);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search information";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Xml_save_button
            // 
            this.Xml_save_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xml_save_button.Location = new System.Drawing.Point(195, 299);
            this.Xml_save_button.Name = "Xml_save_button";
            this.Xml_save_button.Size = new System.Drawing.Size(107, 48);
            this.Xml_save_button.TabIndex = 6;
            this.Xml_save_button.Text = "Save";
            this.Xml_save_button.UseVisualStyleBackColor = true;
            this.Xml_save_button.Click += new System.EventHandler(this.Xml_save_button_Click);
            // 
            // Xml_load_button
            // 
            this.Xml_load_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xml_load_button.Location = new System.Drawing.Point(320, 299);
            this.Xml_load_button.Name = "Xml_load_button";
            this.Xml_load_button.Size = new System.Drawing.Size(93, 48);
            this.Xml_load_button.TabIndex = 7;
            this.Xml_load_button.Text = "Load";
            this.Xml_load_button.UseVisualStyleBackColor = true;
            this.Xml_load_button.Click += new System.EventHandler(this.Xml_load_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(67, 299);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(110, 48);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add Row";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(764, 129);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(177, 20);
            this.Search_textBox.TabIndex = 9;
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(961, 359);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Xml_load_button);
            this.Controls.Add(this.Xml_save_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.FilmGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "FilmForm";
            this.Text = "Film Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.FilmGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilmGridView;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button Xml_save_button;
        private System.Windows.Forms.Button Xml_load_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewComboBoxColumn Format;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quality;
        private System.Windows.Forms.TextBox Search_textBox;
    }
}
