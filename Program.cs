using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree72
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                //Main method that can search the tree size, Insert the element in left and right node of the tree:

                Console.WriteLine("Hello World!");
                BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56); //Binary search tree object reference
                binarySearch.Insert(30);
                binarySearch.Insert(70);
                binarySearch.Insert(22);
                binarySearch.Insert(40);
                binarySearch.Insert(60);
                binarySearch.Insert(95);
                binarySearch.Insert(11);
                binarySearch.Insert(65);
                binarySearch.Insert(3);
                binarySearch.Insert(16);
                binarySearch.Insert(63);
                binarySearch.Insert(67);
                binarySearch.Display(); //Display method
                binarySearch.GetSize(); //Getsize method
                bool result = binarySearch.IfExists(3, binarySearch);
                Console.WriteLine(result);


            }
        }

        class BinarySearchTree<T> where T : IComparable<T>  //Class thet can compare the left and right node of the tree and insert the element accounding to given data:
        {
            public T NodeData //main root tree
            {
                get; set;
            }
            public BinarySearchTree<T> LeftTree //left side tree
            {
                get; set;
            }
            public BinarySearchTree<T> RightTree //right side tree
            {
                get; set;
            }


            public BinarySearchTree(T nodeData) //Binary search tree method:
            {
                this.NodeData = nodeData;
                this.LeftTree = null;
                this.RightTree = null;
            }
            int leftCount = 0, rightCount = 0;
            bool result = false;


            public void Insert(T item)
            {
                T CurrentNodeValue = this.NodeData;
                if ((CurrentNodeValue.CompareTo(item)) > 0) //Compare the tree from left to right that it is null or any value:
                {
                    if (this.LeftTree == null)
                        this.LeftTree = new BinarySearchTree<T>(item);
                    else
                        this.LeftTree.Insert(item);
                }
                else
                {
                    if (this.RightTree == null)
                        this.RightTree = new BinarySearchTree<T>(item);
                    else
                        this.RightTree.Insert(item);
                }
            }


            public void Display() //Display method it will display the nodes present in the tree
            {
                if (this.LeftTree != null)
                {
                    this.leftCount++;
                    this.LeftTree.Display();
                }
                Console.WriteLine(this.NodeData.ToString());
                if (this.RightTree != null)
                {
                    this.rightCount++;
                    this.RightTree.Display();
                }
            }


            public void GetSize() //Display the size of the tree
            {
                Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));

            }


            public bool IfExists(T element, BinarySearchTree<T> node) //Exist method that can show that the node which we are searching is present or not
            {
                if (node == null)
                {
                    return false;
                }
                if (node.NodeData.Equals(element))
                {
                    Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                    result = true;
                }
                else
                {
                    Console.WriteLine("Current element is {0} in BST", node.NodeData);
                }
                if (element.CompareTo(node.NodeData) < 0)
                {
                    IfExists(element, node.LeftTree);
                }
                if (element.CompareTo(node.NodeData) > 0)
                {
                    IfExists(element, node.RightTree);
                }
                return result;

            }
        }
 }
