using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public partial class CustomList<Type>
    {
        private int _size;
        private int _count;
        private Type[] _array;


        public int Count { get { return _count; } }
        public int Capacity { get { return _size; } }

        public Type this[int index] { get { return _array[index]; } set { _array[index] = value; } }


        public CustomList()
        {
            _size = 4;
            _count = 0;
            _array = new Type[_size];
        }

        public CustomList(int size)
        {
            _size = size;
            _count = 0;
            _array = new Type[_size];
        }

        public void Add(Type data)
        {
            if (_count == _size)
            {
                GrowSize();
            }
            _array[_count++] = data;
        }

        public void GrowSize()
        {
            _size = _size * 2;
            Type[] temp = new Type[_size];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> dataList)
        {
            _size = _size + dataList.Count + 4;
            Type[] temp = new Type[_size];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = 0; i < dataList.Count; i++)
            {
                temp[_count++] = dataList[k++];
            }
            _array = temp;
        }

        public void Insert(int position, Type data)
        {
            _size++;
            for (int i = 0; i < _count; i++)
            {
                if (i == position)
                {
                    _array[i] = data;
                }
                if (i > position)
                {
                    _array[i] = _array[i - 1];
                }
            }
            _count++;
        }

        public void RemoveAt(int position)
        {
            _size--;
            for (int i = 0; i < _count; i++)
            {
                if (i == position || (i > position && i + 1 < _count))
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }
        public void RemoveRange(int position1, int position2)
        {
            for (int i = position2; i < _count; i++)
            {
                _array[position1++] = _array[i];
            }
            _count = position1;
        }

    }
}