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
    }
}