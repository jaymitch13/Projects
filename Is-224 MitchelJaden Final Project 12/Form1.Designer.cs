namespace Is_224_MitchelJaden_Final_Project_12
{
    partial class MusicPlaylist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewPlaylist = new DataGridView();
            labelSong = new Label();
            textBoxSong = new TextBox();
            textBoxArtist = new TextBox();
            labelArtist = new Label();
            labelGenre = new Label();
            textBoxGenre = new TextBox();
            labelDuration = new Label();
            textBoxDuration = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            label1 = new Label();
            textBoxReleaseYear = new TextBox();
            buttonUpdate = new Button();
            comboBoxFilter1 = new ComboBox();
            comboBoxFilter2 = new ComboBox();
            comboBoxFilter3 = new ComboBox();
            comboBoxFilter4 = new ComboBox();
            comboBoxFilter5 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPlaylist
            // 
            dataGridViewPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlaylist.Location = new Point(0, 1);
            dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            dataGridViewPlaylist.RowHeadersWidth = 51;
            dataGridViewPlaylist.Size = new Size(551, 545);
            dataGridViewPlaylist.TabIndex = 15;
            dataGridViewPlaylist.CellContentClick += dataGridViewPlaylist_CellContentClick;
            dataGridViewPlaylist.CellValueChanged += dataGridViewPlaylist_CellValueChanged;
            // 
            // labelSong
            // 
            labelSong.Font = new Font("Segoe UI", 20F);
            labelSong.Location = new Point(557, 18);
            labelSong.Name = "labelSong";
            labelSong.Size = new Size(100, 52);
            labelSong.TabIndex = 1;
            labelSong.Text = "Song";
            // 
            // textBoxSong
            // 
            textBoxSong.Location = new Point(671, 35);
            textBoxSong.Name = "textBoxSong";
            textBoxSong.Size = new Size(294, 27);
            textBoxSong.TabIndex = 0;
            textBoxSong.TextChanged += textBoxSong_TextChanged;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(671, 108);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(294, 27);
            textBoxArtist.TabIndex = 1;
            // 
            // labelArtist
            // 
            labelArtist.Font = new Font("Segoe UI", 20F);
            labelArtist.Location = new Point(557, 95);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(100, 40);
            labelArtist.TabIndex = 1;
            labelArtist.Text = "Artist";
            // 
            // labelGenre
            // 
            labelGenre.Font = new Font("Segoe UI", 20F);
            labelGenre.Location = new Point(557, 173);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(113, 40);
            labelGenre.TabIndex = 1;
            labelGenre.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(671, 186);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(294, 27);
            textBoxGenre.TabIndex = 2;
            // 
            // labelDuration
            // 
            labelDuration.Font = new Font("Segoe UI", 20F);
            labelDuration.Location = new Point(557, 328);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(157, 40);
            labelDuration.TabIndex = 1;
            labelDuration.Text = "Duration";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(712, 341);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(253, 27);
            textBoxDuration.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(567, 441);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 95);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(712, 441);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 95);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(1004, 441);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(121, 95);
            buttonRemove.TabIndex = 8;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(557, 247);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 1;
            label1.Text = "Release Year";
            // 
            // textBoxReleaseYear
            // 
            textBoxReleaseYear.Location = new Point(782, 260);
            textBoxReleaseYear.Name = "textBoxReleaseYear";
            textBoxReleaseYear.Size = new Size(183, 27);
            textBoxReleaseYear.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(859, 441);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(126, 95);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxFilter1
            // 
            comboBoxFilter1.FormattingEnabled = true;
            comboBoxFilter1.Items.AddRange(new object[] { "", "Ascending", "Descending" });
            comboBoxFilter1.Location = new Point(974, 35);
            comboBoxFilter1.Name = "comboBoxFilter1";
            comboBoxFilter1.Size = new Size(151, 28);
            comboBoxFilter1.TabIndex = 10;
            comboBoxFilter1.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // comboBoxFilter2
            // 
            comboBoxFilter2.FormattingEnabled = true;
            comboBoxFilter2.Items.AddRange(new object[] { "", "Ascending", "Descending" });
            comboBoxFilter2.Location = new Point(974, 107);
            comboBoxFilter2.Name = "comboBoxFilter2";
            comboBoxFilter2.Size = new Size(151, 28);
            comboBoxFilter2.TabIndex = 11;
            comboBoxFilter2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxFilter3
            // 
            comboBoxFilter3.FormattingEnabled = true;
            comboBoxFilter3.Items.AddRange(new object[] { "", "Ascending", "Descending" });
            comboBoxFilter3.Location = new Point(974, 185);
            comboBoxFilter3.Name = "comboBoxFilter3";
            comboBoxFilter3.Size = new Size(151, 28);
            comboBoxFilter3.TabIndex = 12;
            comboBoxFilter3.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBoxFilter4
            // 
            comboBoxFilter4.FormattingEnabled = true;
            comboBoxFilter4.Items.AddRange(new object[] { "", "Ascending", "Descending" });
            comboBoxFilter4.Location = new Point(974, 259);
            comboBoxFilter4.Name = "comboBoxFilter4";
            comboBoxFilter4.Size = new Size(151, 28);
            comboBoxFilter4.TabIndex = 13;
            comboBoxFilter4.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBoxFilter5
            // 
            comboBoxFilter5.FormattingEnabled = true;
            comboBoxFilter5.Items.AddRange(new object[] { "", "Ascending", "Descending" });
            comboBoxFilter5.Location = new Point(974, 340);
            comboBoxFilter5.Name = "comboBoxFilter5";
            comboBoxFilter5.Size = new Size(151, 28);
            comboBoxFilter5.TabIndex = 14;
            comboBoxFilter5.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // MusicPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 548);
            Controls.Add(comboBoxFilter5);
            Controls.Add(comboBoxFilter4);
            Controls.Add(comboBoxFilter3);
            Controls.Add(comboBoxFilter2);
            Controls.Add(comboBoxFilter1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxReleaseYear);
            Controls.Add(textBoxDuration);
            Controls.Add(label1);
            Controls.Add(textBoxGenre);
            Controls.Add(labelDuration);
            Controls.Add(textBoxArtist);
            Controls.Add(labelGenre);
            Controls.Add(textBoxSong);
            Controls.Add(labelArtist);
            Controls.Add(labelSong);
            Controls.Add(dataGridViewPlaylist);
            Name = "MusicPlaylist";
            Text = "Music Playlist";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPlaylist;
        private Label labelSong;
        private TextBox textBoxSong;
        private TextBox textBoxArtist;
        private Label labelArtist;
        private Label labelGenre;
        private TextBox textBoxGenre;
        private Label labelDuration;
        private TextBox textBoxDuration;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
        private Label label1;
        private TextBox textBoxReleaseYear;
        private Button buttonUpdate;
        private ComboBox comboBoxFilter1;
        private ComboBox comboBoxFilter2;
        private ComboBox comboBoxFilter3;
        private ComboBox comboBoxFilter4;
        private ComboBox comboBoxFilter5;
    }
}
