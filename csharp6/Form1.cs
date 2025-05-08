namespace csharp6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
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

            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            });

            // ������� ������ ��������
            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            });
        }




        // ������� ����������


        private void Form1_Load(object sender, EventArgs e)
        {

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
            // � ��� � ������� �������� ��������� �����
            //emitter.MousePositionX = e.X;
            //emitter.MousePositionY = e.Y;
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

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint) // ��� ��� impactPoints �� ����������� �������� ���� Power, ���� ��������� �� ��� 
                {
                    // ���� �������� �� ������ ����
                    (p as GravityPoint).Power = tbGraviton.Value;
                }
            }
        }
    }
}
