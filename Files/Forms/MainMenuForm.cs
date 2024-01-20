using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using WMPLib;
using Trenches_of_Gallipoli.Properties;


namespace Trenches_of_Gallipoli
{

    

    public partial class MainMenuForm : Form
    {

        WindowsMediaPlayer MainMenuThemeEnglish;
        WindowsMediaPlayer MainMenuThemeTurkish;
            
        public static string Language;


        bool IntroSkip;
        public string playerName;
        public Image playerAvatar;
        public static int bestPlayerScore;
        public static int playerScore;
        public static Image bestPlayerAvatar;
        public static string bestPlayerName;
        int inGameValue;

        public MainMenuForm(string inputLanguage)
        {            
            InitializeComponent();
            Language = inputLanguage;
            IntroSkip = false;

            if (inputLanguage == "ENG")
            {
                MainMenuThemeEnglish = new WindowsMediaPlayer();
                MainMenuThemeEnglish.URL = "Sounds\\Sabaton-CliffsOfGallipoli.mp3";
                MainMenuThemeEnglish.settings.autoStart = true;
                MainMenuThemeEnglish.settings.setMode("loop", true);
            }
            if (inputLanguage == "TR")
            {
                MainMenuThemeTurkish = new WindowsMediaPlayer();
                MainMenuThemeTurkish.URL = "Sounds\\CanakkaleTurkusu.mp3";
                MainMenuThemeTurkish.settings.autoStart = true;
                MainMenuThemeTurkish.settings.setMode("loop", true);

            }

            axIntro.URL = "Video\\Intro.mp4";
            axIntro.Ctlcontrols.stop();













        }

        private void LabelPlay_Click(object sender, EventArgs e)
        {
            TBoxName.Text = string.Empty;
            PBoxSelectPlayerImage.Image = Resources.MehmetEsatBulkat;
            LabelClickToSelect.Show();
            LabelStartGame.Show();
            LabelPlayerName.Show();
            PBoxSelectPlayerImage.Show();
            TBoxName.Show();
            PBoxInputBG.Show();
            LabelCloseInput.Show();
            HideMainMenuGUI();
        }

        private void LabelCloseInput_Click(object sender, EventArgs e)
        {
            
            LabelClickToSelect.Hide();
            LabelStartGame.Hide();
            LabelPlayerName.Hide();
            PBoxSelectPlayerImage.Hide();
            TBoxName.Hide();
            PBoxInputBG.Hide();
            LabelCloseInput.Hide();
            ShowMainMenuGUI();
        }

        private void LabelStartGame_Click(object sender, EventArgs e)
        {

            






            if (TBoxName.Text == String.Empty)
            {
                if (Language == "ENG")
                {
                    MessageBox.Show("Please Enter a Name Before Starting a Game");
                } else if (Language == "TR")
                {
                    MessageBox.Show("Lütfen başlamadan önce isim girin");
                }
             
            } 
            else 
            {
                

                if (IntroSkip == false)
                {

                    if (Language == "ENG")
                    {
                        MainMenuThemeEnglish.close();
                    }
                    if (Language == "TR")
                    {
                        MainMenuThemeTurkish.close();
                    }

                    LabelSkip.Visible = true;
                    axIntro.Show();
                    axIntro.Ctlcontrols.play();
                } 
                else
                {
                    if (Language == "ENG")
                    {
                        MainMenuThemeEnglish.close();
                    }
                    if (Language == "TR")
                    {
                        MainMenuThemeTurkish.close();
                    }




                    playerName = TBoxName.Text;
                    playerAvatar = PBoxSelectPlayerImage.Image;

                    this.Hide();
                    GameForm Form = new GameForm(playerName, playerAvatar, Language, inGameValue);
                    Form.Closed += (s, args) => this.Show();
                    Form.Show();
                }                
                
            }
                     
        }

        private void LabelHighscores_Click(object sender, EventArgs e)
        {
            HideMainMenuGUI();
            ShowHighscoresGUI();
        }

        private void LabelOptions_Click(object sender, EventArgs e)
        {
            HideMainMenuGUI();
            ShowOptionsGUI();
        }

        private void LabelAbout_Click(object sender, EventArgs e)
        {
            HideMainMenuGUI();
            ShowAboutGUI();
        }
        private void LabelRTMainMenu_Click(object sender, EventArgs e)
        {
            LabelRTMainMenu.Hide();
            HideAboutGUI();
            HideHighscoresGUI();
            HideOptionsGUI();
            ShowMainMenuGUI();
        }
        private void LabelQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HideMainMenuGUI()
        {
            LabelTitle.Hide();
            LabelPlay.Hide();            
            LabelHighscores.Hide();
            LabelOptions.Hide();
            LabelAbout.Hide();
            LabelQuit.Hide();
        }

        private void ShowMainMenuGUI()
        {
            LabelTitle.Show();
            LabelPlay.Show();
            LabelHighscores.Show();
            LabelOptions.Show();
            LabelAbout.Show();
            LabelQuit.Show();
        }

        private void ShowHighscoresGUI()
        {
            LabelBestPlayerName.Text = bestPlayerName;
            PBoxBestPlayerAvatar.Image = bestPlayerAvatar;

            LabelRTMainMenu.Show();
            LabelHighscoreHolder.Show();
            LabelBestPlayerName.Show();
            PBoxBestPlayerAvatar.Show();
            PBoxHighscoreBG.Show();

        }

