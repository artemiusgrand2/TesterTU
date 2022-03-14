using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TesterTU.Views
{
    public partial class TableDiagnostControl : UserControl
    {
        public string HeaderText
        {
            get
            {
                return labelHeader.Text;
            }
            set
            {
                labelHeader.Text = value;
            }
        }

        public string ValueMK1
        {
            get
            {
                return labelMK1.Text;
            }
            set
            {
                labelMK1.Text = value;
            }
        }

        public string ValueMK2
        {
            get
            {
                return labelMK2.Text;
            }
            set
            {
                labelMK2.Text = value;
            }
        }

        public TableDiagnostControl()
        {
            InitializeComponent();
        }
    }
}
