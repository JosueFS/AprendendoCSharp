using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WF01
{
    public class Elements
    {
        public static int StartX { get; set; } = 10;
        public static int StartY { get; set; } = 10;

        public Button NewBtn(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Size = new Size(100, 50);
            return btn;
        }

        ////public Label NewLabel(string text, int w, int h, DockStyle d)
        //public void NewRound(Form f, List<List<Jogos>> j)
        //{
        //    Label lblRodada = new Label();
        //    Label lblCasa = new Label();
        //    Label lblFora = new Label();
        //    Label lblLocal = new Label();
        //    Label lblPlacar= new Label();
        //    lbl.Text = text;
        //    lbl.Dock = d;
        //    lbl.Size = new Size(w, h);
        //    return lbl;
        //}

        //public void DesignJogos(Form f)
        //{
        //    var label = new Label();
        //    var textBox = new TextBox();
        //    var checkBox = new CheckBox();
        //    label.Text = Description.ToString();
        //    textBox.Text = TimeSpent.ToString();
        //    label.Left = StartX;
        //    label.Top = StartY;
        //    StartX += 100;// Move position to right
        //    textBox.Left = StartX;
        //    textBox.Top = StartY;
        //    StartX += 150;// Move position to right
        //    checkBox.Left = StartX;
        //    checkBox.Top = StartY;
        //    StartX = 10;// Reset to start
        //    StartY += 50;// Move position to down
        //    f.Controls.Add(label);
        //    f.Controls.Add(textBox);
        //    f.Controls.Add(checkBox);
        //}
    }
}
