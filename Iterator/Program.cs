
namespace Iterator{

    public class Program{
        static void Main(string[] args){

            ListAgregate<string> aggregate = new ListAgregate<string>();
            Iterator<string> iterator = aggregate.CreateIterator();

            aggregate.Append("Item 1");
            aggregate.Append("Item 2");
            aggregate.Append("Item 3");
            Console.WriteLine($"Aggregate count: {aggregate.Count()}");

            Console.WriteLine(iterator.First());
            while (!iterator.IsDone()) {
                Console.WriteLine(iterator.Next());
            }

        }
    }
}