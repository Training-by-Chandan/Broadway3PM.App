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
        private string[] container = new string[5];
        private int counter = 0;

        public void Push(string item)
        {
            if (counter <= 4)
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
}