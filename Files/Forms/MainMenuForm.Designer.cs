namespace Trenches_of_Gallipoli
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelStartGame = new System.Windows.Forms.Label();
            this.LabelHighscores = new System.Windows.Forms.Label();
            this.LabelOptions = new System.Windows.Forms.Label();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.LabelQuit = new System.Windows.Forms.Label();
            this.LabelRTMainMenu = new System.Windows.Forms.Label();
            this.LabelPlayerName = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.LabelPlay = new System.Windows.Forms.Label();
            this.SelectImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.LabelCloseInput = new System.Windows.Forms.Label();
            this.LabelBestPlayerName = new System.Windows.Forms.Label();
            this.LabelHighscoreHolder = new System.Windows.Forms.Label();
            this.LabelClickToSelect = new System.Windows.Forms.Label();
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            this.PBoxBestPlayerAvatar = new System.Windows.Forms.PictureBox();
            this.PBoxSelectPlayerImage = new System.Windows.Forms.PictureBox();
            this.PBoxInputBG = new System.Windows.Forms.PictureBox();
            this.PBoxHighscoreBG = new System.Windows.Forms.PictureBox();
            this.PBoxMainMenuBG = new System.Windows.Forms.PictureBox();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.LabelAbouts = new System.Windows.Forms.Label();
            this.LabelMyName = new System.Windows.Forms.Label();
            this.LabelGithub = new System.Windows.Forms.LinkLabel();
            this.LabelVolume2 = new System.Windows.Forms.Label();
            this.LabelMainMenuVolume = new System.Windows.Forms.Label();
            this.LabelIngameVolume = new System.Windows.Forms.Label();
            this.LabelSkip = new System.Windows.Forms.Label();
            this.axIntro = new AxWMPLib.AxWindowsMediaPlayer();
            this.volumeControl2 = new Trenches_of_Gallipoli.Files.Forms.VolumeControl();
            this.volumeControl1 = new Trenches_of_Gallipoli.Files.Forms.VolumeControl();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBestPlayerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSelectPlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxInputBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxHighscoreBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMainMenuBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTitle.Font = new System.Drawing.Font("Agency FB", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(475, 252);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Trenches Of\r\nGallipoli";
            // 
            // LabelStartGame
            // 
            this.LabelStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStartGame.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelStartGame.Location = new System.Drawing.Point(756, 666);
            this.LabelStartGame.Name = "LabelStartGame";
            this.LabelStartGame.Size = new System.Drawing.Size(370, 77);
            this.LabelStartGame.TabIndex = 2;
            this.LabelStartGame.Text = "To the Trenches !";
            this.LabelStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelStartGame.Visible = false;
            this.LabelStartGame.Click += new System.EventHandler(this.LabelStartGame_Click);
            // 
            // LabelHighscores
            // 
            this.LabelHighscores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelHighscores.AutoSize = true;
            this.LabelHighscores.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHighscores.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelHighscores.Location = new System.Drawing.Point(23, 743);
            this.LabelHighscores.Name = "LabelHighscores";
            this.LabelHighscores.Size = new System.Drawing.Size(203, 58);
            this.LabelHighscores.TabIndex = 3;
            this.LabelHighscores.Text = "Highscores";
            this.LabelHighscores.Click += new System.EventHandler(this.LabelHighscores_Click);
            // 
            // LabelOptions
            // 
            this.LabelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelOptions.AutoSize = true;
            this.LabelOptions.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelOptions.Location = new System.Drawing.Point(23, 801);
            this.LabelOptions.Name = "LabelOptions";
            this.LabelOptions.Size = new System.Drawing.Size(140, 58);
            this.LabelOptions.TabIndex = 4;
            this.LabelOptions.Text = "Options";
            this.LabelOptions.Click += new System.EventHandler(this.LabelOptions_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAbout.Location = new System.Drawing.Point(23, 859);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(109, 58);
            this.LabelAbout.TabIndex = 5;
            this.LabelAbout.Text = "About";
            this.LabelAbout.Click += new System.EventHandler(this.LabelAbout_Click);
            // 
            // LabelQuit
            // 
            this.LabelQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelQuit.AutoSize = true;
            this.LabelQuit.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelQuit.Location = new System.Drawing.Point(23, 1013);
            this.LabelQuit.Name = "LabelQuit";
            this.LabelQuit.Size = new System.Drawing.Size(83, 58);
            this.LabelQuit.TabIndex = 6;
            this.LabelQuit.Text = "Quit";
            this.LabelQuit.Click += new System.EventHandler(this.LabelQuit_Click);
            // 
            // LabelRTMainMenu
            // 
            this.LabelRTMainMenu.AutoSize = true;
            this.LabelRTMainMenu.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRTMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelRTMainMenu.Location = new System.Drawing.Point(23, 27);
            this.LabelRTMainMenu.Name = "LabelRTMainMenu";
            this.LabelRTMainMenu.Size = new System.Drawing.Size(338, 58);
            this.LabelRTMainMenu.TabIndex = 8;
            this.LabelRTMainMenu.Text = "Return to Main Menu";
            this.LabelRTMainMenu.Visible = false;
            this.LabelRTMainMenu.Click += new System.EventHandler(this.LabelRTMainMenu_Click);
            // 
            // LabelPlayerName
            // 
            this.LabelPlayerName.AutoSize = true;
            this.LabelPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelPlayerName.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPlayerName.Location = new System.Drawing.Point(763, 619);
            this.LabelPlayerName.Name = "LabelPlayerName";
            this.LabelPlayerName.Size = new System.Drawing.Size(71, 35);
            this.LabelPlayerName.TabIndex = 10;
            this.LabelPlayerName.Text = "Name:";
            this.LabelPlayerName.Visible = false;
            // 
            // TBoxName
            // 
            this.TBoxName.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxName.Location = new System.Drawing.Point(840, 626);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(215, 27);
            this.TBoxName.TabIndex = 11;
            this.TBoxName.Visible = false;
            // 
            // LabelPlay
            // 
            this.LabelPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlay.AutoSize = true;
            this.LabelPlay.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPlay.Location = new System.Drawing.Point(20, 657);
            this.LabelPlay.Name = "LabelPlay";
            this.LabelPlay.Size = new System.Drawing.Size(111, 77);
            this.LabelPlay.TabIndex = 12;
            this.LabelPlay.Text = "Play";
            this.LabelPlay.Click += new System.EventHandler(this.LabelPlay_Click);
            // 
            // SelectImageDialog
            // 
            this.SelectImageDialog.FileName = "Select Player Avatar";
            // 
            // LabelCloseInput
            // 
            this.LabelCloseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCloseInput.AutoSize = true;
            this.LabelCloseInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCloseInput.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCloseInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCloseInput.Location = new System.Drawing.Point(1094, 290);
            this.LabelCloseInput.Name = "LabelCloseInput";
            this.LabelCloseInput.Size = new System.Drawing.Size(33, 45);
            this.LabelCloseInput.TabIndex = 14;
            this.LabelCloseInput.Text = "X";
            this.LabelCloseInput.Visible = false;
            this.LabelCloseInput.Click += new System.EventHandler(this.LabelCloseInput_Click);
            // 
            // LabelBestPlayerName
            // 
            this.LabelBestPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelBestPlayerName.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBestPlayerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelBestPlayerName.Location = new System.Drawing.Point(840, 666);
            this.LabelBestPlayerName.Name = "LabelBestPlayerName";
            this.LabelBestPlayerName.Size = new System.Drawing.Size(219, 35);
            this.LabelBestPlayerName.TabIndex = 16;
            this.LabelBestPlayerName.Text = "Player";
            this.LabelBestPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelBestPlayerName.Visible = false;
            // 
            // LabelHighscoreHolder
            // 
            this.LabelHighscoreHolder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelHighscoreHolder.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHighscoreHolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelHighscoreHolder.Location = new System.Drawing.Point(863, 321);
            this.LabelHighscoreHolder.Name = "LabelHighscoreHolder";
            this.LabelHighscoreHolder.Size = new System.Drawing.Size(174, 35);
            this.LabelHighscoreHolder.TabIndex = 19;
            this.LabelHighscoreHolder.Text = "Highscore Holder";
            this.LabelHighscoreHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelHighscoreHolder.Visible = false;
            // 
            // LabelClickToSelect
            // 
            this.LabelClickToSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelClickToSelect.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClickToSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelClickToSelect.Location = new System.Drawing.Point(842, 290);
            this.LabelClickToSelect.Name = "LabelClickToSelect";
            this.LabelClickToSelect.Size = new System.Drawing.Size(208, 20);
            this.LabelClickToSelect.TabIndex = 21;
            this.LabelClickToSelect.Text = "Click on the image to select your avatar";
            this.LabelClickToSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelClickToSelect.Visible = false;
            // 
            // MusicTimer
            // 
            this.MusicTimer.Enabled = true;
            this.MusicTimer.Interval = 20;
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // PBoxBestPlayerAvatar
            // 
            this.PBoxBestPlayerAvatar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBoxBestPlayerAvatar.Location = new System.Drawing.Point(841, 359);
            this.PBoxBestPlayerAvatar.Name = "PBoxBestPlayerAvatar";
            this.PBoxBestPlayerAvatar.Size = new System.Drawing.Size(218, 288);
            this.PBoxBestPlayerAvatar.TabIndex = 17;
            this.PBoxBestPlayerAvatar.TabStop = false;
            this.PBoxBestPlayerAvatar.Visible = false;
            // 
            // PBoxSelectPlayerImage
            // 
            this.PBoxSelectPlayerImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBoxSelectPlayerImage.Image = global::Trenches_of_Gallipoli.Properties.Resources.MehmetEsatBulkat;
            this.PBoxSelectPlayerImage.Location = new System.Drawing.Point(837, 309);
            this.PBoxSelectPlayerImage.Name = "PBoxSelectPlayerImage";
            this.PBoxSelectPlayerImage.Size = new System.Drawing.Size(218, 288);
            this.PBoxSelectPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxSelectPlayerImage.TabIndex = 9;
            this.PBoxSelectPlayerImage.TabStop = false;
            this.PBoxSelectPlayerImage.Visible = false;
            this.PBoxSelectPlayerImage.Click += new System.EventHandler(this.PBoxSelectPlayerImage_Click);
            // 
            // PBoxInputBG
            // 
            this.PBoxInputBG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PBoxInputBG.Location = new System.Drawing.Point(741, 275);
            this.PBoxInputBG.Name = "PBoxInputBG";
            this.PBoxInputBG.Size = new System.Drawing.Size(401, 476);
            this.PBoxInputBG.TabIndex = 13;
            this.PBoxInputBG.TabStop = false;
            this.PBoxInputBG.Visible = false;
            // 
            // PBoxHighscoreBG
            // 
            this.PBoxHighscoreBG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PBoxHighscoreBG.Location = new System.Drawing.Point(825, 309);
            this.PBoxHighscoreBG.Name = "PBoxHighscoreBG";
            this.PBoxHighscoreBG.Size = new System.Drawing.Size(250, 410);
            this.PBoxHighscoreBG.TabIndex = 18;
            this.PBoxHighscoreBG.TabStop = false;
            this.PBoxHighscoreBG.Visible = false;
            // 
            // PBoxMainMenuBG
            // 
            this.PBoxMainMenuBG.Image = global::Trenches_of_Gallipoli.Properties.Resources.MainMenuBgLast;
            this.PBoxMainMenuBG.InitialImage = global::Trenches_of_Gallipoli.Properties.Resources.MainMenuBgLast;
            this.PBoxMainMenuBG.Location = new System.Drawing.Point(0, 0);
            this.PBoxMainMenuBG.Name = "PBoxMainMenuBG";
            this.PBoxMainMenuBG.Size = new System.Drawing.Size(1920, 1080);
            this.PBoxMainMenuBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxMainMenuBG.TabIndex = 20;
            this.PBoxMainMenuBG.TabStop = false;
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelVolume.Location = new System.Drawing.Point(728, 531);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(100, 25);
            this.LabelVolume.TabIndex = 23;
            this.LabelVolume.Text = "Volume : 30%";
            this.LabelVolume.Visible = false;
            // 
            // LabelAbouts
            // 
            this.LabelAbouts.BackColor = System.Drawing.Color.Black;
            this.LabelAbouts.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbouts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelAbouts.Location = new System.Drawing.Point(816, 284);
            this.LabelAbouts.Name = "LabelAbouts";
            this.LabelAbouts.Size = new System.Drawing.Size(259, 450);
            this.LabelAbouts.TabIndex = 24;
            this.LabelAbouts.Text = "Created By:\r\n\r\n\r\n\r\n\r\n\r\nThanks to\r\nAll the Redditors \r\nand\r\nPeople from Discord\r\nW" +
    "ho helped me \r\nTroubleshoot ";
            this.LabelAbouts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAbouts.Visible = false;
            // 
            // LabelMyName
            // 
            this.LabelMyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelMyName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelMyName.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMyName.ForeColor = System.Drawing.Color.Gold;
            this.LabelMyName.Location = new System.Drawing.Point(825, 359);
            this.LabelMyName.Name = "LabelMyName";
            this.LabelMyName.Size = new System.Drawing.Size(234, 54);
            this.LabelMyName.TabIndex = 25;
            this.LabelMyName.Text = "M. Eren Bal";
            this.LabelMyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMyName.Visible = false;
            // 
            // LabelGithub
            // 
            this.LabelGithub.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGithub.LinkColor = System.Drawing.Color.Yellow;
            this.LabelGithub.Location = new System.Drawing.Point(825, 413);
            this.LabelGithub.Name = "LabelGithub";
            this.LabelGithub.Size = new System.Drawing.Size(234, 77);
            this.LabelGithub.TabIndex = 26;
            this.LabelGithub.TabStop = true;
            this.LabelGithub.Text = "Github";
            this.LabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGithub.Visible = false;
            this.LabelGithub.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.LabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelGithub_LinkClicked);
            // 
            // LabelVolume2
            // 
            this.LabelVolume2.AutoSize = true;
            this.LabelVolume2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolume2.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelVolume2.Location = new System.Drawing.Point(736, 657);
            this.LabelVolume2.Name = "LabelVolume2";
            this.LabelVolume2.Size = new System.Drawing.Size(100, 25);
            this.LabelVolume2.TabIndex = 28;
            this.LabelVolume2.Text = "Volume : 30%";
            this.LabelVolume2.Visible = false;
            // 
            // LabelMainMenuVolume
            // 
            this.LabelMainMenuVolume.AutoSize = true;
            this.LabelMainMenuVolume.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMainMenuVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelMainMenuVolume.Location = new System.Drawing.Point(701, 499);
            this.LabelMainMenuVolume.Name = "LabelMainMenuVolume";
            this.LabelMainMenuVolume.Size = new System.Drawing.Size(127, 25);
            this.LabelMainMenuVolume.TabIndex = 29;
            this.LabelMainMenuVolume.Text = "Main Menu Volume:";
            this.LabelMainMenuVolume.Visible = false;
            // 
            // LabelIngameVolume
            // 
            this.LabelIngameVolume.AutoSize = true;
            this.LabelIngameVolume.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngameVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelIngameVolume.Location = new System.Drawing.Point(701, 622);
            this.LabelIngameVolume.Name = "LabelIngameVolume";
            this.LabelIngameVolume.Size = new System.Drawing.Size(112, 25);
            this.LabelIngameVolume.TabIndex = 30;
            this.LabelIngameVolume.Text = "In Game Volume:";
            this.LabelIngameVolume.Visible = false;
            // 
            // LabelSkip
            // 
            this.LabelSkip.AutoSize = true;
            this.LabelSkip.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSkip.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSkip.Location = new System.Drawing.Point(1538, 893);
            this.LabelSkip.Name = "LabelSkip";
            this.LabelSkip.Size = new System.Drawing.Size(62, 39);
            this.LabelSkip.TabIndex = 32;
            this.LabelSkip.Text = "Skip";
            this.LabelSkip.Visible = false;
            this.LabelSkip.Click += new System.EventHandler(this.LabelSkip_Click);
            // 
            // axIntro
            // 
            this.axIntro.Enabled = true;
            this.axIntro.Location = new System.Drawing.Point(320, 180);
            this.axIntro.Name = "axIntro";
            this.axIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIntro.OcxState")));
            this.axIntro.Size = new System.Drawing.Size(1280, 720);
            this.axIntro.TabIndex = 31;
            this.axIntro.Visible = false;
            // 
            // volumeControl2
            // 
            this.volumeControl2.BackColor = System.Drawing.Color.Black;
            this.volumeControl2.Bar_color = System.Drawing.Color.GreenYellow;
            this.volumeControl2.Location = new System.Drawing.Point(720, 690);
            this.volumeControl2.Max = 100;
            this.volumeControl2.Min = 0;
            this.volumeControl2.Name = "volumeControl2";
            this.volumeControl2.Size = new System.Drawing.Size(434, 29);
            this.volumeControl2.TabIndex = 27;
            this.volumeControl2.Value = 40;
            this.volumeControl2.Visible = false;
            // 
            // volumeControl1
            // 
            this.volumeControl1.BackColor = System.Drawing.Color.Black;
            this.volumeControl1.Bar_color = System.Drawing.Color.GreenYellow;
            this.volumeControl1.Location = new System.Drawing.Point(720, 568);
            this.volumeControl1.Max = 100;
            this.volumeControl1.Min = 0;
            this.volumeControl1.Name = "volumeControl1";
            this.volumeControl1.Size = new System.Drawing.Size(434, 29);
            this.volumeControl1.TabIndex = 22;
            this.volumeControl1.Value = 40;
            this.volumeControl1.Visible = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.LabelSkip);
            this.Controls.Add(this.axIntro);
            this.Controls.Add(this.LabelIngameVolume);
            this.Controls.Add(this.LabelMainMenuVolume);
            this.Controls.Add(this.LabelVolume2);
            this.Controls.Add(this.volumeControl2);
            this.Controls.Add(this.LabelGithub);
            this.Controls.Add(this.LabelMyName);
            this.Controls.Add(this.LabelAbouts);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.volumeControl1);
            this.Controls.Add(this.LabelClickToSelect);
            this.Controls.Add(this.LabelHighscoreHolder);
            this.Controls.Add(this.PBoxBestPlayerAvatar);
            this.Controls.Add(this.LabelBestPlayerName);
            this.Controls.Add(this.LabelCloseInput);
            this.Controls.Add(this.LabelPlay);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.LabelPlayerName);
            this.Controls.Add(this.PBoxSelectPlayerImage);
            this.Controls.Add(this.LabelRTMainMenu);
            this.Controls.Add(this.LabelQuit);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.LabelOptions);
            this.Controls.Add(this.LabelHighscores);
            this.Controls.Add(this.LabelStartGame);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.PBoxInputBG);
            this.Controls.Add(this.PBoxHighscoreBG);
            this.Controls.Add(this.PBoxMainMenuBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trenches Of Gallipoli";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBestPlayerAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSelectPlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxInputBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxHighscoreBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMainMenuBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIntro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelStartGame;
        private System.Windows.Forms.Label LabelHighscores;
        private System.Windows.Forms.Label LabelOptions;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Label LabelQuit;
        private System.Windows.Forms.Label LabelRTMainMenu;
        private System.Windows.Forms.PictureBox PBoxSelectPlayerImage;
        private System.Windows.Forms.Label LabelPlayerName;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label LabelPlay;
        private System.Windows.Forms.OpenFileDialog SelectImageDialog;
        private System.Windows.Forms.PictureBox PBoxInputBG;
        private System.Windows.Forms.Label LabelCloseInput;
        private System.Windows.Forms.Label LabelBestPlayerName;
        private System.Windows.Forms.PictureBox PBoxBestPlayerAvatar;
        private System.Windows.Forms.PictureBox PBoxHighscoreBG;
        private System.Windows.Forms.Label LabelHighscoreHolder;
        private System.Windows.Forms.PictureBox PBoxMainMenuBG;
        private System.Windows.Forms.Label LabelClickToSelect;
        private System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.Label LabelAbouts;
        private System.Windows.Forms.Label LabelMyName;
        private System.Windows.Forms.LinkLabel LabelGithub;
        public Files.Forms.VolumeControl volumeControl1;
        public Files.Forms.VolumeControl volumeControl2;
        private System.Windows.Forms.Label LabelVolume2;
        private System.Windows.Forms.Label LabelMainMenuVolume;
        private System.Windows.Forms.Label LabelIngameVolume;
        private AxWMPLib.AxWindowsMediaPlayer axIntro;
        private System.Windows.Forms.Label LabelSkip;
    }
}