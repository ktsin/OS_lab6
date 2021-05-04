using System;
using System.Collections.Generic;
using OS_lab6.PlaningMachines;

namespace OS_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProcessInfo> processes = new List<ProcessInfo>()
            {
                new ProcessInfo(3, 3, 1),
                new ProcessInfo(0, 5, 3),
                new ProcessInfo(1, 2, 4),
                new ProcessInfo(7, 7, 1)
            };
            var fcfs = new FCFSMachine();
            fcfs.StartMachine(processes);
        }
    }
}