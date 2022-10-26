namespace ArrayListDS
{
    public partial class ArrayList
    {
        int _count;
        public int Count { get{return _count ;}}
        private int _capacity;
       private dynamic[]_array;  

       public dynamic this[int i]
        {
            get{return _array[i];}
            set{_array[i]=value;}
        }

         


          public ArrayList()
        {
            _count=0;
            _capacity=4;
           _array=new dynamic [_capacity];
        }
        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new dynamic [_capacity];
        }    

        public void Add(dynamic data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        public void AddRange(ArrayList list)
        {
            _capacity=_count+list.Count;
            dynamic []temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=0;i<list.Count;i++)
            {
                temp[i+_count]=list._array[i];
            }
            _array=temp;
            _count+=list._count;
        }
        public void GrowSize()
        {
            _capacity*=2;
            dynamic [] temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public bool Contains(dynamic data)
        {
            bool flag=false;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    flag=true;
                   
                   
                }
                
            }
            if(flag)
            {
                return true;

            }
            else 
            {
                return false;
            }
        
        }
        public void Insert(int pos,dynamic data)
        {
            _capacity+=1;
            dynamic [] temp=new dynamic[_capacity];
             for(int i=0;i<_count;i++)
            {
                if(i<pos)
                {
                    temp[i]=_array[i];
                }
                else if(i==pos)
                {
                   temp[pos]=data;
                }
                else
                {
                   temp[i]=_array[i-1];
                }
            }
            _array=temp;


        }
        public void RemoveAt(int pos)
        {
            for(int i=pos;i<_count;i++)
            {
               _array[i]=_array[i+1];
            }
            _count--;
        }
        
        
        
    }
}