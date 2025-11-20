namespace RectanglePropertiesApp.Domain
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;
        private BorderStyleOptions _border;

        private const int LowerBound = 1;
        private const int UpperBound = 100;




        public BorderStyleOptions Border { 
        
            get { return _border; }
            set { _border = value; }
        }

       public string Color { 
        
            get { return _color; }
            set { _color = SanitizeColor(value); }
        }

        public int Width
        {
            get { return _width; }
            set { _width = SanitizeInputDimension(value); }
        
        }

        public int Height
        {
            get { return _height; }
            set { 
                _height = SanitizeInputDimension(value); 
            }
        
        }



        public  int CalculateArea() { 
         return _width * _height;
        }


        private string SanitizeColor(string color) {

            if (color == "red" || color == "blue" || color == "green")
                return color;

            return "red";

        }
        private int SanitizeInputDimension(int inputDimension) {

            if (inputDimension < LowerBound)
                return LowerBound;

            if(inputDimension > UpperBound)
                return UpperBound;

            return inputDimension;
        
        }

    }
}
