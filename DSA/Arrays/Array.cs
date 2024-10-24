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

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

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
