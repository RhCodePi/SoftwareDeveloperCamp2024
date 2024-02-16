namespace Generics
{
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;

            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public bool SearchItem(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (item.Equals(_array[i]))
                {
                    Console.WriteLine($"{item} item was founded");
                    return true;
                }
            }

            Console.WriteLine($"{item} item that not found ");

            return false;
        }

        public void PrintAll()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"{_array[i]}");
            }
        }

        public int Count => _array.Length;

    }
}
