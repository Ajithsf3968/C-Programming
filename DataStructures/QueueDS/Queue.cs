namespace QueueDS
{
    public class Queue<Type>
    {
       //Fields--head,tail,capacity
       //Property--count
        //Array size--4
        private int _count;
       
        public int Count { get{return _count ;}}

        private int _head;
        private int _tail;

        private int _capacity;
        private Type[]_array;

         public Queue()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
            _head=0;
            _tail=0;
        }
        public Queue(int size)
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Enqueue(Type data)
        {
            if(_tail==_count)
            {
                GrowSize();

            }
            _array[_tail]=data;
            _tail++;
            _count++;

        }
        public Type Dequeue()
        {
            Type temp=default(Type);
            if(_head==_tail)
            {
                System.Console.WriteLine("Queue is empty");
                return temp;
            }
            else
            {
                temp=_array[_head++];
                return temp;

            }
        }
        public Type Peek()
        {
            Type temp=default(Type);
            if(Count>0)
            {
                temp=_array[_head];
                return temp;
                
            }
            else
            {
                System.Console.WriteLine("Queue is empty");
                return temp;
            }
            
        }
        public void GrowSize()
        {
              _capacity*=2;
            Type [] temp=new Type[_capacity];
            for (int i=_head;i<_tail;i++)
            {
                temp[i]=_array[i];
            }
                _array=temp;
        }
        public bool Contains(Type data)
        {
            bool flag=false;
            for(int i=_head;i<_tail;i++)
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