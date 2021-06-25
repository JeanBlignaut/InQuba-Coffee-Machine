using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Machine.Interfaces
{
    public interface IMachineIO
    {
        public Func<string> ReadLine { get; init; }
        public Action<string> WriteLine { get; init; }
    }
}
