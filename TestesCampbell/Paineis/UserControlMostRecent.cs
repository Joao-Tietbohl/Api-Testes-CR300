using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesCampbell.Paineis
{
    public partial class UserControlMostRecent : UserControl
    {
        public UserControlMostRecent()
        {
            InitializeComponent();
        }

        public string P1Value
        {
            get { return textBox1.Text; }
        }

        public string UriValue
        {
            get { return textBox2.Text; }
        }
    }
}
