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
            //Captura os time digitado e o estado selecionado
            string time = txtTime.Text;
            string estado = comboBox1.Text;

            //Verifica se o estado digitado está na lista, caso true, executa o bloco
            if (comboBox1.FindStringExact(estado) >= 0 && time != null && estado != null) {
                ListViewItem dadosTime = new ListViewItem(new[] { time, estado });
                if (DuplicateItem(time, estado))
                {
                    listView1.Items.Add(dadosTime);
                    Select(true, true);
                }
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Verifique os dados inseridos.";
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
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                btAddTime_Click(sender, e);
            }
        }

        //Função para verificar se o time já está na lista
        private bool DuplicateItem(string a, string b) {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == a && item.SubItems[1].Text == b) {
                    label4.ForeColor = Color.Red;
                    label4.Text = ("Time já está na lista e não poderá ser incluído.");
                    return false;
                }
            }
            label4.ForeColor = Color.DarkGreen;
            label4.Text = ("Time adicionado com sucesso!");
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
