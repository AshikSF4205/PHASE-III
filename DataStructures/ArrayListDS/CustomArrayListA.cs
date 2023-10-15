using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDS;

    public partial class CustomArrayList
    {
      
        //fields
        private int _count;

        private int _size;

        //Properties
        public int Count { get { return _count; } }

        public int Capacity { get { return _size; } }

        private dynamic[] _array;
        private dynamic[] temp;

        //Indexer
        public dynamic this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public CustomArrayList()
        {
            _size = 4;
            _count = 0;
            _array = new dynamic[_size];
        }

        public CustomArrayList(int size)
        {
            _size = size;
            _count = 0;
            _array = new dynamic[_size];
        }

        public void Add(dynamic data)
        {
            if (_count == _size)
            {
                GrowSize();
            }
            _array[_count] = data;
            _count++;
        }

        private void GrowSize()
        {
            _size *= 2;
            temp = new dynamic[_size];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomArrayList dataList)
        {
            _size += dataList.Capacity;
            temp = new dynamic[_size];
            int i, j;
            for (i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            i = 0;
            for (j = _count; j < _count + dataList.Count; j++)
            {
                temp[j] = dataList[i];
                i++;
            }
            _array = temp;
            _count = _count + dataList.Count;
        }

        public void Insert(int position, dynamic data)
        {

            _size++;
            temp = new dynamic[_size];
            for (int i = 0; i <= _count; i++)
            {
                if (i < position)
                    temp[i] = _array[i];
                else if (i == position)
                    temp[i] = data;
                else
                    temp[i] = _array[i - 1];
            }
            _array = temp;
            _count++;
        }

        public void RemoveAt(int position)
        {

            for (int i = 0; i < _count; i++)
            {
                if (i >= position)
                    _array[i] = _array[i + 1];
            }
            _array[_count-1] = default;
            _count--;
        }

    }
