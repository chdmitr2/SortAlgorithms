using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private List<SortedItem> items = new List<SortedItem>();
        private const int sleep = 50;
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

       
    }
}
