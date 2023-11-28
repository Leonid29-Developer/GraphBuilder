using System.Collections.Generic;
using System.Drawing;

namespace GraphBuilder
{
    public class Vertexes
    {
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Vertexes(string NewName, int NewX, int NewY, int NewWidth, int NewHeight) { Name = NewName; X = NewX; Y = NewY; Width = NewWidth; Height = NewHeight; }

        public static void RecalculatingNames(List<Vertexes> List_Vertexes) { for (int i = 0; i < List_Vertexes.Count; i++) List_Vertexes[i].Name = (i + 1).ToString(); }
    }

    public class Edges
    {
        public Vertexes A { get; private set; }
        public Vertexes B { get; private set; }
        public int Size { get; private set; }
        public Point Distortion { get; private set; }

        public Edges(Vertexes NewA, Vertexes NewB) { A = NewA; B = NewB; Size = 0; Distortion = new Point(0, 0); }

        public void ReSize(int NewSize) => Size = NewSize;

        public void SetDistortion(Point NewDistortion) => Distortion = NewDistortion;
    }
}