namespace Palladino.src
{
    internal class GameObjectEmpty
    {
        private Position position;
        private int height;
        private int width;
        public GameObjectEmpty(Position position, int height, int width)
        {
            this.position = position;
            this.height = height;
            this.width = width;
        }

        /// <param name="height">height of object</param>
        public void SetHeight(int height)
        {
            this.height = height;
        }

        /// <param name="height">width of object</param>
        public void SetWidth(int width)
        {
            this.width = width;
        }

        /// <param name="position">position of object</param>
        public void SetPos(Position position)
        {
            this.position = position;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public Position GetPos()
        {
            return this.position;
        }

    }
}