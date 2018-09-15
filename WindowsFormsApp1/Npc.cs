using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Npc : Form
    {
        public Npc()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}