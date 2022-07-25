namespace DataStructures.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        public int Count {get;private set;} // geti int dönüyo diye, set ise yazma işlemi sadece sınıfta yapılacak
        // onun için private
        private readonly List<T> list = new List<T>(); 
        public T Peek()
        {
            if (list.Count == 0)
            {
                return default(T);//intse 0, boolsa false, tarihse tarih döner
                /*ya da
                 throw new Exception("Empty stack!");
                 */
            }
            return list[list.Count - 1];
        }

        public T Pop()
        {
            if(Count == 0)
            {
                return default(T);//intse 0, boolsa false, tarihse tarih döner
                /*ya da
                 throw new Exception("Empty stack!");
                 */
            }
            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if (value ==null)
            {
                throw new ArgumentException();
            }
            list.Add(value);
            Count++;
        }
    }
}
