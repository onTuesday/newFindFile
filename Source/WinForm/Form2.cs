using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindFile;
using System.Diagnostics;
using System.Threading;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lock (Result.result);
            foreach (string elem in Result.result)
            {
                treeView1.BeginUpdate();
                treeView1.Nodes.Add(elem);
                Result.result.Remove(elem);
                treeView1.EndUpdate();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Process.Start(treeView1.SelectedNode.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.isWorking = false;
        }
    }
}
