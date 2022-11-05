using System.Collections;

namespace DynamicArrayClass
{
    internal class DynamicArrayEnumerator<Type> : IEnumerator<Type>
    {
        private Type[] _array;
        private int _position = -1;
        private int _length = -1;
        public DynamicArrayEnumerator(Type[] array, int length)
        {
            _array = array;
            _length = length;
        }
        public Type Current
        {
            get
            {
                return CurrentRealization();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return CurrentRealization();
            }
        }

        public void Dispose()
        {
            //пусто
        }

        public bool MoveNext()
        {
            if (_position < _length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() => _position = -1;

        private Type CurrentRealization()
        {
            if (_position == -1 || _position >= _length)
            {
                throw new ArgumentOutOfRangeException("Error in Enumerator");
            }
            return _array[_position];
        }
    }
}