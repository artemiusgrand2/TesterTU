using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TesterTU.Models;
using TesterTU.Controllers;

namespace TesterTU.Views
{
    public partial class TUPanel : UserControl
    {
        IList<ModelOutput> _outputs;
        public TUPanel()
        {
            InitializeComponent();
        }
        public void BindModel(IList<ModelOutput> outputs)
        {
            _outputs = outputs;
            foreach(var output in outputs)
                output.PropertyChanged += PropertyChanged;
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired == false)
                UpdateValue(sender, e);
            else
            {
                var delegateUpdateValue = new DelegateUpdateValue(UpdateValue);
                BeginInvoke(delegateUpdateValue, new object[] { sender, e });
            }
        }

        private void UpdateValue(object sender, PropertyChangedEventArgs e)
        {
            var model = (sender as ModelOutput);
            switch (e.PropertyName)
            {
                case "Value":
                    {
                        if (model.Index != 9)
                            Controls.Find($"panel{model.Index}", false)[0].BackColor = (model.Value == -1) ? Color.Gray : (model.Value == 1) ? Color.Green : Color.Red;
                        else
                            Controls.Find($"panel{model.Index}", false)[0].BackColor = (model.Value == -1) ? Color.Gray : (model.Value == 1) ? Color.Red : Color.Green;
                    }
                    break;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var output = (sender as CheckBox);
            _outputs[int.Parse(output.Name.Replace("checkBox", string.Empty)) - 1].IsOn = output.Checked;
        }
    }
}
