using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphBuilder
{
    public partial class ProgramBody : Form
    {
        public ProgramBody() => InitializeComponent();

        private int ToolsNumber = 1; private Vertexes TemporaryAdd, TemporaryUpdate, TemporaryRemove;
        private List<Vertexes> List_Vertexes { get; set; }
        private List<Edges> List_Edges { get; set; }

        private void ProgramBody_Load(object sender, EventArgs e)
        {
            Save_Button.Location = Load_Button.Location; Load_Button.Visible = false;

            List_Vertexes = new List<Vertexes>(); List_Edges = new List<Edges>();

            Bitmap BM_Map = new Bitmap(Main.Width, Main.Height); Main.Image = BM_Map;
        }

        /// <summary> Метод. Обработка нажатия на Panel - Иконки инструментов </summary>
        private void SelectTools_Click(object sender, EventArgs e)
        {
            foreach (var Elements in this.Controls) if (Elements.GetType().ToString() == "System.Windows.Forms.Panel") { Panel Paneli = (Panel)Elements; if (Paneli.Name.Contains("Tool")) Paneli.BackColor = SystemColors.Control; }
            Panel Element = (Panel)sender; ToolsNumber = Convert.ToInt32(Element.Name[Element.Name.Length - 1]) - 48; Element.BackColor = SystemColors.ScrollBar;
        }

        /// <summary> Метод. Обработка нажатия мышки на PictureBox </summary>
        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            switch (ToolsNumber)
            {
                case 2: // Инструмент 2. Создание вершин
                    {
                        bool T = true; bool[] Ti = { true, true, true, true }; int Distance = 60;

                        foreach (Vertexes Vertex in List_Vertexes)
                        {
                            if ((Vertex.X - Distance <= e.X & e.X <= Vertex.X + Vertex.Width + Distance) & (Vertex.Y - Distance <= e.Y & e.Y <= Vertex.Y + Vertex.Height + Distance)) { T = false; Ti[0] = false; }
                            if ((Vertex.X - Distance <= e.X + Vertex.Width & e.X + Vertex.Width <= Vertex.X + Vertex.Width + Distance) & (Vertex.Y - Distance <= e.Y & e.Y <= Vertex.Y + Vertex.Height + Distance)) { T = false; Ti[1] = false; }
                            if ((Vertex.X - Distance <= e.X & e.X <= Vertex.X + Vertex.Width + Distance) & (Vertex.Y - Distance <= e.Y + Vertex.Height & e.Y + Vertex.Height <= Vertex.Y + Vertex.Height + Distance)) { T = false; Ti[2] = false; }
                            if ((Vertex.X - Distance <= e.X + Vertex.Width & e.X + Vertex.Width <= Vertex.X + Vertex.Width + Distance) & (Vertex.Y - Distance <= e.Y + Vertex.Height & e.Y + Vertex.Height <= Vertex.Y + Vertex.Height + Distance)) { T = false; Ti[3] = false; }
                        }

                        if (T) List_Vertexes.Add(new Vertexes((List_Vertexes.Count + 1).ToString(), e.X, e.Y, 60, 60)); Draw.Vertex(Main, List_Vertexes[List_Vertexes.Count - 1], Color.Black);
                    }
                    break;

                case 3: // Инструмент 3. Создание ребер между выбранными вершинами
                    {
                        foreach (Vertexes Vertex in List_Vertexes) if ((Vertex.X <= e.X & e.X <= Vertex.X + Vertex.Width) & (Vertex.Y <= e.Y & e.Y <= Vertex.Y + Vertex.Height))
                            {
                                if (TemporaryAdd == null) { TemporaryAdd = Vertex; Draw.Vertex(Main, TemporaryAdd, Color.Green); }
                                else if (Vertex == TemporaryAdd) { Draw.Vertex(Main, TemporaryAdd, Color.Black); TemporaryAdd = null; DrawTemporary(); }
                                else if (Vertex != TemporaryAdd) { List_Edges.Add(new Edges(TemporaryAdd, Vertex)); Draw.Edge(Main, List_Edges[List_Edges.Count - 1]); TemporaryAdd = null; DrawTemporary(); }
                            }
                    }
                    break;

                case 4: // Инструмент 4. Изменение размерности ребер между выбранными вершинами
                    {
                        foreach (Vertexes Vertex in List_Vertexes) if ((Vertex.X <= e.X & e.X <= Vertex.X + Vertex.Width) & (Vertex.Y <= e.Y & e.Y <= Vertex.Y + Vertex.Height))
                            {
                                if (TemporaryUpdate == null) { TemporaryUpdate = Vertex; Draw.Vertex(Main, TemporaryUpdate, Color.Gold); }
                                else if (Vertex == TemporaryUpdate) { Draw.Vertex(Main, TemporaryUpdate, Color.Black); TemporaryUpdate = null; DrawTemporary(); }
                                else if (Vertex != TemporaryUpdate) foreach (Edges Edge in List_Edges) if ((Edge.A == TemporaryUpdate & Edge.B == Vertex) | (Edge.A == Vertex & Edge.B == TemporaryUpdate))
                                        { EdgesResize.Sized = Edge.Size; new EdgesResize().ShowDialog(); Edge.ReSize(EdgesResize.Sized); Draw.Edge(Main, Edge); TemporaryUpdate = null; DrawTemporary(); }

                            }
                    }
                    break;

                case 5: // Инструмент 5. Удаление выбранных ребер между выбранными вершинами
                    {

                        foreach (Vertexes Vertex in List_Vertexes) if ((Vertex.X <= e.X & e.X <= Vertex.X + Vertex.Width) & (Vertex.Y <= e.Y & e.Y <= Vertex.Y + Vertex.Height))
                            {
                                if (TemporaryRemove == null) { TemporaryRemove = Vertex; Draw.Vertex(Main, TemporaryRemove, Color.Red); }
                                else if (Vertex == TemporaryRemove) { Draw.Vertex(Main, TemporaryRemove, Color.Black); TemporaryRemove = null; DrawTemporary(); }
                                else if (Vertex != TemporaryRemove) if (MessageBox.Show("Уверены, что хотите удалить выбранное ребро?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                        for (int i = 0; i < List_Edges.Count; i++) if ((List_Edges[i].A == TemporaryRemove & List_Edges[i].B == Vertex) | (List_Edges[i].A == Vertex & List_Edges[i].B == TemporaryRemove))
                                            { List_Edges.Remove(List_Edges[i]); TemporaryRemove = null; Draw.FullDrawing(Main, List_Vertexes, List_Edges); DrawTemporary(); break; }

                            }
                    }
                    break;

                case 6: // Инструмент 6. Удаление выбранных вершин
                    {
                        for (int i = 0; i < List_Vertexes.Count; i++) if ((List_Vertexes[i].X <= e.X & e.X <= List_Vertexes[i].X + List_Vertexes[i].Width) & (List_Vertexes[i].Y <= e.Y & e.Y <= List_Vertexes[i].Y + List_Vertexes[i].Height))
                            {
                                Draw.Vertex(Main, List_Vertexes[i], Color.Red);
                                if (MessageBox.Show("Уверены, что хотите удалить выбранную вершину?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    for (int j = 0; j < List_Edges.Count; j++) if (List_Edges[j].A == List_Vertexes[i] | List_Edges[j].B == List_Vertexes[i]) { List_Edges.Remove(List_Edges[j]); j--; }
                                    if (TemporaryAdd == List_Vertexes[i]) TemporaryAdd = null; if (TemporaryUpdate == List_Vertexes[i]) TemporaryUpdate = null; if (TemporaryRemove == List_Vertexes[i]) TemporaryRemove = null;
                                    List_Vertexes.Remove(List_Vertexes[i]); Vertexes.RecalculatingNames(List_Vertexes); Draw.FullDrawing(Main, List_Vertexes, List_Edges); DrawTemporary(); break;
                                }
                            }
                    }
                    break;

                default: break;
            }
        }

        private void DrawTemporary()
        { if (TemporaryAdd != null) Draw.Vertex(Main, TemporaryAdd, Color.Green); if (TemporaryUpdate != null) Draw.Vertex(Main, TemporaryUpdate, Color.Gold); if (TemporaryRemove != null) Draw.Vertex(Main, TemporaryRemove, Color.Red); }

        /// <summary> Инструмент 7. Удаление всех вершин и ребер </summary>
        private void Tool7_Click(object sender, EventArgs e) => ProgramBody_Load(sender, e);

        /// <summary> Метод. Сохранение графа в формате Image </summary>
        private void Save_Button_Paint(object sender, PaintEventArgs e) { }

        /// <summary> Метод. Чтение графа из формата Image </summary> 
        private void Load_Button_Paint(object sender, PaintEventArgs e) { } // Не реализовано

        private void Matrix_Adjacencies_Click(object sender, EventArgs e)
        {
            OutputWindow.Items.Clear(); int[,] Matrix_Adjacencies = new int[List_Vertexes.Count, List_Vertexes.Count]; string Out = "| x |";

            for (int I1 = 0; I1 < Matrix_Adjacencies.GetLength(0); I1++) for (int I2 = 0; I2 < Matrix_Adjacencies.GetLength(1); I2++) Matrix_Adjacencies[I1, I2] = 0;

            for (int I1 = 0; I1 < List_Edges.Count; I1++)
            { Matrix_Adjacencies[Convert.ToInt32(List_Edges[I1].A.Name) - 1, Convert.ToInt32(List_Edges[I1].B.Name) - 1] = 1; Matrix_Adjacencies[Convert.ToInt32(List_Edges[I1].B.Name) - 1, Convert.ToInt32(List_Edges[I1].A.Name) - 1] = 1; }

            for (int I1 = -1; I1 < Matrix_Adjacencies.GetLength(0); I1++)
            {
                if (I1 == -1) { for (int I2 = 0; I2 < List_Vertexes.Count; I2++) Out += $" | {I2 + 1} |"; OutputWindow.Items.Add(Out); }
                else { Out = $"| {I1 + 1} |"; for (int I2 = 0; I2 < Matrix_Adjacencies.GetLength(1); I2++) Out += $" | {Matrix_Adjacencies[I1, I2]} |"; OutputWindow.Items.Add(Out); }
            }
        }

        private void Matrix_Weights_Click(object sender, EventArgs e)
        {
            OutputWindow.Items.Clear(); int[,] Matrix_Weights = new int[List_Vertexes.Count, List_Edges.Count]; string Out = "| x |";

            for (int I1 = 0; I1 < Matrix_Weights.GetLength(0); I1++) for (int I2 = 0; I2 < Matrix_Weights.GetLength(1); I2++) Matrix_Weights[I1, I2] = 0;

            for (int I1 = 0; I1 < List_Edges.Count; I1++) { Matrix_Weights[Convert.ToInt32(List_Edges[I1].A.Name) - 1, I1] = 1; Matrix_Weights[Convert.ToInt32(List_Edges[I1].B.Name) - 1, I1] = 1; }

            for (int I1 = -1; I1 < Matrix_Weights.GetLength(0); I1++)
            {
                if (I1 == -1) { for (int I2 = 0; I2 < List_Edges.Count; I2++) Out += $" | {I2 + 1} |"; OutputWindow.Items.Add(Out); }
                else { Out = $"| {I1 + 1} |"; for (int I2 = 0; I2 < Matrix_Weights.GetLength(1); I2++) Out += $" | {Matrix_Weights[I1, I2]} |"; OutputWindow.Items.Add(Out); }
            }
        }

        private void Path_Click(object sender, EventArgs e)
        {
            OutputWindow.Items.Clear(); int[] Path = new int[List_Vertexes.Count];

            for (int I1 = 0; I1 < Path.Length; I1++) { for (int I2 = I1 + 1; I2 < Path.Length; I2++) { for (int I3 = 0; I3 < Path.Length; I3++) Path[I3] = 1; Path_P(I1, I2, Path, $"{I1 + 1}"); } }
        }

        private void Path_P(int I1, int I2, int[] Path, string Out)
        {
            if (I1 != I2) Path[I1] = 2; else { OutputWindow.Items.Add(Out); return; }

            for (int I4 = 0; I4 < List_Edges.Count; I4++)
            {
                if (Path[Convert.ToInt32(List_Edges[I4].B.Name) - 1] == 1 & (Convert.ToInt32(List_Edges[I4].A.Name) - 1) == I1)
                { Path_P(Convert.ToInt32(List_Edges[I4].B.Name) - 1, I2, Path, $"{Out}-{Convert.ToInt32(List_Edges[I4].B.Name)}"); Path[Convert.ToInt32(List_Edges[I4].B.Name) - 1] = 1; }
                else if (Path[Convert.ToInt32(List_Edges[I4].A.Name) - 1] == 1 & (Convert.ToInt32(List_Edges[I4].B.Name) - 1) == I1)
                { Path_P(Convert.ToInt32(List_Edges[I4].A.Name) - 1, I2, Path, $"{Out}-{Convert.ToInt32(List_Edges[I4].A.Name)}"); Path[Convert.ToInt32(List_Edges[I4].A.Name) - 1] = 1; }
            }
        }

        private void Cycle_Click(object sender, EventArgs e)
        {
            OutputWindow.Items.Clear(); int[] Path = new int[List_Vertexes.Count];

            for (int I1 = 0; I1 < Path.Length; I1++) { for (int I2 = 0; I2 < Path.Length; I2++) Path[I2] = 1; List<int> Cycle = new List<int>(); Cycle.Add(I1 + 1); Cycle_P(I1, I1, Path, -1, Cycle); }
        }

        private void Cycle_P(int I1, int I2, int[] Path, int UnavailableEdge, List<int> Cycle)
        {
            if (I1 != I2) Path[I1] = 2;
            else if (Cycle.Count >= 2)
            {
                Cycle.Reverse(); string Out = Cycle[0].ToString();
                for (int I3 = 1; I3 < Cycle.Count; I3++) Out += $"-{Cycle[I3]}"; bool Flag = false;
                for (int I3 = 1; I3 < OutputWindow.Items.Count; I3++) if (OutputWindow.Items[I3].ToString() == Out) { Flag = true; break; }
                if (!Flag) { Cycle.Reverse(); Out = Cycle[0].ToString(); for (int I3 = 1; I3 < Cycle.Count; I3++) Out += $"-{Cycle[I3]}"; OutputWindow.Items.Add(Out); }
                return;
            }
            for (int I3 = 0; I3 < List_Edges.Count; I3++)
            {
                if (I3 == UnavailableEdge) continue;
                if (Path[Convert.ToInt32(List_Edges[I3].B.Name) - 1] == 1 & Convert.ToInt32(List_Edges[I3].A.Name) - 1 == I1)
                {
                    List<int> CycleNew = new List<int>(Cycle);
                    CycleNew.Add(Convert.ToInt32(List_Edges[I3].B.Name));
                    Cycle_P(Convert.ToInt32(List_Edges[I3].B.Name) - 1, I2, Path, I3, CycleNew); Path[Convert.ToInt32(List_Edges[I3].B.Name) - 1] = 1;
                }
                else if (Path[Convert.ToInt32(List_Edges[I3].A.Name) - 1] == 1 & Convert.ToInt32(List_Edges[I3].B.Name) - 1 == I1)
                {
                    List<int> CycleNew = new List<int>(Cycle);
                    CycleNew.Add(Convert.ToInt32(List_Edges[I3].A.Name));
                    Cycle_P(Convert.ToInt32(List_Edges[I3].A.Name) - 1, I2, Path, I3, CycleNew); Path[Convert.ToInt32(List_Edges[I3].A.Name) - 1] = 1;
                }
            }
        }
    }
}