using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfTetris.Blockk;
using Block = WpfTetris.Blockk.Block;

namespace WpfTetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// управление пользовательским интерфейсом
    /// Порядок массива не случайный, на входе ноль
    /// 1 метод для правильной настройки элементов управления изображением, считаются строки и столбы, установлена ширина и высота пикселей
    /// 2 прокручиваются все позиции блока 
    /// 3 - перебирает озиции плит и обновляет источник изображения
    /// 4- метод рисует и сетку и блок 
    /// 5 - при нажатии других клавишь ничего не происходит
    /// 6 - видимое меню для выхода из игры
    /// 7 - кликабельность кнопки возобновить игру 
    /// 8 - изменение блков местами, видим предыдущий и следующий 
    /// 9 - показывает здоровье
    /// 10 - пробел чтоб блоки упали
    /// 11 - призрак чтобвиедть куда блок падает
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri ("Assets/TileWHite.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileCyan.jpg",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileBlue.jpg",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileOrange.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileYellow.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileGreen.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TilePurpel.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/TileRed.png",UriKind.Relative)),

        };
        private readonly ImageSource[] blockImages = new ImageSource[]
        {
            new BitmapImage(new Uri ("Assets/EmptyBlock.jpg",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-I.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-J.jpg",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-L.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-O.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-S.png",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-T.jpg",UriKind.Relative)),
            new BitmapImage(new Uri ("Assets/Block-Z.png",UriKind.Relative)),
        };

        private readonly Image[,] imageControls;
        private readonly int maxDelay = 1000;
        private readonly int minDelay = 75;
        private readonly int delayDecrease = 25;


        private GameState gameState = new GameState();
        public MainWindow()
        {
            InitializeComponent();
        }
        private Image [,] SetupGameCanvas(GameGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 25;
            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {
                    Image imageControl = new Image
                    {
                        Width = cellSize,
                        Height = cellSize
                    };
                    Canvas.SetTop(imageControl, (r - 2) * cellSize + 10);
                    Canvas.SetLeft(imageControl, c * cellSize);
                    GameCanvas.Children.Add(imageControl);
                    imageControls[r, c] = imageControl;
                }

            }
            return imageControls;
        }

        private void DrawGrid(GameGrid grid )
        {
            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {
                    int id = grid[r, c];
                    imageControls[r, c].Opacity = 1;
                    imageControls[r, c].Source = tileImages[id];
                }
            }
        }

        private void DrawBlock (Block block)
        {
            foreach (Position p in block.TilePositions())
            {
                imageControls[p.Row, p.Column].Opacity = 1;
                imageControls[p.Row, p.Column].Source = tileImages[block.Id];
            }
        }

        private void DrawNextBlock(BlockQueue blockQueue)
        {
            Block next = blockQueue.NextBlock;
            NextImage.Source = blockImages[next.Id];
        }
        private void DrawHeldBlock(Block heldBlock)
        {
            if (heldBlock == null)
            {
                HoldImage.Source = blockImages[0];
            }
            else
            {
                HoldImage.Source = blockImages[heldBlock.Id];
            }

        }
        private void DrawGhostBlock(Block block)
        {
            int dropDistamce = gameState.BlockDropDistance();
            foreach (Position p in block.TilePositions())
            {
                imageControls[p.Row + dropDistamce, p.Column].Opacity = 0.25;
                imageControls[p.Row + dropDistamce, p.Column].Source = tileImages[block.Id];

            }
        }

        private void Draw (GameState game)
        {
            DrawGrid(gameState.GameGrid);
            DrawGhostBlock(gameState.CurrentBlock);
            DrawBlock(gameState.CurrentBlock);
            DrawNextBlock(gameState.BlockQueue);
            DrawHeldBlock(gameState.HeldBlock);
            ScoreText.Text = $"Score: {gameState.Score}";
        }
        private async Task GameLoop()
        {
            Draw(gameState);
            while (!gameState.GameOver)
            {
                int delay = Math.Max(minDelay, maxDelay - (gameState.Score * delayDecrease));
                await Task.Delay(delay);
                gameState.MoveBlockDown();
                Draw(gameState);
            }
            GameOverMenu.Visibility = Visibility.Visible;
            FinalScoreText.Text = $"Score: {gameState.Score}";
        }
        private void  Window_KeyDown (object sender,KeyEventArgs e)
        {
            if (gameState.GameOver)
            {
                return;
            }
            switch (e.Key)
            {
                case Key.Left:
                    gameState.MoveBlockLeft();
                    break;
                case Key.Right:
                    gameState.MoveBlockRight();
                    break;
                case Key.Down:
                    gameState.MoveBlockDown();
                    break;
                case Key.Up:
                    gameState.RotateBlockCW();
                    break;
                case Key.Space:
                    gameState.DropBlock();
                    break;
                case Key.C:
                    gameState.HoldBlock();
                    break;
                default:
                    return;
            }
            Draw(gameState);
        }
        private async void  GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            await GameLoop();
        }
        private async void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            gameState = new GameState();
            GameOverMenu.Visibility = Visibility.Hidden;
            await GameLoop();
        }
    }
}
