using System.Diagnostics;
using Class.Library.Return;

namespace Console.App.Return
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var individual = new Individual {PersentageDiscount = 50};
            var business1 = new Businness {Employees = 100};
            var business2 = new Businness {Employees = 2000};

            const int price = 100;

            System.Console.WriteLine($"{Test.ApplyDiscount(student,price)}");
            System.Console.WriteLine($"{Test.ApplyDiscount(individual,price)}");
            System.Console.WriteLine($"{Test.ApplyDiscount(business1,price)}");
            System.Console.WriteLine($"{Test.ApplyDiscount(business2,price)}");




          //  System.Console.WriteLine(@"Tree:  
          //     4
          //   /    \
          //  2     6
          // /  \   / \
          //1    3  5  7
          //      "  );

          //  var tree = new Tree(4,
          //      new Tree(2, new Tree(1), new Tree(3)),
          //      new Tree(6, new Tree(5), new Tree(7)));

          //  System.Console.WriteLine("Print in pre order:");
          //  tree.PrintInPreOrder("{0}");
          //  System.Console.WriteLine("\n\nPrint in order: ");
          //  tree.PrintInOrder("[{0}]");
          //  System.Console.WriteLine("\n\nPrint in order post order: ");
          //  tree.PrintInPostOrder("<{0}>");
          //  System.Console.WriteLine();
                



          //  var world = new World(new GameObject{Id = 0}, new GameObject{Id= 1});

          //  var stopWatch = Stopwatch.StartNew();
          //  for (int i = 0; i < 100_000_000; i++)
          //  {
          //      ref GameObject gameObject = ref world.GetReturnRef((ref GameObject x) => x.Id == 1);
          //  }
          //  stopWatch.Stop();

          //  System.Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
