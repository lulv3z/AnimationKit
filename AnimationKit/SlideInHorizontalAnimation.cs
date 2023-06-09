using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationKit
{
    public class SlideInHorizontalAnimation
    {
        private Timer timer;
        private Form form;
        private int duration;
        private int steps;
        private int currentStep;
        private int slideDistance;
        private int slideStep;

        public SlideInHorizontalAnimation(Form form, int duration, int steps, int slideDistance)
        {
            this.form = form; // Store the form on which the slide effect will be applied
            this.duration = duration; // Store the total duration of the slide effect in milliseconds
            this.steps = steps; // Store the number of steps to achieve the slide effect
            this.slideDistance = slideDistance; // Store the total distance to slide the form

            timer = new Timer(); // Create a timer to control the animation
            timer.Tick += Timer_Tick; // Add the event handler for the timer's Tick event
        }

        public void Start()
        {
            currentStep = 0; // Set the current step to 0
            int interval = duration / steps; // Calculate the time interval between steps
            slideStep = slideDistance / steps; // Calculate the step distance to slide the form

            timer.Interval = interval; // Set the timer's interval
            timer.Start(); // Start the timer to begin the slide effect
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps)
            {
                timer.Stop(); // Stop the timer when all steps are completed
            }
            else
            {
                int newX = form.Location.X + slideStep; // Calculate the new X coordinate based on the current step
                form.Location = new System.Drawing.Point(newX, form.Location.Y); // Set the form's new location

                currentStep++; // Increment the current step
            }
        }
    }
}
