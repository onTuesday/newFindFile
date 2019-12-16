using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FindFile;
using System.Threading;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public static bool stopThread = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void helpProvider1_Click()
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Result.result.Clear();
            //Client a = new Client();
            Form2.treeView1.Nodes.Clear();
            Client a = new Client();
            //Thread myThread = new Thread(new ThreadStart(WtiteTree));
            //myThread.Start();

            Thread th1 = new Thread(new ThreadStart(delegate
            {
                a.Find(Path.GetFullPath(textBox1.Text), textBox2.Text + "\n");
                stopThread = false;
                MessageBox.Show("Done \n", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
            th1.Priority = ThreadPriority.Highest;
            th1.IsBackground = true;
            th1.Start();

            //a.Find(Path.GetFullPath(textBox1.Text), textBox2.Text + "\n");
            while (stopThread == true)
            {
                Thread.Sleep(10000);
                foreach (string elem in Result.result)
                {
                    Form2.treeView1.BeginUpdate();

                    Form2.treeView1.Nodes.Add(elem);
                    Form2.treeView1.EndUpdate();
                }
                /*if (Form2.stop == true)
                {
                    break;
                }*/
            }
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет справка по работе программы \n" +
                "Введите путь - \n" +
                "Введите маску - \n", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На покушать нашей замечательной команде \n" +
                "Сбер :", "Поддержание команды разработчиков", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЗДЕСЬ МОГЛА БЫ БЫТЬ ВАША РЕКЛАМА \n" +
                "Контакты: Вайбер       - \n" +
                "                   Телеграмм - \n" +
                "                   Вк                - \n" +
                "                   Вотс            - \n", "Реклама", MessageBoxButtons.OK);
        }
    }
}