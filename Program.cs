﻿namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Problems");
            Binary<int> binarysearch = new Binary<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(70);
            binarysearch.Insert(22);
            binarysearch.Insert(40);
            binarysearch.Insert(60);
            binarysearch.Insert(95);
            binarysearch.Insert(11);
            binarysearch.Insert(65);
            binarysearch.Insert(3);
            binarysearch.Insert(16);
            binarysearch.Insert(63);
            binarysearch.Insert(67);
            binarysearch.Display();
            binarysearch.GetSize(); 
        }
    }
}