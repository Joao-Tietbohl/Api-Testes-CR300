using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestesCampbell.Paineis
{
    public partial class UserControlSinceTime : UserControl
    {
        public UserControlSinceTime()
        {
            InitializeComponent();
        }

        public string P1Value
        {
            get { return dateTimePicker1.Text; }
        }

        public string UriValue
        {
            get { return textBox2.Text; }
        }
    }
}
