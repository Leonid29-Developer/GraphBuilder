using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GraphBuilder
{
    public partial class ProgramBody : Form
    {
        public ProgramBody() => InitializeComponent();

        private int ToolsNumber = 1; private List<Vertexes> List_Vertexes = new List<Vertexes>();

        private void ProgramBody_Load(object sender, EventArgs e)
        {
            Bitmap BM_Map = new Bitmap(Main.Width, Main.Height); Main.Image = BM_Map;
        }

        private void SelectTools_Click(object sender, EventArgs e)
        { Panel Element = (Panel)sender; ToolsNumber = Convert.ToInt32(Element.Name[Element.Name.Length - 1]) -48; }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            switch (ToolsNumber)
            {
                case 2:
                    {
                        List_Vertexes.Add(new Vertexes((List_Vertexes.Count+1).ToString(), e.X, e.Y, 60, 60)); Draw.Vertex(Main, List_Vertexes[List_Vertexes.Count - 1]);
                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                case 6:
                    {

                    }
                    break;
                default:
                    {

                    }
                    break;
            }
        }

        private void Matrix_Adjacencies_Click(object sender, EventArgs e)
        {

        }

        private void Matrix_Weights_Click(object sender, EventArgs e)
        {

        }

        private void Path_Click(object sender, EventArgs e)
        {

        }

        private void Cycle_Click(object sender, EventArgs e)
        {

        }
        
        private void Save_Button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Load_Button_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
