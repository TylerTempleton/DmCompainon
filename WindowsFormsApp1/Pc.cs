using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Pc : Form
    {
        public Pc()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}