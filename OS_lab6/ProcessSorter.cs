using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_lab6
{
    public class ProcessSorter : IComparer<ProcessInfo>
    {
        public enum SortMode
        {
            Start,
            Durration
        }

        public SortMode Mode { get; set; } = SortMode.Start;

        public int Compare(ProcessInfo x, ProcessInfo y)
        {
            switch (Mode)
            {
                case SortMode.Start:
                    return (int)x?.CreationTime.CompareTo(y?.CreationTime);
                case SortMode.Durration:
                    return (int)x?.Duration.CompareTo(y?.Duration);
            }
            throw new Exception($"{Mode} value not used" );
        }
    }
}
