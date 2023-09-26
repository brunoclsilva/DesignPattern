namespace DesignPatterns.Behavioral.Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("MergeSorted list...");
        }
    }
}
