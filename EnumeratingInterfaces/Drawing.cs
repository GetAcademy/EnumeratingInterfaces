namespace EnumeratingInterfaces
{
    internal class Drawing
    {
        private char[] _chars;
        private int _width;

        public Drawing(int width, int height)
        {
            _width = width;
            var size = width * height;
            _chars = Enumerable.Repeat(' ', size).ToArray();
        }

        public Drawing AddStar(int col, int row)
        {
            var index = row * _width + col;
            _chars[index] = '*';
            return this;
        }
        public Drawing AddT(int col, int row)
        {
            var index = row * _width + col;
            _chars[index] = 'T';
            return this;
        }

        public string Build()
        {
            return new string(_chars);
        }
    }
}
