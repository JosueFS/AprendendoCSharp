using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01
{
    public class Dados
    {
        
        public static int PosX { get; set; } = 10;
        public static int PosY { get; set; } = 10;

        //public Label NewLabel(string text, int w, int h, DockStyle d)
        public void NewRound(TabPage tb, List<List<Jogos>> j, TabPage page)
        {
            PosX = 10;
            PosY = 10;
            while (page.Controls.Count > 0) page.Controls[0].Dispose();

            int index = 1;
            foreach (var sublist in j ) {
                var lblRodada = new Label();

                lblRodada.Text = "Rodada " + index;
                lblRodada.Left = PosX;
                lblRodada.Top = PosY;
                PosY += 20;
                foreach (var jogo in sublist) {
                    var lblCasa = new Label();
                    var lblFora = new Label();
                    var lblLocal = new Label();
                    var lblPlacar = new Label();

                    //Dados de cada jogo em Labels
                    lblCasa.Text = jogo.Casa;
                    lblPlacar.Text = jogo.GolsCasa.ToString() + " X " + jogo.GolsFora.ToString();
                    lblFora.Text = jogo.Fora;
                    lblLocal.Text = jogo.Local;

                    //Posicionando os Labels
                    lblCasa.Left = PosX;
                    lblCasa.Top = PosY;
                    PosX += 100; 

                    lblPlacar.Left = PosX;
                    lblPlacar.Top = PosY;
                    PosX += 100;

                    lblFora.Left = PosX;
                    lblFora.Top = PosY;
                    PosX -= 100;
                    PosY += 20;

                    lblLocal.Left = PosX;
                    lblLocal.Top = PosY;
                    

                    //Ajuste para iteração
                    PosX = 10;
                    PosY += 30;

                    tb.Controls.Add(lblRodada);
                    tb.Controls.Add(lblCasa);
                    tb.Controls.Add(lblPlacar);
                    tb.Controls.Add(lblFora);
                    tb.Controls.Add(lblLocal);
                }
                index++;
            }
        }

        //public void DesignJogos(Form f)
        //{
        //    var label = new Label();
        //    var textBox = new TextBox();
        //    var checkBox = new CheckBox();
        //    label.Text = Description.ToString();
        //    textBox.Text = TimeSpent.ToString();
        //    label.Left = PosX;
        //    label.Top = PosY;
        //    PosX += 100;// Move position to right
        //    textBox.Left = PosX;
        //    textBox.Top = PosY;
        //    PosX += 150;// Move position to right
        //    checkBox.Left = PosX;
        //    checkBox.Top = PosY;
        //    PosX = 10;// Reset to start
        //    PosY += 50;// Move position to down
        //    f.Controls.Add(label);
        //    f.Controls.Add(textBox);
        //    f.Controls.Add(checkBox);
        //}
    }

    public class Times
    {
        private string nome;
        private string local;
        private int vitorias = 0;
        private int empates = 0;
        private int derrotas = 0;

        public string Nome { get => nome; set => nome = value; }
        public string Local { get => local; set => local = value; }
        public int Vitorias { get => vitorias; set => vitorias = value; }
        public int Empates { get => empates; set => empates = value; }
        public int Derrotas { get => derrotas; set => derrotas = value; }
    }

    public class Jogos
    {
        private string casa;
        private int golsCasa;
        private string fora;
        private int golsFora;
        private string local;
        private static Random sorteado = new Random();

        public string Casa { get => casa; set => casa = value; }
        public int GolsCasa { get => golsCasa; set => golsCasa = value; }
        public string Fora { get => fora; set => fora = value; }
        public int GolsFora { get => golsFora; set => golsFora = value; }
        public string Local { get => local; set => local = value; }

        public List<List<Jogos>> CriarJogos(List<List<Jogos>> j, List<Times> t)
        {
            int qtd = t.Count;
            for (int y = 0; y < qtd - 1; y++) {
                j.Add(new List<Jogos>());
                for (int z = 0; z < qtd / 2; z++) {
                    if (t[z].Nome != "-" && t[qtd - 1 - z].Nome != "-") {
                        j[y].Add(
                            new Jogos {
                                Casa = t[z].Nome,
                                GolsCasa = Gols(0, 6),
                                Fora = t[qtd - 1 - z].Nome,
                                GolsFora = Gols(0, 6),
                                Local = "Local: " + t[z].Local
                        });
                    }
                }
            }
            return j;
        }

        private int Gols(int min, int max)
        {
            int[] g = new int[max];
            for (int x = min; x < max; x++)
            {
                g[x] = x;
            }
            double[] chance = { 0.40, 0.26, 0.15, 0.10, 0.06, 0.03 };
            double s = sorteado.NextDouble();
            double fix = 0;

            for (int n = min; n < max; n++)
            {
                fix += chance[n];
                if (s <= fix)
                {
                    return g[Array.IndexOf(chance, chance[n])];
                }
            }
            return 0;
        }
    }
}
