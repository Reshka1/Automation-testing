
namespace WpfTetris
{
    /// <summary>
    /// чтоб указать позицию в сетке, класс буде хранить строку и столбец
    /// </summary>
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
