using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Criando objeto para atribuir o link
            LinkLabel.Link url = new LinkLabel.Link();

            //Atribuindo valor ao link
            url.LinkData = "https://github.com/JosueFS/AprendendoCSharp";

            //Configurando o label do form para receber o link acima
            linkLabel1.Links.Add(url);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAddTime_Click(object sender, EventArgs e)
        {
            string time = txtTime.Text;
            string estado = comboBox1.Text;
            if (comboBox1.FindStringExact(estado) >= 0){
                ListViewItem times = new ListViewItem(new[] { time, estado });
                listView1.Items.Add(times);
                Select(true, true);
            }
        }

        private void btDelTime_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                if (item.Selected)
                    listView1.Items.Remove(item);
        }

        private void btAddTime_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys)e.KeyCode == Keys.Enter)
            {
                btAddTime_Click(sender, e);
            }
        }
    }
}
