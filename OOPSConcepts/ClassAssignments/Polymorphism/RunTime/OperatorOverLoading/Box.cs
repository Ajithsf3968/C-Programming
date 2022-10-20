namespace OperatorOverLoading
{
    class Box
    {
        private double _length;
        private double _breadth;
        private double _height;
        public Box()
        {

        }
        public Box(double length,double breath,double height)
        {
            _length=length;
            _breadth=breath;
            _height=height;
        }
        public double CalculateVolume()
        {
           return _length*_breadth*_height;
             
        }
        public static Box operator +(Box box1,Box box2)
        {
            Box box = new Box();
            box._length=box1._length+box2._height;
            box._height=box1._height+box2._height;
            box._breadth=box1._breadth+box2._breadth;
            return box;

        }
        public Box Add(Box box1,Box box2)
        {
            Box box = new Box();
            box._length=box1._length+box2._height;
            box._height=box1._height+box2._height;
            box._breadth=box1._breadth+box2._breadth;
            return box;

    
      
        }
    }

}