        private void HideHighscoresGUI()
        {
            LabelRTMainMenu.Hide();
            LabelHighscoreHolder.Hide();
            LabelBestPlayerName.Hide();
            PBoxBestPlayerAvatar.Hide();
            PBoxHighscoreBG.Hide();
        }

        private void ShowOptionsGUI()
        {
            LabelRTMainMenu.Show();
            volumeControl1.Show();
            LabelVolume.Show();
            volumeControl2.Show();
            LabelVolume2.Show();
            LabelMainMenuVolume.Show();
            LabelIngameVolume.Show();
        }

        private void HideOptionsGUI()
        {
            LabelRTMainMenu.Hide();
            volumeControl1.Hide();
            LabelVolume.Hide();
            volumeControl2.Hide();
            LabelVolume2.Hide();
            LabelMainMenuVolume.Hide();
            LabelIngameVolume.Hide();
        }

        private void ShowAboutGUI()
        {
            LabelRTMainMenu.Show();
            LabelMyName.Show();
            LabelGithub.Show();
            LabelAbouts.Show();
            
            
        }

        private void HideAboutGUI()
        {
            LabelRTMainMenu.Hide();
            LabelAbouts.Hide();
            LabelGithub.Hide();
            LabelMyName.Hide();
        }

        private void PBoxSelectPlayerImage_Click(object sender, EventArgs e)
        {
            DialogResult Image;

            

            if (Language == "ENG")
            {
                SelectImageDialog.Filter = "Image Files |*.JPG;*.BMP;*.GIF";
                Image = SelectImageDialog.ShowDialog();
                if (Convert.ToString(Image) == "OK")
                {
                    string ImageFile = SelectImageDialog.FileName;
                    PBoxSelectPlayerImage.Image = Bitmap.FromFile(ImageFile);

                }
            }
            else if (Language == "TR")
            {
                SelectImageDialog.Filter = "Resim Dosyası |*.JPG;*.BMP;*.GIF";
                Image = SelectImageDialog.ShowDialog();
                if (Convert.ToString(Image) == "OK")
                {
                    string ImageFile = SelectImageDialog.FileName;
                    PBoxSelectPlayerImage.Image = Bitmap.FromFile(ImageFile);

                }
            }

            
        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {

            

            if (Language == "ENG")
            {
                MainMenuThemeEnglish.settings.volume = volumeControl1.Value;
                LabelVolume.Text = "Volume : " + volumeControl1.Value.ToString() + "%";
                
                LabelVolume2.Text = "Volume : " + volumeControl2.Value.ToString() + "%";
                inGameValue = volumeControl2.Value;
            }
            else if (Language == "TR")
            {
                MainMenuThemeTurkish.settings.volume = volumeControl1.Value;
                LabelVolume.Text = "Ses : %" + volumeControl1.Value.ToString();

                LabelVolume2.Text = "Ses : %" + volumeControl2.Value.ToString();
                inGameValue = volumeControl2.Value;

            }

            if (GameForm.isMainMenuShown == 1)
            {
                if (Language == "ENG")
                {
                    MainMenuThemeEnglish.controls.play();
                    MainMenuThemeEnglish.settings.setMode("loop", true);
                    GameForm.isMainMenuShown = 0;
                }
                else if (Language == "TR")
                {
                    MainMenuThemeTurkish.controls.play();
                    MainMenuThemeTurkish.settings.setMode("loop", true);
                    GameForm.isMainMenuShown=0;
                }
              
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
            if (Language == "TR")
            {
                LabelRTMainMenu.Text = "Ana Menüye geri dön";
                LabelPlay.Text = "Oyna";
                LabelHighscores.Text = "Rekortmen";
                LabelOptions.Text = "Ayarlar";
                LabelAbout.Text = "Hakkında";
                LabelQuit.Text = "Çık";

                LabelPlayerName.Text = "İsim:";
                LabelClickToSelect.Text = "Avatar seçmek için resme tıklayın";
                LabelStartGame.Text = "Cepheye !";
                LabelHighscoreHolder.Text = "Rekortmen";
                LabelIngameVolume.Text = "Oyun İçi Ses Seviyesi";
                LabelMainMenuVolume.Text = "Ana Menu Ses Seviyesi";
                LabelSkip.Text = "Geç";

                LabelAbouts.Text = "Oluşturan:\n\n\n\n\n\nBana Yardımcı Olan\nTüm Reddit kullanıcılarına\nve\nDiscorddaki insanlara\nTeşekkür Ederim";


            }


           


        }
    
      

        private void LabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/merenbal");
        }

        private void LabelSkip_Click(object sender, EventArgs e)
        {
            axIntro.Ctlcontrols.stop();
            LabelSkip.Visible = false;
            axIntro.Visible = false;

            IntroSkip = true; //Remove this if you want the Intro shown everytime

            

            playerName = TBoxName.Text;
            playerAvatar = PBoxSelectPlayerImage.Image;

            this.Hide();
            GameForm Form = new GameForm(playerName, playerAvatar, Language, inGameValue);
            Form.Closed += (s, args) => this.Show();
            Form.Show();
        }
    }
}
