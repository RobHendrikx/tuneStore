using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices; //nodig voor de audio dll
using System.IO;

namespace tuneStore
{
    public partial class frmTunestoreShoo : Form
    {

        csNummerFormulier[] song = new csNummerFormulier[500];
        int nr = 0;
        int index;

        private ulong Lng = 0;

        #region belangrijke toevoeging, anders werkt het niet
        //dll import mogelijk maken
        //bovenin toevoegen
        //using System.Runtime.InteropServices;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        #endregion

        private void addSong()
        {
            int m_existingSongNumber = 0;
            bool m_songFound = false;
            bool m_notFound = false;

            if (nr > 0)
            {
                while (m_songFound == false && m_notFound == false)
                {
                    if (song[m_existingSongNumber].location == tbTuneLocationShoo.Text)
                    {
                        m_songFound = true;
                        lblDoubleSongShoo.Text = "Song already found!";
                    }
                    else
                    {
                        m_existingSongNumber++;

                        if (m_existingSongNumber >= nr)
                        {
                            m_notFound = true;
                        }
                    }
                }
            }


            if (m_songFound == false && m_existingSongNumber <= nr)
            {
                song[nr] = new csNummerFormulier();

                song[nr].naam = tbTuneNameShoo.Text;
                song[nr].location = tbTuneLocationShoo.Text;

                nr++;
                lblDoubleSongShoo.Text = "...";
            }
            //song[nr] = new csNummerFormulier();

            //song[nr].naam = tbTuneNameShoo.Text;
            //song[nr].location = tbTuneLocationShoo.Text;

            //nr++;
        }

        private void ShowFile()
        {
            int m_nr;

            rtbTunesTotalShoo.Clear();

            for (m_nr = 0; m_nr < nr; m_nr++)
            {
                rtbTunesTotalShoo.AppendText(m_nr.ToString() + ")  -  " + song[m_nr].naam + " \n");


                //cbbAvailableSongsShoo.Text = (song[m_nr].naam + " \n");
            }
        }

        public frmTunestoreShoo()
        {
            InitializeComponent();
            initView();
            Application.EnableVisualStyles();
            tpDebugShoo.SelectedIndex = 2;
            msTunestoreShoo.Hide();
            tbVolumeShoo.Value = 100;
            lblVolumeShoo.Text = Convert.ToString("Volume: " + tbVolumeShoo.Value + "%");
        }

        private void initView()
        {
            tpDebugShoo.Appearance = TabAppearance.FlatButtons;
            tpDebugShoo.ItemSize = new Size(0, 1);
            tpDebugShoo.SizeMode = TabSizeMode.Fixed;
        }

        private void miStockShoo_Click(object sender, EventArgs e)
        {
            tpDebugShoo.SelectedIndex = 0;
        }

        private void miModeShoo_Click(object sender, EventArgs e)
        {
            tpDebugShoo.SelectedIndex = 1;
        }

        private void miColorMainShoo_Click(object sender, EventArgs e)
        {
            cldColorMainShoo.ShowDialog();
            tpInventoryShoo.BackColor = cldColorMainShoo.Color;
            tpModeShoo.BackColor = cldColorMainShoo.Color;

            rtbDebugShoo.AppendText("User Selected Color Change" + "\t" + Convert.ToString(DateTime.Now) + "\n");

            if (tpInventoryShoo.BackColor == Color.Black)
            {
                tpInventoryShoo.ForeColor = Color.White;
            }
            if (tpInventoryShoo.BackColor == Color.White)
            {
                tpInventoryShoo.ForeColor = Color.Black;
            }
        }

