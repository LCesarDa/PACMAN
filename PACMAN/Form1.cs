using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class Form1 : Form
    {
        
        Image playerUpImage;
        Image playerDownImage;
        Image playerLeftImage;
        Image playerRightImage;
        Image RGUpImage;
        Image RGDownImage;
        Image RGLeftImage;
        Image RGRightImage;
        Image PGUpImage;
        Image PGDownImage;
        Image PGLeftImage;
        Image PGRightImage;
        Image BGUpImage;
        Image BGDownImage;
        Image BGLeftImage;
        Image BGRightImage;
        Image OGUpImage;
        Image OGDownImage;
        Image OGLeftImage;
        Image OGRightImage;
        Graphics g;
        Bitmap map, coin;
        Point playerPos, RGPos, PGPos, BGPos, OGPos;
        PictureBox playerBox, RGBox, PGBox, BGBox, OGBox;
        Boolean InitR, InitP, InitB, InitO;
        static byte[,] actualMap, actualCoin;
        Boolean up = false, down = false, left = false, right = false;
        int score = 0, count1 = 318, count2 = 0, count3 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (InitR == false)
            {
                RGPos = new Point(2, 11);
                RGBox.Location = new Point(2 * 30, 11 * 30);
                InitR = true;
            }
            if (RGPos.Y > 0 && actualMap[RGPos.Y - 1, RGPos.X] == 0)
            {
                if (actualMap[RGPos.Y - 1, RGPos.X] == 0)
                {
                    RGPos.Y--;
                    RGBox.Image = RGUpImage;
                }
            }
            else if (RGPos.Y < 25 - 1 && actualMap[RGPos.Y + 1, RGPos.X] == 0)
            {
                if (actualMap[RGPos.Y + 1, RGPos.X] == 0)
                {
                    RGPos.Y++;
                    RGBox.Image = RGDownImage;
                }
            }
            
            RGBox.Location = new Point(RGPos.X * 30, RGPos.Y * 30);
            Invalidate();
            timer5.Enabled = true;

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (InitP == false)
            {
                PGPos = new Point(22, 11);
                PGBox.Location = new Point(22 * 30, 11 * 30);
                InitP = true;
            }
            if (PGPos.Y > 0 && actualMap[PGPos.Y - 1, PGPos.X] == 0)
            {
                if (actualMap[PGPos.Y - 1, PGPos.X] == 0)
                {
                    PGPos.Y--;
                    PGBox.Image = PGUpImage;
                }
            }
            else if (PGPos.Y < 25 - 1 && actualMap[PGPos.Y + 1, PGPos.X] == 0)
            {
                if (actualMap[PGPos.Y + 1, PGPos.X] == 0)
                {
                    PGPos.Y++;
                    PGBox.Image = PGDownImage;
                }
            }

            PGBox.Location = new Point(PGPos.X * 30, PGPos.Y * 30);
            timer6.Enabled = true;
            Invalidate();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (InitB == false)
            {
                BGPos = new Point(22, 11);
                BGBox.Location = new Point(22 * 30, 11 * 30);
                InitP = true;
            }
            if (BGPos.X > 0)
            {
                if (actualMap[BGPos.Y, BGPos.X - 1] == 0 || actualMap[BGPos.Y, BGPos.X - 1] == 2)
                {
                    BGPos.X--;
                    BGBox.Image = BGLeftImage;
                }
                if (actualMap[BGPos.Y, BGPos.X] == 2 || BGPos == new Point(0, 11))
                {
                    BGPos = new Point(24, 11);
                    BGBox.Image = BGLeftImage;
                }
                if (actualMap[BGPos.Y, BGPos.X] == 2 || BGPos == new Point(0, 12))
                {
                    BGPos = new Point(24, 12);
                    BGBox.Image = BGLeftImage;
                }
            }
            else if (BGPos.X < 25 - 1)
            {
                if (actualMap[BGPos.Y, BGPos.X + 1] == 0 || actualMap[BGPos.Y, BGPos.X + 1] == 2)
                {
                    BGPos.X++;
                    BGBox.Image = BGRightImage;
                }
                if (actualMap[BGPos.Y, BGPos.X] == 2 || BGPos == new Point(24, 11))
                {
                    BGPos = new Point(0, 11);
                    BGBox.Image = BGRightImage;
                }
                if (actualMap[BGPos.Y, BGPos.X] == 2 || BGPos == new Point(24, 12))
                {
                    BGPos = new Point(0, 12);
                    BGBox.Image = BGRightImage;
                }
            }
            BGBox.Location = new Point(BGPos.X * 30, BGPos.Y * 30);
            timer7.Enabled = true;
            Invalidate();

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (InitO == false)
            {
                OGPos = new Point(22, 11);
                OGBox.Location = new Point(22 * 30, 11 * 30);
                InitO = true;
            }
            if (OGPos.X > 0)
            {
                if (actualMap[OGPos.Y, OGPos.X - 1] == 0 || actualMap[OGPos.Y, OGPos.X - 1] == 2)
                {
                    OGPos.X--;
                    OGBox.Image = OGLeftImage;
                }
                if (actualMap[OGPos.Y, OGPos.X] == 2 || OGPos == new Point(0, 11))
                {
                    OGPos = new Point(24, 11);
                    OGBox.Image = OGLeftImage;
                }
                if (actualMap[OGPos.Y, OGPos.X] == 2 || OGPos == new Point(0, 12))
                {
                    OGPos = new Point(24, 12);
                    OGBox.Image = OGLeftImage;
                }
            }
            else if (OGPos.X < 25 - 1)
            {
                if (actualMap[OGPos.Y, OGPos.X + 1] == 0 || actualMap[OGPos.Y, OGPos.X + 1] == 2)
                {
                    OGPos.X++;
                    OGBox.Image = OGLeftImage;
                }
                if (actualMap[OGPos.Y, OGPos.X] == 2 || OGPos == new Point(24, 11))
                {
                    OGPos = new Point(0, 11);
                    OGBox.Image = OGLeftImage;
                }
                if (actualMap[OGPos.Y, OGPos.X] == 2 || OGPos == new Point(24, 12))
                {
                    OGPos = new Point(0, 12);
                    OGBox.Image = OGLeftImage;
                }
            }
            OGBox.Location = new Point(OGPos.X * 30, OGPos.Y * 30);
            Invalidate();




        }

        

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (playerPos == RGPos || playerPos == OGPos || playerPos == BGPos || playerPos == PGPos)
            {
                Application.Exit();
            }
            if (up == true)
            {
                if (playerPos.Y > 0)
                {
                    if (actualMap[playerPos.Y - 1, playerPos.X] == 0 || actualMap[playerPos.Y - 1, playerPos.X] == 2)
                    {
                        playerPos.Y--;
                        playerBox.Image = playerUpImage;
                    }
                    else up = false;
                }
                else up = false;
            }
            if (down == true)
            {
                if (playerPos.Y < 25 - 1)
                {
                    if (actualMap[playerPos.Y + 1, playerPos.X] == 0 || actualMap[playerPos.Y + 1, playerPos.X] == 2)
                    {
                        playerPos.Y++;
                        playerBox.Image = playerDownImage;
                    }
                    else down = false;
                }
                else down = false;
            }
            if (left == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                {
                    playerPos = new Point(24, 11);
                    playerBox.Image = playerLeftImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                {
                    playerPos = new Point(24, 12);
                    playerBox.Image = playerLeftImage;
                }
                if (playerPos.X > 0)
                {
                    if (actualMap[playerPos.Y, playerPos.X - 1] == 0 || actualMap[playerPos.Y, playerPos.X - 1] == 2)
                    {
                        playerPos.X--;
                        playerBox.Image = playerLeftImage;
                    }
                    else left = false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                    {
                        playerPos = new Point(24, 11);
                        playerBox.Image = playerLeftImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                    {
                        playerPos = new Point(24, 12);
                        playerBox.Image = playerLeftImage;
                    }
                }

            }
            else left = false;
            if (right == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                {
                    playerPos = new Point(0, 11);
                    playerBox.Image = playerRightImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                {
                    playerPos = new Point(0, 12);
                    playerBox.Image = playerRightImage;
                }
                if (playerPos.X < 25 - 1)
                {
                    if (actualMap[playerPos.Y, playerPos.X + 1] == 0 || actualMap[playerPos.Y, playerPos.X + 1] == 2)
                    {
                        playerPos.X++;
                        playerBox.Image = playerRightImage;
                    }
                    else right = false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                    {
                        playerPos = new Point(0, 11);
                        playerBox.Image = playerRightImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                    {
                        playerPos = new Point(0, 12);
                        playerBox.Image = playerRightImage;
                    }
                }
                else right = false;
            }
            if (actualCoin[playerPos.Y, playerPos.X] == 0)
            {
                actualCoin[playerPos.Y, playerPos.X] = 2;
                score += 10;
                count3++;
                Drawings.DrawCoins(actualCoin, coin);
            }
            if (count3 == 273)
            {
                
                    Application.Exit();
                
            }
            label1.Text = score.ToString();
            playerBox.Location = new Point(playerPos.X * 30, playerPos.Y * 30);
            Invalidate();
        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (playerPos == RGPos || playerPos == OGPos || playerPos == BGPos || playerPos == PGPos)
            {
                Application.Exit();
            }
            if (up == true)
            {
                if (playerPos.Y > 0)
                {
                    if (actualMap[playerPos.Y - 1, playerPos.X] == 0 || actualMap[playerPos.Y - 1, playerPos.X] == 2)
                    {
                        playerPos.Y--;
                        playerBox.Image = playerUpImage;
                    }
                    else up = false;
                }
                else up = false;
            }
            if (down == true)
            {
                if (playerPos.Y < 25 - 1)
                {
                    if (actualMap[playerPos.Y + 1, playerPos.X] == 0 || actualMap[playerPos.Y + 1, playerPos.X] == 2)
                    {
                        playerPos.Y++;
                        playerBox.Image = playerDownImage;
                    }
                    else down = false;
                }
                else down = false;
            }
            if (left == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                {
                    playerPos = new Point(24, 11);
                    playerBox.Image = playerLeftImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                {
                    playerPos = new Point(24, 12);
                    playerBox.Image = playerLeftImage;
                }
                if (playerPos.X > 0)
                {
                    if (actualMap[playerPos.Y, playerPos.X - 1] == 0 || actualMap[playerPos.Y, playerPos.X - 1] == 2)
                    {
                        playerPos.X--;
                        playerBox.Image = playerLeftImage;
                    }
                    else left = false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                    {
                        playerPos = new Point(24, 11);
                        playerBox.Image = playerLeftImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                    {
                        playerPos = new Point(24, 12);
                        playerBox.Image = playerLeftImage;
                    }
                }

            }
            else left = false;
            if (right == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                {
                    playerPos = new Point(0, 11);
                    playerBox.Image = playerRightImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                {
                    playerPos = new Point(0, 12);
                    playerBox.Image = playerRightImage;
                }
                if (playerPos.X < 25 - 1)
                {
                    if (actualMap[playerPos.Y, playerPos.X + 1] == 0 || actualMap[playerPos.Y, playerPos.X + 1] == 2)
                    {
                        playerPos.X++;
                        playerBox.Image = playerRightImage;
                    }
                    else right = false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                    {
                        playerPos = new Point(0, 11);
                        playerBox.Image = playerRightImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                    {
                        playerPos = new Point(0, 12);
                        playerBox.Image = playerRightImage;
                    }
                }
                else right = false;
            }
            if (actualCoin[playerPos.Y, playerPos.X] == 0)
            {
                actualCoin[playerPos.Y, playerPos.X] = 2;
                score += 10;
                count2++;
                Drawings.DrawCoins0(actualCoin, coin);
            }
            if (count2 == 343)
            {
                actualMap = Maps.map2;
                actualCoin = Coins.coin2;
                timer3.Enabled = true; timer2.Enabled = false;
                Drawings.DrawMap(actualMap, map);
                Drawings.DrawCoins(actualCoin, coin);
                RGPos = new Point(11, 4);
                PGPos = new Point(13, 4);
                BGPos = new Point(10, 4);
                OGPos = new Point(14, 4);
                playerPos = new Point(12, 5);
                playerBox.Location = new Point(12 * 30, 5 * 30);
                RGBox.Location = new Point(11 * 30, 4 * 30);
                PGBox.Location = new Point(13 * 30, 4 * 30);
                BGBox.Location = new Point(10 * 30, 4 * 30);
                OGBox.Location = new Point(14 * 30, 4 * 30);
            }
            label1.Text = score.ToString();
            playerBox.Location = new Point(playerPos.X * 30, playerPos.Y * 30);
            Invalidate();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           if (playerPos == RGPos || playerPos == OGPos || playerPos == BGPos || playerPos == PGPos)
            {
                Application.Exit();
            }
            if (up == true)
            {
                if (playerPos.Y > 0)
                {
                    if (actualMap[playerPos.Y - 1, playerPos.X] == 0 || actualMap[playerPos.Y - 1, playerPos.X] == 2)
                    {
                        playerPos.Y--;
                        playerBox.Image = playerUpImage;
                    }
                    else up = false;
                }
                else up = false;
            }
            if (down == true)
            {
                if (playerPos.Y < 25 - 1)
                {
                    if (actualMap[playerPos.Y + 1, playerPos.X] == 0 || actualMap[playerPos.Y + 1, playerPos.X] == 2)
                    {
                        playerPos.Y++;
                        playerBox.Image = playerDownImage;
                    } else down = false;
                } else down = false;
            }
            if (left == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                {
                    playerPos = new Point(24, 11);
                    playerBox.Image = playerLeftImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                {
                    playerPos = new Point(24, 12);
                    playerBox.Image = playerLeftImage;
                }
                if (playerPos.X > 0)
                {
                    if (actualMap[playerPos.Y, playerPos.X - 1] == 0 || actualMap[playerPos.Y, playerPos.X - 1] == 2)
                    {
                        playerPos.X--;
                        playerBox.Image = playerLeftImage;
                    } else left= false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 11))
                    {
                        playerPos = new Point(24, 11);
                        playerBox.Image = playerLeftImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(0, 12))
                    {
                        playerPos = new Point(24, 12);
                        playerBox.Image = playerLeftImage;
                    }
                }
               
            } else left = false;
            if (right == true)
            {
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                {
                    playerPos = new Point(0, 11);
                    playerBox.Image = playerRightImage;
                }
                if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                {
                    playerPos = new Point(0, 12);
                    playerBox.Image = playerRightImage;
                }
                if (playerPos.X < 25 - 1)
                {
                    if (actualMap[playerPos.Y, playerPos.X + 1] == 0 || actualMap[playerPos.Y, playerPos.X + 1] == 2)
                    {
                        playerPos.X++;
                        playerBox.Image = playerRightImage;
                    }
                    else right = false;
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 11))
                    {
                        playerPos = new Point(0, 11);
                        playerBox.Image = playerRightImage;
                    }
                    if (actualMap[playerPos.Y, playerPos.X] == 2 || playerPos == new Point(24, 12))
                    {
                        playerPos = new Point(0, 12);
                        playerBox.Image = playerRightImage;
                    }
                }
                else right = false;
            }
            if (actualCoin[playerPos.Y,playerPos.X] == 0)
            {
                actualCoin[playerPos.Y, playerPos.X] = 2;
                score += 10;
                count1++;
                Drawings.DrawCoins(actualCoin, coin);
            }
            if (count1==319)
            {
                actualMap = Maps.map1;
                actualCoin = Coins.coin1;
                timer2.Enabled = true; timer1.Enabled = false;
                Drawings.DrawMap0(actualMap, map);
                Drawings.DrawCoins0(actualCoin, coin);
                RGPos = new Point(11, 4);
                PGPos = new Point(13, 4);
                BGPos = new Point(10, 4);
                OGPos = new Point(14, 4);
                playerPos = new Point(12, 5);
                playerBox.Location = new Point(12 * 30, 5 * 30);
                RGBox.Location = new Point(11 * 30, 4 * 30);
                PGBox.Location = new Point(13 * 30, 4 * 30);
                BGBox.Location = new Point(10 * 30, 4 * 30);
                OGBox.Location = new Point(14 * 30, 4 * 30);

            }
            label1.Text = score.ToString();
            playerBox.Location = new Point(playerPos.X * 30, playerPos.Y * 30);
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            timer4.Enabled = true;
            
            if (e.KeyCode == Keys.Up)
            {
                up = true;
                down= false;
                left = false;
                right = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = true;
                right = false;
                up= false;
                down= false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right= true;
                left= false;
                up= false;
                down= false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(map,0,0,map.Width,map.Height);
            g.DrawImage(coin,0,0,coin.Width,coin.Height);

        }

        public Form1()
        {
            InitializeComponent();

            map = new Bitmap(750, 750);
            actualMap = Maps.map0;
            Drawings.DrawMap(actualMap, map);
            coin = new Bitmap(750, 750);
            actualCoin = Coins.coin0;
            Drawings.DrawCoins(actualCoin, coin);
            playerUpImage = Resource1.PAC2;
            playerDownImage = Resource1.PAC4;
            playerLeftImage = Resource1.PAC3;
            playerRightImage = Resource1.PAC1;
            RGUpImage = Resource1.RGUp;
            RGDownImage = Resource1.RGDo;
            RGLeftImage = Resource1.RGLe;
            RGRightImage = Resource1.RGRi;
            PGUpImage = Resource1.PGUp;
            PGDownImage = Resource1.PGDo;
            PGLeftImage = Resource1.PGLe;
            PGRightImage = Resource1.PGRi;
            BGUpImage = Resource1.BGUp;
            BGDownImage = Resource1.BGDo;
            BGLeftImage = Resource1.BGLe;
            BGRightImage = Resource1.BGRi;
            OGUpImage = Resource1.OGUp;
            OGDownImage = Resource1.OGDo;
            OGLeftImage = Resource1.OGLe;
            OGRightImage = Resource1.OGRi;
            RGPos = new Point(11, 4);
            PGPos = new Point(13, 4);
            BGPos = new Point(10, 4);
            OGPos = new Point(14, 4);
            playerPos = new Point(12,5);
            playerBox = new PictureBox
            {
                Image = playerDownImage,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(12*30,5*30),
                BackColor = Color.Transparent
            };
            RGBox = new PictureBox
            {
                Image = RGLeftImage,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(11 * 30, 4 * 30),
                BackColor = Color.Transparent
            };
            PGBox = new PictureBox
            {
                Image = PGLeftImage,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(13 * 30, 4 * 30),
                BackColor = Color.Transparent
            };
            BGBox = new PictureBox
            {
                Image = BGRightImage,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10 * 30, 4 * 30),
                BackColor = Color.Transparent
            };
            OGBox = new PictureBox
            {
                Image = OGLeftImage,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(14 * 30, 4 * 30),
                BackColor = Color.Transparent
            };
            this.Controls.Add(playerBox);
            this.Controls.Add(RGBox);
            this.Controls.Add(PGBox);
            this.Controls.Add(BGBox);
            this.Controls.Add(OGBox);


        }

        
    }




}

