using System.Collections;
namespace ArrayListDS
{
    public partial class ArrayList:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
             i=-1;
             return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_capacity-1)
            {
                ++i;
                return true;
            }
            Reset();    //Rset position value if no element in list
            return false;
        }
        public void Reset()    //Reset i for next turn
        {
            i=-1;
        }
        public object Current
        {
            get {return _array[i];}
        }
    }
}