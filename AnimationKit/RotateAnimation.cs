using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationKit
{
    public class RotateAnimation
    {
        private Timer timer;
        private Form form;
        private PictureBox pictureBox;
        private int duration;
        private int angleStep;
        private int totalAngle;
        private int currentAngle;

        public RotateAnimation(Form form, int duration, int totalAngle)
        {
            this.form = form; // Speichern der zu animierenden Form
            this.duration = duration; // Gesamtdauer der Animation in Millisekunden
            this.totalAngle = totalAngle; // Gesamtwinkel, um den die Form rotiert werden soll

            pictureBox = new PictureBox
            {
                Size = form.Size,
                Location = Point.Empty,
                BackColor = Color.Transparent
            };

            form.Controls.Add(pictureBox);

            timer = new Timer(); // Erstellen eines Timers zur Steuerung der Animation
            timer.Tick += Timer_Tick; // Hinzufügen des Ereignishandlers für das Tick-Ereignis des Timers
        }

        public void Start()
        {
            currentAngle = 0; // Setzen des aktuellen Winkels auf 0
            int steps = duration / 10; // Berechnen der Anzahl der Schritte basierend auf der Dauer (hier: 10ms pro Schritt)
            angleStep = totalAngle / steps; // Berechnen des Winkel-Schritts für jeden Schritt der Animation

            timer.Interval = 10; // Setzen des Timer-Intervalls auf 10ms
            timer.Start(); // Starten des Timers zur Durchführung der Animation
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentAngle >= totalAngle)
            {
                timer.Stop(); // Stoppen des Timers, wenn der gewünschte Gesamtwinkel erreicht wurde
            }
            else
            {
                currentAngle += angleStep; // Inkrementieren des aktuellen Winkels um den Schritt

                // Rotieren des PictureBox-Objekts
                pictureBox.Image = RotateImage(form.BackgroundImage, currentAngle);
            }
        }

        private Bitmap RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.DrawImage(image, Point.Empty);
            }

            return rotatedImage;
        }
    }
}
