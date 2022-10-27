using System.Collections;
namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>:IEnumerable,IEnumerator
    {
        private int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position <Count-1)
            {
                ++position;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;

        }
        public object Current
        {
            get{return _array[position];}
        }
    }
}