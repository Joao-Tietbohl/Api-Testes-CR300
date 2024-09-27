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
    public partial class UserControlDateRange : UserControl
    {
        public UserControlDateRange()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
            
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
        }

        public string P1Value
        {
            get { return dateTimePicker1.Text; }
        }

        public string P2Value
        {
            get { return dateTimePicker2.Text; }
        }

        public string UriValue
        {
            get { return textBox2.Text; }
        }
    }
}
