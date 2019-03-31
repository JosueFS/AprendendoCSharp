using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTAGIO
{
    public partial class Tabela : MetroFramework.Forms.MetroForm
    {
        Elements elm = new Elements();

        public Tabela()
        {
            InitializeComponent();

            //foreach (var r in MainForm.rodadas) {
            //    tabPage1.Controls.Add(elm.NewLabel("Rodada " + r.GetEnumerator().Current, 200, 50, DockStyle.Top));
            //    foreach (var j in r) {
            //        tabPage1.Controls.Add(elm.NewLabel(j.Casa, 100, 50, DockStyle.Left));
            //        tabPage1.Controls.Add(elm.NewLabel(j.Fora, 100, 50, DockStyle.Left));
            //        tabPage1.Controls.Add(elm.NewLabel(j.Local, 100, 50, DockStyle.Left));
            //    }
            //}
        }

        // TODO: CLASSIFICAÇÃO DOS TIMES
        // TODO: CALCULO DOS PONTOS

        private void Tabela_Load(object sender, EventArgs e)
        {
            var dados = new Dados();
            dados.NewRound(tabPage1, MainForm.rodadas, tabPage1);
            dados.Rank(MainForm.ListaTimes, RankList, lblCampeao);
            
        }

        private void Tabela_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ListaTimes = new List<Times>();
            MainForm.rodadas = new List<List<Jogos>>();

            UnloadTabpage(tabPage1);
        }

        public static void UnloadTabpage(TabPage page)
        {
            Dados.PosX = 10;
            Dados.PosY = 10;
            while (page.Controls.Count > 0) page.Controls[0].Dispose();
        }
    }
}
