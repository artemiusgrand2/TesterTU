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
    public partial class TSPanel : UserControl
    {
        IList<ModelOutput> _outputs;
        public TSPanel()
        {
            InitializeComponent();
        }

        public void BindModel(IList<ModelOutput> outputs)
        {
            _outputs = outputs;
            foreach (var output in outputs)
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
                        if (model.Index <= 16)
                            Controls.Find($"panel{model.Index}", false)[0].BackColor = ControllerHelper.GetColorOutPut(model.Value);
                        else
                            Controls.Find($"panel{model.Index}", false)[0].BackColor = (model.Value == 1) ? Color.Red : Color.Green;
                    }
                    break;
            }
        }
    }
}
