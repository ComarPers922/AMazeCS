using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMazeCS
{
    public enum TileType
    {
        Road, Wall
    }
    public class MazeData
    {
        public readonly TileType[,] Maze;
        public readonly int Size;
        public bool[,] IsPath { private set; get; }

        private readonly bool[,] visited;
        private readonly int[,] direction = new int[4,2]{{-1,0},{0,1},{1,0},{0,-1}};
        public readonly bool[,] solutionVisited;

        public readonly int entranceX = 0;
        public readonly int entranceY = 1;
        public readonly int exitX;
        public readonly int exitY; 

        public MazeData(int size)
        {
            Size = size % 2 == 0 ? size + 1 : size;
            exitX = Size - 1;
            exitY = Size - 2;
            Maze = new TileType[Size,Size];
            visited = new bool[Size,Size];
            IsPath = new bool[Size,Size];
            solutionVisited = new bool[Size,Size];
            Reset();
        }
        public bool inArea(int x, int y)
        {
            return x >= 0 && x < Size && y >= 0 && y < Size;
        }
        public void Reset()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i % 2 == 1 && j % 2 == 1)
                    {
                        Maze[i,j] = TileType.Road;
                    }
                    else
                    {
                        Maze[i,j] = TileType.Wall;
                    }
                    visited[i,j] = false;
                    solutionVisited[i, j] = false;
                    IsPath[i, j] = false;
                }
            }
            Maze[entranceX,entranceY] = TileType.Road;
            Maze[exitX,exitY] = TileType.Road;

            var queue = new RandomQueue<Point>();
            Point first = new Point(entranceX + 1, entranceY);
            queue.Enqueue(first);
            while(!queue.IsEmpty)
            {
                var currentPoint = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int newX = currentPoint.X + direction[i,0] * 2;
                    int newY = currentPoint.Y + direction[i,1] * 2;

                    if (inArea(newX, newY)
                            && !visited[newX,newY]
                            && Maze[newX,newY] == TileType.Road)
                    {
                        queue.Enqueue(new Point(newX, newY));
                        visited[newX,newY] = true;
                        Maze[currentPoint.X + direction[i,0], currentPoint.Y + direction[i,1]] = TileType.Road;
                    }
                }
            }
        }

        public void Solve()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    solutionVisited[i,j] = false;
                    IsPath[i,j] = false;
                }
            }
            bool isSolved = false;
            Queue<Position> queue = new Queue<Position>();
            Position entrance = new Position(entranceX, entranceY);
            queue.Enqueue(entrance);
            visited[entrance.X, entrance.Y] = true;

            while (queue.Count != 0)
            {
                Position currentPosition = queue.Dequeue();

                if (currentPosition.X == exitX && currentPosition.Y == exitY)
                {
                    findPath(currentPosition);
                    isSolved = true;
                    break;
                }

                for (int i = 0; i < 4; i++)
                {
                    int newX = currentPosition.X+ direction[i,0];
                    int newY = currentPosition.Y + direction[i,1];

                    if (inArea(newX, newY)
                            && !solutionVisited[newX, newY]
                            && Maze[newX, newY] == TileType.Road)
                    {
                        Position nextPos = new Position(newX, newY, currentPosition);
                        queue.Enqueue(nextPos);
                        solutionVisited[newX,newY] = true;
                    }
                }
            }
            if (!isSolved)
            {
                throw new Exception("Unsolvable Maze!");
            }
        }
        private void findPath(Position destination)
        {

            Position currentPosition = destination;
            while (currentPosition != null)
            {
                IsPath[currentPosition.X,currentPosition.Y] = true;
                currentPosition = currentPosition.From;
            }
        }
    }
}
