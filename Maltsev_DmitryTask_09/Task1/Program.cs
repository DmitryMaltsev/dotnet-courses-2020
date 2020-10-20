using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listItem = new List<int>();
            LinkedList<int> linkedItem = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                listItem.Add(i);
                linkedItem.AddFirst(i);
            }
            RemoveEachSecondItem(listItem);
        }

        public static void RemoveEachSecondItem <T> ( IEnumerable<T> ie )
        {
            var elementsCount = ie.Count();
            if (elementsCount == 0)
                throw new Exception("Empty array");
            var firstNode = CreateList(ie);
            var isOdd = false;
            var currentNode = firstNode; 
            MyNode<T> previousNode = null;
            while(elementsCount>1)
            {                
                if(isOdd)
                { 
                    previousNode.next = currentNode.next;
                    elementsCount--; 
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.next;
                isOdd = !isOdd;
            }          
        }
        
        public static MyNode<T> CreateList<T>(IEnumerable<T> ie)
        {
            MyNode<T> firstNode = null;
            MyNode<T> previousNode = null;
            int count = ie.Count();
            foreach (var item in ie)
            {
                var newNode = new MyNode<T>(item);
                if (firstNode == null)
                {
                    firstNode = newNode;
                }
                else
                {
                    previousNode.next = newNode;
                }
                previousNode = newNode;
            }
            previousNode.next = firstNode;
            return firstNode;
        }
    }


}
