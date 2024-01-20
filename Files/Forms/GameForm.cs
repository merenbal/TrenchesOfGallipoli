using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Media;
using WMPLib;


namespace Trenches_of_Gallipoli
{
    public partial class GameForm : Form
    {
        Random RandomNumber = new Random();
        public static int isMainMenuShown;
        string LanguageChoice;
        int vvolume;       
        WindowsMediaPlayer BGMusic;
        SoundPlayer Whistle = new SoundPlayer("Sounds\\TrenchWhistle.wav");
        



        public GameForm(string playerName,Image playerAvatar, string lang, int volumeValue)
        {
            
            InitializeComponent();
            PBoxPlayer.Image = playerAvatar;
            LabelPlayerName.Text = playerName;
            LanguageChoice = lang;
            GameStart();
            vvolume = volumeValue;

            
            
            
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            PBoxBackGround.SendToBack();
            
                if (LanguageChoice == "ENG")
                {
                    CommandPointsLabel.Text = "Command Points: " + GameManager.CommandPoints;

                    WaveLabel.Text = "Wave: " + GameManager.Wave + " Clear";
                    NextWaveLabel.Text = " " + GameManager.PrepDuration + " Seconds to Next Wave";
                }
                else if (LanguageChoice == "TR")
                {
                    CommandPointsLabel.Text = "Komuta Puanları: " + GameManager.CommandPoints;

                    WaveLabel.Text = "Wave: " + GameManager.Wave + " Temizlendi";
                    NextWaveLabel.Text = "Sıradaki Dalgaya " + GameManager.PrepDuration + " Saniye";
                }

            

            if (EnemyList.Count == 0)
            {
                if (WaveTimer.Enabled==false)
                {
                    GameManager.CommandPoints += EnemyStats.MaxEnemy;
                }
                
                WaveLabel.Show();
                NextWaveLabel.Show();
                WaveTimer.Start();

                GameManager.Line1 = 0;
                GameManager.Line2 = 0;
                GameManager.Line3 = 0;
                GameManager.Line4 = 0;
                GameManager.Line5 = 0;
                GameManager.Line6 = 0;
                GameManager.Line7 = 0;
                GameManager.Line8 = 0;
                GameManager.Line9 = 0;
                GameManager.Line10 = 0;
                GameManager.Line11 = 0;
                GameManager.Line12 = 0;
                GameManager.Line13 = 0;
                GameManager.Line14 = 0;
                GameManager.Line15 = 0;
                GameManager.Line16 = 0;
                GameManager.Line17 = 0;

                
                if (NextWaveLabel.Text == " 0 Seconds to Next Wave" || NextWaveLabel.Text == "Sıradaki Dalgaya 0 Saniye")
                {
                    WaveLabel.Hide();
                    NextWaveLabel.Hide();
                    GameManager.Wave++;
                    
                    WaveTimer.Stop();
                    GameManager.PrepDuration = 5;
                    EnemyStats.MaxEnemy += GameManager.EnemyIncreaseRate;
                    Whistle.Play();
                    for (int i = 0; i < EnemyStats.MaxEnemy; i++)
                    {
                        MakeEnemy();
                    }
                }
                

            }

           foreach(Control Bullet in this.Controls)
            {
                if (Bullet is PictureBox && (string)Bullet.Tag == "SoldiersBullet")
                Bullet.Top -= BulletSpeed;
            }

            var controlsToRemove = new List<Control>();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy")
                {

                    if (isGameOver == true)
                    {
                        controlsToRemove.Add(x);
                    }

                    
                    if (GameManager.BarbedWireLevel == "0")
                    {
                        x.Top += EnemyStats.EnemySpeed;
                    }
                    if (GameManager.BarbedWireLevel == "1")
                    {
                        if (x.Location.Y < 183)
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastbarbed)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastbarbed;
                            }                          
                            x.Top += EnemyStats.EnemySpeed - 1;
                        } else
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastdirt)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastdirt;
                            }                            
                            x.Top += EnemyStats.EnemySpeed;
                        }
                                             
                    }

                    if (GameManager.BarbedWireLevel == "2")
                    {
                        if (x.Location.Y < 183*2)
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastbarbed)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastbarbed;
                            }
                            x.Top += EnemyStats.EnemySpeed - 1;
                        }
                        else
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastdirt)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastdirt;
                            }
                            x.Top += EnemyStats.EnemySpeed;
                        }

                    }
                    if (GameManager.BarbedWireLevel == "3")
                    {
                        if (x.Location.Y < 183*3)
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastbarbed)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastbarbed;
                            }
                            x.Top += EnemyStats.EnemySpeed - 1;
                        }
                        else
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastdirt)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastdirt;
                            }
                            x.Top += EnemyStats.EnemySpeed;
                        }

                    }
                    if (GameManager.BarbedWireLevel == "4")
                    {
                        if (x.Location.Y < 183*4)
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastbarbed)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastbarbed;
                            }
                            x.Top += EnemyStats.EnemySpeed - 1;
                        }
                        else
                        {
                            if (((PictureBox)x).Image != Properties.Resources.EnemyLastdirt)
                            {
                                ((PictureBox)x).Image = Properties.Resources.EnemyLastdirt;
                            }
                            x.Top += EnemyStats.EnemySpeed;
                        }

                    }
                    if (GameManager.BarbedWireLevel == "5")
                    {
                        if (((PictureBox)x).Image != Properties.Resources.EnemyLastbarbed)
                        {
                            ((PictureBox)x).Image = Properties.Resources.EnemyLastbarbed;
                        }
                        
                        x.Top += EnemyStats.EnemySpeed - 1;
                    }





                    if (x.Location.Y > 1070)
                    {
                        if (!controlsToRemove.Contains(x))
                        {
                            controlsToRemove.Add(x);                            
                            GameOver();
                        }

                    }

                    
                        x.Click += new EventHandler(Kill);
                    
                    

                    foreach (Control j in this.Controls)
                    {


                        if (j is PictureBox && (string)j.Tag == "SoldiersBullet")
                        {
                            
                            
                            if (j.Top < SoldierStats.BulletQuality)
                            {
                                if (!controlsToRemove.Contains(j))
                                {
                                    controlsToRemove.Add(j);
                                }                               
                            }

                            if (j.Bounds.IntersectsWith(x.Bounds) && j.Visible == true)
                            {

                                if (!controlsToRemove.Contains(x))
                                {
                                    controlsToRemove.Add(x);
                                }

                                if (!controlsToRemove.Contains(j))
                                {
                                    controlsToRemove.Add(j);
                                }
                            }
                        }
                    }
                }              
            }

            foreach (Control a in controlsToRemove)
            {
                this.Controls.Remove(a);
                EnemyList.Remove((PictureBox)a);
            }

            
        }


        // SOLDIER SHOOT //////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<PictureBox> BulletList = new List<PictureBox>();

        int BulletSpeed = 10;
        public void Soldier1Shoot()
        {
           
            for (int i = 0; i < SoldierStats.SoldierMaxBullet;  i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier1.Left + (Soldier1.Width / 2);
                Bullet.Top = Soldier1.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);                
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier2Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier2.Left + (Soldier2.Width / 2);
                Bullet.Top = Soldier2.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier3Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier3.Left + (Soldier3.Width / 2);
                Bullet.Top = Soldier3.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier4Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier4.Left + (Soldier4.Width / 2);
                Bullet.Top = Soldier4.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier5Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier5.Left + (Soldier5.Width / 2);
                Bullet.Top = Soldier5.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier6Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier6.Left + (Soldier6.Width / 2);
                Bullet.Top = Soldier6.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier7Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier7.Left + (Soldier7.Width / 2);
                Bullet.Top = Soldier7.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier8Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier8.Left + (Soldier8.Width / 2);
                Bullet.Top = Soldier8.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier9Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier9.Left + (Soldier9.Width / 2);
                Bullet.Top = Soldier9.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier10Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier10.Left + (Soldier10.Width / 2);
                Bullet.Top = Soldier10.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier11Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier11.Left + (Soldier11.Width / 2);
                Bullet.Top = Soldier11.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier12Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier12.Left + (Soldier12.Width / 2);
                Bullet.Top = Soldier12.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier13Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier13.Left + (Soldier13.Width / 2);
                Bullet.Top = Soldier13.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier14Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier14.Left + (Soldier14.Width / 2);
                Bullet.Top = Soldier14.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier15Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier15.Left + (Soldier15.Width / 2);
                Bullet.Top = Soldier15.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier16Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier16.Left + (Soldier16.Width / 2);
                Bullet.Top = Soldier16.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }
        public void Soldier17Shoot()
        {
            for (int i = 0; i < SoldierStats.SoldierMaxBullet; i++)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Left = Soldier17.Left + (Soldier17.Width / 2);
                Bullet.Top = Soldier17.Top;
                Bullet.BackColor = Color.Yellow;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "SoldiersBullet";
                Bullet.BringToFront();
                Controls.Add(Bullet);
            }
        }

        private void Soldier1CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier1.Visible == true)
                {                    
                    if (x.Location.X == Soldier1.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier1Shoot();
                    }
                }
            }    
        }
        private void Soldier2CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier2.Visible == true)
                {
                    if (x.Location.X == Soldier2.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier2Shoot();
                    }
                }
            }
        }
        private void Soldier3CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier3.Visible == true)
                {
                    if (x.Location.X == Soldier3.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier3Shoot();
                    }
                }
            };
        }
        private void Soldier4CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier4.Visible == true)
                {
                    if (x.Location.X == Soldier4.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier4Shoot();
                    }
                }
            };
        }
        private void Soldier5CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier5.Visible == true)
                {
                    if (x.Location.X == Soldier5.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier5Shoot();
                    }
                }
            }
        }
        private void Soldier6CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier6.Visible == true)
                {
                    if (x.Location.X == Soldier6.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier6Shoot();
                    }
                }
            }
        }
        private void Soldier7CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier7.Visible == true)
                {
                    if (x.Location.X == Soldier7.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier7Shoot();
                    }
                }
            }
        }
        private void Soldier8CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier8.Visible == true)
                {
                    if (x.Location.X == Soldier8.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier8Shoot();
                    }
                }
            }
        }
        private void Soldier9CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier9.Visible == true)
                {
                    if (x.Location.X == Soldier9.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier9Shoot();
                    }
                }
            }
        }
        private void Soldier10CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier10.Visible == true)
                {
                    if (x.Location.X == Soldier10.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier10Shoot();
                    }
                }
            }
        }
        private void Soldier11CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier11.Visible == true)
                {
                    if (x.Location.X == Soldier11.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier11Shoot();
                    }
                }
            }
        }
        private void Soldier12CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier12.Visible == true)
                {
                    if (x.Location.X == Soldier12.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier12Shoot();
                    }
                }
            }
        }
        private void Soldier13CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier13.Visible == true)
                {
                    if (x.Location.X == Soldier13.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier13Shoot();
                    }
                }
            }
        }
        private void Soldier14CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier14.Visible == true)
                {
                    if (x.Location.X == Soldier14.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier14Shoot();
                    }
                }
            }
        }
        private void Soldier15CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier15.Visible == true)
                {
                    if (x.Location.X == Soldier15.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier15Shoot();
                    }
                }
            }
        }
        private void Soldier16CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier16.Visible == true)
                {
                    if (x.Location.X == Soldier16.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier16Shoot();
                    }
                }
            }
        }
        private void Soldier17CooldownTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy" && Soldier17.Visible == true)
                {
                    if (x.Location.X == Soldier17.Location.X && x.Location.Y > SoldierStats.BulletQuality)
                    {
                        Soldier17Shoot();
                    }
                }
            }
        }



        // MARKET & UPGRADES //////////////////////////////////////////////////////////////////////////////////////////////////

        private void Soldier1Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier1.Show();
                //Soldier1HealthBar.Show();
                //Soldier1HealButton.Show();
                Soldier1LevelLabel.Show();
                Soldier1UpgradeButton.Show();
                Soldier1Button.Hide();
            }
        }

        private void Soldier2Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier2.Show();
                //Soldier2HealthBar.Show();
                //Soldier2HealButton.Show();
                Soldier2LevelLabel.Show();
                Soldier2UpgradeButton.Show();
                Soldier2Button.Hide();
            }
        }

        private void Soldier3Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier3.Show();
                //Soldier3HealthBar.Show();
                //Soldier3HealButton.Show();
                Soldier3LevelLabel.Show();
                Soldier3UpgradeButton.Show();
                Soldier3Button.Hide();
            }
        }

        private void Soldier4Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier4.Show();
                //Soldier4HealthBar.Show();
                //Soldier4HealButton.Show();
                Soldier4LevelLabel.Show();
                Soldier4UpgradeButton.Show();
                Soldier4Button.Hide();
            }
        }

        private void Soldier5Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier5.Show();
                //Soldier5HealthBar.Show();
                //Soldier5HealButton.Show();
                Soldier5LevelLabel.Show();
                Soldier5UpgradeButton.Show();
                Soldier5Button.Hide();
            }
        }

        private void Soldier6Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier6.Show();
                //Soldier6HealthBar.Show();
                //Soldier6HealButton.Show();
                Soldier6LevelLabel.Show();
                Soldier6UpgradeButton.Show();
                Soldier6Button.Hide();
            }
        }

        private void Soldier7Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier7.Show();
                //Soldier7HealthBar.Show();
                //Soldier7HealButton.Show();
                Soldier7LevelLabel.Show();
                Soldier7UpgradeButton.Show();
                Soldier7Button.Hide();
            }
        }

        private void Soldier8Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier8.Show();
                //Soldier8HealthBar.Show();
                //Soldier8HealButton.Show();
                Soldier8LevelLabel.Show();
                Soldier8UpgradeButton.Show();
                Soldier8Button.Hide();
            }
        }

        private void Soldier9Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier9.Show();
                //Soldier9HealthBar.Show();
                //Soldier9HealButton.Show();
                Soldier9LevelLabel.Show();
                Soldier9UpgradeButton.Show();
                Soldier9Button.Hide();
            }
        }

        private void Soldier10Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier10.Show();
                //Soldier10HealthBar.Show();
                //Soldier10HealButton.Show();
                Soldier10LevelLabel.Show();
                Soldier10UpgradeButton.Show();
                Soldier10Button.Hide();
            }
        }

        private void Soldier11Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier11.Show();
                //Soldier11HealthBar.Show();
                //Soldier11HealButton.Show();
                Soldier11LevelLabel.Show();
                Soldier11UpgradeButton.Show();
                Soldier11Button.Hide();
            }
        }

        private void Soldier12Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier12.Show();
                //Soldier12HealthBar.Show();
                //Soldier12HealButton.Show();
                Soldier12LevelLabel.Show();
                Soldier12UpgradeButton.Show();
                Soldier12Button.Hide();
            }
        }

        private void Soldier13Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier13.Show();
                //Soldier13HealthBar.Show();
                //Soldier13HealButton.Show();
                Soldier13LevelLabel.Show();
                Soldier13UpgradeButton.Show();
                Soldier13Button.Hide();
            }
        }

        private void Soldier14Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier14.Show();
                //Soldier14HealthBar.Show();
                //Soldier14HealButton.Show();
                Soldier14LevelLabel.Show();
                Soldier14UpgradeButton.Show();
                Soldier14Button.Hide();
            }
        }

        private void Soldier15Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier15.Show();
                //Soldier15HealthBar.Show();
                //Soldier15HealButton.Show();
                Soldier15LevelLabel.Show();
                Soldier15UpgradeButton.Show();
                Soldier15Button.Hide();
            }
        }

        private void Soldier16Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier16.Show();
                //Soldier16HealthBar.Show();
                //Soldier16HealButton.Show();
                Soldier16LevelLabel.Show();
                Soldier16UpgradeButton.Show();
                Soldier16Button.Hide();
            }
        }

        private void Soldier17Button_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuySoldierPrice)
            {
                GameManager.CommandPoints -= GameManager.BuySoldierPrice;
                Soldier17.Show();
                //Soldier17HealthBar.Show();
                //Soldier17HealButton.Show();
                Soldier17LevelLabel.Show();
                Soldier17UpgradeButton.Show();
                Soldier17Button.Hide();
            }
        }


       

        private void Soldier1UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier1LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier1.Image = Properties.Resources.Soldier1LEVELmax;
                    Soldier1CooldownTimer.Interval = 1000;
                    Soldier1LevelLabel.Text = "Level:MAX";
                    Soldier1UpgradeButton.Hide();
                }

                else if (Soldier1LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier1.Image = Properties.Resources.Soldier1LEVEL3;
                    Soldier1CooldownTimer.Interval = 1500;
                    Soldier1LevelLabel.Text = "Level: 3";
                    Soldier1UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";

                }

                else if (Soldier1LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier1.Image = Properties.Resources.Soldier1;
                    Soldier1CooldownTimer.Interval = 1750;
                    Soldier1LevelLabel.Text = "Level: 2";
                    Soldier1UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier1LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier1.Image = Properties.Resources.Soldier1LEVELmax;
                    Soldier1CooldownTimer.Interval = 1000;
                    Soldier1LevelLabel.Text = "Seviye:MAKS";
                    Soldier1UpgradeButton.Hide();
                    
                }

                else if (Soldier1LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier1.Image = Properties.Resources.Soldier1LEVEL3;
                    Soldier1CooldownTimer.Interval = 1500;
                    Soldier1LevelLabel.Text = "Seviye: 3";
                    Soldier1UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";

                }

                else if (Soldier1LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier1.Image = Properties.Resources.Soldier1;
                    Soldier1CooldownTimer.Interval = 1750;
                    Soldier1LevelLabel.Text = "Seviye: 2";
                    Soldier1UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";

                }
            }


            



        }

        private void Soldier2UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier2LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier2.Image = Properties.Resources.Soldier2LEVELmax;
                    Soldier2CooldownTimer.Interval = 1000;
                    Soldier2LevelLabel.Text = "Level:MAX";
                    Soldier2UpgradeButton.Hide();
                }

                else if (Soldier2LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier2.Image = Properties.Resources.Soldier2LEVEL3;
                    Soldier2CooldownTimer.Interval = 1500;
                    Soldier2LevelLabel.Text = "Level: 3";
                    Soldier2UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier2LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier2.Image = Properties.Resources.Soldier2;
                    Soldier2CooldownTimer.Interval = 1750;
                    Soldier2LevelLabel.Text = "Level: 2";
                    Soldier2UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier2LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier2.Image = Properties.Resources.Soldier2LEVELmax;
                    Soldier2CooldownTimer.Interval = 1000;
                    Soldier2LevelLabel.Text = "Seviye:MAKS";
                    Soldier2UpgradeButton.Hide();
                }

                else if (Soldier2LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier2.Image = Properties.Resources.Soldier2LEVEL3;
                    Soldier2CooldownTimer.Interval = 1500;
                    Soldier2LevelLabel.Text = "Seviye: 3";
                    Soldier2UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier2LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier2.Image = Properties.Resources.Soldier2;
                    Soldier2CooldownTimer.Interval = 1750;
                    Soldier2LevelLabel.Text = "Seviye: 2";
                    Soldier2UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier3UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier3LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier3.Image = Properties.Resources.Soldier3LEVELmax;
                    Soldier3CooldownTimer.Interval = 1000;
                    Soldier3LevelLabel.Text = "Level:MAX";
                    Soldier3UpgradeButton.Hide();
                }

                else if (Soldier3LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier3.Image = Properties.Resources.Soldier3LEVEL3;
                    Soldier3CooldownTimer.Interval = 1500;
                    Soldier3LevelLabel.Text = "Level: 3";
                    Soldier3UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier3LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier3.Image = Properties.Resources.Soldier3;
                    Soldier3CooldownTimer.Interval = 1750;
                    Soldier3LevelLabel.Text = "Level: 2";
                    Soldier3UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier3LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier3.Image = Properties.Resources.Soldier3LEVELmax;
                    Soldier3CooldownTimer.Interval = 1000;
                    Soldier3LevelLabel.Text = "Seviye:MAKS";
                    Soldier3UpgradeButton.Hide();
                }

                else if (Soldier3LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier3.Image = Properties.Resources.Soldier3LEVEL3;
                    Soldier3CooldownTimer.Interval = 1500;
                    Soldier3LevelLabel.Text = "Seviye: 3";
                    Soldier3UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier3LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier3.Image = Properties.Resources.Soldier3;
                    Soldier3CooldownTimer.Interval = 1750;
                    Soldier3LevelLabel.Text = "Seviye: 2";
                    Soldier3UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier4UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier4LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier4.Image = Properties.Resources.Soldier4LEVELmax;
                    Soldier4CooldownTimer.Interval = 1000;
                    Soldier4LevelLabel.Text = "Level:MAX";
                    Soldier4UpgradeButton.Hide();
                }

                else if (Soldier4LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier4.Image = Properties.Resources.Soldier4LEVEL3;
                    Soldier4CooldownTimer.Interval = 1500;
                    Soldier4LevelLabel.Text = "Level: 3";
                    Soldier4UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier4LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier4.Image = Properties.Resources.Soldier4;
                    Soldier4CooldownTimer.Interval = 1750;
                    Soldier4LevelLabel.Text = "Level: 2";
                    Soldier4UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier4LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier4.Image = Properties.Resources.Soldier4LEVELmax;
                    Soldier4CooldownTimer.Interval = 1000;
                    Soldier4LevelLabel.Text = "Seviye:MAKS";
                    Soldier4UpgradeButton.Hide();
                }

                else if (Soldier4LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier4.Image = Properties.Resources.Soldier4LEVEL3;
                    Soldier4CooldownTimer.Interval = 1500;
                    Soldier4LevelLabel.Text = "Seviye: 3";
                    Soldier4UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier4LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier4.Image = Properties.Resources.Soldier4;
                    Soldier4CooldownTimer.Interval = 1750;
                    Soldier4LevelLabel.Text = "Seviye: 2";
                    Soldier4UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier5UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier5LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier5.Image = Properties.Resources.Soldier5LEVELmax;
                    Soldier5CooldownTimer.Interval = 1000;
                    Soldier5LevelLabel.Text = "Level:MAX";
                    Soldier5UpgradeButton.Hide();
                }

                else if (Soldier5LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier5.Image = Properties.Resources.Soldier5LEVEL3;
                    Soldier5CooldownTimer.Interval = 1500;
                    Soldier5LevelLabel.Text = "Level: 3";
                    Soldier5UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier5LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier5.Image = Properties.Resources.Soldier5;
                    Soldier5CooldownTimer.Interval = 1750;
                    Soldier5LevelLabel.Text = "Level: 2";
                    Soldier5UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier5LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier5.Image = Properties.Resources.Soldier5LEVELmax;
                    Soldier5CooldownTimer.Interval = 1000;
                    Soldier5LevelLabel.Text = "Seviye:MAKS";
                    Soldier5UpgradeButton.Hide();
                }

                else if (Soldier5LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier5.Image = Properties.Resources.Soldier5LEVEL3;
                    Soldier5CooldownTimer.Interval = 1500;
                    Soldier5LevelLabel.Text = "Seviye: 3";
                    Soldier5UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier5LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier5.Image = Properties.Resources.Soldier5;
                    Soldier5CooldownTimer.Interval = 1750;
                    Soldier5LevelLabel.Text = "Seviye: 2";
                    Soldier5UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier6UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier6LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier6.Image = Properties.Resources.Soldier6LEVELmax;
                    Soldier6CooldownTimer.Interval = 1000;
                    Soldier6LevelLabel.Text = "Level:MAX";
                    Soldier6UpgradeButton.Hide();
                }

                else if (Soldier6LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier6.Image = Properties.Resources.Soldier6LEVEL3;
                    Soldier6CooldownTimer.Interval = 1500;
                    Soldier6LevelLabel.Text = "Level: 3";
                    Soldier6UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier6LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier6.Image = Properties.Resources.Soldier6;
                    Soldier6CooldownTimer.Interval = 1750;
                    Soldier6LevelLabel.Text = "Level: 2";
                    Soldier6UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier6LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier6.Image = Properties.Resources.Soldier6LEVELmax;
                    Soldier6CooldownTimer.Interval = 1000;
                    Soldier6LevelLabel.Text = "Seviye:MAKS";
                    Soldier6UpgradeButton.Hide();
                }

                else if (Soldier6LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier6.Image = Properties.Resources.Soldier6LEVEL3;
                    Soldier6CooldownTimer.Interval = 1500;
                    Soldier6LevelLabel.Text = "Seviye: 3";
                    Soldier6UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier6LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier6.Image = Properties.Resources.Soldier6;
                    Soldier6CooldownTimer.Interval = 1750;
                    Soldier6LevelLabel.Text = "Seviye: 2";
                    Soldier6UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier7UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier7LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier7.Image = Properties.Resources.Soldier7LEVELmax;
                    Soldier7CooldownTimer.Interval = 1000;
                    Soldier7LevelLabel.Text = "Level:MAX";
                    Soldier7UpgradeButton.Hide();
                }

                else if (Soldier7LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier7.Image = Properties.Resources.Soldier7LEVEL3;
                    Soldier7CooldownTimer.Interval = 1500;
                    Soldier7LevelLabel.Text = "Level: 3";
                    Soldier7UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier7LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier7.Image = Properties.Resources.Soldier7;
                    Soldier7CooldownTimer.Interval = 1750;
                    Soldier7LevelLabel.Text = "Level: 2";
                    Soldier7UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier7LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier7.Image = Properties.Resources.Soldier7LEVELmax;
                    Soldier7CooldownTimer.Interval = 1000;
                    Soldier7LevelLabel.Text = "Seviye:MAKS";
                    Soldier7UpgradeButton.Hide();
                }

                else if (Soldier7LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier7.Image = Properties.Resources.Soldier7LEVEL3;
                    Soldier7CooldownTimer.Interval = 1500;
                    Soldier7LevelLabel.Text = "Seviye: 3";
                    Soldier7UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier7LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier7.Image = Properties.Resources.Soldier7;
                    Soldier7CooldownTimer.Interval = 1750;
                    Soldier7LevelLabel.Text = "Seviye: 2";
                    Soldier7UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier8UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier8LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier8.Image = Properties.Resources.Soldier8LEVELmax;
                    Soldier8CooldownTimer.Interval = 1000;
                    Soldier8LevelLabel.Text = "Level:MAX";
                    Soldier8UpgradeButton.Hide();
                }

                else if (Soldier8LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier8.Image = Properties.Resources.Soldier8LEVEL3;
                    Soldier8CooldownTimer.Interval = 1500;
                    Soldier8LevelLabel.Text = "Level: 3";
                    Soldier8UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier8LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier8.Image = Properties.Resources.Soldier8;
                    Soldier8CooldownTimer.Interval = 1750;
                    Soldier8LevelLabel.Text = "Level: 2";
                    Soldier8UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier8LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier8.Image = Properties.Resources.Soldier8LEVELmax;
                    Soldier8CooldownTimer.Interval = 1000;
                    Soldier8LevelLabel.Text = "Seviye:MAKS";
                    Soldier8UpgradeButton.Hide();
                }

                else if (Soldier8LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier8.Image = Properties.Resources.Soldier8LEVEL3;
                    Soldier8CooldownTimer.Interval = 1500;
                    Soldier8LevelLabel.Text = "Seviye: 3";
                    Soldier8UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier8LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier8.Image = Properties.Resources.Soldier8;
                    Soldier8CooldownTimer.Interval = 1750;
                    Soldier8LevelLabel.Text = "Seviye: 2";
                    Soldier8UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier9UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier9LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier9.Image = Properties.Resources.Soldier9LEVELmax;
                    Soldier9CooldownTimer.Interval = 1000;
                    Soldier9LevelLabel.Text = "Level:MAX";
                    Soldier9UpgradeButton.Hide();
                }

                else if (Soldier9LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier9.Image = Properties.Resources.Soldier9LEVEL3;
                    Soldier9CooldownTimer.Interval = 1500;
                    Soldier9LevelLabel.Text = "Level: 3";
                    Soldier9UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier9LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier9.Image = Properties.Resources.Soldier9;
                    Soldier9CooldownTimer.Interval = 1750;
                    Soldier9LevelLabel.Text = "Level: 2";
                    Soldier9UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier9LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier9.Image = Properties.Resources.Soldier9LEVELmax;
                    Soldier9CooldownTimer.Interval = 1000;
                    Soldier9LevelLabel.Text = "Seviye:MAKS";
                    Soldier9UpgradeButton.Hide();
                }

                else if (Soldier9LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier9.Image = Properties.Resources.Soldier9LEVEL3;
                    Soldier9CooldownTimer.Interval = 1500;
                    Soldier9LevelLabel.Text = "Seviye: 3";
                    Soldier9UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier9LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier9.Image = Properties.Resources.Soldier9;
                    Soldier9CooldownTimer.Interval = 1750;
                    Soldier9LevelLabel.Text = "Seviye: 2";
                    Soldier9UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier10UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier10LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier10.Image = Properties.Resources.Soldier10LEVELmax;
                    Soldier10CooldownTimer.Interval = 1000;
                    Soldier10LevelLabel.Text = "Level:MAX";
                    Soldier10UpgradeButton.Hide();
                }

                else if (Soldier10LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier10.Image = Properties.Resources.Soldier10LEVEL3;
                    Soldier10CooldownTimer.Interval = 1500;
                    Soldier10LevelLabel.Text = "Level: 3";
                    Soldier10UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier10LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier10.Image = Properties.Resources.Soldier10;
                    Soldier10CooldownTimer.Interval = 1750;
                    Soldier10LevelLabel.Text = "Level: 2";
                    Soldier10UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier10LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier10.Image = Properties.Resources.Soldier10LEVELmax;
                    Soldier10CooldownTimer.Interval = 1000;
                    Soldier10LevelLabel.Text = "Seviye:MAKS";
                    Soldier10UpgradeButton.Hide();
                }

                else if (Soldier10LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier10.Image = Properties.Resources.Soldier10LEVEL3;
                    Soldier10CooldownTimer.Interval = 1500;
                    Soldier10LevelLabel.Text = "Seviye: 3";
                    Soldier10UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier10LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier10.Image = Properties.Resources.Soldier10;
                    Soldier10CooldownTimer.Interval = 1750;
                    Soldier10LevelLabel.Text = "Seviye: 2";
                    Soldier10UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier11UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier11LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier11.Image = Properties.Resources.Soldier11LEVELmax;
                    Soldier11CooldownTimer.Interval = 1000;
                    Soldier11LevelLabel.Text = "Level:MAX";
                    Soldier11UpgradeButton.Hide();
                }

                else if (Soldier11LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier11.Image = Properties.Resources.Soldier11LEVEL3;
                    Soldier11CooldownTimer.Interval = 1500;
                    Soldier11LevelLabel.Text = "Level: 3";
                    Soldier11UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier11LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier11.Image = Properties.Resources.Soldier11;
                    Soldier11CooldownTimer.Interval = 1750;
                    Soldier11LevelLabel.Text = "Level: 2";
                    Soldier11UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier11LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier11.Image = Properties.Resources.Soldier11LEVELmax;
                    Soldier11CooldownTimer.Interval = 1000;
                    Soldier11LevelLabel.Text = "Seviye:MAKS";
                    Soldier11UpgradeButton.Hide();
                }

                else if (Soldier11LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier11.Image = Properties.Resources.Soldier11LEVEL3;
                    Soldier11CooldownTimer.Interval = 1500;
                    Soldier11LevelLabel.Text = "Seviye: 3";
                    Soldier11UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier11LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier11.Image = Properties.Resources.Soldier11;
                    Soldier11CooldownTimer.Interval = 1750;
                    Soldier11LevelLabel.Text = "Seviye: 2";
                    Soldier11UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier12UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier12LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier12.Image = Properties.Resources.Soldier12LEVELmax;
                    Soldier12CooldownTimer.Interval = 1000;
                    Soldier12LevelLabel.Text = "Level:MAX";
                    Soldier12UpgradeButton.Hide();
                }

                else if (Soldier12LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier12.Image = Properties.Resources.Soldier12LEVEL3;
                    Soldier12CooldownTimer.Interval = 1500;
                    Soldier12LevelLabel.Text = "Level: 3";
                    Soldier12UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier12LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier12.Image = Properties.Resources.Soldier12;
                    Soldier12CooldownTimer.Interval = 1750;
                    Soldier12LevelLabel.Text = "Level: 2";
                    Soldier12UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier12LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier12.Image = Properties.Resources.Soldier12LEVELmax;
                    Soldier12CooldownTimer.Interval = 1000;
                    Soldier12LevelLabel.Text = "Seviye:MAKS";
                    Soldier12UpgradeButton.Hide();
                }

                else if (Soldier12LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier12.Image = Properties.Resources.Soldier12LEVEL3;
                    Soldier12CooldownTimer.Interval = 1500;
                    Soldier12LevelLabel.Text = "Seviye: 3";
                    Soldier12UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier12LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier12.Image = Properties.Resources.Soldier12;
                    Soldier12CooldownTimer.Interval = 1750;
                    Soldier12LevelLabel.Text = "Seviye: 2";
                    Soldier12UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier13UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier13LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier13.Image = Properties.Resources.Soldier13LEVELmax;
                    Soldier13CooldownTimer.Interval = 1000;
                    Soldier13LevelLabel.Text = "Level:MAX";
                    Soldier13UpgradeButton.Hide();
                }

                else if (Soldier13LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier13.Image = Properties.Resources.Soldier13LEVEL3;
                    Soldier13CooldownTimer.Interval = 1500;
                    Soldier13LevelLabel.Text = "Level: 3";
                    Soldier13UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier13LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier13.Image = Properties.Resources.Soldier13;
                    Soldier13CooldownTimer.Interval = 1750;
                    Soldier13LevelLabel.Text = "Level: 2";
                    Soldier13UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier13LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier13.Image = Properties.Resources.Soldier13LEVELmax;
                    Soldier13CooldownTimer.Interval = 1000;
                    Soldier13LevelLabel.Text = "Seviye:MAKS";
                    Soldier13UpgradeButton.Hide();
                }

                else if (Soldier13LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier13.Image = Properties.Resources.Soldier13LEVEL3;
                    Soldier13CooldownTimer.Interval = 1500;
                    Soldier13LevelLabel.Text = "Seviye: 3";
                    Soldier13UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier13LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier13.Image = Properties.Resources.Soldier13;
                    Soldier13CooldownTimer.Interval = 1750;
                    Soldier13LevelLabel.Text = "Seviye: 2";
                    Soldier13UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier14UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier14LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier14.Image = Properties.Resources.Soldier14LEVELmax;
                    Soldier14CooldownTimer.Interval = 1000;
                    Soldier14LevelLabel.Text = "Level:MAX";
                    Soldier14UpgradeButton.Hide();
                }

                else if (Soldier14LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier14.Image = Properties.Resources.Soldier14LEVEL3;
                    Soldier14CooldownTimer.Interval = 1500;
                    Soldier14LevelLabel.Text = "Level: 3";
                    Soldier14UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier14LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier14.Image = Properties.Resources.Soldier14;
                    Soldier14CooldownTimer.Interval = 1750;
                    Soldier14LevelLabel.Text = "Level: 2";
                    Soldier14UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier14LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier14.Image = Properties.Resources.Soldier14LEVELmax;
                    Soldier14CooldownTimer.Interval = 1000;
                    Soldier14LevelLabel.Text = "Seviye:MAKS";
                    Soldier14UpgradeButton.Hide();
                }

                else if (Soldier14LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier14.Image = Properties.Resources.Soldier14LEVEL3;
                    Soldier14CooldownTimer.Interval = 1500;
                    Soldier14LevelLabel.Text = "Seviye: 3";
                    Soldier14UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier14LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier14.Image = Properties.Resources.Soldier14;
                    Soldier14CooldownTimer.Interval = 1750;
                    Soldier14LevelLabel.Text = "Seviye: 2";
                    Soldier14UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier15UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier15LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier15.Image = Properties.Resources.Soldier15LEVELmax;
                    Soldier15CooldownTimer.Interval = 1000;
                    Soldier15LevelLabel.Text = "Level:MAX";
                    Soldier15UpgradeButton.Hide();
                }

                else if (Soldier15LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier15.Image = Properties.Resources.Soldier15LEVEL3;
                    Soldier15CooldownTimer.Interval = 1500;
                    Soldier15LevelLabel.Text = "Level: 3";
                    Soldier15UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier15LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier15.Image = Properties.Resources.Soldier15;
                    Soldier15CooldownTimer.Interval = 1750;
                    Soldier15LevelLabel.Text = "Level: 2";
                    Soldier15UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier15LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier15.Image = Properties.Resources.Soldier15LEVELmax;
                    Soldier15CooldownTimer.Interval = 1000;
                    Soldier15LevelLabel.Text = "Seviye:MAKS";
                    Soldier15UpgradeButton.Hide();
                }

                else if (Soldier15LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier15.Image = Properties.Resources.Soldier15LEVEL3;
                    Soldier15CooldownTimer.Interval = 1500;
                    Soldier15LevelLabel.Text = "Seviye: 3";
                    Soldier15UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier15LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier15.Image = Properties.Resources.Soldier15;
                    Soldier15CooldownTimer.Interval = 1750;
                    Soldier15LevelLabel.Text = "Seviye: 2";
                    Soldier15UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier16UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier16LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier16.Image = Properties.Resources.Soldier16LEVELmax;
                    Soldier16CooldownTimer.Interval = 1000;
                    Soldier16LevelLabel.Text = "Level:MAX";
                    Soldier16UpgradeButton.Hide();
                }

                else if (Soldier16LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier16.Image = Properties.Resources.Soldier16LEVEL3;
                    Soldier16CooldownTimer.Interval = 1500;
                    Soldier16LevelLabel.Text = "Level: 3";
                    Soldier16UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier16LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier16.Image = Properties.Resources.Soldier16;
                    Soldier16CooldownTimer.Interval = 1750;
                    Soldier16LevelLabel.Text = "Level: 2";
                    Soldier16UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier16LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier16.Image = Properties.Resources.Soldier16LEVELmax;
                    Soldier16CooldownTimer.Interval = 1000;
                    Soldier16LevelLabel.Text = "Seviye:MAKS";
                    Soldier16UpgradeButton.Hide();
                }

                else if (Soldier16LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier16.Image = Properties.Resources.Soldier16LEVEL3;
                    Soldier16CooldownTimer.Interval = 1500;
                    Soldier16LevelLabel.Text = "Seviye: 3";
                    Soldier16UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier16LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier16.Image = Properties.Resources.Soldier16;
                    Soldier16CooldownTimer.Interval = 1750;
                    Soldier16LevelLabel.Text = "Seviye: 2";
                    Soldier16UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void Soldier17UpgradeButton_Click(object sender, EventArgs e)
        {
            if (LanguageChoice == "ENG")
            {
                if (Soldier17LevelLabel.Text == "Level: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier17.Image = Properties.Resources.Soldier17LEVELmax;
                    Soldier17CooldownTimer.Interval = 1000;
                    Soldier17LevelLabel.Text = "Level:MAX";
                    Soldier17UpgradeButton.Hide();
                }

                else if (Soldier17LevelLabel.Text == "Level: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier17.Image = Properties.Resources.Soldier17LEVEL3;
                    Soldier17CooldownTimer.Interval = 1500;
                    Soldier17LevelLabel.Text = "Level: 3";
                    Soldier17UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " CP";
                }

                else if (Soldier17LevelLabel.Text == "Level: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier17.Image = Properties.Resources.Soldier17;
                    Soldier17CooldownTimer.Interval = 1750;
                    Soldier17LevelLabel.Text = "Level: 2";
                    Soldier17UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " CP";
                }
            }
            else if (LanguageChoice == "TR")
            {
                if (Soldier17LevelLabel.Text == "Seviye: 3" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToFinalLevelPrice)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToFinalLevelPrice;
                    Soldier17.Image = Properties.Resources.Soldier17LEVELmax;
                    Soldier17CooldownTimer.Interval = 1000;
                    Soldier17LevelLabel.Text = "Seviye:MAKS";
                    Soldier17UpgradeButton.Hide();
                }

                else if (Soldier17LevelLabel.Text == "Seviye: 2" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel3Price;
                    Soldier17.Image = Properties.Resources.Soldier17LEVEL3;
                    Soldier17CooldownTimer.Interval = 1500;
                    Soldier17LevelLabel.Text = "Seviye: 3";
                    Soldier17UpgradeButton.Text = GameManager.UpgradeSoldierToFinalLevelPrice + " KP";
                }

                else if (Soldier17LevelLabel.Text == "Seviye: 1" && GameManager.CommandPoints >= GameManager.UpgradeSoldierToLevel2Price)
                {
                    GameManager.CommandPoints -= GameManager.UpgradeSoldierToLevel2Price;
                    Soldier17.Image = Properties.Resources.Soldier17;
                    Soldier17CooldownTimer.Interval = 1750;
                    Soldier17LevelLabel.Text = "Seviye: 2";
                    Soldier17UpgradeButton.Text = GameManager.UpgradeSoldierToLevel3Price + " KP";
                }
            }

            
        }

        private void LabelBuyBarbedwire_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.BuyBarbedWirePrice && GameManager.BarbedWireLevel == "0")
            {
                GameManager.CommandPoints -= GameManager.BuyBarbedWirePrice;
                PBoxBackGround.Image = Properties.Resources.BGBARBED1;
                GameManager.BarbedWireLevel = "1";
                LabelBuyBarbedwire.Hide();
                LabelBuyAdditionalBarbedwire.Show();

            }
     
        }

        private void LabelBuyAdditionalBarbedwire_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.UpgradeBarbedWirePrice && GameManager.BarbedWireLevel == "1")
            {
                GameManager.CommandPoints -= GameManager.UpgradeBarbedWirePrice;
                PBoxBackGround.Image = Properties.Resources.BGBARBED2;
                GameManager.BarbedWireLevel = "2";
                LabelBuyAdditionalBarbedwire.Hide();
                LabelBuyAdditionalBarbedwire2.Show();
            }
        }

        private void LabelBuyAdditionalBarbedwire2_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.UpgradeBarbedWirePrice && GameManager.BarbedWireLevel == "2")
            {
                GameManager.CommandPoints -= GameManager.UpgradeBarbedWirePrice;
                PBoxBackGround.Image = Properties.Resources.BGBARBED3;
                GameManager.BarbedWireLevel = "3";
                LabelBuyAdditionalBarbedwire2.Hide();
                LabelBuyAdditionalBarbedwire3.Show();

            }
        }

        private void LabelBuyAdditionalBarbedwire3_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.UpgradeBarbedWirePrice && GameManager.BarbedWireLevel == "3")
            {
                GameManager.CommandPoints -= GameManager.UpgradeBarbedWirePrice;
                PBoxBackGround.Image = Properties.Resources.BGBARBED4;
                GameManager.BarbedWireLevel = "4";
                LabelBuyAdditionalBarbedwire3.Hide();
                LabelBuyAdditionalBarbedwire4.Show();

            }
        }

        private void LabelBuyAdditionalBarbedwire4_Click(object sender, EventArgs e)
        {
            if (GameManager.CommandPoints >= GameManager.UpgradeBarbedWirePrice && GameManager.BarbedWireLevel == "4")
            {
                GameManager.CommandPoints -= GameManager.UpgradeBarbedWirePrice;
                PBoxBackGround.Image = Properties.Resources.BGBARBED5;
                GameManager.BarbedWireLevel = "5";
                LabelBuyAdditionalBarbedwire4.Hide();
                

            }
        }

        private void LabelUpgradeAmmo_Click(object sender, EventArgs e)
        {
            if (GameManager.AmmunitionLevel == 0 && GameManager.CommandPoints >= GameManager.UpgradeAmmoPrice)
            {
                GameManager.CommandPoints -= GameManager.UpgradeAmmoPrice;
                SoldierStats.BulletQuality = 350;
                LabelUpgradeAmmo.Hide();
                LabelUpgradeAmmo2.Show();
                GameManager.AmmunitionLevel = 1;
            }
        }

        private void LabelUpgradeAmmo2_Click(object sender, EventArgs e)
        {
            if (GameManager.AmmunitionLevel == 1 && GameManager.CommandPoints >= GameManager.UpgradeAmmoPrice)
            {
                GameManager.CommandPoints -= GameManager.UpgradeAmmoPrice;
                SoldierStats.BulletQuality = 200;
                LabelUpgradeAmmo2.Hide();
                LabelUpgradeAmmo3.Show();
                GameManager.AmmunitionLevel = 2;
            }
        }

        private void labelLabelUpgradeAmmo3_Click(object sender, EventArgs e)
        {
            if (GameManager.AmmunitionLevel == 2 && GameManager.CommandPoints >= GameManager.UpgradeAmmoPrice)
            {
                GameManager.CommandPoints -= GameManager.UpgradeAmmoPrice;
                SoldierStats.BulletQuality = 100;
                LabelUpgradeAmmo3.Hide();
                GameManager.AmmunitionLevel = 3;
            }
        }

        private void LabelAddCP_Click(object sender, EventArgs e)
        {
            GameManager.CommandPoints += 500;
        }

        // Enemy /////////////////////////////////////////////////////////////////////////////////////////////////

        List<PictureBox> EnemyList = new List<PictureBox>();

        private void MakeEnemy()
        {
            if (EnemyList.Count < EnemyStats.MaxEnemy)
            {
                PictureBox Enemy = new PictureBox();
                Enemy.Image = Properties.Resources.EnemyLastdirt;


                int EnemyLocationRoll = RandomNumber.Next(1, 18);

                if (EnemyLocationRoll == 1)
                {
                    Enemy.Left = Soldier1.Left;
                    Enemy.Top = -100 - ((GameManager.Line1 * 64) + (GameManager.Line1 * 10));
                    GameManager.Line1++;

                }

                if (EnemyLocationRoll == 2)
                {

                    Enemy.Left = Soldier2.Left;
                    Enemy.Top = -100 - ((GameManager.Line2 * 64) + (GameManager.Line2 * 10));
                    GameManager.Line2++;
                }

                if (EnemyLocationRoll == 3)
                {

                    Enemy.Left = Soldier3.Left;
                    Enemy.Top = -100 - ((GameManager.Line3 * 64) + (GameManager.Line3 * 10));
                    GameManager.Line3++;
                }

                if (EnemyLocationRoll == 4)
                {
                    Enemy.Left = Soldier4.Left;
                    Enemy.Top = -100 - ((GameManager.Line4 * 64) + (GameManager.Line4 * 10));
                    GameManager.Line4++;
                }

                if (EnemyLocationRoll == 5)
                {
                    Enemy.Left = Soldier5.Left;
                    Enemy.Top = -100 - ((GameManager.Line5 * 64) + (GameManager.Line5 * 10));
                    GameManager.Line5++;
                }

                if (EnemyLocationRoll == 6)
                {
                    Enemy.Left = Soldier6.Left;
                    Enemy.Top = -100 - ((GameManager.Line6 * 64) + (GameManager.Line6 * 10));
                    GameManager.Line6++;
                }

                if (EnemyLocationRoll == 7)
                {
                    Enemy.Left = Soldier7.Left;
                    Enemy.Top = -100 - ((GameManager.Line7 * 64) + (GameManager.Line7 * 10));
                    GameManager.Line7++;
                }

                if (EnemyLocationRoll == 8)
                {
                    Enemy.Left = Soldier8.Left;
                    Enemy.Top = -100 - ((GameManager.Line8 * 64) + (GameManager.Line8 * 10));
                    GameManager.Line8++;
                }

                if (EnemyLocationRoll == 9)
                {
                    Enemy.Left = Soldier9.Left;
                    Enemy.Top = -100 - ((GameManager.Line9 * 64) + (GameManager.Line9 * 10));
                    GameManager.Line9++;
                }

                if (EnemyLocationRoll == 10)
                {
                    Enemy.Left = Soldier10.Left;
                    Enemy.Top = -100 - ((GameManager.Line10 * 64) + (GameManager.Line10 * 10));
                    GameManager.Line10++;
                }

                if (EnemyLocationRoll == 11)
                {
                    Enemy.Left = Soldier11.Left;
                    Enemy.Top = -100 - ((GameManager.Line11 * 64) + (GameManager.Line11 * 10));
                    GameManager.Line11++;
                }

                if (EnemyLocationRoll == 12)
                {
                    Enemy.Left = Soldier12.Left;
                    Enemy.Top = -100 - ((GameManager.Line12 * 64) + (GameManager.Line12 * 10));
                    GameManager.Line12++;
                }

                if (EnemyLocationRoll == 13)
                {
                    Enemy.Left = Soldier13.Left;
                    Enemy.Top = -100 - ((GameManager.Line13 * 64) + (GameManager.Line13 * 10));
                    GameManager.Line13++;
                }

                if (EnemyLocationRoll == 14)
                {
                    Enemy.Left = Soldier14.Left;
                    Enemy.Top = -100 - ((GameManager.Line14 * 64) + (GameManager.Line14 * 10));
                    GameManager.Line14++;
                }

                if (EnemyLocationRoll == 15)
                {
                    Enemy.Left = Soldier15.Left;
                    Enemy.Top = -100 - ((GameManager.Line15 * 64) + (GameManager.Line15 * 10));
                    GameManager.Line15++;
                }

                if (EnemyLocationRoll == 16)
                {
                    Enemy.Left = Soldier16.Left;
                    Enemy.Top = -100 - ((GameManager.Line16 * 64) + (GameManager.Line16 * 10));
                    GameManager.Line16++;
                }

                if (EnemyLocationRoll == 17)
                {
                    Enemy.Left = Soldier17.Left;
                    Enemy.Top = -100 - ((GameManager.Line17 * 64) + (GameManager.Line17 * 10));
                    GameManager.Line17++;
                }

                Enemy.Tag = "Enemy";
                Enemy.Size = new Size(64, 64);
                Enemy.BackColor = Color.Red;
                Enemy.BringToFront();

                EnemyList.Add(Enemy);
                this.Controls.Add(Enemy);
            }
        }
        
        public void Kill(object sender, EventArgs e)
        {

            if (isGamePaused == false && isGameOver == false)
            {
                var enemy = (PictureBox)sender;

                this.Controls.Remove(enemy);
                ((PictureBox)enemy).Dispose();
                EnemyList.Remove(((PictureBox)enemy));
            }
        }

        // GAME //////////////////////////////////////////////////////////////////////////////////////////////////


        bool isGameOver;
        bool isGamePaused;
        public void GameStart()
        {

            

            isMainMenuShown = 0;
            Whistle.Play();

            // Hide Unnecessary Stuff
            short groupHideEverything = 0;
            if (groupHideEverything == 0)
            {
                LabelRestart.Hide();
                LabelYouCant.Hide();
                LabelGameOver.Hide();
                LabelGamePaused.Hide();
                LabelInfo.Hide();

                LabelBuyBarbedwire.Show();
                LabelBuyAdditionalBarbedwire.Hide();
                LabelBuyAdditionalBarbedwire2.Hide();
                LabelBuyAdditionalBarbedwire3.Hide();
                LabelBuyAdditionalBarbedwire4.Hide();

                LabelUpgradeAmmo.Show();
                LabelUpgradeAmmo2.Hide();
                LabelUpgradeAmmo3.Hide();


                Soldier1.Hide();
                Soldier1Button.Show();
                Soldier1LevelLabel.Hide();
                Soldier1HealthBar.Hide();
                Soldier1UpgradeButton.Hide();
                Soldier1HealButton.Hide();

                Soldier2.Hide();
                Soldier2Button.Show();
                Soldier2LevelLabel.Hide();
                Soldier2HealthBar.Hide();
                Soldier2UpgradeButton.Hide();
                Soldier2HealButton.Hide();

                Soldier3.Hide();
                Soldier3Button.Show();
                Soldier3LevelLabel.Hide();
                Soldier3HealthBar.Hide();
                Soldier3UpgradeButton.Hide();
                Soldier3HealButton.Hide();

                Soldier4.Hide();
                Soldier4Button.Show();
                Soldier4LevelLabel.Hide();
                Soldier4HealthBar.Hide();
                Soldier4UpgradeButton.Hide();
                Soldier4HealButton.Hide();

                Soldier5.Hide();
                Soldier5Button.Show();
                Soldier5LevelLabel.Hide();
                Soldier5HealthBar.Hide();
                Soldier5UpgradeButton.Hide();
                Soldier5HealButton.Hide();

                Soldier6.Hide();
                Soldier6Button.Show();
                Soldier6LevelLabel.Hide();
                Soldier6HealthBar.Hide();
                Soldier6UpgradeButton.Hide();
                Soldier6HealButton.Hide();

                Soldier7.Hide();
                Soldier7Button.Show();
                Soldier7LevelLabel.Hide();
                Soldier7HealthBar.Hide();
                Soldier7UpgradeButton.Hide();
                Soldier7HealButton.Hide();

                Soldier8.Hide();
                Soldier8Button.Show();
                Soldier8LevelLabel.Hide();
                Soldier8HealthBar.Hide();
                Soldier8UpgradeButton.Hide();
                Soldier8HealButton.Hide();

                Soldier9.Hide();
                Soldier9Button.Show();
                Soldier9LevelLabel.Hide();
                Soldier9HealthBar.Hide();
                Soldier9UpgradeButton.Hide();
                Soldier9HealButton.Hide();

                Soldier10.Hide();
                Soldier10Button.Show();
                Soldier10LevelLabel.Hide();
                Soldier10HealthBar.Hide();
                Soldier10UpgradeButton.Hide();
                Soldier10HealButton.Hide();

                Soldier11.Hide();
                Soldier11Button.Show();
                Soldier11LevelLabel.Hide();
                Soldier11HealthBar.Hide();
                Soldier11UpgradeButton.Hide();
                Soldier11HealButton.Hide();

                Soldier12.Hide();
                Soldier12Button.Show();
                Soldier12LevelLabel.Hide();
                Soldier12HealthBar.Hide();
                Soldier12UpgradeButton.Hide();
                Soldier12HealButton.Hide();

                Soldier13.Hide();
                Soldier13Button.Show();
                Soldier13LevelLabel.Hide();
                Soldier13HealthBar.Hide();
                Soldier13UpgradeButton.Hide();
                Soldier13HealButton.Hide();

                Soldier14.Hide();
                Soldier14Button.Show();
                Soldier14LevelLabel.Hide();
                Soldier14HealthBar.Hide();
                Soldier14UpgradeButton.Hide();
                Soldier14HealButton.Hide();

                Soldier15.Hide();
                Soldier15Button.Show();
                Soldier15LevelLabel.Hide();
                Soldier15HealthBar.Hide();
                Soldier15UpgradeButton.Hide();
                Soldier15HealButton.Hide();

                Soldier16.Hide();
                Soldier16Button.Show();
                Soldier16LevelLabel.Hide();
                Soldier16HealthBar.Hide();
                Soldier16UpgradeButton.Hide();
                Soldier16HealButton.Hide();

                Soldier17.Hide();
                Soldier17Button.Show();
                Soldier17LevelLabel.Hide();
                Soldier17HealthBar.Hide();
                Soldier17UpgradeButton.Hide();
                Soldier17HealButton.Hide();

                WaveLabel.Hide();
                NextWaveLabel.Hide();
            }

            // Reset All
            short groupResetAll = 0;
            if (groupResetAll == 0)
            {
                MainTimer.Start();
                EnemyStats.MaxEnemy = 1;

                for (int i = 0; i < EnemyStats.MaxEnemy; i++)
                {
                    MakeEnemy();
                }

                PBoxBackGround.Image = Properties.Resources.TrenchBackground;
                GameManager.BarbedWireLevel = "0";
                GameManager.Wave = 1;
                GameManager.CommandPoints = 0;
                GameManager.AmmunitionLevel = 0;
                SoldierStats.BulletQuality = 500;

                if (LanguageChoice == "ENG")
                {
                    LabelPauseButton.Text = "PAUSE";
                    CommandPointsLabel.Text = "Command Points: " + GameManager.CommandPoints;
                }
                else if (LanguageChoice == "TR")
                {
                    LabelPauseButton.Text = "DURDUR";
                    CommandPointsLabel.Text = "Komuta Puanları: " + GameManager.CommandPoints;
                }

                
                isGameOver = false;


                

                Soldier1.Image = Properties.Resources.Soldier1LEVEL1;
                Soldier2.Image = Properties.Resources.Soldier2LEVEL1;
                Soldier3.Image = Properties.Resources.Soldier3LEVEL1;
                Soldier4.Image = Properties.Resources.Soldier4LEVEL1;
                Soldier5.Image = Properties.Resources.Soldier5LEVEL1;
                Soldier6.Image = Properties.Resources.Soldier6LEVEL1;
                Soldier7.Image = Properties.Resources.Soldier7LEVEL1;
                Soldier8.Image = Properties.Resources.Soldier8LEVEL1;
                Soldier9.Image = Properties.Resources.Soldier9LEVEL1;
                Soldier10.Image = Properties.Resources.Soldier10LEVEL1;
                Soldier11.Image = Properties.Resources.Soldier11LEVEL1;
                Soldier12.Image = Properties.Resources.Soldier12LEVEL1;
                Soldier13.Image = Properties.Resources.Soldier13LEVEL1;
                Soldier14.Image = Properties.Resources.Soldier14LEVEL1;
                Soldier15.Image = Properties.Resources.Soldier15LEVEL1;
                Soldier16.Image = Properties.Resources.Soldier16LEVEL1;
                Soldier17.Image = Properties.Resources.Soldier17LEVEL1;
               

                Soldier1HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier2HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier3HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier4HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier5HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier6HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier7HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier8HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier9HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier10HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier11HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier12HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier13HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier14HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier15HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier16HealthBar.Value = SoldierStats.SoldierMaximumHealth;
                Soldier17HealthBar.Value = SoldierStats.SoldierMaximumHealth;

                if (LanguageChoice == "ENG")
                {
                    Soldier1LevelLabel.Text = "Level: 1";
                    Soldier2LevelLabel.Text = "Level: 1";
                    Soldier3LevelLabel.Text = "Level: 1";
                    Soldier4LevelLabel.Text = "Level: 1";
                    Soldier5LevelLabel.Text = "Level: 1";
                    Soldier6LevelLabel.Text = "Level: 1";
                    Soldier7LevelLabel.Text = "Level: 1";
                    Soldier8LevelLabel.Text = "Level: 1";
                    Soldier9LevelLabel.Text = "Level: 1";
                    Soldier10LevelLabel.Text = "Level: 1";
                    Soldier11LevelLabel.Text = "Level: 1";
                    Soldier12LevelLabel.Text = "Level: 1";
                    Soldier13LevelLabel.Text = "Level: 1";
                    Soldier14LevelLabel.Text = "Level: 1";
                    Soldier15LevelLabel.Text = "Level: 1";
                    Soldier16LevelLabel.Text = "Level: 1";
                    Soldier17LevelLabel.Text = "Level: 1";

                    LabelBuyBarbedwire.Text = "Buy Barbed Wire (100 CP)";
                    LabelBuyAdditionalBarbedwire4.Text = "Buy Additional Barbed Wire (100 CP)";
                    LabelBuyAdditionalBarbedwire3.Text = "Buy Additional Barbed Wire (100 CP)";
                    LabelBuyAdditionalBarbedwire2.Text = "Buy Additional Barbed Wire (100 CP)";
                    LabelBuyAdditionalBarbedwire.Text = "Buy Additional Barbed Wire (100 CP)";

                    LabelUpgradeAmmo.Text = "Upgrade Ammunition (lvl1) (300 KP)";
                    LabelUpgradeAmmo2.Text = "Upgrade Ammunition (lvl2) (300 KP)";
                    LabelUpgradeAmmo3.Text = "Upgrade Ammunition (lvl3) (300 KP)";
                }
                if (LanguageChoice == "TR")
                {
                    Soldier1LevelLabel.Text = "Seviye: 1";
                    Soldier2LevelLabel.Text = "Seviye: 1";
                    Soldier3LevelLabel.Text = "Seviye: 1";
                    Soldier4LevelLabel.Text = "Seviye: 1";
                    Soldier5LevelLabel.Text = "Seviye: 1";
                    Soldier6LevelLabel.Text = "Seviye: 1";
                    Soldier7LevelLabel.Text = "Seviye: 1";
                    Soldier8LevelLabel.Text = "Seviye: 1";
                    Soldier9LevelLabel.Text = "Seviye: 1";
                    Soldier10LevelLabel.Text = "Seviye: 1";
                    Soldier11LevelLabel.Text = "Seviye: 1";
                    Soldier12LevelLabel.Text = "Seviye: 1";
                    Soldier13LevelLabel.Text = "Seviye: 1";
                    Soldier14LevelLabel.Text = "Seviye: 1";
                    Soldier15LevelLabel.Text = "Seviye: 1";
                    Soldier16LevelLabel.Text = "Seviye: 1";
                    Soldier17LevelLabel.Text = "Seviye: 1";

                    Soldier1Button.Text = "10 KP";
                    Soldier2Button.Text = "10 KP";
                    Soldier3Button.Text = "10 KP";
                    Soldier4Button.Text = "10 KP";
                    Soldier5Button.Text = "10 KP";
                    Soldier6Button.Text = "10 KP";
                    Soldier7Button.Text = "10 KP";
                    Soldier8Button.Text = "10 KP";
                    Soldier9Button.Text = "10 KP";
                    Soldier10Button.Text = "10 KP";
                    Soldier11Button.Text = "10 KP";
                    Soldier12Button.Text = "10 KP";
                    Soldier13Button.Text = "10 KP";
                    Soldier14Button.Text = "10 KP";
                    Soldier15Button.Text = "10 KP";
                    Soldier16Button.Text = "10 KP";
                    Soldier17Button.Text = "10 KP";

                    Soldier1UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier2UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier3UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier4UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier5UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier6UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier7UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier8UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier9UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier10UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier11UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier12UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier13UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier14UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier15UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier16UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";
                    Soldier17UpgradeButton.Text = GameManager.UpgradeSoldierToLevel2Price + " KP";



                    LabelUpgrades.Text = "Geliştirmeler";
                    LabelBuyBarbedwire.Text = "Dikenli Tel Al (100 KP)";
                    LabelBuyAdditionalBarbedwire4.Text = "Ekstra Dikenli Tel Al (100 KP)";
                    LabelBuyAdditionalBarbedwire3.Text = "Ekstra Dikenli Tel Al (100 KP)";
                    LabelBuyAdditionalBarbedwire2.Text = "Ekstra Dikenli Tel Al (100 KP)";                   
                    LabelBuyAdditionalBarbedwire.Text = "Ekstra Dikenli Tel Al (100 KP)";
                    LabelPauseButton.Text = "DURDUR";
                    LabelQuit.Text = "ÇIKIS";
                    LabelGameOver.Text = "YENİLDİN";
                    LabelGamePaused.Text = "Oyun Durduruldu";

                    LabelUpgradeAmmo.Text = "Mermiyi Geliştir (s1) (300 KP)";
                    LabelUpgradeAmmo2.Text = "Mermiyi Geliştir (s2) (300 KP)";
                    LabelUpgradeAmmo3.Text = "Mermiyi Geliştir (s3) (300 KP)";

                    LabelRestart.Text = "Yeniden Başla";

                    LabelYouCant.Text = "Hazırlık aşamasında \noyunu duraklatamazsınız";

                    LabelAddCP.Text = "500 KP Ekle";
                    LabelCheats.Text = "Hileler:";
                    









                }

                

                Soldier1CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier2CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier3CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier4CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier5CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier6CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier7CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier8CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier9CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier10CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier11CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier12CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier13CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier14CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier15CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier16CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;
                Soldier17CooldownTimer.Interval = SoldierStats.SoldierDeffaultCooldown;


            }


        }

        public void GamePause()
        {
            isGamePaused = true;

            if (WaveLabel.Visible == true)
            {
                LabelYouCant.Show();
            }


            else if (WaveLabel.Visible == false)
            {
                if (LanguageChoice == "ENG")
                {
                    LabelPauseButton.Text = "CONTUINE";
                }
                else if (LanguageChoice == "TR")
                {
                    LabelPauseButton.Text = "DEVAM ET";
                }
                

                LabelYouCant.Hide();
                LabelGamePaused.Show();
                MainTimer.Stop();
                Soldier1CooldownTimer.Stop();
                Soldier2CooldownTimer.Stop();
                Soldier3CooldownTimer.Stop();
                Soldier4CooldownTimer.Stop();
                Soldier5CooldownTimer.Stop();
                Soldier6CooldownTimer.Stop();
                Soldier7CooldownTimer.Stop();
                Soldier8CooldownTimer.Stop();
                Soldier9CooldownTimer.Stop();
                Soldier10CooldownTimer.Stop();
                Soldier11CooldownTimer.Stop();
                Soldier12CooldownTimer.Stop();
                Soldier13CooldownTimer.Stop();
                Soldier14CooldownTimer.Stop();
                Soldier15CooldownTimer.Stop();
                Soldier16CooldownTimer.Stop();
                Soldier17CooldownTimer.Stop();
               
            }
            
            

        }

        public void GameOver()
        {
           

            if (LanguageChoice == "ENG")
            {
                LabelInfo.Text = "You survived for " + GameManager.Wave.ToString() + " waves.";
            }
            else if (LanguageChoice == "TR")
            {
                LabelInfo.Text = GameManager.Wave.ToString() + "Dalga saldırıya dayandın.";
            }


            
            MainMenuForm.playerScore = GameManager.Wave;
            if (MainMenuForm.playerScore > MainMenuForm.bestPlayerScore)
            {
                MainMenuForm.bestPlayerScore = GameManager.Wave;
                MainMenuForm.bestPlayerAvatar = PBoxPlayer.Image;
                MainMenuForm.bestPlayerName = LabelPlayerName.Text;
            }

            isGameOver = true;
            LabelRestart.Show();
            LabelYouCant.Hide();
            LabelGamePaused.Hide();
            LabelGameOver.Show();

            

            LabelInfo.Show();
            MainTimer.Stop();
            Soldier1CooldownTimer.Stop();
            Soldier2CooldownTimer.Stop();
            Soldier3CooldownTimer.Stop();
            Soldier4CooldownTimer.Stop();
            Soldier5CooldownTimer.Stop();
            Soldier6CooldownTimer.Stop();
            Soldier7CooldownTimer.Stop();
            Soldier8CooldownTimer.Stop();
            Soldier9CooldownTimer.Stop();
            Soldier10CooldownTimer.Stop();
            Soldier11CooldownTimer.Stop();
            Soldier12CooldownTimer.Stop();
            Soldier13CooldownTimer.Stop();
            Soldier14CooldownTimer.Stop();
            Soldier15CooldownTimer.Stop();
            Soldier16CooldownTimer.Stop();
            Soldier17CooldownTimer.Stop();
            
        }

        public void GameContuine()
        {
            isGamePaused = false;

            if (LanguageChoice == "ENG")
            {
                LabelPauseButton.Text = "PAUSE";
            }
            else if (LanguageChoice == "TR")
            {
                LabelPauseButton.Text = "DURDUR";
            }

           

            LabelGamePaused.Hide();
            MainTimer.Start();
            Soldier1CooldownTimer.Start();
            Soldier2CooldownTimer.Start();
            Soldier3CooldownTimer.Start();
            Soldier4CooldownTimer.Start();
            Soldier5CooldownTimer.Start();
            Soldier6CooldownTimer.Start();
            Soldier7CooldownTimer.Start();
            Soldier8CooldownTimer.Start();
            Soldier9CooldownTimer.Start();
            Soldier10CooldownTimer.Start();
            Soldier11CooldownTimer.Start();
            Soldier12CooldownTimer.Start();
            Soldier13CooldownTimer.Start();
            Soldier14CooldownTimer.Start();
            Soldier15CooldownTimer.Start();
            Soldier16CooldownTimer.Start();
            Soldier17CooldownTimer.Start();            
           
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void WaveTimer_Tick(object sender, EventArgs e)
        {
            GameManager.PrepDuration--;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void LabelPauseButton_Click(object sender, EventArgs e)
        {
            
            
                if (isGamePaused == true && isGameOver == false)
                {
                    GameContuine();
                    
                }

                else if (isGamePaused == false && isGameOver == false)
                {
                    GamePause();
                        
                }
            
        }

        private void LabelQuit_Click(object sender, EventArgs e)
        {

            if (LanguageChoice == "ENG")
            {
                DialogResult areYouSure = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (areYouSure == DialogResult.Yes)
                {
                    isMainMenuShown = 1;
                    BGMusic.controls.stop();
                    this.Close();
                }
            }
            else if (LanguageChoice == "TR")
            {
                DialogResult areYouSure = MessageBox.Show("Çıkmak istediğine emin misin ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (areYouSure == DialogResult.Yes)
                {
                    isMainMenuShown = 1;
                    BGMusic.controls.stop();
                    this.Close();

                }
            }


                   
        }

        private void LabelRestart_Click(object sender, EventArgs e)
        {
            GameContuine();
            GameStart();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

            BGMusic = new WindowsMediaPlayer();
            BGMusic.settings.setMode("loop", true);
            BGMusic.URL = "Sounds\\BGMusic.mp3";
            BGMusic.settings.volume = vvolume;
            BGMusic.settings.autoStart = true;

            GameStart();
            
        }

        
    }
}
