using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HamiltonianCircuit
{
    public partial class MainForm : Form
    {
        private bool generate = true;
        private int n, x, y, x1, y1, x2, y2;
        private Algorithm algo = new Algorithm();
        private Color[] colors =
            {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.Turquoise,
            Color.Violet,
            Color.Tan,
            Color.Plum,
            Color.Teal,
            Color.Yellow
            };
        private List<Edge> E, F;
        private List<Vertex> V;
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (generate)
                GenerateDraw(e.Graphics);

            else
                PathDraw(e.Graphics);
        }

        private void calculateXY(int id)
        {
            int Width = panel1.Width;
            int Height = panel1.Height;

            x = Width / 2 + (int)(Width * Math.Cos(2 * id * Math.PI / n) / 4.0);
            y = Height / 2 + (int)(Width * Math.Sin(2 * id * Math.PI / n) / 4.0);
        }

        private void PathDraw(Graphics g)
        {
            if (V != null)
            {
                GenerateDraw(g);

                int Width = panel1.Width;
                int Height = panel1.Height;
                Pen pen = new Pen(Color.Blue,2);

                n = V.Count;

                for (int i = 0; i < F.Count; i++)
                {
                    Vertex u = F[i].Lt, v = F[i].Rt;

                    calculateXY(u.Id);
                    x1 = x + (Width / 2) / n / 2;
                    y1 = y + (Width / 2) / n / 2;
                    calculateXY(v.Id);
                    x2 = x + (Width / 2) / n / 2;
                    y2 = y + (Width / 2) / n / 2;
                    g.DrawLine(pen, x1, y1, x2, y2);
                }

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];
                    SolidBrush brush = new SolidBrush(colors[u.Id]);

                    calculateXY(u.Id);
                    g.FillEllipse(brush, x, y, (Width / 2) / n, (Width / 2) / n);
                }
            }
        }

        private void GenerateDraw(Graphics g)
        {
            if (V != null)
            {
                int Width = panel1.Width;
                int Height = panel1.Height;
                Pen pen = new Pen(Color.Black);

                n = V.Count;

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];

                    calculateXY(u.Id);
                    x1 = x + (Width / 2) / n / 2;
                    y1 = y + (Width / 2) / n / 2;

                    if (u.Edges != null)
                    {
                        for (int j = 0; j < u.Edges.Count; j++)
                        {
                            Vertex v = u.Edges[j].Rt;

                            calculateXY(v.Id);
                            x2 = x + (Width / 2) / n / 2;
                            y2 = y + (Width / 2) / n / 2;
                            g.DrawLine(pen, x1, y1, x2, y2);
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Vertex u = V[i];
                    SolidBrush brush = new SolidBrush(colors[u.Id]);

                    calculateXY(u.Id);
                    g.FillEllipse(brush, x, y, (Width / 2) / n, (Width / 2) / n);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate = true;
            button2.Enabled = true;

            int numVers = (int)numericUpDown1.Value;

            E = new List<Edge>();
            V = new List<Vertex>();

            for (int i = 0; i < numVers; i++)
            {
                Vertex v = new Vertex(i);

                v.Edges = new List<Edge>();
                V.Add(v);
            }

            for (int i = 0; i < numVers; i++)
            {
                int numEdges = random.Next(numVers - 1);

                while (numEdges < 2)
                    numEdges = random.Next(numVers - 1);

                Vertex v = V[i];

                for (int j = 0; j < numEdges; j++)
                {
                    int id = random.Next(numVers);
                    int wt = random.Next(100);
                    Edge edge;

                    while (wt < 10)
                        wt = random.Next(100);

                    while (id == v.Id)
                        id = random.Next(numVers);

                    edge = new Edge(v, V[id], wt);

                    if (!edge.InList(E))
                        E.Add(edge);

                    edge = new Edge(V[id], v, wt);

                    if (!edge.InList(E))
                        E.Add(edge);
                }
            }

            for (int i = 0; i < E.Count; i++)
            {
                Vertex u = E[i].Lt, v = E[i].Rt;

                u.Edges.Add(new Edge(u, v, E[i].Wt));
                v.Edges.Add(new Edge(v, u, E[i].Wt));
            }

            for (int i = 0; i < V.Count; i++)
            {
                if (V[i].Edges.Count == 0)
                {
                    MessageBox.Show("Generate a new graph", "Warning Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            textBox1.Text = string.Empty;
            textBox1.Text = "Edges(u, v)\r\n";
            textBox1.Text += " u  v wt\r\n";

            for (int i = 0; i < E.Count; i++)
            {
                textBox1.Text += E[i].Lt.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += E[i].Rt.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += E[i].Wt.ToString().PadLeft(2) + "\r\n";
            }

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generate = false;

            Algorithm algo = new Algorithm();

            int n = V.Count;
            bool[,] graph = new bool[n, n];
            int[] ipath;

            for (int i = 0; i < E.Count; i++)
            {
                Edge edge = E[i];
                Vertex u = edge.Lt, v = edge.Rt;

                graph[u.Id, v.Id] = true;
            }

            if (!algo.HamCycle(graph, n, out ipath))
            {
                MessageBox.Show("No Hamilton circuit exists", "Warning Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox1.Text += "\r\n";
            textBox1.Text += "Edges(u, v)\r\n";
            textBox1.Text += " u  v wt\r\n";

            Vertex[] path = new Vertex[n];
            int tcost = 0;

            F = new List<Edge>();

            for (int i = 0; i < n - 1; i++)
            {
                Vertex u = V[ipath[i]], v = V[ipath[i + 1]];
                Edge edge = new Edge(u, v, 0);

                for (int j = 0; j < E.Count; j++)
                {
                    if (edge.Lt == E[j].Lt && edge.Rt == E[j].Rt)
                    {
                        edge.Wt = E[j].Wt;
                        tcost += edge.Wt;
                        break;
                    }
                }

                F.Add(edge);
                textBox1.Text += u.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += v.Id.ToString().PadLeft(2) + " ";
                textBox1.Text += edge.Wt.ToString().PadLeft(2) + "\r\n";
            }

            Vertex up = V[ipath[n - 1]], vp = V[0];

            Edge edgep = new Edge(up, vp, 0);

            for (int j = 0; j < E.Count; j++)
            {
                if (edgep.Lt == E[j].Lt && edgep.Rt == E[j].Rt)
                {
                    edgep.Wt = E[j].Wt;
                    tcost += edgep.Wt;
                    break;
                }
            }

            F.Add(edgep);
            textBox1.Text += up.Id.ToString().PadLeft(2) + " ";
            textBox1.Text += vp.Id.ToString().PadLeft(2) + " ";
            textBox1.Text += edgep.Wt.ToString().PadLeft(2) + "\r\n";

            textBox1.Text += "Cost = " + tcost + "\r\n";
            panel1.Invalidate();
        }
    }
}