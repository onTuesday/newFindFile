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
using System.IO;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public static List<string> WriteTreeList = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            bool endForeach = false;
            lock (Program.locker)
            {
                foreach (string elem in Result.result)
                {
                    endForeach = false;
                    for (int i = WriteTreeList.Count - 1; i >= 0; i--)
                    {
                        if (WriteTreeList[i] == elem)
                        {
                            endForeach = true;
                            break;
                        }
                    }
                    if (endForeach)
                    {
                        continue;
                    }
                    treeView1.BeginUpdate();
                    treeView1.Nodes.Add(elem);
                    treeView1.EndUpdate();
                    WriteTreeList.Add(elem);
                }
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
