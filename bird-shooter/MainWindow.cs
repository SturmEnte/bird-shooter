namespace bird_shooter
{
    public partial class MainWindow : Form
    {

        private static int WIDTH = 800;
        private static int HEIGHT = 500;

        private Random random;

        public MainWindow()
        {
            InitializeComponent();

            random = new Random();
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        public void target_Click(object sender, EventArgs e)
        {
            
        }

        private int[] generateRandomCoords()
        {
            int[] coords = new int[2];

            coords[0] = random.Next(0, WIDTH - target.Width);
            coords[1] = random.Next(0, HEIGHT - target.Height);

            return coords;
        }
    }
}
