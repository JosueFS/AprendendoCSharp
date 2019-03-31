using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ESTAGIO
{
    public partial class MainForm : Form
    {
        public static int qtdTimes;
        public static List<Times> ListaTimes = new List<Times>();
        public static List<List<Jogos>> rodadas = new List<List<Jogos>>();

        public MainForm()
        {
            
            InitializeComponent();
            //MessageBox.Show("" + qtdTimes);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Criando objeto para atribuir o link
            LinkLabel.Link url = new LinkLabel.Link();

            //Atribuindo valor ao link
            url.LinkData = "https://github.com/JosueFS/AprendendoCSharp";

            //Configurando o label do form para receber o link acima
            linkGit.Links.Add(url);

        }

        private void GerarTabela(object sender, EventArgs e)
        {
            LerTimes();
            if (checkShuffle.Checked)
            {
                ListaTimes.Shuffle();
            }
            rodadas = new Jogos().CriarJogos(rodadas, ListaTimes, checkShift.Checked);
            var t = new Tabela();
            t.Show();
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void btAddTime_Click(object sender, EventArgs e)
        {
            //Verifica se o cbUF.Text digitado está na lista, caso true, executa o bloco
            if (cbUF.FindStringExact(cbUF.Text) >= 0 && txtTime.Text != "" && txtTime.Text != null && cbUF.Text != null) {
                ListViewItem dadosTime = new ListViewItem(new[] { txtTime.Text, cbUF.Text });
                if (DuplicateItem(txtTime.Text, cbUF.Text))
                {
                    qtdTimes = ListaTimes != null ? ListaTimes.Count : 0;
                    lvTimes.Items.Add(dadosTime);
                    Select(true, true);
                }
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Verifique os dados inseridos.";
            }
        }

        private void btDelTime_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTimes.Items)
            {
                if (item.Selected && item.SubItems.Count > 0 )
                {
                    lvTimes.Items.Remove(item);
                    //int indexT = ListaTimes.FindIndex(x => x.Nome == item.SubItems[0].Text && x.Local == item.SubItems[1].Text);
                    //ListaTimes.RemoveAt(indexT);
                }
            }
            qtdTimes = ListaTimes.Count;
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
            foreach (ListViewItem item in lvTimes.Items)
            {
                if (item.Text == a && item.SubItems[1].Text == b) {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = ("Time já está na lista e não poderá ser incluído.");
                    return false;
                }
            }
            lblMsg.ForeColor = Color.DarkGreen;
            lblMsg.Text = ("Time adicionado com sucesso!");
            return true;
        }

        private void LerTimes()
        {
            foreach (ListViewItem t in lvTimes.Items)
            {
                ListaTimes.Add(new Times
                {
                    Nome = t.SubItems[0].Text,
                    Local = t.SubItems[1].Text
                });
            }
        }
    }
}