        private void btnContinueShoo_Click(object sender, EventArgs e)
        {
            tpDebugShoo.SelectedIndex = 0;
            msTunestoreShoo.Show();

            rtbDebugShoo.AppendText("User Continued To Form" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void btnAddShoo_Click(object sender, EventArgs e)
        {
            //this.Hide();

            OpenFileDialog ofdSongsShoo = new OpenFileDialog();

            /*//openfiledialog file filter
            this.ofdSongsShoo.Filter =
            "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            ofdSongsShoo.FilterIndex = 1;

            //this.openFileDialog1.Multiselect = true;
            this.ofdSongsShoo.Title = "My Image Browser";*/

            if (ofdSongsShoo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbTuneLocationShoo.Text = ofdSongsShoo.FileName;
                this.tbTuneNameShoo.Text = ofdSongsShoo.SafeFileName;
                rtbDebugShoo.AppendText("User Added a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");
            }
            else
            {
                tpDebugShoo.SelectedIndex = 0;
            }
        }

        private void btnPlayShoo_Click(object sender, EventArgs e)
        {
            btnPlayShoo.Hide();
            btnPauseShoo.Show();
            playAudio();
            rtbDebugShoo.AppendText("User Plays a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void btnStopShoo_Click(object sender, EventArgs e)
        {
            stopAudio();
            btnPauseShoo.Hide();
            btnPlayShoo.Show();
            rtbDebugShoo.AppendText("User Stopped a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void btnPauseShoo_Click(object sender, EventArgs e)
        {
            pauseAudio();
            btnPlayShoo.Show();
            btnPauseShoo.Hide();

            rtbDebugShoo.AppendText("User Paused a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void playAudio()
        {
            string m_location;

            //CalculateLength();

            //eerst plaats van applicatie ophalen
            m_location = Application.StartupPath;

            //dan bepalen waar het geluid staat en daar naar toe stappen
            m_location = tbCurrentSelectionShoo.Text;

            //voor het afspelen moet de geluidsweergave gestopt zijn!
            //en afspelen
            mciSendString("open \"" + m_location + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);

            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void stopAudio()
        {
            //stoppen
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }

        private void pauseAudio()
        {
            //pauzeren
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
        }

        //private void CalculateLength()
        //{
        //    StringBuilder str = new StringBuilder(128);
        //    mciSendString("status MediaFile length", str, 0, IntPtr.Zero);
        //    Lng = Convert.ToUInt64(str.ToString());
        //    lblTimeShoo.Text = Lng.ToString();
        //}

        //Progressing the volume
        public static class NativeMethods
        {
            //Winm WindowsSound
            [DllImport("winmm.dll")]
            internal static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
            [DllImport("winmm.dll")]
            internal static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        }

        private void tbVolumeShoo_Scroll(object sender, EventArgs e)
        {
            uint CurrVol = ushort.MaxValue / 2;
            NativeMethods.waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            int NewVolume = ((ushort.MaxValue / 100) * tbVolumeShoo.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            NativeMethods.waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            lblVolumeShoo.Text = Convert.ToString("Volume: " + tbVolumeShoo.Value + "%");
        }

        private void rtbTunesTotalShoo_TextChanged(object sender, EventArgs e)
        {
            rtbTunesTotalShoo.SelectionStart = rtbTunesTotalShoo.Text.Length;
            rtbTunesTotalShoo.ScrollToCaret();
        }

        private void miSearchShoo_Click(object sender, EventArgs e)
        {
            miSearchShoo.Text = "";
            rtbDebugShoo.AppendText("User Searches a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void rtbTunesTotalShoo_Click(object sender, EventArgs e)
        {
            miSearchShoo.Text = "Search a song...";

            rtbDebugShoo.AppendText("User Selected Tunes Index" + "\t" + Convert.ToString(DateTime.Now) + "\n");

           // int m_index;

           // m_index = rtbTunesTotalShoo.GetLineFromCharIndex(rtbTunesTotalShoo.SelectionStart);


            if (this.song[index] == null)
            {

            }
            else {
                //tbCurrentSelectionShoo.Text = song[m_index].location;
                //tbTuneLocationShoo.Text = song[m_index].location;
                //tbTuneNameShoo.Text = song[m_index].naam;

                int m_selectStart;
                int m_index;
                string m_line;
                int m_nr = 0;
                bool m_found = false;
                bool m_songNotInList = false;

                //haal characternummer op in de regel
                m_selectStart = rtbTunesTotalShoo.SelectionStart;

                //gebruik deze als vindplaats voor een regelnummer
                m_index = rtbTunesTotalShoo.GetLineFromCharIndex(m_selectStart);

                //zet dan dit nummer als index voor alle regels in de rtb
                m_line = rtbTunesTotalShoo.Lines[m_index];

                while (m_found == false && m_songNotInList == false)
                {
                    if (m_nr < nr)
                    {
                        if (m_line.IndexOf(song[m_nr].naam) > -1)
                        {
                            index = m_nr;
                            m_found = true;
                        }
                        m_nr++;
                    }
                    else
                    {
                        m_songNotInList = true;
                    }
                }
                selectSong();
            }
        }

        private void selectSong()
        {
            tbTuneNameShoo.Text = song[index].naam;
            tbCurrentSelectionShoo.Text = song[index].location;

            lblNowPlayingShoo.Text = song[index].naam;
            tbTuneLocationShoo.Text = song[index].location;
        }

        private void tpInventoryShoo_Click(object sender, EventArgs e)
        {
            miSearchShoo.Text = "Search a song...";
        }

        private void btnSetShoo_Click(object sender, EventArgs e)
        {
            rtbTunesTotalShoo.Enabled = true;

            if (tbTuneNameShoo.Text == "")
            {

            }
            else
            {
                addSong();
                ShowFile();
            }

        }

        private void miSearchShoo_TextChanged(object sender, EventArgs e)
        {
            int m_index;

            rtbTunesTotalShoo.Clear();

            for (m_index = 0; m_index < nr; m_index++)
            {
                if (song[m_index].naam.IndexOf(miSearchShoo.Text) >= 0)
                {
                    rtbTunesTotalShoo.AppendText(song[m_index].naam + "\n");

                    //Dit kan nog niet want nu laat hij voor iedere letter een debug regel zien... vergelijken en filteren dat het maar 1 keer word getoond
                    //rtbDebugShoo.AppendText("User Searched for Song: (" + (song[m_index].naam) + ")" + "\t" + Convert.ToString(DateTime.Now) + "\n");
                }
            }
        }

        private void btnSaveShoo_Click(object sender, EventArgs e)
        {
            if (sfdPlaylistShoo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string m_fileNameAndLocation;
                int m_nr;

                //sfdPlaylistShoo.ShowDialog();

                rtbDebugShoo.AppendText("User Saved a Playlist" + "\t" + Convert.ToString(DateTime.Now) + "\n");

                m_fileNameAndLocation = sfdPlaylistShoo.FileName;

                StreamWriter inschrijfFormulieren = new StreamWriter(m_fileNameAndLocation);

                rtbTunesTotalShoo.AppendText(m_fileNameAndLocation);

                for (m_nr = 0; m_nr < nr; m_nr++)
                {
                    inschrijfFormulieren.WriteLine(song[m_nr].naam);
                    inschrijfFormulieren.WriteLine(song[m_nr].location);
                }
                inschrijfFormulieren.Close();
            }
            else
            {
                tpDebugShoo.SelectedIndex = 0;
            }


        }

        private void btnOpenShoo_Click(object sender, EventArgs e)
        {
            if (ofdPlaylistShoo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string m_fileNameAndLocation;

                rtbDebugShoo.AppendText("User Selected a Song" + "\t" + Convert.ToString(DateTime.Now) + "\n");

                //ofdPlaylistShoo.ShowDialog();

                m_fileNameAndLocation = ofdPlaylistShoo.FileName;

                StreamReader inhoud = new StreamReader(m_fileNameAndLocation);

                //rtbTunesTotalShoo.AppendText(m_fileNameAndLocation);

                while (inhoud.EndOfStream == false)
                {
                    tbTuneNameShoo.Text = inhoud.ReadLine();
                    tbTuneLocationShoo.Text = inhoud.ReadLine();

                    addSong();
                }

                inhoud.Close();
                ShowFile();
            }
            else
            {
                tpDebugShoo.SelectedIndex = 0;
            }
        }
        private void miHelpShoo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\AsusNotebook\Desktop\Sander\Documents\Visual Studio 2010\UserManualTuneStore.docx");
            rtbDebugShoo.AppendText("User Selected Help" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miDebugShoo_Click(object sender, EventArgs e)
        {
            tpDebugShoo.SelectedIndex = 3;
            rtbDebugShoo.AppendText("User Selected Debug" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miFileShoo_Click(object sender, EventArgs e)
        {
            rtbDebugShoo.AppendText("User Selected File" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miEditShoo_Click(object sender, EventArgs e)
        {
            rtbDebugShoo.AppendText("User Selected Edit" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miViewShoo_Click(object sender, EventArgs e)
        {
            rtbDebugShoo.AppendText("User Selected View" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miToolsShoo_Click(object sender, EventArgs e)
        {
            rtbDebugShoo.AppendText("User Selected Tools" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miTunestoreShoo_Click(object sender, EventArgs e)
        {
            tpDebugShoo.SelectedIndex = 0;
            rtbDebugShoo.AppendText("User Selected Tunestore tab" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbDebugShoo.Text = "";
        }

        private void frmTunestoreShoo_Load(object sender, EventArgs e)
        {
            rtbDebugShoo.AppendText("Form Loaded" + "\t" + Convert.ToString(DateTime.Now) + "\n");
        }

        private void miDebugShoo_MouseHover(object sender, EventArgs e)
        {
            miDebugShoo.BackColor = Color.DimGray;
        }

        private void nextSong()
        {
            int m_song;

            m_song = rtbTunesTotalShoo.GetLineFromCharIndex(rtbTunesTotalShoo.SelectionStart);
        }

        private void btnPreviousSongShoo_Click(object sender, EventArgs e)
        {
            previousAudio();
        }

        private void nextAudio()
        {
            //volgende
            if (index < nr - 1)
            {
                btnPauseShoo.Visible = true;
                btnPlayShoo.Visible = false;
                index++;
                selectSong();
                stopAudio();
                playAudio();
            }
            else
            {
                //MessageBox.Show("No songs left in the playlist");
                lblDoubleSongShoo.Text = "No songs found";
            }
        }

        private void previousAudio()
        {
            //vorige
            if (index > 0)
            {
                btnPauseShoo.Visible = true;
                btnPlayShoo.Visible = false;
                index--;
                selectSong();
                stopAudio();
                playAudio();
            }
            else
            {
                //MessageBox.Show("No songs left in the playlist");
                lblDoubleSongShoo.Text = "No songs found";
            }
        }

        private void btnNextSongShoo_Click(object sender, EventArgs e)
        {
            nextAudio();
        }

        //private void tmLengthShoo_Tick(object sender, EventArgs e)
        //{
        //    CalculateLength();
        //}

        private void tbCurrentSelectionShoo_TextChanged(object sender, EventArgs e)
        {
            stopAudio();
            playAudio();
            btnPlayShoo.Visible = false;
            btnPauseShoo.Visible = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gemaakt door: sander \n Hulp: Rick huijbers");
        }

        private void msTunestoreShoo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
