using Algorithm;
using Algorithm_DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private List<SortedItem> items = new List<SortedItem>();
        private const int sleep = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();

            addTextBox.Text = "";
        }

        private void fillNumbers_Click(object sender, EventArgs e)
        {
            if (int.TryParse(fillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }

            RefreshItems();

            fillTextBox.Text = "";
        }
        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();
            panel3.Refresh();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            panel3.Refresh();
        }
        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void AlgorithmSwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aqua);
            e.Item2.SetColor(Color.Brown);
            panel3.Refresh();

            Thread.Sleep(sleep);

            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }


        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwapEvent += AlgorithmSwapEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();

            TimeLbl.Text = "Time: " + time.Seconds;
            SwapLbl.Text = "Number of Swaps: " + algorithm.SwapCount;
            CompareLbl.Text = "Number of Compares: " + algorithm.ComparisonCount;
        }

        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
        }

        private void CocktailSortBtn_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }

        private void InsertionSortBtn_Click(object sender, EventArgs e)
        {
            var insertion = new InsertionSort<SortedItem>(items);
            BtnClick(insertion);
        }

        private void ShellSortBtn_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void SelectionSortBtn_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnClick(selection);
        }

        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            BtnClick(heap);
        }

        private void GnomeSortBtn_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            BtnClick(gnome);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);
            BtnClick(tree);
        }

        private void LsdRadixSortBtn_Click(object sender, EventArgs e)
        {
            var lsdRadix = new LsdRadixSort<SortedItem>(items);
            BtnClick(lsdRadix);
        }

        private void MsdRadixSortBtn_Click(object sender, EventArgs e)
        {
            var msdRadix = new LsdRadixSort<SortedItem>(items);
            BtnClick(msdRadix);
        }

        private void MergeSortBtn_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            BtnClick(merge);
        }
    }
}
