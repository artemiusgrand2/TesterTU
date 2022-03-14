using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesterTU.Views
{
    public partial class KevValueControlcs : UserControl
    {

        public string KeyText
        {
            get
            {
                return labelKey.Text;
            }
            set
            {
                labelKey.Text = value;
            }
        }

        public string ValueText
        {
            get
            {
                return labelValue.Text;
            }
            set
            {
                labelValue.Text = value;
            }
        }

        public KevValueControlcs()
        {
            InitializeComponent();
        }
    }
}
