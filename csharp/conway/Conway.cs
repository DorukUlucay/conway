namespace conway
{
    public class Conway
    {
        int _size;
        int[,] world = null;
        int[,] newWorld = null;

        public Conway(int size)
        {
            _size = size;
            world = new int[_size, _size];
            newWorld = new int[_size, _size];

            //to be moved
            //glider
            world[6, 4] = 1;
            world[7, 5] = 1;
            world[5, 6] = 1;
            world[6, 6] = 1;
            world[7, 6] = 1;
        }

        public int[,] Evolve()
        {
            newWorld = new int[_size, _size];

            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    int neighborCount = getAliveNeighborCount(x, y);

                    if (world[x, y] == 0)
                    {
                        if (neighborCount == 3)
                        {
                            newWorld[x, y] = 1;
                        }
                        else
                        {
                            newWorld[x, y] = world[x, y];
                        }
                    }
                    else
                    {
                        if (neighborCount < 2)
                        {
                            newWorld[x, y] = 0;
                        }
                        else if (neighborCount > 3)
                        {
                            newWorld[x, y] = 0;
                        }
                        else
                        {
                            newWorld[x, y] = world[x, y];
                        }
                    }
                }
            }

            world = newWorld;
            return world;
        }

        bool isOutOfBounds(int x, int y)
        {
            if (x >= _size || x < 0 || y >= _size || y < 0)
            {
                return true;
            }
            return false;
        }

        int getAliveNeighborCount(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (!isOutOfBounds(x + i, y + j))
                    {
                        if (i == 0 && j == 0)
                        {

                        }
                        else
                        {
                            if (world[x + i, y + j] == 1)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
