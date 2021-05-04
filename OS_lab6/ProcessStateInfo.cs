namespace OS_lab6
{
    public class ProcessStateInfo
    {
        public ProcessStateInfo(int q, ProcessState st)
        {
            QuantsFromStart = q;
            State = st;
        }
        
        
        public int QuantsFromStart { get; set; } = 0;

        public ProcessState State { get; set; } = ProcessState.Waits;
    }
}