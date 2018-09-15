using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Dungeon : Form
    {
        public Dungeon()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}