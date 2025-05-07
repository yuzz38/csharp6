namespace csharp6
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

           
        }
        private void UpdateState()
        {
            foreach (var particle in particles)
            {

                particle.Life -= 1; // уменьшаю здоровье
                
            // если здоровье кончилось
                if (particle.Life < 0)
                {
                    // восстанавливаю здоровье
                    particle.Life = 20 + Particle.rand.Next(100);
                    // перемещаю частицу в центр
                    
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    // восстанавливаю здоровье
                    
                    /* Ё“ќ ƒќЅј¬Ћяё, тут сброс состо€ни€ частицы */
                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
                    /* конец Ё“ќ ƒќЅј¬Ћяё  */
                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
                {
                    // а у тут уже наш новый класс используем
                    var particle = new ParticleColorful();
                    // ну и цвета мен€ем
                    particle.FromColor = Color.Yellow;
                    particle.ToColor = Color.FromArgb(0, Color.Magenta);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        // функци€ рендеринга
        private void Render(Graphics g)
        {
            // утащили сюда отрисовку частиц
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
        int counter = 0; // добавлю счетчик чтобы считать вызовы функции
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();
            counter++; // увеличиваю значение счетчика каждый вызов
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                Render(g);
                foreach (var particle in particles)
                {
                    particle.Draw(g);
                }
                // рисую на изображении сколько насчитал
               

            }
            picDisplay.Invalidate();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные дл€ хранени€ положени€ мыши
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}
