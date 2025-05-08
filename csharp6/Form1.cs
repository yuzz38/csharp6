namespace csharp6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку
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

            // добавляем телепорт к эмиттеру
            emitter.impactPoints.Add(teleport);

            // привязываем гравитоны к полям
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

            //// привязываем поля к эмиттеру
            //emitter.impactPoints.Add(point1);
            //emitter.impactPoints.Add(point2);
        }




        // функция рендеринга


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void picDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // левая кнопка - перемещаем вход
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                // правая кнопка - перемещаем выход
                teleport.ExitX = e.X;
                teleport.ExitY = e.Y;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
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
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpread.Value;
            lblSpread.Text = $"{tbSpread.Value}°";
        }

      
    }
}
