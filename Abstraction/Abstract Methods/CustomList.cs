namespace Abstract_Methods
{
    public partial class CustomList<Type>
    {
        private int _Count;
        private int _Size;

        private Type[] _List;
        public int Count {get{return _Count;}}
        public int Size {get{return _Size;}}

        public CustomList(){
            _Count = 0;
            _Size = 4;
            _List = new Type[_Size];            
        }
        public CustomList(int size){
            _Count = 0;
            _Size = size;
            _List = new Type[_Size];            
        }
        public void Add(Type value){
                if(_Size == _Count){
                    GrowSize();
                }
                _List[_Count] = value;
                _Count++;
        }
        public void GrowSize(){
            _Size = _Size*2;
            Type[] temp = new Type[_Size];
            for(int i = 0 ;i<_Count;i++){
                temp[i] = _List[i];
            }
            _List = temp;
        }
        public void Display(){
            foreach(Type type in _List){
                System.Console.WriteLine(type+"=>");
            }   
        }
    }
}