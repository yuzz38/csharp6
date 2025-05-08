namespace csharp6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point1; // ������� ���� ��� ������ �����
        GravityPoint point2; // ������� ���� ��� ������ �����
        TeleportPoint teleport;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDown);
            this.emitter = new TopEmitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);
            teleport = new TeleportPoint
            {
                X = 100,
                Y = 100,
                ExitX = 700,
                ExitY = 100
            };

            // ��������� �������� � ��������
            emitter.impactPoints.Add(teleport);

            // ����������� ��������� � �����
            //point1 = new GravityPoint
            //{
            //    X = picDisplay.Width / 2 + 100,
            //    Y = picDisplay.Height / 2,
            //};
            //point2 = new GravityPoint
            //{
            //    X = picDisplay.Width / 2 - 100,
            //    Y = picDisplay.Height / 2,
            //};

            //// ����������� ���� � ��������
            //emitter.impactPoints.Add(point1);
            //emitter.impactPoints.Add(point2);
        }




        // ������� ����������


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void picDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ����� ������ - ���������� ����
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                // ������ ������ - ���������� �����
                teleport.ExitX = e.X;
                teleport.ExitY = e.Y;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // ��� ������ ��������� �������

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // � ��� ������ �������� ����� �������
            }

            picDisplay.Invalidate();
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }
            //point2.X = e.X;
            //point2.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}�";
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpread.Value;
            lblSpread.Text = $"{tbSpread.Value}�";
        }

      
    }
}
