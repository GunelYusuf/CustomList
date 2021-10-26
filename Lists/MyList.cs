using System;
using System.Collections.Generic;

namespace Lists
{
    public class MyList<T>
    {
        private T[] arr;
        public int count { get; set; }

        public MyList()
        {
            arr = new T[10];
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    if (index < count)
                    {
                        return arr[index];
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Bu index movcud deyil");
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentOutOfRangeException("Bu index movcud deyil");
                }

            }
            set
            {
                try
                {
                   arr[index] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Out of Range");
                }
            }
        }

        

        public void Add(T obj)
        {
            if ((count!=0)&&(count%10==0))
            {
                ArrayResize();
            }
            arr[count] = obj;
            count++;
        }

        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);
        }

        public void Clear()
        {
            arr = new T[10];
            count = 0;
        }

        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public T Find(Predicate<T> func)
        {
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
            }return default;
            
        }

        public bool Contains(T obj)
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item,obj)==0)
                {
                    return true;
                }
            }return false;
            
        }

        public int Count
        {
            get
            {
                foreach (var item in arr)
                {
                   if (item!=null)
                   {
                        Console.WriteLine(item);
                   }
                }return count;
            }
        }


        public bool Remove(T obj)
        {
            foreach (var item in arr)
            {
                if (Contains(obj))
                {


                }

            }
            return false;
        }


        public int IndexOf(T obj)
        {
            foreach (var item in arr)
            {

            }


            return default;
        }


    }
}
