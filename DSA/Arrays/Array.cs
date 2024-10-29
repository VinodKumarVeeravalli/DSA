namespace DSA.Arrays
{
    public class Array
    {
        private int[] items;
        private int size;

        public Array(int length)
        {
            items = new int[length];
        }

        //O(1) & O(1)
        public void Insert(int value)
        {
            if (items.Length == size)
            {
                int[] newItems = new int[size * 2];

                for (int i = 0; i < size; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }

            items[size] = value;
            size++;
        }

        // O(N) & O(1)
        public void InsertAt(int index, int value)
        {
            if (items.Length == size)
            {
                if (items.Length == size)
                {
                    int[] newItems = new int[size * 2];

                    for (int i = 0; i < size; i++)
                    {
                        newItems[i] = items[i];
                    }
                    items = newItems;
                }
            }

            for (int i = size - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
            items[index] = value;
            size++;
        }

        //O(N) & O(1)
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < size; i++)
            {
                items[i] = items[i + 1];
            }

            size--;
        }

        public int Max()
        {
            int left = items[0];

            for (int i = 0; i < size - 1; i++)
            {
                if (left < items[i + 1])
                {
                    left = items[i + 1];
                }
            }
            return left;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        //O(N) & O(1)
        public int IndexOf(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (items[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Reverse(int[] arr)
        {
            //to do
        }
    }

}
