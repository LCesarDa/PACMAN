using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN
{
    public class Drawings
    {
        public static void DrawMap(byte[,] map0, Bitmap map)
        {
            Graphics g = Graphics.FromImage(map);
            g.Clear(Color.Blue);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.DrawRectangle(Pens.Gray, x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.Orange), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 2)
                    {
                        g.FillRectangle(new SolidBrush(Color.Turquoise), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 8)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), x * 30, y * 30, 30, 30);
                    }
                }
            }

        }
        public static void DrawCoins(byte[,] map0, Bitmap coin)
        {
            Graphics g = Graphics.FromImage(coin);
            g.Clear(Color.Transparent);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.FillEllipse(new SolidBrush(Color.White), x * 30 +10, y * 30 +10, 10, 10);
                    }

                }
            }

        }
        public static void DrawMap0(byte[,] map0, Bitmap map)
        {
            Graphics g = Graphics.FromImage(map);
            g.Clear(Color.Navy);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.DrawRectangle(Pens.Gray, x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 2)
                    {
                        g.FillRectangle(new SolidBrush(Color.Purple), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 8)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), x * 30, y * 30, 30, 30);
                    }
                }
            }

        }
        public static void DrawCoins0(byte[,] map0, Bitmap coin)
        {
            Graphics g = Graphics.FromImage(coin);
            g.Clear(Color.Transparent);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.FillEllipse(new SolidBrush(Color.White), x * 30 + 10, y * 30 + 10, 10, 10);
                    }

                }
            }
        }
        public static void DrawMap1(byte[,] map0, Bitmap map)
        {
            Graphics g = Graphics.FromImage(map);
            g.Clear(Color.Navy);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.DrawRectangle(Pens.Gray, x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 2)
                    {
                        g.FillRectangle(new SolidBrush(Color.Purple), x * 30, y * 30, 30, 30);
                    }
                    if (map0[y, x] == 8)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), x * 30, y * 30, 30, 30);
                    }
                }
            }

        }
        public static void DrawCoins1(byte[,] map0, Bitmap coin)
        {
            Graphics g = Graphics.FromImage(coin);
            g.Clear(Color.Transparent);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y, x] == 0)
                    {
                        g.FillEllipse(new SolidBrush(Color.White), x * 30 + 10, y * 30 + 10, 10, 10);
                    }

                }
            }
        }

    }
}
