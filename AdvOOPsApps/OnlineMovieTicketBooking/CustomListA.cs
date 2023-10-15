using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{

    /// <summary>
    /// Partial Class used to CustomList Datatype creation
    /// </summary>
    public partial class CustomList<Type>
    {
        /// <summary>
        /// field for return the count of list <see cref="CustomList"/> class
        /// </summary>
        private int _count;

        /// <summary>
        /// field for return the size of list <see cref="CustomList"/> class
        /// </summary>
        private int _size;

        // property
        /// <summary>
        /// Property name used to get count of list
        /// </summary>
        /// <value>int returnType</value>
        public int Count { get { return _count; } }

        // property
        /// <summary>
        /// Property name used to get size/capacity of list
        /// </summary>
        /// <value>int returnType</value>
        public int Capacity { get { return _size; } }

        /// <summary>
        /// field for return the array of list <see cref="CustomList"/> class
        /// </summary>
        private Type[] _array;

        /// <summary>
        /// field for return the temp array of list <see cref="CustomList"/> class
        /// </summary>
        private Type[] temp;

        //Indexer
        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        // constructor
        /// <summary>
        /// Constructor used to get properties of list
        /// </summary>
        /// <param name="_size"></param>
        /// <param name="_count"></param>
        /// <param name="_array"></param>
        public CustomList()
        {
            _size = 4;
            _count = 0;
            _array = new Type[_size];
        }

        // constructor
        /// <summary>
        /// Constructor used to get properties of list
        /// </summary>
        /// <param name="_size"></param>
        /// <param name="_count"></param>
        /// <param name="_array"></param>
        public CustomList(int size)
        {
            _size = size;
            _count = 0;
            _array = new Type[_size];
        }

        // Add Method
        /// <summary>
        /// Method used to add elements to the list
        /// </summary>
        /// <param name="data"></param>
        public void Add(Type data)
        {
            if (_count == _size)
            {
                GrowSize();
            }
            _array[_count] = data;
            _count++;
        }

        // GrowSize Method
        /// <summary>
        /// Method used to grow the size of the list
        /// </summary>
        private void GrowSize()
        {
            _size *= 2;
            temp = new Type[_size];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        // AddRange Method
        /// <summary>
        /// Method used to Add a range to the current list
        /// </summary>
        /// <param name="dataList"></param>
        public void AddRange(CustomList<Type> dataList)
        {
            _size += dataList.Capacity;
            temp = new Type[_size];
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

        // Insert Method
        /// <summary>
        /// Method used to insert an element at an index
        /// </summary>
        /// <param name="position, data"></param>
        public void Insert(int position, Type data)
        {

            _size++;
            temp = new Type[_size];
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

        // RemoveAt Method
        /// <summary>
        /// Method used to remove an element at an index
        /// </summary>
        /// <param name="position"></param>
        public void RemoveAt(int position)
        {

            for (int i = 0; i < _count; i++)
            {
                if (i >= position)
                    _array[i] = _array[i + 1];
            }
            _array[_count - 1] = default;
            _count--;
        }


    }
}