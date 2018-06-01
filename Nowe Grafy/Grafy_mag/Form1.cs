﻿using Grafy_mag.Models;
using Grafy_mag.Services;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using QuickGraph;
using SimpleGraph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Media;
using HamiltonianCircuit;
using Color = System.Windows.Media.Color;
using MessageBox = System.Windows.MessageBox;
using System.Drawing.Imaging;

namespace Grafy_mag
{
	public partial class Form1 : Form
	{
		public const int penalty = 1000;
		public const int functions = 3;
		public static string path = @"..\..\permutacje";

		private ZoomControl _zoomctrl;
		private GraphAreaGeneric _gArea;
		private int layer = 0;
		Random R = new Random();
		bool hideOtherEdges = false;
		public List<string[]>[] InputPermutations { get; private set; } = new List<string[]>[functions];
		public List<int>[] LackingEdges { get; private set; }
		public List<DataVertex> Vertices { get; private set; }

		public Form1()
		{
			InitializeComponent();
			InitData();

			Load += Form1_Load;
		}

        public static void UpdatePareto(List<Cycle> cycles, Population population, int[][][] perms)
        {
            foreach (var cycle in population.Cycles)
            {
                for (int i = 0; i < perms.GetLength(0); i++)
                {
                    if (cycles.Any(x => cycle.GetCost(perms[i]) < x.GetCost(perms[i])))
                    {
                        CleanPareto(cycles, cycle, perms);
                        cycles.Add(cycle);
                        break;
                    }
                }
            }
        }

        static void CleanPareto(List<Cycle> cycles, Cycle newCycle, int[][][] perms)
        {
            bool canStay = false;
            List<Cycle> toDelete = new List<Cycle>();

            for (int i = 0; i < cycles.Count; i++)
            {
                canStay = false;

                for (int j = 0; j < perms.GetLength(0); j++)
                {
                    if (cycles[i].GetCost(perms[j]) < newCycle.GetCost(perms[j]))
                    {
                        canStay = true;
                        break;
                    }
                }

                if (!canStay)
                {
                    toDelete.Add(cycles[i]);
                }
            }

            foreach (var item in toDelete)
            {
                cycles.Remove(item);
            }
        }

        void InitData()
		{

			DirectoryInfo d = new DirectoryInfo(path);
			FileInfo[] Files = d.GetFiles("*.csv");
			for (int i = 0; i < Files.Count(); i++)
			{
				InputPermutations[i] = new List<string[]>();
				using (var reader = new StreamReader(Files[i].FullName))
				{
					while (!reader.EndOfStream)
					{
						var line = reader.ReadLine();
						var values = line.Split(';');

						InputPermutations[i].Add(values);
					}
				}
			}
            if (Files.Count() == 0)
            {
                MessageBox.Show("No csv files foound!");
                labelPath.Text = "Choose correct directory";

            }
            else
            {
                labelPath.Text = "Path: " + path;

            }

        }
		private void ButtonDatasetLocation_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			using (var dialog = new FolderBrowserDialog())
			{

				DialogResult result = dialog.ShowDialog();
				if (result.ToString() == "OK")
				{
					path = dialog.SelectedPath.ToString();
					//DirectoryInfo d = new DirectoryInfo(path);
					//FileInfo[] Files = d.GetFiles("*.csv");
				}

			}
            labelPath.Text = "Path: " + path;

        }

        void Form1_Load(object sender, EventArgs e)
		{
			wpfHost.Child = GenerateWpfVisuals();
			_gArea.GenerateGraph(true);
			_gArea.SetVerticesDrag(true, true);
			_zoomctrl.ZoomToFill();
		}

