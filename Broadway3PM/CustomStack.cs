using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    //Data type = string
    //Container to store the data type  wih container size = array
    //Push Function
    //Pop Function
    //Display function
    //Current location number = int
    public class CustomStack
    {
        public CustomStack()
        {
            maxSize = 5;
            container = new string[5];
        }

        public CustomStack(int maxSize)
        {
            this.maxSize = maxSize;
            container = new string[maxSize];
        }

        private int maxSize;
        private string[] container;
        private int counter = 0;

        public void Push(string item)
        {
            if (counter < maxSize)
            {
                container[counter] = item;
                counter++;
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                counter--;
                Console.WriteLine($"Popped {container[counter]}");
            }
        }

        public void Display()
        {
            for (int i = counter - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    public class CustomStackDynamic
    {
        private string[] container = new string[0];

        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            if (container.Length > 0)
            {
                Console.WriteLine($"Popped {container[container.Length - 1]}");
                Array.Resize(ref container, container.Length - 1);
            }
        }

        public void Display()
        {
            for (int i = container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    public class CustomStackDynamicTemplated<T>
    {
        private T[] container = new T[0];

        public void Push(T item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            if (container.Length > 0)
            {
                Console.WriteLine($"Popped {container[container.Length - 1]}");
                Array.Resize(ref container, container.Length - 1);
            }
        }

        public void Display()
        {
            for (int i = container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    namespace Partial
    {
        public partial class PClass
        {
            public void FunctionOne()
            {
                Test();
            }
        }
    }
}