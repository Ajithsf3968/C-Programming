using System;
namespace StackDS;

    public class Stack<Type>
    {
        private int _count;
       
        public int Count { get{return _count ;}}
        private int _capacity;
        private Type[]_array;
        public Stack()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void push(Type data)
        {
          
            if(_count==_capacity)
            {
                GrowSize();
            }

              _array[_count]=data;
            _count++;
        }
        void GrowSize()
        {
            _capacity*=2;
            Type [] temp=new Type[_capacity];
            for (int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type Peek()
        {
              int top=_count;
            Type temp=default(Type);
            if(Count>0)
            {
                temp=_array[--top];
                return temp;
                
            }
            else
            {
                System.Console.WriteLine("Stack is empty");
                return temp;
            }

        }
         public Type pop()
        {
              
            Type temp=default(Type);
            if(Count>0)
            {
                temp=_array[--_count];
                return temp;
                
            }
            else
            {
                System.Console.WriteLine("Stack is empty");
                return temp;
            }

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
