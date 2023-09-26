namespace DesignPatterns.Behavioral.Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("ShellSorted list...");
        }
    }
}
