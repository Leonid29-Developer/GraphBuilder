using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphBuilder
{
    /// <summary> Инструменты и краски </summary>
    public class Paints
    {
        public static Pen Pen(Color color) { Pen Pen_Color = new Pen(color); return Pen_Color; }
        public static Brush Brush(Color color) { Brush Brush_Color = new SolidBrush(color); return Brush_Color; }
    }

    public static class Draw
    {
        /// <summary> Метод. Создания изображения вершины с отрисовкой имени </summary>
        public static void Vertex(PictureBox Main, Vertexes Vertex)
        {
            Bitmap BM_Main = new Bitmap(Main.Image); Graphics Grap_Main = Graphics.FromImage(BM_Main);
            
            Bitmap BM_Vertex = new Bitmap(Vertex.Width, Vertex.Height); Graphics Grap_Vertex = Graphics.FromImage(BM_Vertex);

            Grap_Vertex.DrawEllipse( new Pen(Color.Black,2), 0,0,Vertex.Width-3,Vertex.Height-3);
            int Inaccuracy = -1; if (Vertex.Name.Length <2) Inaccuracy = 2;
            Grap_Vertex.DrawString(Vertex.Name, new Font("Times New Roman", 12), Paints.Brush(Color.Black), Vertex.Width/3+ Inaccuracy, Vertex.Height/ 3);

            RF_BM(Grap_Main, BM_Vertex,"None",Vertex.X,Vertex.Y); Main.Image = BM_Main;
        }

        /// <summary> Метод. Отзеркаливание или переворот изображения и наложение его на интерфейс </summary>
        private static void RF_BM(Graphics Source, Bitmap Appended, string Flip, float PositionX, float PositionY)
        {
            switch (Flip)
            {
                case "None": for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = 0; I2 < Appended.Width; I2++) { Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1)); Source.FillRectangle(Brush_Color, PositionX + I2, PositionY + I1, 1, 1); } break;

                case "FlipX": for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = Appended.Width - 1; I2 >= 0; I2--) { Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1)); Source.FillRectangle(Brush_Color, PositionX + (Appended.Width - 1 - I2), PositionY + I1, 1, 1); } break;
            }
        }
    }
}
