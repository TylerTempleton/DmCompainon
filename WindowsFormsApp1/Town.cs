using System.Windows.Forms;

namespace WindowsFormsApp1
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