		private UIElement GenerateWpfVisuals()
		{
			_zoomctrl = new ZoomControl();
			ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
			var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
			_gArea = new GraphAreaGeneric
			{
				//EnableWinFormsHostingMode = false,
				LogicCore = logic,
				EdgeLabelFactory = new DefaultEdgelabelFactory()
			};
			_gArea.ShowAllEdgesLabels(true);
			_gArea.SetEdgesDashStyle(EdgeDashStyle.Solid);
			_gArea.ShowAllEdgesArrows(false);

			logic.Graph = GenerateGraph();
			logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.LinLog;
			logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
			//((LinLogLayoutParameters)logic.DefaultLayoutAlgorithmParams). = 100;
			logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
			logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
			((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
			((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
			logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
			logic.AsyncAlgorithmCompute = false;
			_zoomctrl.Content = _gArea;

			_gArea.RelayoutFinished += gArea_RelayoutFinished;


			var myResourceDictionary = new ResourceDictionary { Source = new Uri("Templates\\template.xaml", UriKind.Relative) };
			_zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);

			return _zoomctrl;
		}

		void gArea_RelayoutFinished(object sender, EventArgs e)
		{
			_zoomctrl.ZoomToFill();
		}

		private GraphGeneric GenerateGraph()
		{
			Vertices = new List<DataVertex>();
			var dataGraph = new GraphGeneric();
			var nodeCount = InputPermutations[0].Count;
			var probability = Convert.ToDouble(txb_prob.Text, CultureInfo.InvariantCulture);

			LackingEdges = new List<int>[nodeCount];
			for (int i = 0; i < nodeCount; i++)
			{
				LackingEdges[i] = new List<int>();
				for (int j = 0; j < i; j++)
				{
					if (R.NextDouble() >= probability)
					{
						LackingEdges[j].Add(i);
					}
				}
			}

			int[][] permutationsMatrix = MakePermutationsMatrix(0);

			for (int i = 0; i < nodeCount; i++)
			{
				var dataVertex = new DataVertex(i.ToString());
				Vertices.Add(dataVertex);
				dataGraph.AddVertex(dataVertex);
			}

			for (int i = 0; i < nodeCount; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (permutationsMatrix[i][j] >= penalty)
					{
						dataGraph.AddEdge(new DataEdge(Vertices[j], Vertices[i], permutationsMatrix[i][j]) { EdgeColor = Colors.Red });
					}
					dataGraph.AddEdge(new DataEdge(Vertices[j], Vertices[i], permutationsMatrix[i][j]));
				}
			}

			return dataGraph;
		}

		int[][] MakePermutationsMatrix(int functionNum)
		{
			var nodeCount = InputPermutations[0].Count;
			int[][] permutationsMatrix = new int[nodeCount][];

			for (int i = 0; i < nodeCount; i++)
			{
				permutationsMatrix[i] = new int[i];
				for (int j = 0; j < i; j++)
				{
					if (LackingEdges[j].Count > 0 && LackingEdges[j].Contains(i))
					{
						permutationsMatrix[i][j] = penalty;
					}
					else
					{
						permutationsMatrix[i][j] = Convert.ToInt32(InputPermutations[functionNum][i][j]);
					}
				}
			}
			return permutationsMatrix;
		}

		private void TestTourney()
		{
			var pop = new Population(121, Vertices.Count);
			var split = pop.Split(3);
			var t1 = Tourney.Eliminate(split[0], MakePermutationsMatrix(0));
			var t2 = Tourney.Eliminate(split[1], MakePermutationsMatrix(1));
			var t3 = Tourney.Eliminate(split[2], MakePermutationsMatrix(2));
		}

		private void TestSplit()
		{
			var pop = new Population(120, Vertices.Count);
			var split = pop.Split(3);
		}

		private void TestMut()
		{
			int[][] cycles = new int[100][];
			List<Tuple<int, int[]>> mutated = new List<Tuple<int, int[]>>();
			for (int i = 0; i < 100; i++)
			{
				cycles[i] = Helper.GetRandomCycle(Vertices.Count);
				var mut = MutationNodeSwap.Mutation(new Models.Cycle() { Nodes = (int[])(cycles[i].Clone()) }, 0.5);
				if (!mut.Nodes.IsSame(cycles[i]))
				{
					mutated.Add(new Tuple<int, int[]>(i, mut.Nodes));
				}
			}
		}

		private void GenerateEdges()
		{
			_gArea.GenerateAllEdges();

			foreach (var item in _gArea.EdgesList)
			{
				item.Value.ShowLabel = item.Key.IsVisible;
				if (!item.Key.IsVisible)
				{
					item.Value.Visibility = Visibility.Hidden;
				}
				else
				{
					item.Value.Visibility = Visibility.Visible;
				}
			}

		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			DataEdge[] edges = new DataEdge[Vertices.Count];

			foreach (var item in _gArea.EdgesList)
			{
				if (!edges.Contains(item.Key))
				{
					if (item.Key.EdgeColor == Colors.Red)
					{
						item.Key.EdgeColor = Colors.Red;
					}
					else
					{
						item.Key.EdgeColor = changeEdgeColor(comboBox1.Text);
					}
				}
			}
			_gArea.GenerateAllEdges();

			TestMut();
			TestSplit();
			TestTourney();
		}

		public Color changeEdgeColor(string choice)
		{
			switch (choice)
			{
				case "Blue":
				return Colors.Blue;
				case "DarkGreen":
				return Colors.DarkGreen;
				case "Black":
				return Colors.Black;
				case "DarkViolet":
				return Colors.DarkViolet;
				case "Coral":
				return Colors.Coral;
				case "Gold":
				return Colors.Gold;
			}

			return Colors.Blue;
		}

		private void btn_generate_Click_1(object sender, EventArgs e)
		{
			InitData();
			_gArea.ClearLayout(true, true, false);
			_gArea.LogicCore.Graph.Clear();
			_gArea.LogicCore.Graph = GenerateGraph();
			_gArea.GenerateGraph(true);
			_gArea.SetVerticesDrag(true, true);
			_zoomctrl.ZoomToFill();

			comboBox1.SelectedItem = "Blue";
		}

		private void Btn_reload_Click(object sender, EventArgs e)
		{
			_gArea.RelayoutGraph();
		}

		private void btn_nxtWeights_Click(object sender, EventArgs e)
		{
			layer++;
			if (layer > functions - 1)
			{
				layer = 0;
			}
			lbl_weight_layer.Text = (layer + 1).ToString();
			int[][] weights = MakePermutationsMatrix(layer);

			DataEdge edge;
			for (int i = 0; i < Vertices.Count; i++)
			{
				for (int j = 0; j < i; j++)
				{
					_gArea.LogicCore.Graph.TryGetEdge(Vertices[j], Vertices[i], out edge);
					edge.Weight = weights[i][j];
				}
			}
			GenerateEdges();
		}

		private void Btn_start_Click_1(object sender, EventArgs e)
		{
            double mutationProbability = Convert.ToDouble(txb_mut_prob.Text, CultureInfo.InvariantCulture);
            int popCount = Convert.ToInt32(txb_pop_size.Text, CultureInfo.InvariantCulture);
            int iterations = Convert.ToInt32(txb_iter_count.Text, CultureInfo.InvariantCulture);

            var pop = new Population(popCount, Vertices.Count);
            int[][][] matrices = new int[functions][][];

            for (int i = 0; i < functions; i++)
            {
                matrices[i] = MakePermutationsMatrix(i);
            }

            List<Cycle> pareto = new List<Cycle>();
            Cycle[] bestCycles = new Cycle[functions];
            ListViewItem[][] sums = new ListViewItem[functions][];

            for (int k = 0; k < functions; k++)
            {
                pareto.Add(pop.GetBest(matrices[k]));
                bestCycles[k] = pop.GetBest(matrices[k]);

                sums[k] = new ListViewItem[iterations + 1];
                sums[k][0] = new ListViewItem();
                sums[k][0].Text = pop.Cycles.Sum(x => x.GetCost(matrices[k])).ToString();
            }

            for (int i = 1; i <= iterations; i++)
            {
                pop = GeneticIteration.Next(pop, functions, matrices, mutationProbability);
                UpdatePareto(pareto, pop, matrices);

                for (int k = 0; k < functions; k++)
                {
                    Cycle currentBest;
                    if ((currentBest = pop.GetBest(matrices[k])).GetCost(matrices[k]) < bestCycles[k].GetCost(matrices[k]))
                    {
                        bestCycles[k] = currentBest;
                    }

                    sums[k][i] = new ListViewItem();
                    sums[k][i].Text = pop.Cycles.Sum(x => x.GetCost(matrices[k])).ToString();
                }
            }

            List<ListViewCycle> paretoItems = new List<ListViewCycle>();

            foreach (var item in pareto)
            {
                paretoItems.Add(new ListViewCycle() { Cycle = item, Text = $"{item.GetCyclesString()} : {item.GetCost(matrices[0])};{item.GetCost(matrices[1])};{item.GetCost(matrices[2])}" });
            }

            listView4.Items.Clear();
            listView4.Items.AddRange(paretoItems.ToArray());

            label2.Text = bestCycles[0].GetCyclesString();
            label3.Text = bestCycles[0].GetCost(matrices[0]).ToString();

            label4.Text = bestCycles[1].GetCyclesString();
            label5.Text = bestCycles[1].GetCost(matrices[1]).ToString();

            label6.Text = bestCycles[2].GetCyclesString();
            label7.Text = bestCycles[2].GetCost(matrices[2]).ToString();

            listView1.Items.Clear();
            listView1.Items.AddRange(sums[0]);
            listView2.Items.Clear();
            listView2.Items.AddRange(sums[1]);
            listView3.Items.Clear();
            listView3.Items.AddRange(sums[2]);
        }

        private void btnHide_Click(object sender, EventArgs e)
		{
			hideOtherEdges = !hideOtherEdges;
			int[] cycle = Helper.GetRandomCycle(Vertices.Count);
			DataEdge[] edges = new DataEdge[Vertices.Count];
			DataEdge edge;
			Tuple<int, int> nodes;

			if (hideOtherEdges)
			{
				for (int i = 0; i < Vertices.Count - 1; i++)
				{
					nodes = Helper.OrderNodes(cycle[i], cycle[i + 1]);
					_gArea.LogicCore.Graph.TryGetEdge(Vertices[nodes.Item1], Vertices[nodes.Item2], out edge);
					edge.EdgeColor = Colors.Green;
					edges[i] = edge;
				}
				nodes = Helper.OrderNodes(cycle[0], cycle[Vertices.Count - 1]);
				_gArea.LogicCore.Graph.TryGetEdge(Vertices[nodes.Item1], Vertices[nodes.Item2], out edge);
				edge.EdgeColor = Colors.Green;
				edges[Vertices.Count - 1] = edge;

				_gArea.GenerateAllEdges();
			}

			foreach (var item in _gArea.EdgesList)
			{
				if (!edges.Contains(item.Key))
				{
					item.Value.ShowLabel = !hideOtherEdges;
					item.Key.IsVisible = !hideOtherEdges;
					if (item.Key.EdgeColor != Colors.Red)
					{
						item.Key.EdgeColor = changeEdgeColor(comboBox1.Text);
					}
					if (hideOtherEdges)
					{
						item.Value.Visibility = Visibility.Hidden;
					}
					else
					{
						item.Value.Visibility = Visibility.Visible;
					}
				}
			}

			TestMut();
			TestSplit();
			TestTourney();
		}

        private void roundButton2_Click(object sender, EventArgs e)
        {
            MainForm CycleHorm = new MainForm();
            CycleHorm.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\"+ Environment.UserName + @"\Desktop\HamiltonGrafy\Nowe Grafy\Grafy_mag\permutacje\file1.csv");
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(wpfHost.Width);
                int height = Convert.ToInt32(wpfHost.Height);
                Bitmap bmp = new Bitmap(width, height);
                wpfHost.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                visible();
            }
            else
            {
                unVisible();
            }
        }

        public void visible()
        {
            listView1.Visible = true;
            listView2.Visible = true;
            listView3.Visible = true;
            listView4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
        }

        public void unVisible()
        {
            listView1.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            unVisible();
        }
    }

    public class EdgeColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return new SolidColorBrush((System.Windows.Media.Color)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	public struct Edge
	{
		public int NodeFirst { get; set; }
		public int NodeSecond { get; set; }
		public int Weight { get; set; }

		public Edge(int nodeFirst, int nodeSecond, int weight)
		{
			if (nodeSecond < nodeFirst)
			{
				int t = nodeFirst;
				nodeFirst = nodeSecond;
				nodeSecond = t;
			}

			this.NodeFirst = nodeFirst;
			this.NodeSecond = nodeSecond;
			this.Weight = weight;
		}
	}

}
