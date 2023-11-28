using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphBuilder
{
    public static class Draw
    {
        /// <summary> Метод. Создания изображения вершины с отрисовкой имени </summary>
        public static void Vertex(PictureBox Main, Vertexes Vertex, Color DrawColor)
        {
            Bitmap BM_Main = new Bitmap(Main.Image); Graphics Grap_Main = Graphics.FromImage(BM_Main);
            Grap_Main.FillEllipse(new SolidBrush(Main.BackColor), Vertex.X + 1, Vertex.Y + 1, Vertex.Width - 2, Vertex.Height - 2);
            Grap_Main.DrawEllipse(new Pen(DrawColor, 3), Vertex.X + 1, Vertex.Y + 1, Vertex.Width - 2, Vertex.Height - 2);
            int Inaccuracy = 3 - (Convert.ToInt32(Vertex.Name.Length) - 1) * (2 + Convert.ToInt32(Vertex.Name.Length) - 1);
            Grap_Main.DrawString(Vertex.Name, new Font("Times New Roman", 12), new SolidBrush(Color.Black), Vertex.X + Vertex.Width / 3 + Inaccuracy, Vertex.Y + Vertex.Height / 3);
            Main.Image = BM_Main;
        }

        /// <summary> Метод. Создания изображения ребра с размерностью между заданными вершинами </summary>
        public static void Edge(PictureBox Main, Edges Edge)
        {
            Bitmap BM_Start = new Bitmap(Main.Image); Graphics Grap_Start = Graphics.FromImage(BM_Start);

            Grap_Start.DrawLine(new Pen(Color.Black, 2), new Point(Edge.A.X + Edge.A.Width / 2, Edge.A.Y + Edge.A.Height / 2), new Point(Edge.B.X + Edge.B.Width / 2, Edge.B.Y + Edge.B.Height / 2));

            Main.Image = BM_Start; Vertex(Main, Edge.A, Color.Black); Vertex(Main, Edge.B, Color.Black); Bitmap BM_Main = new Bitmap(Main.Image); Graphics Grap_Main = Graphics.FromImage(BM_Main);

            int DX = 0, DY = 0, DistanceX = 0, DistanceY = 0;

            if (Edge.A.X <= Edge.B.X)
            {
                if (Edge.A.Y >= Edge.B.Y)
                {
                    DX = (int)((float)(Edge.A.X + Edge.A.Width / 2 + Edge.B.X + Edge.B.Width / 2) / 2.0); DY = (int)((float)(Edge.A.Y + Edge.A.Height / 2 + Edge.B.Y + Edge.B.Height / 2) / 2.0);
                    DistanceX = 6; DistanceY = 3; if (((float)(Edge.B.X - Edge.A.X) / 2.0) < 84 & (float)((Edge.A.Y - Edge.B.Y) / 2.0) < 30) DistanceX -= (int)(84 - (float)(Edge.B.X - Edge.A.X) / 2.0);
                }
                else if (Edge.A.Y < Edge.B.Y)
                {
                    DX = (int)((float)(Edge.A.X + Edge.A.Width / 2 + Edge.B.X + Edge.B.Width / 2) / 2.0); DY = (int)((float)(Edge.A.Y + Edge.A.Height / 2 + Edge.B.Y + Edge.B.Height / 2) / 2.0);
                    DistanceX = 6; DistanceY = -21; if (((float)(Edge.B.X - Edge.A.X) / 2.0) < 84 & (float)((Edge.B.Y - Edge.A.Y) / 2.0) < 30) DistanceX -= (int)(84 - (float)(Edge.B.X - Edge.A.X) / 2.0);
                }
            }
            else if (Edge.A.X > Edge.B.X)
            {
                if (Edge.A.Y <= Edge.B.Y)
                {
                    DX = (int)((float)(Edge.A.X + Edge.A.Width / 2 + Edge.B.X + Edge.B.Width / 2) / 2.0); DY = (int)((float)(Edge.A.Y + Edge.A.Height / 2 + Edge.B.Y + Edge.B.Height / 2) / 2.0);
                    DistanceX = 6; DistanceY = 3; if (((float)(Edge.A.X - Edge.B.X) / 2.0) < 84 & (float)((Edge.B.Y - Edge.A.Y) / 2.0) < 30) DistanceX -= (int)(84 - (float)(Edge.A.X - Edge.B.X) / 2.0);
                }
                else if (Edge.A.Y > Edge.B.Y)
                {
                    DX = (int)((float)(Edge.A.X + Edge.A.Width / 2 + Edge.B.X + Edge.B.Width / 2) / 2.0); DY = (int)((float)(Edge.A.Y + Edge.A.Height / 2 + Edge.B.Y + Edge.B.Height / 2) / 2.0);
                    DistanceX = 6; DistanceY = -21; if (((float)(Edge.A.X - Edge.B.X) / 2.0) < 84 & (float)((Edge.A.Y - Edge.B.Y) / 2.0) < 30) DistanceX -= (int)(84 - (float)(Edge.A.X - Edge.B.X) / 2.0);
                }
            }

            Grap_Main.FillEllipse(new SolidBrush(Main.BackColor), DX + DistanceX, DY + DistanceY, 46, 18);
            Grap_Main.DrawString($"{Edge.Size:00000}", new Font("Times New Roman", 12), new SolidBrush(Color.Black), DX + DistanceX, DY + DistanceY);
            Grap_Main.DrawLine(new Pen(Color.Black, 1), new Point(DX, DY), new Point(DX + DistanceX, DY + DistanceY + 9));
            Grap_Main.DrawRectangle(new Pen(Color.Black, 1), DX + DistanceX, DY + DistanceY, 46, 18);

            Main.Image = BM_Main;
        }

        /// <summary> Метод. Полная прорисовка всех вершин и ребер </summary>
        public static void FullDrawing(PictureBox Main, List<Vertexes> List_Vertexes, List<Edges> List_Edges)
        { Bitmap BM_Map = new Bitmap(Main.Width, Main.Height); Main.Image = BM_Map; foreach (Vertexes Vertex in List_Vertexes) Draw.Vertex(Main, Vertex, Color.Black); foreach (Edges Edge in List_Edges) Draw.Edge(Main, Edge); }
    }
}