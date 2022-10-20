namespace Interface
{
    public class Square:Icalculate
    {
        private int _number;
        public int Number {get {return _number;} set{_number=value;}}
        public int Calculate ()
        {
            _number*=_number;
            return _number;
        }
    }
}