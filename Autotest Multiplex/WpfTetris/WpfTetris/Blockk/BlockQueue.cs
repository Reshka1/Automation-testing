

using System;

namespace WpfTetris.Blockk
{
    /// <summary>
    /// Класс для очереди блоков, которій отвечает за вібор след блока в игре 
    /// 1 метод - возвращает случайный блок 
    /// 2 - возвращает след блок и обновлят свойства, чтоб не было подяр одинаковых
    /// </summary>
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
              new IBlock(),
              new JBlock(),
              new LBlock(),
              new OBlock(),
              new SBlock(),
              new TBlock(),
              new ZBlock()

        };
        private readonly Random random = new Random();
        public Block NextBlock { get; private set; }
        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }
        public Block GetAndUpdate()
        {
            Block block = NextBlock;
            do
            {
                NextBlock = RandomBlock();
            } 
            while (block.Id == NextBlock.Id);
            return block;
        }
    }
}
