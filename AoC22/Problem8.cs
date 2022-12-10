namespace AoC22
{
    namespace Problem8
    {
        
        public class Grid
        {
            private List<List<int>> _grid = new(); 
            public Grid(string input)
            {
                foreach (var line in input.Split(Environment.NewLine))
                {
                    _grid.Add(line.Select(x => int.Parse(x.ToString())).ToList());
                }
            }

            public int GetGridAt(int x, int y)
            {
                if (x < 0 || y < 0 || x >= GetGridWidth() || y >= GetGridHeight())
                {
                    return -1;
                }
                
                return _grid[y][x];
            }
            
            public int GetGridHeight()
            {
                return _grid.Count;
            }
            
            public int GetGridWidth()
            {
                return _grid[0].Count;
            }

            public int GetBiggestLeft(int x, int y)
            {
                int biggest = -1;
                for (int i = 0; i < x; i++)
                {
                    if (GetGridAt(i, y) > biggest)
                    {
                        biggest = GetGridAt(i, y);
                    }
                }

                return biggest;
            }
            
            public int GetBiggestRight(int x, int y)
            {
                int biggest = -1;
                for (int i = x + 1; i < GetGridWidth(); i++)
                {
                    if (GetGridAt(i, y) > biggest)
                    {
                        biggest = GetGridAt(i, y);
                    }
                }

                return biggest;
            }
            
            public int GetBiggestDown(int x, int y)
            {
                int biggest = -1;
                for (int i = y + 1; i < GetGridHeight(); i++)
                {
                    if (_grid[i][x] > biggest)
                    {
                        biggest = _grid[i][x];
                    }
                }

                return biggest;
            }

            public int GetBiggestUp(int x, int y)
            {
                int biggest = -1;
                for (int i = 0; i < y; i++)
                {
                    if (_grid[i][x] > biggest)
                    {
                        biggest = _grid[i][x];
                    }
                }

                return biggest;
            }

            public bool IsVisibleFromUp(int x, int y)
            {
                return GetGridAt(x, y) > GetBiggestUp(x, y);
            }

            public bool IsVisibleFromDown(int x, int y)
            {
                return GetGridAt(x, y) > GetBiggestDown(x, y);
            }

            public bool IsVisibleFromLeft(int x, int y)
            {
                return GetGridAt(x, y) > GetBiggestLeft(x, y);
            }

            public bool IsVisibleFromRight(int x, int y)
            {
                return GetGridAt(x, y) > GetBiggestRight(x, y);
            }

        }
        
        public class Problem8: IProblem<long>
        {
            public long Solve(string input)
            {
                var grid = new Grid(input);
                var count = 0;
                for (int i = 0; i < grid.GetGridWidth(); i++)
                {
                    for (int j = 0; j < grid.GetGridHeight(); j++)
                    {
                        if (grid.IsVisibleFromDown(i, j) || grid.IsVisibleFromUp(i, j) || grid.IsVisibleFromRight(i, j)
                            || grid.IsVisibleFromLeft(i, j))
                        {
                            ++count;
                        }
                    }
                }

                return count;
            }

            public long Solve2(string input)
            {
                throw new NotImplementedException();
            }
        }        
    }
}

