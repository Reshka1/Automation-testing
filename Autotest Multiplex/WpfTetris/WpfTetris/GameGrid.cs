
namespace WpfTetris
{
    /// <summary>
    /// этот класс для содержания двумерного прямоугольника
    /// массив первое измерен - строка, второе - столец + создадим свойства для них и определим индекатор для легкого доступа к массиву
    /// для них созданы свойства и определен индексатор для легкого доступа к массиву 
    /// первый метод будет проверять есть ли заданая строка или столбец внутри сетки
    /// второй - пуста ли данная ячейка
    /// 3 - заполнена ли вся строка
    /// 4 - пуста ли вся строка
    /// 5 - перемещение строки вниз, если строка пустая
    /// 6 - перемещение на пределенное количество строк
    /// </summary>

    public class GameGrid
    {
        private readonly int[,] grid;

        public int Rows { get; }
        public int Columns { get; }

        public int this [int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }

        public bool IsInside (int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }

        public bool IsEmpty(int r, int c)
        {
            return IsInside(r,c) && grid[r,c] == 0;
        }

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r,c] ==0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void ClearRow(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = 0;
            }
        }

        private void MoveRowDown(int r, int numRows)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r + numRows, c] = grid[r, c];
                grid[r, c] = 0;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;
            for (int r = Rows - 1; r >=0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }
            return cleared;
        }
    }

}
