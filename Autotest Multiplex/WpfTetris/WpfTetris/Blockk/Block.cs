

using System.Collections.Generic;

namespace WpfTetris.Blockk
{
    /// <summary>
    /// описывается двумерный массив позиций, который содержит позиции плиток в 4 состояниях
    /// начальное смещение, которое рещает где блок появится в сетке
    /// и идентификатор, который различает блоки 
    /// будет храниться текущее состояние и вращение
    /// 1ый метод перебираетпозиции плитки в текущем состоянии поворота 
    /// 2- поворачивает блок на 90 градусов по часовой стрелке
    /// 3 - аналогично но против часовой
    /// 4 - перемещения блока с заданым количеством строк
    /// 5- метод сброса вращений и положений 
    /// </summary>
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Position offset;

        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }
        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }
        public void RotateCCW()
        {
            if (rotationState ==0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void Move (int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }
        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }

    }
}
