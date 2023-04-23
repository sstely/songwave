using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace MuzicaOnline
{
    public partial class frmBase : Form
    {
        private SoundPlayer s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public frmBase(string user)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(73, 46, 46);
            lbUsername.Text = user;
            lbUsername2User.Text = user;
            usersTableAdapter.userInfo(bdDataSet.users, user);
            DataTable t = bdDataSet.users;
            lbIDUser.Text =  t.Rows[0]["ID_user"].ToString();
            lbEmail3User.Text = t.Rows[0]["email"].ToString();
            lbPasswordUser.Text = t.Rows[0]["password"].ToString();
            lbAdsCountUser.Text = usersTableAdapter.adsCount(user).ToString();
            pnlHomeActive();

        }

        List<int> listAlbumID = new List<int>();
        List<int> listAdsID = new List<int>();


        void listInfoClear()
        {
            ptbAlbum.Visible = false;
            txtAlbum.Visible = false;
            lbSellerUser.Visible = false;
            txtDescription.Visible = false;
            btnReadMore.Visible = false;
            lbPrice.Visible = false;
            pnlPrice.Visible = false;
            lbSeller.Visible = false;
        }
        void listAdsInfoClear()
        {
            ptbAlbum2.Visible = false;
            txtAlbum2.Visible = false;
            txtDescription2.Visible = false;
            btnUpdate.Visible = false;
            lbPrice2.Visible = false;
            pnlPrice2.Visible = false;
        }
        void listInfoAdd()
        {
            lbAlbum.Items.Clear();
            listAlbumID.Clear();
            usersTableAdapter.infoAll(bdDataSet.users);
            DataTable t = bdDataSet.users;
            for (int i = 0; i < t.Rows.Count; i++)
            {
                string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                listAlbumID.Add((int)t.Rows[i]["ID_album"]);
            }
        }
        void listAdsInfoAdd()
        {
            listAds.Items.Clear();
            listAdsID.Clear();
            string user = lbUsername.Text;
            albumsTableAdapter.userAdsInfo(bdDataSet.albums, user);
            DataTable t = bdDataSet.albums;
            for (int i = 0; i < t.Rows.Count; i++)
            {
                string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                listAds.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                listAdsID.Add((int)t.Rows[i]["ID_album"]);
            }
        }


        private void frmBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdDataSet.preview' table. You can move, or remove it, as needed.
            this.previewTableAdapter.Fill(this.bdDataSet.preview);
            // TODO: This line of code loads data into the 'bdDataSet.albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.bdDataSet.albums);
            // TODO: This line of code loads data into the 'bdDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bdDataSet.users);
            cbSort.Items.Clear();
            cbSort.Items.Add("Fara sortare");
            cbSort.Items.Add("Dupa album");
            cbSort.Items.Add("Dupa artist");
            cbSort.Items.Add("Dupa pret");
            cbSort.Items.Add("Dupa data publicarii");
            cbSort.Items.Add("Dupa gen muzical");
            cbSort.Items.Add("Dupa conditie");
            cbSort.Items.Add("Dupa format");
            cbCondition.Items.Add("Sigilat");
            cbCondition.Items.Add("Desigilat");
            cbFormat.Items.Add("CD/DVD");
            cbFormat.Items.Add("Vinyl");
            cbCondition2.Items.Add("Sigilat");
            cbCondition2.Items.Add("Desigilat");
            cbFormat2.Items.Add("CD/DVD");
            cbFormat2.Items.Add("Vinyl");
            listInfoAdd();
            
        }

        void pnlHomeActive()
        {
            pnlHome.BringToFront();
            deco6.BringToFront();
            listInfoClear();
            listInfoAdd();
        }
        void pnlAdsActive()
        {
            pnlAds.BringToFront();
            deco6.BringToFront();
            listAdsInfoClear();
            listAdsInfoAdd();
        }
        void pnlAdsAddActive()
        {
            pnlAdsAdd.BringToFront();
            deco6.BringToFront();
        }
        void pnlAdsUpdateActive()
        {
            pnlAdsUpdate.BringToFront();
            deco6.BringToFront();
            int id = listAdsID[listAds.SelectedIndex];
            albumsTableAdapter.infoAlbum(bdDataSet.albums, id);
            DataTable t = bdDataSet.albums;
            txtImageURL2.Text = t.Rows[0]["URL_image"].ToString();
            ptbAlbum4.ImageLocation = txtImageURL2.Text;
            txtAlbum4.Text = t.Rows[0]["Album"].ToString();
            txtPrice2.Text = t.Rows[0]["Price"].ToString();
            txtArtist2.Text = t.Rows[0]["Artist"].ToString();
            txtGenre2.Text = t.Rows[0]["Genre"].ToString();
            cbCondition2.Text = t.Rows[0]["Condition"].ToString();
            cbFormat2.Text = t.Rows[0]["Format"].ToString();
            txtDescription4.Text = t.Rows[0]["Description"].ToString();
            lbSellerUser2.Text = t.Rows[0]["username"].ToString();
            lbEmailUser.Text = t.Rows[0]["email"].ToString();
            lbDatePublishUser.Text = ((DateTime)t.Rows[0]["Date_Publish"]).ToShortDateString();
        }
        void SoundsClear()
        {
            mpVideo.Ctlcontrols.stop();
            btnPlay1.Checked = false;
            btnPlay1.Text = "▶️";
            btnPlay2.Checked = false;
            btnPlay2.Text = "▶️";
            btnPlay3.Checked = false;
            btnPlay3.Text = "▶️";
            btnPlay4.Checked = false;
            btnPlay4.Text = "▶️";
            btnPlay5.Checked = false;
            btnPlay5.Text = "▶️";
            btnPlay6.Checked = false;
            btnPlay6.Text = "▶️";
            btnPlay7.Checked = false;
            btnPlay7.Text = "▶️";
            btnPlay8.Checked = false;
            btnPlay8.Text = "▶️";
        }
        void previewInfo()
        {
            int id = listAlbumID[lbAlbum.SelectedIndex];
            previewTableAdapter.infoPreview(bdDataSet.preview,id);
            DataTable t = bdDataSet.preview;
            if (t.Rows[0]["video"].ToString() == "") mpVideo.URL = "";
            else
            {
                mpVideo.URL = t.Rows[0]["video"].ToString();
                mpVideo.Ctlcontrols.stop();
            }
            if (t.Rows[0]["song1"].ToString() == "")
            {
                btnPlay1.Visible = false;
                lbSong1.Visible = false;
            }
            else
            {
                btnPlay1.Visible = true;
                lbSong1.Visible = true;
                lbSong1.Text = t.Rows[0]["song1"].ToString();
                s1 = new SoundPlayer(t.Rows[0]["song1"].ToString() + ".wav");
            }
            if (t.Rows[0]["song2"].ToString() == "")
            {
                btnPlay2.Visible = false;
                lbSong2.Visible = false;
            }
            else
            {
                btnPlay2.Visible = true;
                lbSong2.Visible = true;
                lbSong2.Text = t.Rows[0]["song2"].ToString();
                s2 = new SoundPlayer(t.Rows[0]["song2"].ToString() + ".wav");
            }
            if (t.Rows[0]["song3"].ToString() == "")
            {
                btnPlay3.Visible = false;
                lbSong3.Visible = false;
            }
            else
            {
                btnPlay3.Visible = true;
                lbSong3.Visible = true;
                lbSong3.Text = t.Rows[0]["song3"].ToString();
                s3 = new SoundPlayer(t.Rows[0]["song3"].ToString() + ".wav");
            }
            if (t.Rows[0]["song4"].ToString() == "")
            {
                btnPlay4.Visible = false;
                lbSong4.Visible = false;
            }
            else
            {
                if (t.Rows[0]["song4"].ToString() == "04. Skit") btnPlay4.Visible = false;
                else btnPlay4.Visible = true;
                lbSong4.Visible = true;
                lbSong4.Text = t.Rows[0]["song4"].ToString();
                s4 = new SoundPlayer(t.Rows[0]["song4"].ToString() + ".wav");
            }
            if (t.Rows[0]["song5"].ToString() == "")
            {
                btnPlay5.Visible = false;
                lbSong5.Visible = false;
            }
            else
            {
                btnPlay5.Visible = true;
                lbSong5.Visible = true;
                lbSong5.Text = t.Rows[0]["song5"].ToString();
                s5 = new SoundPlayer(t.Rows[0]["song5"].ToString() + ".wav");
            }
            if (t.Rows[0]["song6"].ToString() == "")
            {
                btnPlay6.Visible = false;
                lbSong6.Visible = false;
            }
            else
            {
                if (t.Rows[0]["song6"].ToString() == "06. Interlude - Brother Act") btnPlay6.Visible = false;
                else btnPlay6.Visible = true;
                lbSong6.Visible = true;
                lbSong6.Text = t.Rows[0]["song6"].ToString();
                s6 = new SoundPlayer(t.Rows[0]["song6"].ToString() + ".wav");
            }
            if (t.Rows[0]["song7"].ToString() == "")
            {
                btnPlay7.Visible = false;
                lbSong7.Visible = false;
            }
            else
            {
                btnPlay7.Visible = true;
                lbSong7.Visible = true;
                lbSong7.Text = t.Rows[0]["song7"].ToString();
                s7 = new SoundPlayer(t.Rows[0]["song7"].ToString() + ".wav");
            }
            if (t.Rows[0]["song8"].ToString() == "")
            {
                lbSong8.Visible = false;
                btnPlay8.Visible = false;
            }
            else
            {
                btnPlay8.Visible = true;
                lbSong8.Visible = true;
                lbSong8.Text = t.Rows[0]["song8"].ToString();
                s8 = new SoundPlayer(t.Rows[0]["song8"].ToString() + ".wav");
            }
            if (t.Rows[0]["song9"].ToString() == "")
            {
                btnPlay9.Visible = false;
                lbSong9.Visible = false;
            }
            else
            {
                btnPlay9.Visible = true;
                lbSong9.Visible = true;
                lbSong9.Text = t.Rows[0]["song9"].ToString();
                s9 = new SoundPlayer(t.Rows[0]["song9"].ToString() + ".wav");
            }
            if (t.Rows[0]["song10"].ToString() == "")
            {
                btnPlay10.Visible = false;
                lbSong10.Visible = false;
            }
            else
            {
                btnPlay10.Visible = true;
                lbSong10.Visible = true;
                lbSong10.Text = t.Rows[0]["song10"].ToString();
                s10 = new SoundPlayer(t.Rows[0]["song10"].ToString() + ".wav");
            }
            if (t.Rows[0]["song11"].ToString() == "")
            {
                btnPlay11.Visible = false;
                lbSong11.Visible = false;
            }
            else
            {
                btnPlay11.Visible = true;
                lbSong11.Visible = true;
                lbSong11.Text = t.Rows[0]["song11"].ToString();
                s11 = new SoundPlayer(t.Rows[0]["song11"].ToString() + ".wav");
            }
            if (t.Rows[0]["song12"].ToString() == "")
            {
                btnPlay12.Visible = false;
                lbSong12.Visible = false;
            }
            else
            {
                btnPlay12.Visible = true;
                lbSong12.Visible = true;
                lbSong12.Text = t.Rows[0]["song12"].ToString();
                s12 = new SoundPlayer(t.Rows[0]["song12"].ToString() + ".wav");
            }
            if (t.Rows[0]["song13"].ToString() == "")
            {
                btnPlay13.Visible = false;
                lbSong13.Visible = false;
            }
            else
            {
                btnPlay13.Visible = true;
                lbSong13.Visible = true;
                lbSong13.Text = t.Rows[0]["song13"].ToString();
                s13 = new SoundPlayer(t.Rows[0]["song13"].ToString() + ".wav");
            }
            if (t.Rows[0]["song14"].ToString() == "")
            {
                btnPlay14.Visible = false;
                lbSong14.Visible = false;
            }
            else
            {
                btnPlay14.Visible = true;
                lbSong14.Visible = true;
                lbSong14.Text = t.Rows[0]["song14"].ToString();
                s14 = new SoundPlayer(t.Rows[0]["song14"].ToString() + ".wav");
            }
            if (t.Rows[0]["song15"].ToString() == "")
            {
                btnPlay15.Visible = false;
                lbSong15.Visible = false;
            }
            else
            {
                btnPlay15.Visible = true;
                lbSong15.Visible = true;
                lbSong15.Text = t.Rows[0]["song15"].ToString();
                s15 = new SoundPlayer(t.Rows[0]["song15"].ToString() + ".wav");
            }
            if (t.Rows[0]["song16"].ToString() == "")
            {
                btnPlay16.Visible = false;
                lbSong16.Visible = false;
            }
            else
            {
                btnPlay16.Visible = true;
                lbSong16.Visible = true;
                lbSong16.Text = t.Rows[0]["song16"].ToString();
                s16 = new SoundPlayer(t.Rows[0]["song16"].ToString() + ".wav");
            }
            if (t.Rows[0]["song17"].ToString() == "")
            {
                btnPlay17.Visible = false;
                lbSong17.Visible = false;
            }
            else
            {
                btnPlay17.Visible = true;
                lbSong17.Visible = true;
                lbSong17.Text = t.Rows[0]["song17"].ToString();
                s17 = new SoundPlayer(t.Rows[0]["song17"].ToString() + ".wav");
            }
        }
        void pnlInfoActive()
        {
            pnlInfo.BringToFront();
            deco6.BringToFront();
            int id = listAlbumID[lbAlbum.SelectedIndex];
            albumsTableAdapter.infoAlbum(bdDataSet.albums, id);
            DataTable t = bdDataSet.albums;
            ptbAlbum6.ImageLocation = t.Rows[0]["URL_image"].ToString();
            txtAlbum6.Text = t.Rows[0]["Album"].ToString();
            lbPrice4.Text = t.Rows[0]["Price"].ToString() + " RON";
            lbArtist4User.Text = t.Rows[0]["Artist"].ToString();
            lbGenre4User.Text = t.Rows[0]["Genre"].ToString();
            lbCondition4User.Text = t.Rows[0]["Condition"].ToString();
            lbFormat4User.Text = t.Rows[0]["Format"].ToString();
            txtDescription4User.Text = t.Rows[0]["Description"].ToString();
            lbSeller4User.Text = t.Rows[0]["username"].ToString();
            lbContact3User.Text = t.Rows[0]["email"].ToString();
            lbDatePublish3User.Text = ((DateTime)t.Rows[0]["Date_Publish"]).ToShortDateString();
            SoundsClear();
            previewInfo();
        }
        void pnlInfo2Active()
        {
            pnlInfo2.BringToFront();
            deco6.BringToFront();
            int id = listAlbumID[lbAlbum.SelectedIndex];
            albumsTableAdapter.infoAlbum(bdDataSet.albums, id);
            DataTable t = bdDataSet.albums;
            ptbAlbum5.ImageLocation = t.Rows[0]["URL_image"].ToString();
            txtAlbum5.Text = t.Rows[0]["Album"].ToString();
            lbPrice3.Text = t.Rows[0]["Price"].ToString() + " RON";
            lbArtistUser.Text = t.Rows[0]["Artist"].ToString();
            lbGenreUser.Text = t.Rows[0]["Genre"].ToString();
            lbConditionUser.Text = t.Rows[0]["Condition"].ToString();
            lbFormatUser.Text = t.Rows[0]["Format"].ToString();
            txtDescription5.Text = t.Rows[0]["Description"].ToString();
            lbSellerUser3.Text = t.Rows[0]["username"].ToString();
            lbEmail2.Text = t.Rows[0]["email"].ToString();
            lbDatePublishUser2.Text = ((DateTime)t.Rows[0]["Date_Publish"]).ToShortDateString();
        }
        void pnlProfileActive()
        {
            pnlProfile.BringToFront();
            deco6.BringToFront();
            lbUsername2User.Text = lbUsername.Text;
            string user = lbUsername2User.Text;
            usersTableAdapter.userInfo(bdDataSet.users, user);
            DataTable t = bdDataSet.users;
            lbIDUser.Text = t.Rows[0]["ID_user"].ToString();
            lbEmail3User.Text = t.Rows[0]["email"].ToString();
            lbPasswordUser.Text = t.Rows[0]["password"].ToString();
            lbAdsCountUser.Text = usersTableAdapter.adsCount(user).ToString();

        }
        void pnlProfile2Active()
        {
            pnlProfile2.BringToFront();
            deco6.BringToFront();
        }


        void pnlAdsAddClear()
        {
            txtImageURL.Text = "Alege fisier...";
            ptbAlbum3.Image = null;
            txtAlbum3.Text = "<Titlu>";
            txtPrice.Text = "<Pret>";
            txtArtist.Text = "";
            txtGenre.Text = "";
            cbCondition.Text = "Adauga...";
            cbFormat.Text = "Adauga...";
            txtDescription3.Text = "Adauga detalii despre produs...";
        }
        void pnlAdsUpdateClear()
        {
            txtImageURL2.Text = "Alege fisier...";
            ptbAlbum4.Dispose();
            txtAlbum4.Text = "<Titlu>";
            txtPrice2.Text = "<Pret>";
            txtArtist2.Text = "";
            txtGenre2.Text = "";
            cbCondition2.Text = "Adauga...";
            cbFormat2.Text = "Adauga...";
            txtDescription4.Text = "Adauga detalii despre produs...";
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(73, 46, 46);
            pnlHomeActive();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            btnProfile.BackColor = Color.FromArgb(73, 46, 46);
            pnlProfileActive();
        }
        private void btnAds_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAds.Height;
            pnlNav.Top = btnAds.Top;
            btnAds.BackColor = Color.FromArgb(73, 46, 46);
            pnlAdsActive();
        }
        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(54, 24, 24);
        }
        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(54, 24, 24);
        }
        private void btnAds_Leave(object sender, EventArgs e)
        {
            btnAds.BackColor = Color.FromArgb(54, 24, 24);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa iesiti?", "Iesire", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }


        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Cauta...";
            listInfoAdd();
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string word = txtSearch.Text;
            listInfoClear();
            lbAlbum.Items.Clear();
            listAlbumID.Clear();
            albumsTableAdapter.searchAlbum(bdDataSet.albums, word);
            DataTable t = bdDataSet.albums;
            for (int i = 0; i < t.Rows.Count; i++)
            {
                string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                listAlbumID.Add((int)t.Rows[i]["ID_album"]);
            }
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            listInfoClear();
            if (cbSort.SelectedItem.ToString() == "Dupa album")
            {
                cbSort2.Visible = false;
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortAlbum(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort.SelectedItem.ToString() == "Dupa artist")
            {
                cbSort2.Visible = false;
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortArtist(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort.SelectedItem.ToString() == "Dupa pret")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                cbSort2.Text = "In functie de...";
                cbSort2.Items.Clear();
                cbSort2.Items.Add("Crescator");
                cbSort2.Items.Add("Descrescator");
                cbSort2.Visible = true;

            }
            if (cbSort.SelectedItem.ToString() == "Dupa data publicarii")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                cbSort2.Text = "In functie de...";
                cbSort2.Items.Clear();
                cbSort2.Items.Add("Cel mai recent");
                cbSort2.Items.Add("Cel mai vechi");
                cbSort2.Visible = true;
            }
            if (cbSort.SelectedItem.ToString() == "Dupa gen muzical")
            {
                cbSort2.Visible = false;
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortGenre(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort.SelectedItem.ToString() == "Dupa conditie")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                cbSort2.Text = "In functie de...";
                cbSort2.Items.Clear();
                cbSort2.Items.Add("Sigilat");
                cbSort2.Items.Add("Desigilat");
                cbSort2.Visible = true;
            }
            if (cbSort.SelectedItem.ToString() == "Dupa format")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                cbSort2.Text = "In functie de...";
                cbSort2.Items.Clear();
                cbSort2.Items.Add("CD/DVD");
                cbSort2.Items.Add("Vinyl");
                cbSort2.Visible = true;
            }
            if (cbSort.SelectedItem.ToString() == "Fara sortare")
            {
                cbSort2.Visible = false;
                listInfoAdd();
            }
        }
        private void lbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlbum.SelectedIndex != -1)
            {
                ptbAlbum.Visible = true;
                txtAlbum.Visible = true;
                lbSellerUser.Visible = true;
                txtDescription.Visible = true;
                btnReadMore.Visible = true;
                lbPrice.Visible = true;
                pnlPrice.Visible = true;
                lbSeller.Visible = true;
                int id = listAlbumID[lbAlbum.SelectedIndex];
                albumsTableAdapter.infoAlbum(bdDataSet.albums, id);
                DataTable t = bdDataSet.albums;
                ptbAlbum.ImageLocation = t.Rows[0]["URL_image"].ToString();
                txtAlbum.Text = t.Rows[0]["Album"].ToString();
                lbSellerUser.Text = t.Rows[0]["username"].ToString();
                txtDescription.Text = t.Rows[0]["Description"].ToString();
                lbPrice.Text = t.Rows[0]["Price"].ToString() + " RON";
            }
            else
            {
                ptbAlbum.Visible = false;
                txtAlbum.Visible = false;
                lbSellerUser.Visible = false;
                txtDescription.Visible = false;
                btnReadMore.Visible = false;
                lbPrice.Visible = false;
                pnlPrice.Visible = false;
                lbSeller.Visible = false;
            }
        }
        private void cbSort2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listInfoClear();
            if (cbSort2.SelectedItem.ToString() == "Crescator")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortPriceAsc(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort2.SelectedItem.ToString() == "Descrescator")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortPriceDesc(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort2.SelectedItem.ToString() == "Cel mai recent")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortDatePublishDesc(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cbSort2.SelectedItem.ToString() == "Cel mai vechi")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortDatePublishAsc(bdDataSet.albums);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            string cond = cbSort2.SelectedItem.ToString();
            if (cond == "Sigilat")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortCondition(bdDataSet.albums, cond);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (cond == "Desigilat")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortCondition(bdDataSet.albums, cond);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            string format = cbSort2.SelectedItem.ToString();
            if (format == "CD/DVD")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortFormat(bdDataSet.albums, format);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
            if (format == "Vinyl")
            {
                lbAlbum.Items.Clear();
                listAlbumID.Clear();
                albumsTableAdapter.sortFormat(bdDataSet.albums, format);
                DataTable t = bdDataSet.albums;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    string data = ((DateTime)t.Rows[i]["Date_Publish"]).ToShortDateString();
                    lbAlbum.Items.Add(t.Rows[i]["Album"] + "  |  Artist: " + t.Rows[i]["Artist"] + "  |  Gen: " + t.Rows[i]["Genre"] + "  |  Format: " + t.Rows[i]["Format"] + "  |  Data publicarii: " + data);
                    listAlbumID.Add((int)t.Rows[i]["ID_album"]);
                }
            }
        }


        private void listAds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAds.SelectedIndex != -1)
            {
                ptbAlbum2.Visible = true;
                txtAlbum2.Visible = true;
                txtDescription2.Visible = true;
                btnUpdate.Visible = true;
                lbPrice2.Visible = true;
                pnlPrice2.Visible = true;
                int id = listAdsID[listAds.SelectedIndex];
                albumsTableAdapter.infoAlbum(bdDataSet.albums, id);
                DataTable t = bdDataSet.albums;
                ptbAlbum2.ImageLocation = t.Rows[0]["URL_image"].ToString();
                txtAlbum2.Text = t.Rows[0]["Album"].ToString();
                txtDescription2.Text = t.Rows[0]["Description"].ToString();
                lbPrice2.Text = t.Rows[0]["Price"].ToString() + " RON";
            }
            else
            {
                ptbAlbum2.Visible = false;
                txtAlbum2.Visible = false;
                txtDescription2.Visible = false;
                btnUpdate.Visible = false;
                lbPrice2.Visible = false;
                pnlPrice2.Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdsAddActive();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAdsActive();
            pnlAdsAddClear();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    txtImageURL.Text = imgLocation;
                    ptbAlbum3.ImageLocation = imgLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o eroare, Va rugam sa reincercati", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(txtPrice.Text, out price))
            {
                if (cbCondition.SelectedIndex != -1)
                {
                    if (cbFormat.SelectedIndex != -1)
                    {
                        price = double.Parse(txtPrice.Text);
                        string album = txtAlbum3.Text;
                        string artist = txtArtist.Text;
                        string genre = txtGenre.Text;
                        string condition = cbCondition.SelectedItem.ToString();
                        string format = cbFormat.SelectedItem.ToString();
                        string description = txtDescription3.Text;
                        string url = txtImageURL.Text;
                        string username = lbUsername.Text;
                        string email = lbEmail3User.Text;
                        int iduser = int.Parse(lbIDUser.Text);
                        
                        DateTime data = DateTime.Now;
                        albumsTableAdapter.addAlbum(album, artist, genre, price, condition, data, description, url, format, iduser);
                        albumsTableAdapter.Update(bdDataSet.albums);
                        MessageBox.Show("Anuntul a fost adaugat", "Anunt adaugat", MessageBoxButtons.OK);
                        pnlAdsActive();
                        pnlAdsAddClear();
                    }
                    else
                    {
                        MessageBox.Show("Alege un format", "Format neselectat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alege o conditie", "Conditie neselectata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pretul introdus nu e compatibil, Va rugam reintroduceti", "Valoare incompatibila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(txtPrice2.Text, out price))
            {
                if (cbCondition2.SelectedIndex != -1)
                {
                    if (cbFormat2.SelectedIndex != -1)
                    {
                        price = double.Parse(txtPrice2.Text);
                        string album = txtAlbum4.Text;
                        string artist = txtArtist2.Text;
                        string genre = txtGenre2.Text;
                        string condition = cbCondition2.SelectedItem.ToString();
                        string format = cbFormat2.SelectedItem.ToString();
                        string description = txtDescription4.Text;
                        string url = txtImageURL2.Text;
                        int id = listAdsID[listAds.SelectedIndex];
                        string username = lbUsername.Text;
                        string email = lbEmail3User.Text;
                        int iduser = int.Parse(lbIDUser.Text);

                        albumsTableAdapter.updateAlbum(album, artist, genre, price, condition, description, url, iduser, format, id);
                        albumsTableAdapter.Update(bdDataSet.albums);
                        MessageBox.Show("Anuntul a fost modificat", "Anunt modificat", MessageBoxButtons.OK);
                        pnlAdsActive();
                    }
                    else
                    {
                        MessageBox.Show("Alege un format", "Format neselectat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alege o conditie", "Conditie neselectata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pretul introdus nu e compatibil, Va rugam reintroduceti", "Valoare incompatibila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            pnlAdsActive();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlAdsUpdateActive();
        }
        private void btnLoad2_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    txtImageURL2.Text = imgLocation;
                    ptbAlbum3.ImageLocation = imgLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o eroare, Va rugam sa reincercati", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti anuntul?", "Stergere anunt", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = listAdsID[listAds.SelectedIndex];
                albumsTableAdapter.deleteAlbum(id);
                albumsTableAdapter.Update(bdDataSet.albums);
                MessageBox.Show("Anuntul a fost sters", "Anunt sters", MessageBoxButtons.OK);
                pnlAdsActive();
            }
        }


        private void btnReadMore_Click(object sender, EventArgs e)
        {
            int id = listAlbumID[lbAlbum.SelectedIndex];
            if (id > 9)
                pnlInfo2Active();
            else
                pnlInfoActive();
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            pnlInfo2.SendToBack();
        }


        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            pnlProfile2Active();
            lbID2User.Text = lbIDUser.Text;
            lbAdsCount2User.Text=lbAdsCountUser.Text;
            txtUsername3User.Text=lbUsername2User.Text;
            txtEmail4User.Text=lbEmail3User.Text;
            txtPassword2User.Text = "";
            txtConfPassword2User.Text = "";
            
        }
        private void btnExit3_Click(object sender, EventArgs e)
        {
            pnlProfileActive();
        }

        private void btnUpdate4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbID2User.Text);
            if (txtUsername3User.Text == "" || txtEmail4User.Text == "" || txtPassword2User.Text == "" || txtConfPassword2User.Text == "")
            {
                MessageBox.Show("Unul dintre campuri este gol", "Salvare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername3User.TextLength < 6)
                {
                    MessageBox.Show("Alege un nume mai lung de 6 caractere", "Salvare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtUsername3User.TextLength > 13)
                    {
                        MessageBox.Show("Numele este prea lung", "Salvare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtPassword2User.Text == txtConfPassword2User.Text)
                        {
                            string username = txtUsername3User.Text;
                            string email = txtEmail4User.Text;
                            string pass = txtPassword2User.Text;
                            int valid1 = int.Parse(usersTableAdapter.validUser(username).ToString());
                            int valid2 = int.Parse(usersTableAdapter.validUser3(email).ToString());
                            int valid3= int.Parse(usersTableAdapter.validUser4(username,email,id).ToString());

                            if (valid1 == 0 || valid2 == 0 || valid3 == 1)
                            {
                                usersTableAdapter.updateUser(username, email, pass, id);
                                usersTableAdapter.Update(bdDataSet.users);
                                lbUsername.Text = username;
                                txtPassword2User.Text = "";
                                txtConfPassword2User.Text = "";
                                MessageBox.Show("Datele au fost modificate cu succes", "Salvare completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pnlProfileActive();
                            }
                            else
                            {
                                
                                    MessageBox.Show("Acest cont exista deja, Va rugam sa reintroduceti", "Salvare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPassword2User.Text = "";
                                    txtConfPassword2User.Text = "";
                            }
                        }
                        else
                        {
 
                            MessageBox.Show("Parolele nu se potrivesc, Va rugam sa reintroduceti", "Salvare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword2User.Text = "";
                            txtConfPassword2User.Text = "";
                            txtPassword2User.Focus();
                        }
                    }
                }
            }
        }


        private void btnPlay1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay1.Checked)
            {
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay1.Text = "⬛";
                s1.Play();
            }
            else
            {
                btnPlay1.Text = "▶️";
                s1.Stop();
            }
        }
        private void btnPlay2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay2.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay2.Text = "⬛";
                s2.Play();
            }
            else
            {
                btnPlay2.Text = "▶️";
                s2.Stop();
            }
        }
        private void btnPlay3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay3.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay3.Text = "⬛";
                s3.Play();
            }
            else
            {
                btnPlay3.Text = "▶️";
                s3.Stop();
            }
        }
        private void btnPlay4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay4.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay4.Text = "⬛";
                s4.Play();
            }
            else
            {
                btnPlay4.Text = "▶️";
                s4.Stop();
            }
        }
        private void btnPlay5_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay5.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay5.Text = "⬛";
                s5.Play();
            }
            else
            {
                btnPlay5.Text = "▶️";
                s5.Stop();
            }
        }
        private void btnPlay6_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay6.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay6.Text = "⬛";
                s6.Play();
            }
            else
            {
                btnPlay6.Text = "▶️";
                s6.Stop();
            }
        }
        private void btnPlay7_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay7.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay7.Text = "⬛";
                s7.Play();
            }
            else
            {
                btnPlay7.Text = "▶️";
                s7.Stop();
            }
        }
        private void btnPlay8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnPlay8.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay8.Text = "⬛";
                s8.Play();
            }
            else
            {
                btnPlay8.Text = "▶️";
                s8.Stop();
            }
        }
        private void btnPlay9_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay9.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay9.Text = "⬛";
                s9.Play();
            }
            else
            {
                btnPlay9.Text = "▶️";
                s9.Stop();
            }
        }
        private void btnPlay10_CheckedChanged(object sender, EventArgs e)
        {

            if (btnPlay10.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay10.Text = "⬛";
                s10.Play();
            }
            else
            {
                btnPlay10.Text = "▶️";
                s10.Stop();
            }
        }
        private void btnPlay11_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay11.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay11.Text = "⬛";
                s11.Play();
            }
            else
            {
                btnPlay11.Text = "▶️";
                s11.Stop();
            }
        }
        private void btnPlay12_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay12.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay12.Text = "⬛";
                s12.Play();
            }
            else
            {
                btnPlay12.Text = "▶️";
                s12.Stop();
            }
        }
        private void btnPlay13_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay13.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay13.Text = "⬛";
                s13.Play();
            }
            else
            {
                btnPlay13.Text = "▶️";
                s13.Stop();
            }
        }
        private void btnPlay14_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay14.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay14.Text = "⬛";
                s14.Play();
            }
            else
            {
                btnPlay14.Text = "▶️";
                s14.Stop();
            }
        }
        private void btnPlay15_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay15.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Checked = false;
                btnPlay15.Text = "⬛";
                s15.Play();
            }
            else
            {
                btnPlay15.Text = "▶️";
                s15.Stop();
            }
        }
        private void btnPlay16_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay16.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay17.Checked = false;
                btnPlay16.Text = "⬛";
                s16.Play();
            }
            else
            {
                btnPlay16.Text = "▶️";
                s16.Stop();
            }
        }
        private void btnPlay17_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay17.Checked)
            {
                btnPlay1.Checked = false;
                btnPlay2.Checked = false;
                btnPlay3.Checked = false;
                btnPlay4.Checked = false;
                btnPlay5.Checked = false;
                btnPlay6.Checked = false;
                btnPlay7.Checked = false;
                btnPlay8.Checked = false;
                btnPlay9.Checked = false;
                btnPlay10.Checked = false;
                btnPlay11.Checked = false;
                btnPlay12.Checked = false;
                btnPlay13.Checked = false;
                btnPlay14.Checked = false;
                btnPlay15.Checked = false;
                btnPlay16.Checked = false;
                btnPlay17.Text = "⬛";
                s17.Play();
            }
            else
            {
                btnPlay17.Text = "▶️";
                s17.Stop();
            }
        }


        private void btnExit4_Click(object sender, EventArgs e)
        {
            pnlInfo.SendToBack();
            SoundsClear();
        }
        


    }
}
