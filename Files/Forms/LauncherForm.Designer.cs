namespace Trenches_of_Gallipoli
{
    partial class LauncherForm
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
            this.LabelSelectLanguage = new System.Windows.Forms.Label();
            this.LabelQuit = new System.Windows.Forms.Label();
            this.LangTurkish = new System.Windows.Forms.PictureBox();
            this.LangEnglish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LangTurkish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangEnglish)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSelectLanguage
            // 
            this.LabelSelectLanguage.AutoSize = true;
            this.LabelSelectLanguage.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectLanguage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSelectLanguage.Location = new System.Drawing.Point(50, 34);
            this.LabelSelectLanguage.Name = "LabelSelectLanguage";
            this.LabelSelectLanguage.Size = new System.Drawing.Size(281, 59);
            this.LabelSelectLanguage.TabIndex = 2;
            this.LabelSelectLanguage.Text = "Select Language";
            // 
            // LabelQuit
            // 
            this.LabelQuit.AutoSize = true;
            this.LabelQuit.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelQuit.Location = new System.Drawing.Point(149, 208);
            this.LabelQuit.Name = "LabelQuit";
            this.LabelQuit.Size = new System.Drawing.Size(64, 44);
            this.LabelQuit.TabIndex = 3;
            this.LabelQuit.Text = "Quit";
            this.LabelQuit.Click += new System.EventHandler(this.LabelQuit_Click);
            // 
            // LangTurkish
            // 
            this.LangTurkish.BackColor = System.Drawing.Color.Red;
            this.LangTurkish.Image = global::Trenches_of_Gallipoli.Properties.Resources.Ekran_görüntüsü_2024_01_01_005153;
            this.LangTurkish.Location = new System.Drawing.Point(205, 118);
            this.LangTurkish.Name = "LangTurkish";
            this.LangTurkish.Size = new System.Drawing.Size(100, 70);
            this.LangTurkish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LangTurkish.TabIndex = 1;
            this.LangTurkish.TabStop = false;
            this.LangTurkish.Click += new System.EventHandler(this.LangTurkish_Click);
            // 
            // LangEnglish
            // 
            this.LangEnglish.BackColor = System.Drawing.Color.Blue;
            this.LangEnglish.Image = global::Trenches_of_Gallipoli.Properties.Resources.Flag_of_the_United_Kingdom__3_5_1;
            this.LangEnglish.Location = new System.Drawing.Point(60, 118);
            this.LangEnglish.Name = "LangEnglish";
            this.LangEnglish.Size = new System.Drawing.Size(100, 70);
            this.LangEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LangEnglish.TabIndex = 0;
            this.LangEnglish.TabStop = false;
            this.LangEnglish.Click += new System.EventHandler(this.LangEnglish_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.LabelQuit);
            this.Controls.Add(this.LabelSelectLanguage);
            this.Controls.Add(this.LangTurkish);
            this.Controls.Add(this.LangEnglish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliffs Of Gallipoli Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.LangTurkish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangEnglish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LangEnglish;
        private System.Windows.Forms.PictureBox LangTurkish;
        private System.Windows.Forms.Label LabelSelectLanguage;
        private System.Windows.Forms.Label LabelQuit;
    }
}

