using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Is_224_MitchelJaden_Final_Project_12
{
    public partial class MusicPlaylist : Form
    {
        BindingList<MusicItem> musicList;

        public MusicPlaylist()
        {
            InitializeComponent();
            musicList = new BindingList<MusicItem>();
            dataGridViewPlaylist.DataSource = musicList;

        }

        private void textBoxSong_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(textBoxSong.Text) ||
                string.IsNullOrWhiteSpace(textBoxArtist.Text) ||
                string.IsNullOrWhiteSpace(textBoxGenre.Text) ||
                string.IsNullOrWhiteSpace(textBoxReleaseYear.Text) ||
                string.IsNullOrWhiteSpace(textBoxDuration.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse and validate numeric fields
            if (!int.TryParse(textBoxReleaseYear.Text, out int releaseYear))
            {
                MessageBox.Show("Invalid release year. Please enter a valid number.");
                return;
            }

            if (!double.TryParse(textBoxDuration.Text, out double duration))
            {
                MessageBox.Show("Invalid duration. Please enter a valid number.");
                return;
            }

            // Create a new MusicItem instance
            var itemToAdd = new MusicItem(
                textBoxSong.Text,
                textBoxArtist.Text,
                textBoxGenre.Text,
                releaseYear,
                duration
            );

            // Add the item to the music list
            musicList.Add(itemToAdd);

            textBoxSong.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            textBoxGenre.Text = string.Empty;
            textBoxReleaseYear.Text = string.Empty;
            textBoxDuration.Text = string.Empty;
        }

        private void dataGridViewPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPlaylist.SelectedRows.Count > 0)
            {
                MusicItem selectedItem = (MusicItem)dataGridViewPlaylist.SelectedRows[0].DataBoundItem;

                if (selectedItem != null)
                {
                    // Set controls to properties of selected item
                    textBoxSong.Text = selectedItem.Song;
                    textBoxArtist.Text = selectedItem.Artist;
                    textBoxReleaseYear.Text = selectedItem.ReleaseYear.ToString();
                    textBoxDuration.Text = selectedItem.Duration.ToString();
                    textBoxGenre.Text = selectedItem.Genre;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlaylist.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPlaylist.SelectedRows[0];

                // Enable editing for the row  
                dataGridViewPlaylist.BeginEdit(true);

                string Song = dataGridViewPlaylist.CurrentRow.Cells[0].Value + string.Empty;
                string Artist = dataGridViewPlaylist.CurrentRow.Cells[1].Value + string.Empty;
                string Genre = dataGridViewPlaylist.CurrentRow.Cells[2].Value + string.Empty;
                string ReleaseYear = dataGridViewPlaylist.CurrentRow.Cells[3].Value + string.Empty;
                string Duration = dataGridViewPlaylist.CurrentRow.Cells[4].Value + string.Empty;

                textBoxSong.Text = Song;
                textBoxArtist.Text = Artist;
                textBoxGenre.Text = Genre;
                textBoxReleaseYear.Text = ReleaseYear;
                textBoxDuration.Text = Duration;

            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }

        }

        private void dataGridViewPlaylist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string Song = (string)(dataGridViewPlaylist.CurrentRow.Cells[0].Value = textBoxSong.Text);
            string Artist = (string)(dataGridViewPlaylist.CurrentRow.Cells[1].Value = textBoxArtist.Text);
            string Genre = (string)(dataGridViewPlaylist.CurrentRow.Cells[2].Value = textBoxGenre.Text);
            string ReleaseYear = (string)(dataGridViewPlaylist.CurrentRow.Cells[3].Value = textBoxReleaseYear.Text);
            string Duration = (string)(dataGridViewPlaylist.CurrentRow.Cells[4].Value = textBoxDuration.Text);

            textBoxSong.Text = Song;
            textBoxArtist.Text = Artist;
            textBoxGenre.Text = Genre;
            textBoxReleaseYear.Text = ReleaseYear;
            textBoxDuration.Text = Duration;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewPlaylist.SelectedRows)
            {
                dataGridViewPlaylist.Rows.RemoveAt(item.Index);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy items to a List for sorting
            var sortedList = musicList.ToList();

            if (comboBoxFilter1.SelectedItem == "Ascending")
            {
                // Example: Sort by Song ascending
                sortedList = sortedList.OrderBy(item => item.Song).ToList();
            }

            if (comboBoxFilter1.SelectedItem == "Descending")
            {
                sortedList = sortedList.OrderByDescending(item => item.Song).ToList();
            }

            // Clear and repopulate the BindingList
            musicList.Clear();
            foreach (var item in sortedList)
            {
                musicList.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy items to a List for sorting
            var sortedList = musicList.ToList();

            if (comboBoxFilter2.SelectedItem == "Ascending")
            {
                // Example: Sort by Song ascending
                sortedList = sortedList.OrderBy(item => item.Artist).ToList();
            }

            if (comboBoxFilter2.SelectedItem == "Descending")
            {
                sortedList = sortedList.OrderByDescending(item => item.Artist).ToList();
            }

            // Clear and repopulate the BindingList
            musicList.Clear();
            foreach (var item in sortedList)
            {
                musicList.Add(item);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy items to a List for sorting
            var sortedList = musicList.ToList();

            if (comboBoxFilter3.SelectedItem == "Ascending")
            {
                // Example: Sort by Song ascending
                sortedList = sortedList.OrderBy(item => item.Genre).ToList();
            }

            if (comboBoxFilter3.SelectedItem == "Descending")
            {
                sortedList = sortedList.OrderByDescending(item => item.Genre).ToList();
            }

            // Clear and repopulate the BindingList
            musicList.Clear();
            foreach (var item in sortedList)
            {
                musicList.Add(item);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy items to a List for sorting
            var sortedList = musicList.ToList();

            if (comboBoxFilter4.SelectedItem == "Ascending")
            {
                // Example: Sort by Song ascending
                sortedList = sortedList.OrderBy(item => item.ReleaseYear).ToList();
            }

            if (comboBoxFilter4.SelectedItem == "Descending")
            {
                sortedList = sortedList.OrderByDescending(item => item.ReleaseYear).ToList();
            }

            // Clear and repopulate the BindingList
            musicList.Clear();
            foreach (var item in sortedList)
            {
                musicList.Add(item);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy items to a List for sorting
            var sortedList = musicList.ToList();

            if (comboBoxFilter5.SelectedItem == "Ascending")
            {
                // Example: Sort by Song ascending
                sortedList = sortedList.OrderBy(item => item.Duration).ToList();
            }

            if (comboBoxFilter5.SelectedItem == "Descending")
            {
                sortedList = sortedList.OrderByDescending(item => item.Duration).ToList();
            }

            // Clear and repopulate the BindingList
            musicList.Clear();
            foreach (var item in sortedList)
            {
                musicList.Add(item);
            }
        }
    }
}

public class MusicItem
{
    public string Song { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public double Duration { get; set; }

    public MusicItem(string song, string artist, string genre, int releaseYear, double duration)
    {
        Song = song;
        Artist = artist;
        Genre = genre;
        ReleaseYear = releaseYear;
        Duration = duration;
    }

    // Field Update Method
    public virtual void UpdateFields(string song, string artist, string genre, int releaseYear, double duration)
    {
        Song = song;
        Artist = artist;
        Genre = genre;
        ReleaseYear = releaseYear;
        Duration = duration;
    }
}
