using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Library.Return
{
    public class Tree
    {
        public int Value { get; set; }private Tree Left { get; }private Tree Right { get; }

        public Tree(int value, Tree left = null,Tree right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public void PrintInPreOrder(string format)
        {
            PrintInPreOrder(this);
             void PrintInPreOrder(Tree tree)
            {
                if (tree == null)
                {
                    return;
                }
                PrintValue(tree, format);
                PrintInPreOrder(tree.Left);
                PrintInPreOrder(tree.Right);
            }
        }

        public void PrintInOrder(string format)
        {
            PrintInOrder(this);
           

            void PrintInOrder(Tree tree)
            {
                if (tree == null)
               {
                return;
                }

                PrintInOrder(tree.Left);
                PrintValue(tree, format);
                PrintInOrder(tree.Right);
            }
        }

        public void PrintInPostOrder(string format)
        {
            PrintInPostOrder(this);
             void PrintInPostOrder(Tree tree)
            {
                if (tree == null)
                {
                    return;
                }
                PrintInPostOrder(tree.Left);
                PrintInPostOrder(tree.Right);
                PrintValue(tree, format);

            }
        }

        private void PrintInPostOrder(Tree tree, string format)
        {
            if (tree==null)
            {
                return;
            }
            PrintInPostOrder(tree.Left,format);
           PrintInPostOrder(tree.Right,format);
            PrintValue(tree,format);
          
        }

        //private void PrintInOrder(Tree tree, string format)
        //{
        //    if (tree == null)
        //    {
        //        return;
        //    }
        //    PrintInOrder(tree.Left,format);
        //    PrintValue(tree,format);
        //    PrintInOrder(tree.Right,format);
        //}

        //private void PrintInPreOrder(Tree tree, string format)
        //{
        //    if (tree == null)
        //    {
        //        return;
        //    }
        //    PrintValue(tree, format);
        //    PrintInPreOrder(tree.Left,format);
        //    PrintInPreOrder(tree.Right,format);
        //}

        private void PrintValue(Tree tree, string format)
        {
            Console.WriteLine($"{format} ",tree.Value);
        }
    }
}
