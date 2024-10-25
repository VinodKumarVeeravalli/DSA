namespace DSA.Arrays
{
    public class ArrayReverse
    {

        //Time Complexity = O(n) & SPACE COMPLEXITY = O(n)
        public void UsingTempArray(int[] arr)
        {

            int n = arr.Length;
            int[] tempArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                tempArr[i] = arr[n - 1 - i];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = tempArr[i];
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }

        //O(n) Time and O(1) Space
        public void Using2Pointer(int[] arr)
        {

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                // Increment the left pointer
                left++;

                // Decrement the right pointer
                right--;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //O(n) Time and O(1) Space
        public void UsingBySwapping(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //O(n) Time and O(1) Space
        public void UsingInBuilt(int[] arr)
        {
            Array.Reverse(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public void UsingReccursion(int[] arr)
        {
            //TODO
        }

    }

}
