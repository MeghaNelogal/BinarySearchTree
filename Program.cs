namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Problems");
            Binary<int> binarysearch = new Binary<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(70);
            binarysearch.Display();
        }
    }
}