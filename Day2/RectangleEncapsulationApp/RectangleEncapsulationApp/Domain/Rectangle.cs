namespace RectangleEncapsulationApp.Domain
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;
        private const int LowerBound = 1;
        private const int UpperBound = 100;


        //setter are write,methods should do onething 


        public string GetColor() {
            return _color;
        }

        public void SetColor(string color)
        {
            if (color == "red" || color == "blue" || color == "green")
                _color = color;
            else
                _color = "red";
        
        }

        public int GetWidth() {

            return _width;
        }

        public void SetWidth(int width) {

            _width = SanitizeInputDimension(width);
        }

        public int GetHeight() {
            return _height;
        }
        public void SetHeight(int height)
        {

               _height = SanitizeInputDimension( height);
        }

        public  int CalculateArea() { 
         return _width * _height;
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
