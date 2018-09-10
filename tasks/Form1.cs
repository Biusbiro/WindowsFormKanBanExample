using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listTodo = new ListViewItem(inpTodo.Text);
            lstTodo.Items.Add(listTodo);
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            ListViewItem listDoing = new ListViewItem(inpDoing.Text);
            lstDoing.Items.Add(listDoing);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ListViewItem listDone = new ListViewItem(inpDone.Text);
            lstDone.Items.Add(listDone);
        }

        private void btnTodoToDoing_Click(object sender, EventArgs e)
        {
            

            foreach (ListViewItem listTodo in lstTodo.SelectedItems)
            {
                ListViewItem listDoing = new ListViewItem(listTodo.Text);
                lstDoing.Items.Add(listDoing);
                listTodo.Remove();
            }
        }

        private void btnTodoToDone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listTodo in lstTodo.SelectedItems)
            {
                ListViewItem listDone = new ListViewItem(listTodo.Text);
                lstDone.Items.Add(listDone);
                listTodo.Remove();
            }
        }

        private void btnDoingToTodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listDoing in lstDoing.SelectedItems)
            {
                ListViewItem listTodo = new ListViewItem(listDoing.Text);
                lstTodo.Items.Add(listTodo);
                listDoing.Remove();
            }
        }

        private void btnDoingToDone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listDoing in lstDoing.SelectedItems)
            {
                ListViewItem listDone = new ListViewItem(listDoing.Text);
                lstDone.Items.Add(listDone);
                listDoing.Remove();
            }
        }

        private void btnDoneToTodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listDone in lstDone.SelectedItems)
            {
                ListViewItem listTodo = new ListViewItem(listDone.Text);
                lstTodo.Items.Add(listTodo);
                listDone.Remove();
            }
        }

        private void btnDoneToDoing_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listDone in lstDone.SelectedItems)
            {
                ListViewItem listDoing = new ListViewItem(listDone.Text);
                lstDoing.Items.Add(listDoing);
                listDone.Remove();
            }
        }
    }
}
