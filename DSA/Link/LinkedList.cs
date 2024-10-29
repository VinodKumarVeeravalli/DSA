namespace DSA.Link
{
    public class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;

        public void AddLast(int value)
        {
            var node = new Node(value);
            if (first == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

        }
        public void Print()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write("{0} ", current.value);
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
