using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPM
{
    public partial class MusicPM : Form
    {
        public MusicPM()
        {
            InitializeComponent();
        }

        //Private Attributes
        private User userP;
        private int totalSongs;
        private HashSet<string> value;
        private Dictionary<string, HashSet<string>> playlist;
        private Dictionary<string, string> songFiles;
        private BinaryFormatter formatter;
        private string playlistFilename = "Playlist.dat";
        private string totalSongsFileName = "TotalSongs.dat";
        private string songFileName = "Songs.dat";


        public void MenyimpanDataPlaylistUser()
        {
            //Mencapai akses pada data yang akan ditulis
            try
            {
                //Membuat FileStream yang akan menulis data pada File
                FileStream writeFileStream = new FileStream(playlistFilename, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(writeFileStream, playlist);

                //Close the WriteFileStream when done
                writeFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Tidak dapat menyimpan data user!");
            }
        }

        public void MembacaDataPlaylistUser()
        {
            //Melihat apakah data user sebelumnya sudah ada
            if (File.Exists(playlistFilename))
            {
                try
                {
                    //Membuat FileStream yang akan mendapat akses ke Data File
                    FileStream bacaFileStream = new FileStream(playlistFilename, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    playlist = (Dictionary<string, HashSet<string>>)formatter.Deserialize(bacaFileStream);

                    //Close readFileStream ketika selesai
                    bacaFileStream.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Terdapat masalah membaca file user!");
                }
            }
        }

        public void SimpanFileLagu()
        {
            //Gain Access to the file that I am going to write to
            try
            {
                //Create the FileStream that will write data on File
                FileStream buatFileStream = new FileStream(songFileName, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(buatFileStream, songFiles);

                //Close the WriteFileStream when done
                buatFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Tidak dapat menyimpan informasi user!");
            }
        }

        public void BacaLaguFile()
        {
            //Check if I Had previously saved info on my Customers Datafile
            if (File.Exists(songFileName))
            {
                try
                {
                    //Create the FileStream will gain read Access to the Data File
                    FileStream readFileStream = new FileStream(songFileName, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    songFiles = (Dictionary<string, string>)formatter.Deserialize(readFileStream);

                    //Close readFileStream when Done
                    readFileStream.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Terdapat masalah dalam membaca file!");
                }
            }
        }


        private void MenyimpanTotalLaguDataFile()
        {
            //Gain Access to the file that I am going to write to
            try
            {
                //Create the FileStream that will write data on File
                FileStream writeFileStream = new FileStream(totalSongsFileName, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(writeFileStream, totalSongs);

                //Close the WriteFileStream when done
                writeFileStream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tidak dapat menyimpan informasi point!");
            }
        }

        private void ReadTotalSongsDataFile()
        {
            //Check if I Had previously saved info on my users Datafile
            if (File.Exists(totalSongsFileName))
            {
                try
                {
                    //Create the FileStream will gain read Access to the Data File
                    FileStream readFileStream = new FileStream(totalSongsFileName, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    totalSongs = (int)formatter.Deserialize(readFileStream);

                    //Close readFileStream when Done
                    readFileStream.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Terdapat masalah dalam penyimpanan file point!");
                }
            }
        }

        public MusicPM(User user)
        {
            InitializeComponent();
            userP = user;
            playlistFilename = userP.UserName + playlistFilename;
            totalSongsFileName = userP.UserName + totalSongsFileName;
            songFileName = userP.UserName + songFileName;

        }

        public void addList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lstDaftarLagu.Items.Add(list[i]);
            }
        }
        public void addCmb()
        {
            foreach (KeyValuePair<string, HashSet<string>> playlists in playlist)
            {
                cmbPlaylist.Items.Add(playlists.Key);
                cmbPlaylist2.Items.Add(playlists.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDaftarLagu.Items.Clear();
            var listoflist = new List<List<string>>();
            HashSet<string> unify = new HashSet<string>();
            foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
            {
                listoflist.Add(new List<string>(kv.Value));
            }
            if (listoflist.Count > 0)
            {
                unify = new HashSet<string>(listoflist[0]);
            }
            for (int i = 0; i < listoflist.Count; i++)
            {
                var set = new HashSet<string>(listoflist[i]);
                unify.UnionWith(set);
            }
            if (unify.Count > 0)
            {
                lstDaftarLagu.Items.Add("-Semua Daftar Lagu-");
                List<string> list = new List<string>(unify);
                addList(list);
                cmbPlaylist.SelectedItem = null;
                cmbPlaylist2.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Playlist kosong!");
            }
        }

        private void MusicPM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuatPlaylist.Text = "";
            lstDaftarLagu.Items.Clear();
            foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
            {
                if (kv.Key.Equals(cmbPlaylist.SelectedItem) && kv.Value != null)
                {
                    List<string> list = new List<string>(kv.Value);
                    addList(list);
                }
            }
        }

        private void lstDaftarLagu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambahLagu_Click(object sender, EventArgs e)
        {
            txtBuatPlaylist.Text = "";
            lstDaftarLagu.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 Files|*.mp3";
            if (cmbPlaylist.SelectedIndex > -1)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(cmbPlaylist.SelectedItem))
                        {
                            if (!(kv.Value.Contains(ofd.SafeFileName)))
                            {
                                if (!(userP.PremiumUser) && totalSongs > 100)
                                {
                                    MessageBox.Show("Anda tidak bisa menambahkan lagu lagi! \nSilahkan upgrade ke Premium!");
                                }
                                else if (!(userP.PremiumUser) && totalSongs <= 100)
                                {
                                    kv.Value.Add(ofd.SafeFileName);

                                    MenyimpanDataPlaylistUser();

                                    if (!(songFiles.ContainsKey(ofd.SafeFileName)))
                                    {
                                        songFiles.Add(ofd.SafeFileName, ofd.FileName);
                                        SimpanFileLagu();
                                    }
                                    List<string> list = new List<string>(kv.Value);
                                    MessageBox.Show("Lagu telah ditambahkan ke playlist!");
                                    addList(list);
                                    totalSongs++;
                                    txtLimit.Text = "Lagu total: " + totalSongs;
                                    MenyimpanTotalLaguDataFile();
                                }
                                if (userP.PremiumUser)
                                {
                                    kv.Value.Add(ofd.SafeFileName);
                                    MenyimpanDataPlaylistUser();
                                    if (!(songFiles.ContainsKey(ofd.SafeFileName)))
                                    {
                                        songFiles.Add(ofd.SafeFileName, ofd.FileName);
                                        SimpanFileLagu();
                                    }
                                    List<string> list = new List<string>(kv.Value);
                                    MessageBox.Show("Lagu telah ditambahkan ke playlist!");
                                    totalSongs++;
                                    txtLimit.Text = "Total Lagu: " + totalSongs;
                                    addList(list);
                                    MenyimpanTotalLaguDataFile();
                                }
                            }
                            else if (kv.Value.Contains(ofd.SafeFileName))
                            {
                                MessageBox.Show("Lagu sudah ada dalam playlist!");
                                List<string> list = new List<string>(kv.Value);
                                addList(list);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih playlist terlebih dahulu!");
            }
        }

        private void btnTambahkanPlaylist_Click(object sender, EventArgs e)
        {
            cmbPlaylist.Items.Clear();
            cmbPlaylist2.Items.Clear();
            if (txtBuatPlaylist.Text != "")
            {
                value = new HashSet<string>();
                HashSet<string> newVal = new HashSet<string>();
                string key = txtBuatPlaylist.Text;
                if (playlist.TryGetValue(key, out value))
                {
                    MessageBox.Show("Sudah terdapat playlist yang sama!");
                }
                else
                {
                    playlist.Add(key, newVal);
                    MessageBox.Show("Playlist telah ditambahkan!");
                }
                MenyimpanDataPlaylistUser();
                txtBuatPlaylist.Text = "";
                addCmb();
            }
            else
            {
                MessageBox.Show("Tolong masukkan nama playlist!");
                addCmb();
            }
        }

        private void btnGabungPlaylist_Click(object sender, EventArgs e)
        {
            lstDaftarLagu.Items.Clear();
            if (cmbPlaylist.SelectedIndex >= 0 && cmbPlaylist2.SelectedIndex >= 0)
            {
                string key1 = cmbPlaylist.SelectedItem.ToString();
                string key2 = cmbPlaylist2.SelectedItem.ToString();

                if (!(key1.Equals(key2)))
                {
                    HashSet<string> unify = new HashSet<string>();

                    HashSet<string> set1 = new HashSet<string>();

                    HashSet<string> set2 = new HashSet<string>();
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(key1))
                        {
                            set1 = new HashSet<string>(kv.Value);
                        }
                        else if (kv.Key.Equals(key2))
                        {
                            set2 = new HashSet<string>(kv.Value);
                        }
                    }

                    unify = new HashSet<string>(set1.Union(set2));
                    if (unify.Count > 0)
                    {
                        lstDaftarLagu.Items.Add("-Playlist Gabungan-");
                        var list = new List<string>(unify);
                        addList(list);
                    }
                    else
                    {
                        MessageBox.Show("Playlist Kosong!");
                    }
                }
                else
                {
                    MessageBox.Show("Tolong pilih playlist untuk digabung!");
                }

            }
            else
            {
                MessageBox.Show("Pilih 2 playlist!");
            }
        }
    }
}
