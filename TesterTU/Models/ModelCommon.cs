using System;
using System.Collections.Generic;

using TesterTU.Enums;

namespace TesterTU.Models
{
    public class ModelCommon
    {
        public IList<KeyValuePair<ViewSource, string>> ConnectionStrs = new List<KeyValuePair<ViewSource, string>>() {new KeyValuePair<ViewSource, string>(ViewSource.comPort, string.Empty), new KeyValuePair<ViewSource, string>(ViewSource.comPort, string.Empty) };
        public List<ModelDevice> Devices { get; } = new List<ModelDevice>();
        public void SetConnectionStr(int number, string connectionStr, ViewSource view)
        {
            if (number < ConnectionStrs.Count && number >= 0)
                ConnectionStrs[number] = new KeyValuePair<ViewSource, string>(view, connectionStr);
        }
    }
}
