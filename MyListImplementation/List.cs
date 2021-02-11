using System;

namespace MyListImplementation
{
    public class List
    {
        private Box _head;
        private Box _tail;
        private Box _current;
        private int _count;

        public List()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public object Current
        {
            get
            {
                return _current.Value;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                return false;
            }

            _current = _current.Next;

            return _current != null;
        }

        public void Add(object value)
        {
            Box box = new Box(value);
            box.Index = _count + 1;

            if (_head == null && _tail == null)
            {
                _head = box;
                _current = box;
                _tail = box;
            }
            else
            {
                _tail.Next = box;
                _tail = box;
            }

            _count++;
        }

        public void Remove(int index)
        {
            _current = _head;

            Box prev = _head;

            if (index == _head.Index)
            {
                _head = _head.Next;
                _current = _head;
            }

            else if (index>_count)
            {
                Console.WriteLine("В списке элемента с таким номером нет, попробуйте другой номер");
            }

            else
            {
                for (int i = 1; i <= _count; i++)
                {
                    if (i < index)
                    {
                        prev = _current;
                        _current = _current.Next;
                    }
                    else if (i == index && index != _count)
                    {
                        prev.Next = _current.Next;
                        _current = null;
                        _current = _head;
                        prev = prev.Next;
                        prev.Index--;
                    }
                    else if (index == _count)
                    {
                        prev.Next = null;
                        _tail = prev;
                        _current = _head;
                    }
                    else
                    {
                        prev.Index--;
                        prev = prev.Next;
                    }
                }
            }
            _count--;

        }
    }
}
