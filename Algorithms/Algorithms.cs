namespace SortRace.Algorithms
{
    class Sort
    {
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private static int Max(int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
                if(max < arr[i])
                    max = arr[i];
            return max;
        }
        public static void BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++) {
                bool swapped = false;
                for(int j = 0; j < arr.Length - i - 1; j++) {
                    if(arr[j] > arr[j + 1]) {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if(!swapped)
                    break;
            }
        }
        public static void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for(int j = i; j < arr.Length; j++)
                {
                    if(arr[min] > arr[j])
                    min = j;
                }
                Swap(ref arr[i], ref arr[min]);
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = k;
            }
        }
        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for(int gap = n/2; gap > 0; gap /=2)
            {
                for(int i = gap; i < n; i++)
                {
                    int k = arr[i];
                    int j = i;
                    while (j >= gap && arr[j - gap] > k)
                    {
                        arr[j] = arr[j - gap];
                        j-=gap;
                    }
                    arr[j] = k;
                }
            }
        }
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = n/2-1; i>=0; i--)
                Heapify(arr,n,i);
            
            for(int i = n-1; i > 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                Heapify(arr, i, 0);
            }
        }
        private static void Heapify(int[] arr, int n, int i)
        {
            int max = i;
            int left = 2*i + 1;
            int right = 2*i + 2;

            if(left < n && arr[left] > arr[max])
                max = left;
            if(right < n && arr[right] > arr[max])
                max = right;
            
            if(max != i) {
                Swap(ref arr[i], ref arr[max]);
                Heapify(arr, n, max);
            }
        }
        public static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = Partition(arr, left, right);

                QuickSort(arr, left, mid - 1);
                QuickSort(arr, mid + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i],ref arr[j]);
                }
            }
            Swap(ref arr[i+1], ref arr[right]);
            return i+1;
        }
        public static void InsertionSort(List<int> arr)
        {
            for(int i = 1; i < arr.Count(); i++)
            {
                int k = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = k;
            }
        }
        public static void BucketSort(int[] arr)
        {
            int n = arr.Length;
            int k = Max(arr) / 10;
            List<int>[] buckets = new List<int>[k];
            for(int i = 0; i < k; i++)
                buckets[i] = new List<int>();
            
            for(int i = 0; i < n; i++)
            {
                int bi = (int)(arr[i]/10);
                if(bi == 0)
                    bi++;

                buckets[bi - 1].Add(arr[i]);
            }

            for(int i = 0; i < k; i++) {
                if(buckets[i].Count > 0)
                    InsertionSort(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }
    }
}