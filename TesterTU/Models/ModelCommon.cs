using System;
using System.Collections.Generic;
using System.Text;

namespace TesterTU.Models
{
    public class ModelCommon
    {
        public IList<string> ConnectionStrs = new List<string>() { string.Empty, string.Empty };
        public List<ModelDevice> Devices { get; } = new List<ModelDevice>();
        public void SetConnectionStr(int number, string namePort, string boudRoute)
        {
            if (number < ConnectionStrs.Count && number >= 0)
                ConnectionStrs[number] = $"{namePort}:{boudRoute}";
        }
    }
}
