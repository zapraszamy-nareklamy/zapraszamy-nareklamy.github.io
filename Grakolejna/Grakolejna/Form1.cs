using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Grakolejna
{
    public partial class Form1 : Form
    {
     

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int ammo = 10;
        int kills;
        int playerSpeed = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();

        List<PictureBox> zombieList = new List<PictureBox>();

        public Form1()
        {
           
            InitializeComponent();
            RestartGame();
        }

       



        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1) 
            {
                healthBar.Value = playerHealth;
            
            }
            else
            {
                gameOver = true;
                Player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtKills.Text = "Kills: " + kills;
         
            if(goLeft==true && Player.Left>0)
            {
                Player.Left -= playerSpeed;

            }

            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {

                Player.Left += playerSpeed;
            }
            if (goUp == true && Player.Top >45)
            {
                Player.Top -= playerSpeed;
            }

            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;


                    }

                }
                    if (x is PictureBox && (string)x.Tag == "zombie")
                    {
                       
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }
                    
                    
                    
                    if (x.Left > Player.Left)
                        {
                            x.Left -= zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zleft;
                        }
                        if (x.Left < Player.Left)
                        {
                            x.Left += zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zright;
                        }
                        if (x.Top > Player.Top)
                        {
                            x.Top -= zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zup;
                        }
                        if (x.Top < Player.Top)
                        {
                            x.Top += zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zdown;
                        }

                    }
                 foreach(Control  j in this.Controls)
                {
                    if (j is PictureBox&&(string)j.Tag=="bullet"&& x is PictureBox&&(string)x.Tag=="zombie")
                        {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kills++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombieList.Remove(((PictureBox)x));
                            MakeZombies();

                        }
                    }
                }

            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        { 
          
            if (gameOver==true)
            {
              

                return;
            }
            
            
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                Player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                Player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)

            {   goUp = true;
                facing = "up[";
                Player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                Player.Image = Properties.Resources.down;
            }

         
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }

            if (e.KeyCode == Keys.Up)

            {
                goUp = false;

            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;

            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;

                ShootBullet(facing);
                if (ammo < 1)
                {
                    DropAmmo();
                }

                

            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
    
        private void ShootBullet(string direction)
        {
            
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = Player.Left + (Player.Width / 2);
            shootBullet.bulletTop = Player.Top + (Player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies() 
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieList.Add(zombie);
            this.Controls.Add(zombie);
            Player.BringToFront();



        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width-ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            Player.BringToFront();
        }

        private void RestartGame()
        {
            Player.Image = Properties.Resources.up;
            
            
            foreach(PictureBox i  in zombieList)
            {
                this.Controls.Remove(i);

            }
            zombieList.Clear();
        for(int i=0; i<3; i++)
            {
                MakeZombies();
            }
            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            gameOver = false;
            playerHealth = 100;
            kills = 0;
            ammo = 10;

            GameTimer.Start();
        
        }
    
    }
}
