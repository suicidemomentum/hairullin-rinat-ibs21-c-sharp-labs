using System.Collections;

namespace DynamicArrayClass 
{
    internal class DynamicArray<Type> : IEnumerable<Type>, IDisposable
    {
        public delegate void DynamicArrayHandler(Object sender, DynamicArrayEventArgs e);
        public event DynamicArrayHandler? Notify;

        private bool _disposed = false;

        private Type[] _array;
        private int _length;
        private int _capacity;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Type> GetEnumerator()
        {
            return new DynamicArrayEnumerator<Type>(_array, Length);
        }

        public DynamicArray()
        {
            _array = new Type[8];
            Length = 0;
        }

        public DynamicArray(int capacity)
        {
            _array = new Type[capacity];
            Length = 0;
        }

        public DynamicArray(IEnumerable<Type> collection)
        {
            Length = GetLengthCollection(collection);
            _array = new Type[Length];

            CopyCollectionToArray(collection, 0);
        }

        private int GetLengthCollection(IEnumerable<Type> collection)
        {
            int length = 0;

            foreach (var item in collection)
            {
                if (!item.Equals(default(Type)))
                {
                    length++;
                }
            }

            return length;
        }

        private void CopyCollectionToArray(IEnumerable<Type> collection, int index)
        {
            foreach (var item in collection)
            {
                if (!item.Equals(default(Type)))
                {
                    _array[index] = item;
                    index++;
                }
            }
        }

        public void Add(Type element)
        {
            if (Length >= Capacity)
            {
                ResizeArray(Capacity * 2);
            }

            _array[Length] = element;
            Length++;
        }

        public void ResizeArray(int capacity)
        {
            Notify?.Invoke(this, new DynamicArrayEventArgs(Capacity, capacity));
            Array.Resize(ref _array, capacity);
        }

        public void AddRange(IEnumerable<Type> collection)
        {
            int length = GetLengthCollection(collection);
            int tempLength = Length;
            Length += length;

            if (Length > Capacity)
            {
                ResizeArray(Length);
            }

            CopyCollectionToArray(collection, tempLength);
        }

        public void Remove(Type element, Func<Type, Type, bool> equals = null)
        {
            if (equals == null)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (element.Equals(_array[i]))
                    {
                        DeleteElement(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (equals(element, _array[i]))
                    {
                        DeleteElement(i);
                    }
                }
            }
        }

        private void DeleteElement(int ind)
        {
            for (int i = ind; i + 1 < Length; i++)
            {
                _array[i] = _array[i + 1];
            }

            _array[Length - 1] = default(Type);
            Length--;
        }

        public void Insert(Type element, int index)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException($"Index {index} doesn`t exist in this collection!");
            }

            Length++;
            ResizeArray(Capacity + 1);

            for (int i = Length - 1; i != index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = element;
        }

        public int Length
        {
            private set
            {
                _length = value;
            }
            get
            {
                return _length;
            }
        }

        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }

        public Type this[int index]
        {
            get
            {
                CheckIndex(index);
                return _array[index];
            }
            set
            {
                CheckIndex(index);
                _array[index] = value;
            }
        }

        private void CheckIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException($"Index {index} doesn`t exist in this collection!");
            }
        }

        public override bool Equals(object? obj)
        {
            if (Length != (obj as DynamicArray<Type>).Length)
                return false;
            for (int i = 0; i < Length; i++)
            {
                if (!_array[i].Equals((obj as DynamicArray<Type>)[i]))
                    return false;
            }
            return true;
        }

        public static explicit operator Type[](DynamicArray<Type> array)
        {
            return array._array.Clone() as Type[];
        }
        
        public static implicit operator DynamicArray<Type>(Type[] array)
        {
            return new DynamicArray<Type> (array);
        }

        public static bool operator !=(DynamicArray<Type> firstArray, DynamicArray<Type> secondArray)
        {
            return !firstArray.Equals(secondArray);
        }

        public static bool operator ==(DynamicArray<Type> firstArray, DynamicArray<Type> secondArray)
        {
            return firstArray.Equals(secondArray);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                foreach (var item in _array)
                {
                    if (item is IDisposable)
                    {
                        ((IDisposable)item).Dispose();
                    }
                }
                Notify?.Invoke(this, new DynamicArrayEventArgs(Capacity, 0));
                Array.Clear(_array);
                Length = 0;
            }
            // освобождаем неуправляемые объекты
            _disposed = true;
        }

        ~DynamicArray()
        {
            Dispose(false);
        }

        public void PrintArray() //удалить
        {
            for (int i = 0; i < Capacity; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
