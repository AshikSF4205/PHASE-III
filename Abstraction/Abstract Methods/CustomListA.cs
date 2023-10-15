using System.Collections;

namespace Abstract_Methods
{
    public partial class CustomList<Type> : IEnumerable,IEnumerator
    {
        int i;

        public object Current {get{return _List[i];}}

        public IEnumerator GetEnumerator()
        {
            i = -1;
            return (IEnumerator)this;
        }


        public bool MoveNext()
        {
            if(i<_Count-1){
                i++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            i=-1;
        }

    }
}