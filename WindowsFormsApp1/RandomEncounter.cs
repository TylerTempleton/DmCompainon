using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RandomEncounter : Form
    {
        public RandomEncounter()
        {
            InitializeComponent();
        }
        public void cNameLabelFill(Label cNameLabel)
        {
            cWMNameLabel.Text = cNameLabel.Text;
        }
    }
}
