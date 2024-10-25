namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 45, 67 };

            //ArrayReverse arrObj = new ArrayReverse();

            //arrObj.UsingTempArray(arr);

            //arrObj.Using2Pointer(arr);

            //arrObj.UsingBySwapping(arr);

            //arrObj.UsingInBuilt(arr);

            Arrays.Array arr = new Arrays.Array(4);
            arr.Insert(10);
            arr.Insert(20);
            arr.Insert(60);
            arr.Insert(90);
            arr.InsertAt(1, 15);
            arr.Print();
            Console.WriteLine(arr.Max());
        }
    }

}
