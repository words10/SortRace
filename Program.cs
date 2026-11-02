using SortRace.Algorithms;

namespace SortRace 
{
    public class Program
    {
        public static int[] nums;
        public static String key = "";
        public const String split = "--------------------";
        public static void Input()
        {
            Console.Write("Array size (N): ");
            int n = int.Parse(Console.ReadLine());
            nums = new int[n];
            Randomize(nums);
            Console.WriteLine(split);
        }
        public static void Randomize(int[] arr, int minVal=0, int maxVal=4097)
        {
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(minVal, maxVal);
        }
        public static void Key()
        {
            Console.WriteLine(@"Algorithms to use (default=0123456):
[0]BubbleSort
[1]SelectionSort
[2]Insertion
[3]Shellsort
[4]HeapSort
[5]QuickSort
[6]BucketSort");
            key = Console.ReadLine();
            if(key == "" || key == null)
                key = "0123456";
            Console.WriteLine(split);
            
        }
        public static void SortComparison(int[] nums, string key)
        {
            for(int i = 0; i < key.Length; i++)
            {
                int[] a = nums;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                switch (key[i])
                {
                    case '0':
                        Console.Write("Bubble Sort: ");
                        Sort.BubbleSort(a);
                        break;    
                    case '1':
                        Console.Write("Selection Sort: ");
                        Sort.SelectionSort(a);
                        break;     
                    case '2':
                        Console.Write("Insertion Sort: ");
                        Sort.InsertionSort(a);
                        break;
                    case '3':
                        Console.Write("Shell Sort: ");
                        Sort.ShellSort(a);
                        break;       
                    case '4':
                        Console.Write("Heap Sort: ");
                        Sort.HeapSort(a);
                        break; 
                    case '5':
                        Console.Write("Quick Sort: ");
                        Sort.QuickSort(a,0,a.Length-1);
                        break; 
                    case '6':
                        Console.Write("Bucket Sort: ");
                        Sort.BucketSort(a);
                        break;     
                    default:
                        throw new Exception("Error!");
                }
                watch.Stop();
                Console.WriteLine($"{watch.ElapsedMilliseconds} ms");
            }
        }
        public static void Main(string[] args)
        {
            Input();
            Key();
            SortComparison(nums, key);
        }
    }
}