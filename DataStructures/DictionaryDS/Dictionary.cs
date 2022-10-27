namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        private int _count;
        private int _capacity;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        private KeyValuePair<TKey,TValue>[]_array;
        public TValue this [TKey key]
        {
            get
            {
                TValue value=default(TValue);
                if(IsKeyPresent(key,out value))
                {
                    return value;
                }
                return value;
            }
            set
            {
               int position=KeyPosition(key);
               if(position!=-1)
               {
                _array[position].Value=value;
               }
            }
        }

            public Dictionary()
            {
                _count=0;
                _capacity=4;
                _array=new KeyValuePair<TKey,TValue>[_capacity];
            }
            public Dictionary(int size)
            {
                _count=0;
                _capacity=size;
                _array=new KeyValuePair<TKey,TValue>[_capacity];
            } 
            
            public void Add(TKey key,TValue value)
            {
                  if(_count==_capacity)
                  {
                      GrowSize();
                  }
                  KeyValuePair<TKey,TValue> data=new KeyValuePair<TKey,TValue>();
                  if(!IsKeyPresent(key,out TValue value1))
                  {
                    data.Key=key;
                    data.Value=value;
                    _array[_count]=data;
                    _count++;
                  }
                  else
                  {
                     System.Console.WriteLine("Key is already present ");
                  }
                  
            }
            public void GrowSize()
            {
                _capacity*=2;
                KeyValuePair<TKey,TValue>[] temp=new KeyValuePair<TKey,TValue>[_capacity];
                for(int i=0;i<_count;i++)
                {
                    temp[i]=_array[i];
                }
                _array=temp;
                
            }
            private bool IsKeyPresent(TKey key,out TValue value)
            {
                 for(int i=0;i<_count;i++)
                 {
                    if(_array[i].Key.Equals(key))
                    {
                        value=_array[i].Value;
                        return true;
                    }
                 }
                 value=default(TValue);
                 return false;
            }
             private int KeyPosition(TKey key)
            {
                 for(int i=0;i<_count;i++)
                 {
                    if(_array[i].Key.Equals(key))
                    {
                       
                        return i;
                    }
                 }
             
                 return -1;
            }
            public bool ContainsKey(TKey key)
            {
                return IsKeyPresent(key,out TValue value);
            }
             private bool ContainsValue(TValue value)
            {
                 for(int i=0;i<_count;i++)
                 {
                    if(_array[i].Value.Equals(value))
                    {
                        return true;
                    }
                 }
                 return false;
            }
        
        
        
           
    }
}