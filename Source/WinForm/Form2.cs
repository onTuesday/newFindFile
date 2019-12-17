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

        public void button2_Click(object sender, EventArgs e)
        {
            foreach (string elem in Result.result)
            {
                treeView1.BeginUpdate();
                treeView1.Nodes.Add(elem);
                treeView1.EndUpdate();

                lock (Result.result)
                {
                    Result.result.Remove(elem); 
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
