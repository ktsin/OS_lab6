using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace OS_lab6.PlaningMachines
{
    public interface IMachine
    {
        public void StartMachine(List<ProcessInfo> processes);
        
        public int ModelingTime { get; set; }

        public int TimeQuant { get; set; }

        public string GetResult();
    }
}