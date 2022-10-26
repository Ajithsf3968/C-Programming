namespace ListDS
{
    public partial class List<Type>
    {
        
        private int _count;
       
        public int Count { get{return _count ;}}
               
        private int _capacity;
        private Type[]_array;       
        public Type this[int i]
        {
            get{return _array[i];}
            set{_array[i]=value;}

        }
         public List()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public List(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Add(Type data)
        {
          
           if(_count==_capacity)
           {
            GrowSize();
           }
           _array[_count]=data;
           _count++;
        }
        public void AddRange(List<Type> list)
        {
            _capacity=_count+list.Count;
            Type []temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=0;i<list.Count;i++)
            {
                temp[i+_count]=list._array[i];
               
            }
            _array=temp;
             _count+=list.Count;
            

        }
        public void Insert(int pos,Type data)
        {
            _capacity+=1;
            Type[]temp=new Type[_capacity];
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
        public void GrowSize()
        {
            _capacity*=2;
            Type []temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
         public int IndexOf(Type data)
        {
            int i;
            int flag=0;
            for(i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    flag=1;
                    
                }
                else
                {
                    flag=0;
                }
            }
            if(flag==1)
            {
              return i;
            }
            else{
                return 0;
            }
        }
        public void Remove(Type data)
        {
            int pos=IndexOf(data);
            RemoveAt(pos);
        }
        public bool Contains(Type data)
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

    }
}