using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add("hello", 50);
            tree.Add("world", 100);
            tree.Add("prize", 200);
            tree.Add("peaceful", 50);
            tree.Add("gift", 100);
            tree.Add("project", 200);
            tree.Add("soldier", 50);
            tree.Add("right", 100);
            tree.Add("beauty", 300);
            tree.Add("year", 200);
            tree.Add("hero", 50);
            tree.Add("dove", 100);
            tree.Add("lazy", 1000);


            tree.Remove("right");
            tree.Remove("world");

            Search(tree, "hello");
            Search(tree, "world");
            Search(tree, "cloud");
            Search(tree, "peaceful");
            Search(tree, "lazy");
            Search(tree, "year");

            Console.ReadLine();
        }

        private static void Search(Tree<int> tree, string word)
        {
            if (tree.TrySearch(word, out int value))
            {
                Console.WriteLine(word + " " + value);
            }
            else
            {
                Console.WriteLine("Not found " + word);
            }
        }
    }
}
