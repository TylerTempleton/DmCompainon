using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Loot : Form
    {
        public Loot()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}