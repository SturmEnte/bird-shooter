namespace bird_shooter
{
    public partial class MainWindow : Form
    {

        private static int WIDTH = 800;
        private static int HEIGHT = 500;

        private Random random;

        private Direction targetDirection;

        public MainWindow()
        {
            InitializeComponent();

            random = new Random();

            int[] position = generateRandomCoords();
            target.Location = new Point(position[0], position[1]);
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        public void target_Click(object sender, EventArgs e)
        {
            int[] position = generateRandomCoords();
            target.Location = new Point(position[0], position[1]);
        }

        private int[] generateRandomCoords()
        {
            int[] coords = new int[2];

            coords[0] = random.Next(0, WIDTH - target.Width);
            coords[1] = random.Next(0, HEIGHT - target.Height);

            return coords;
        }

        private Direction selectRandomDirection()
        {
            int randomNumber = random.Next(1, 8);
            Direction direction;

            switch(randomNumber)
            {
                case 1:
                    direction = Direction.Up;
                    break;
                case 2:
                    direction = Direction.UpRight;
                    break;
                case 3:
                    direction = Direction.Right;
                    break;
                case 4:
                    direction = Direction.DownRight;
                    break;
                case 5:
                    direction = Direction.Down;
                    break;
                case 6:
                    direction = Direction.DownLeft;
                    break;
                case 7:
                    direction = Direction.Left;
                    break;
                case 8:
                    direction = Direction.UpLeft;
                    break;
            }

            return direction;
        }
    }

    enum Direction
    {
        Up,
        UpRight,
        UpLeft,
        Right,
        DownRight,
        Down,
        DownLeft,
        Left,
    }
}
