namespace ListDS
{
    public partial class List<Type>
    {
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