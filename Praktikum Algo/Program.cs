using System;

namespace Praktikum_Algo
{
    class Program
    {
        // quick sort
        //Array of of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        // number of element in array
        private int n;


        void input()
        {

            while (true)
            {
                Console.Write("Enter the Number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array Can Have maximum 20 elements \n");
            }
            Console.WriteLine("\n========================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n========================");

            // get array element
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        // swap the element at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            // partititon the list into two parts:
            // one containing elements less that or equal to pivot
            //outher conntainning elements greather than pivot
            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                // search for an element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                // search for an element less than or equal to pivot
                while ((arr[j] <= pivot) && (i <= high))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;


                if (i < j) //if the greater element is on the left of the element 
                {
                    //swap the element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            if (low < j)
            {
                // move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
            //short the list on the left of tpivot using quick sort
            q_sort(low, j - 1);

            //short the list on the right of pivot using quick sort
            q_sort(j + 1, high);

            void display()
            {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine(" sorted array elements ");
                Console.WriteLine("-------------------------");

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr[j]);
                }
                Console.WriteLine("\n Number of comparisons: " + cmp_count);
                Console.WriteLine("\n Number of data movements: " + mov_count);
            }
            int getSize()
            {
                return (n);
            }
            static void main(string[] args)
            {
                // declaring the object of the class
                Program myList = new Program
                //accept array element
                mylist.input();
                //calling the shorting function
                //first call to quick short Algorithm
                mylist.q_short(0, myList.getSize() - 1);
                //display shorted array
                object value = myList.display();
                //to exit from the console
                Console.WriteLine("\n\n Press enter to exit.");
                Console.Read();
            }
        }
    }
}
