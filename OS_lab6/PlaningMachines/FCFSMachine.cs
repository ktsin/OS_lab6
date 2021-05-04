using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OS_lab6.PlaningMachines
{
    public class FCFSMachine
    {
        public void StartMachine(ProcessInfo[] processes)
        {
            PrepareData(processes);
        }
        
        public int ModelingTime { get; set; } = 15;
        
        public int TimeQuant { get; set; } = 1;
        
        public ProcessState[][] GetResult()
        {
            Array.Sort(_processes, new ProcessSorter() { Mode = ProcessSorter.SortMode.Start });
            //fill by ProcessState.NotExist each line until process appears
            for (int i = 0; i < _processes.Length; i++)
            {
                for (int j = 0; j < _processes[i].CreationTime; i++)
                {
                    _internalState[i][j] = ProcessState.NotExist;
                }
            }
            int executionD = 0;
            int currentExec = -1;
            bool[] procDone = new bool[_processes.Length];

            for(int col = 0; col < ModelingTime; col++)
            {
                //main cycle
                for(int row = 0; row < _processes.Length && !procDone[row]; row++)
                {
                    if(_processes[row].CreationTime < col)
                        _internalState[row][col] = ProcessState.NotExist;
                    else
                    {
                        if (row == currentExec)
                        {
                            if(++executionD > _processes[row].Duration)
                            {
                                currentExec = -1;
                                executionD = 0;
                                _internalState[row][col] = ProcessState.Done;
                                procDone[row] = true;
                                row = 0;
                            }
                            else
                            {
                                currentExec = -1;
                                executionD = 0;
                                _internalState[row][col] = ProcessState.Executing;
                            }
                        }
                        else
                        {
                            //если сейчас ничего не исполняется, то захватываем.
                            bool isAvailable = true;
                            for(int k = 0; k < _processes.Length; k++)
                            {
                                if (_internalState[col][k] == ProcessState.Executing)
                                    isAvailable = false;
                            }
                            if (isAvailable)
                            {
                                currentExec = row;
                                _internalState[row][col] = ProcessState.Executing;
                                ++executionD;
                            }
                        }
                    }
                }
            }

            
            return _internalState;
        }

        public string FormatResult()
        {

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