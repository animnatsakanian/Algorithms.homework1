using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms.homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Data structures
            //Create a list of integers and add 5 elements to it.
            List<int> listt = new List<int>();
            listt.Add(1);
            listt.Add(2);
            listt.Add(3);
            listt.Add(4);
            listt.Add(5);


            //Create a dictionary with string keys and integer values, and add 5 key-value pairs to it.
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 10);
            dict.Add("b", 2);
            dict.Add("c", 3);
            dict.Add("d", 4);
            dict.Add("e", 5);


            //Create a queue of integers and add 5 elements to it.
            Queue<int> myqueue = new Queue<int>();
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);
            myqueue.Enqueue(4);
            myqueue.Enqueue(5);


            //Create a stack of integers and add 5 elements to it.
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            //Operations on Data Structures
            //Calculate and print the sum of all elements in the list.
            int sum = 0;
            for (int i = 0; i < listt.Count; ++i)
            {
                sum += listt[i];

            }
            Console.WriteLine(sum);


            // 	Calculate and print the sum of all values in the dictionary
            Console.WriteLine();
            int sum1 = 0;
            foreach (int item in dict.Values)
            {
                sum1 += item;
            }
            Console.WriteLine(sum1);


            //Remove 2 elements from the queue and print the remaining elements.
            myqueue.Dequeue();
            myqueue.Dequeue();
            Console.WriteLine();
            foreach (int item in myqueue)
            {
                Console.WriteLine(item);
            }


            //Remove 2 elements from the stack and print the remaining elements.
            stack.Pop();
            stack.Pop();
            Console.WriteLine();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }


            //Additional Tasks
            //Print all elements of the list.
            Console.WriteLine();
            foreach (int item in listt)
            {
                Console.WriteLine(item);
            }


            //From a three-digit number (e.g., 124), print the largest digit. 
            Console.WriteLine();
            int a = 124;
            int b = a / 100;
            
            int c = a % 10;
            
            int d = a % 100 / 10;

            int largest = b;

            if (c>largest)
            {
                largest = c;
            }
            if (d>largest)
            {
                largest=d;

            }
            Console.WriteLine(largest);

            //From a three-digit number(e.g., 124), print the smallest digit.

            int smallest = b;
            if (c<smallest) {
                smallest = c;
            }

            if (d<smallest)
            {
                smallest = d;
            }
            Console.WriteLine(smallest);


            //From an array, find all even values and print their sum
            int[] arr = [1, 2, 6, 7, 5, 9, 48, 36, 21];
            int summ = 0;
            foreach (int item in arr)
            {
                if (item%2==0)
                {
                    summ+=item;
                }
            }
            Console.WriteLine(summ);


            //Calculate and print the average of all elements in the array.
            double mysum = 0;
            foreach (int item in arr)
            {
                mysum+=item;
            }
            Console.WriteLine(mysum/arr.Length);






        }
    }
}
