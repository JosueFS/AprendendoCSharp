using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementosAutomaticos
{
    public partial class Teste : Form
    {
        Elements bt = new Elements();
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(bt.LabelsAuto("Label " + (i+1)));
                this.Controls.Add(bt.BtnAuto("Botão " + (i+1)));
            }
        }
    }
}
