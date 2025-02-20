namespace CruzPatinoDiego_Practica6_EventosdeBoton
{
    public partial class FrmPrincipal : Form
    {
        Random Random = new Random();
        private Random random;
        private List<Button> dynamicButtons;

        public FrmPrincipal()
        {
            InitializeComponent();

         
            random = new Random();
            dynamicButtons = new List<Button>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveButton(btnpares, true);
            MoveButton(btnimpares, false);
        }

        private void MoveButton(Button btn, bool isPar)
        {
            int mayorX = this.ClientSize.Width - (btn.Width - 15);
            int mayorY = this.ClientSize.Height - (btn.Height - 15);
            int nuevoX = Random.Next(0, mayorX);
            int nuevoY = Random.Next(0, mayorY);
            btn.Location = new Point(nuevoX, nuevoY);
            CheckCollisions(btn, isPar);
        }

        private void CheckCollisions(Button btn, bool isPar)
        {
            if (btn.Top <= 0) // Toca la parte superior
                this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (btn.Bottom >= ClientSize.Height) // Toca la parte inferior
            {
                if (isPar) GenerateButtons(5);
                else RemoveButtons(3);
            }
            if (btn.Left <= 0) // Toca la izquierda
            {
                if (isPar) btn.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                else ResetForm();
            }
            if (btn.Right >= ClientSize.Width) // Toca la derecha
            {
                if (!isPar) ChangeColorMultipleTimes(5);
            }
        }

        private void GenerateButtons(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Button newBtn = new Button
                {
                    Size = new Size(90, 70),
                    Location = new Point(random.Next(ClientSize.Width - 50), random.Next(ClientSize.Height - 30)),
                    BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)),
                    Text = "BTN ALEATORIO"
                };
                Controls.Add(newBtn);
                dynamicButtons.Add(newBtn);
            }
        }

        private void RemoveButtons(int count)
        {
            for (int i = 0; i < count && dynamicButtons.Any(); i++)
            {
                Controls.Remove(dynamicButtons.Last());
                dynamicButtons.RemoveAt(dynamicButtons.Count - 1);
            }
        }

        private void ChangeColorMultipleTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
        }

        private void ResetForm()
        {
            BackColor = DefaultBackColor;
            btnpares.Location = new Point(50, 50);
            btnimpares.Location = new Point(190, 50);
            foreach (var btn in dynamicButtons) Controls.Remove(btn);
            dynamicButtons.Clear();
        }

    }
}
