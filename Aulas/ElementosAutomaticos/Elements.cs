using System.Drawing;
using System.Windows.Forms;

namespace ElementosAutomaticos
{
    class Elements
    {
        public Button BtnAuto(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Size = new Size(100, 50);
            return btn;
        }

        public Label LabelsAuto(string text)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Dock = DockStyle.Top;
            lbl.Size = new Size(100, 50);
            return lbl;
        }
    }
}
