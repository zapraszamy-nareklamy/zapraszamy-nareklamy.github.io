
namespace Grakolejna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblgameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAmmo.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAmmo.Location = new System.Drawing.Point(12, 20);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(170, 35);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Amunicja: 0";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHealth.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHealth.Location = new System.Drawing.Point(619, 20);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(99, 35);
            this.txtHealth.TabIndex = 1;
            this.txtHealth.Text = " Życie:";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKills.ForeColor = System.Drawing.SystemColors.Control;
            this.txtKills.Location = new System.Drawing.Point(348, 20);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(177, 35);
            this.txtKills.TabIndex = 2;
            this.txtKills.Text = "Likwidacje 0";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(724, 28);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(203, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // Player
            // 
            this.Player.Image = global::Grakolejna.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(407, 432);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // lblgameOver
            // 
            this.lblgameOver.AutoSize = true;
            this.lblgameOver.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblgameOver.ForeColor = System.Drawing.Color.Crimson;
            this.lblgameOver.Location = new System.Drawing.Point(160, 9);
            this.lblgameOver.Name = "lblgameOver";
            this.lblgameOver.Size = new System.Drawing.Size(110, 51);
            this.lblgameOver.TabIndex = 5;
            this.lblgameOver.Text = "        ";
            this.lblgameOver.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(327, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(938, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblgameOver);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtAmmo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zombie Strzelacz";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblgameOver;
        private System.Windows.Forms.Label label1;
    }
}

