namespace ArrayListDS
{
    public partial class ArrayList
    {
        public int IndexOf(dynamic data)
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
        public void Remove(dynamic data)
        {
            int pos=IndexOf(data);
           RemoveAt(pos);
        }
        
    }
}