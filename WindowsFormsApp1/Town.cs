using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Town : Form
    {
        public Town()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}