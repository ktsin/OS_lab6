using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OS_lab6.PlaningMachines
{
    public class FCFSMachine : IMachine
    {
        public void StartMachine(ProcessInfo[] processes)
        {
            PrepareData(processes);
        }
        
        public int ModelingTime { get; set; } = 15;
        
        public int TimeQuant { get; set; } = 1;
        
        public string GetResult()
        {
            //fill by ProcessState.NotExist each line until process appears
            for (int i = 0; i < _processes.Length; i++)
            {
                for (int j = 0; j < _processes[i].CreationTime; i++)
                {
                    _internalState[i][j] = ProcessState.NotExist;
                }
            }
            var sortedProcesses = Array.Sort(_processes, )
            
            return "null";
        }

        private void PrepareData(ProcessInfo[] processes)
        {
            _processes = processes;
            _internalState = new ProcessState[processes.Length][];
            for (int i = 0; i < processes.Length; i++)
            {
                _internalState[i] = new ProcessState[ModelingTime];
            }

        }

        private ProcessInfo[] _processes = null;

        private ProcessState[][] _internalState = null;
    }
}