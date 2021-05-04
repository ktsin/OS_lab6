namespace OS_lab6
{
    public class ProcessInfo
    {
        public ProcessInfo(int c, int d, int p)
        {
            CreationTime = c;
            Duration = d;
            Priority = p;
        }
        public int CreationTime { get; set; }
        
        public int Duration { get; set; }
        
        public int Priority { get; set; }
    }
}