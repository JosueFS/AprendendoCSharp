using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTAGIO
{
    public class Dados
    {
        
        public static int PosX { get; set; } = 100;
        public static int PosY { get; set; } = 10;

        //public Label NewLabel(string text, int w, int h, DockStyle d)
        public void NewRound(TabPage tb, List<List<Jogos>> j, TabPage page)
        {
            PosX = 100;
            PosY = 10;
            while (page.Controls.Count > 0) page.Controls[0].Dispose();

            int index = 1;
            foreach (var sublist in j ) {
                var lblRodada = new Label();
                
                //Propriedades do Label
                lblRodada.BackColor = System.Drawing.Color.Transparent;
                lblRodada.Cursor = System.Windows.Forms.Cursors.Default;
                lblRodada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                lblRodada.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblRodada.ForeColor = System.Drawing.Color.MidnightBlue;
                //lblRodada.Location = new System.Drawing.Point(11, 9);
                lblRodada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblRodada.Size = new System.Drawing.Size(200, 33);

                lblRodada.Text = "Rodada " + index;
                lblRodada.Left = PosX;
                lblRodada.Top = PosY;
                PosY += 33;

                foreach (var jogo in sublist) {
                    var lblCasa = new Label();

                    //Propriedades do Label
                    lblCasa.BackColor = System.Drawing.Color.Transparent;
                    lblCasa.Cursor = System.Windows.Forms.Cursors.Default;
                    lblCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    lblCasa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCasa.ForeColor = System.Drawing.Color.MidnightBlue;
                    lblCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblCasa.Size = new System.Drawing.Size(200, 20);
                    //lblCasa.BorderStyle = BorderStyle.FixedSingle;
                    lblCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    var lblFora = new Label();

                    //Propriedades do Label
                    lblFora.BackColor = System.Drawing.Color.Transparent;
                    lblFora.Cursor = System.Windows.Forms.Cursors.Default;
                    lblFora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    lblFora.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblFora.ForeColor = System.Drawing.Color.MidnightBlue;
                    lblFora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblFora.Size = new System.Drawing.Size(200, 20);
                    //lblFora.BorderStyle = BorderStyle.FixedSingle;
                    lblFora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                    var lblLocal = new Label();

                    //Propriedades do Label
                    lblLocal.BackColor = System.Drawing.Color.Transparent;
                    lblLocal.Cursor = System.Windows.Forms.Cursors.Default;
                    lblLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    lblLocal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblLocal.ForeColor = System.Drawing.Color.MidnightBlue;
                    lblLocal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    //lblLocal.BorderStyle = BorderStyle.FixedSingle;
                    lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    var lblPlacar = new Label();

                    //Propriedades do Label
                    lblPlacar.BackColor = System.Drawing.Color.Transparent;
                    lblPlacar.Cursor = System.Windows.Forms.Cursors.Default;
                    lblPlacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    lblPlacar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPlacar.ForeColor = System.Drawing.Color.MidnightBlue;
                    lblPlacar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblPlacar.Size = new System.Drawing.Size(70, 20);
                    //lblPlacar.BorderStyle = BorderStyle.FixedSingle;
                    lblPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    //Dados de cada jogo em Labels
                    lblCasa.Text = jogo.Casa;
                    lblPlacar.Text = jogo.GolsCasa + " X " + jogo.GolsFora;
                    lblFora.Text = jogo.Fora;
                    lblLocal.Text = "Local: " + jogo.Local;

                    //Posicionando os Labels
                    lblCasa.Left = PosX;
                    lblCasa.Top = PosY;
                    PosX += lblCasa.Width; 

                    lblPlacar.Left = PosX;
                    lblPlacar.Top = PosY;
                    PosX += lblPlacar.Width;

                    lblFora.Left = PosX;
                    lblFora.Top = PosY;
                    PosX += lblFora.Width;
                    PosY += 20;

                    lblLocal.Size = new System.Drawing.Size(PosX-100, 20);
                    lblLocal.Left = 100;
                    lblLocal.Top = PosY;
                    

                    //Ajuste para iteração
                    PosX = 100;
                    PosY += 25;

                    tb.Controls.Add(lblRodada);
                    tb.Controls.Add(lblCasa);
                    tb.Controls.Add(lblPlacar);
                    tb.Controls.Add(lblFora);
                    tb.Controls.Add(lblLocal);
                }
                index++;
                PosY += 10;
            }
        }

        public void Rank(List<Times> t, ListView lv, Label c)
        {
            List<Times> Rank = t.OrderByDescending(o => o.Pontos).ToList();
            int rankPosition = 1;
            foreach (var time in Rank)
            {
                if(rankPosition == 1)
                {
                    c.Text = time.Nome;
                }
                ListViewItem rowItem = new ListViewItem(new string[] {rankPosition.ToString()+"°", time.Nome, time.Pontos.ToString(), time.Vitorias.ToString(), time.Empates.ToString(), time.Derrotas.ToString() });
                lv.Items.Add(rowItem);
                rankPosition++;
            }
        }
    }

    public class Times
    {
        private string nome;
        private string local;
        private int pontos;
        private int vitorias = 0;
        private int empates = 0;
        private int derrotas = 0;

        public string Nome { get => nome; set => nome = value; }
        public string Local { get => local; set => local = value; }
        public int Pontos { get => pontos; set => pontos = value; }
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

        public List<List<Jogos>> CriarJogos(List<List<Jogos>> j, List<Times> original, bool doubleShift)
        {
            List<Times> t = new List<Times>(original);

            int qtd = t.Count;

            if (qtd % 2 == 1)
            {
                t.Add(new Times { Nome = "-" });
                qtd++;
            }

            
            
            //Iteração de rodadas
            for (int y = 0; y < qtd - 1; y++) {
                j.Add(new List<Jogos>());
                
                //Iteração de jogos + Escalonamento Round Robin
                for (int z = 0; z < qtd / 2; z++) {
                    if (t[z].Nome != "-" && t[qtd - 1 - z].Nome != "-") {
                        j[y].Add(
                            new Jogos {
                                Casa = t[z].Nome,
                                GolsCasa = Gols(0, 6),
                                Fora = t[qtd - 1 - z].Nome,
                                GolsFora = Gols(0, 6),
                                Local = t[z].Local
                        });

                        //Verificando resultado da partida
                        //Cálculo de vitórias, empates, derrotas e pontos
                        if (j[y][z].GolsCasa > j[y][z].GolsFora)
                        {
                            t[z].Vitorias++;
                            t[qtd - 1 - z].Derrotas++;
                        }
                        else if(j[y][z].GolsCasa < j[y][z].GolsFora)
                        {
                            t[z].Derrotas++;
                            t[qtd - 1 - z].Vitorias++;
                        }
                        else if (j[y][z].GolsCasa == j[y][z].GolsFora)
                        {
                            t[z].Empates++;
                            t[qtd - 1 - z].Empates++;
                        }
                    }
                }
                t.Insert(1, t[t.Count-1]);
                t.RemoveAt(t.Count-1);
            }

            if (doubleShift)
            {
                List<List<Jogos>> stShift = new List<List<Jogos>>();
                for (int round = 0; round < qtd - 1; round++)
                {
                    stShift.Add(new List<Jogos>());
                    stShift.Add(new List<Jogos>());
                    stShift.Add(new List<Jogos>());

                    for (int jogo = 0; jogo < t.Count / 2; jogo++)
                    {
                        stShift[round].Add(
                            new Jogos
                            {
                                Casa = j[round][jogo].Fora,
                                GolsCasa = Gols(0, 6),
                                Fora = j[round][jogo].Casa,
                                GolsFora = Gols(0, 6),
                                Local = t[t.FindIndex(x => x.Nome.Equals(j[round][jogo].Fora))].Local
                            }
                        );

                        //Verificando resultado da partida
                        //Cálculo de vitórias, empates, derrotas e pontos
                        if (stShift[round][jogo].GolsCasa > stShift[round][jogo].GolsFora)
                        {
                            t[jogo].Vitorias++;
                            t[qtd - 1 - jogo].Derrotas++;
                        }
                        else if (stShift[round][jogo].GolsCasa < stShift[round][jogo].GolsFora)
                        {
                            t[jogo].Derrotas++;
                            t[qtd - 1 - jogo].Vitorias++;
                        }
                        else if (stShift[round][jogo].GolsCasa == stShift[round][jogo].GolsFora)
                        {
                            t[jogo].Empates++;
                            t[qtd - 1 - jogo].Empates++;
                        }
                    }
                }
                j.AddRange(stShift);
            }

            //Verificando condição de Rodada Dupla
            for (int st = 0; st < j.Count; st++)
            {
                for (int rd = 0; rd < j[st].Count; rd++)
                {
                    for (int jg = 0; jg < j[st].Count; jg++)
                    {
                        if (rd != jg && j[st][rd].Local == j[st][jg].Local && !j[st][jg].Local.Contains(" - Rodada Dupla"))
                        {
                            j[st][rd].Local += " - Rodada Dupla";
                            j[st][jg].Local += " - Rodada Dupla";
                        }
                    }
                }
            }

            CalcularPontos(t);
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

        private void CalcularPontos(List<Times> t)
        {
            foreach (var time in t)
            {
                time.Pontos = (time.Vitorias * 3) + (time.Empates * 1);
            }
        }


    }

    static class ShuffleExtension
    {
        private static Random posRandom = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int qtdTimes = list.Count;
            while (qtdTimes > 1)
            {
                qtdTimes--;
                int pos = posRandom.Next(qtdTimes + 1);
                T value = list[pos];
                list[pos] = list[qtdTimes];
                list[qtdTimes] = value;
            }
        }
    }
}
