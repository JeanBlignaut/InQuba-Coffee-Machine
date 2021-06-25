using Coffee.Machine.Interfaces;
using System;

namespace Coffee.Machine.Logic
{
    public class MachineIO : IMachineIO
    {
        public Func<string> ReadLine { get; init; }
        public Action<string> WriteLine { get; init; }

        public MachineIO(Func<string> readLine, Action<string> writeLine)
        {
            WriteLine = writeLine;
            ReadLine = readLine;
        }
    }
}
