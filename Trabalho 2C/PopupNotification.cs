using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Trabalho_2C
{
    public partial class PopupNotification : Form
    {
        private Timer timer;

        public PopupNotification(string title, string message, int duration)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = RoundCorners(this.ClientRectangle, 15);
            lblTitle.Text = title;
            lblMessage.Text = message;

            // Configurar a posição e o tamanho do formulário
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - this.Width,
                                      Screen.PrimaryScreen.WorkingArea.Bottom - this.Height);

            // Configurar o temporizador para fechar o formulário após a duração especificada
            timer = new Timer();
            timer.Interval = duration;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Fechar o formulário quando o temporizador expirar
            timer.Stop();
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Desenhar um contorno no formulário
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawRectangle(pen, this.ClientRectangle);
            }
        }
        private Region RoundCorners(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
