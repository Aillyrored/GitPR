using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_PR
{
    public enum Command
    {
        Quit,
        Message,
        Connect,
        Sum
    };
    class CommandModel
    {
        public Command Command { set; get; }
        public string Data { set; get; }
    }
}
