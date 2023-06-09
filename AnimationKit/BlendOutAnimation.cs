using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace AnimationKit
{
    public class BlendOutAnimation
    {
        private Timer timer;
        private Form form;
        private int duration;
        private int steps;
        private int currentStep;
        private double opacityStep;

        public BlendOutAnimation(Form form, int duration, int steps)
        {
            this.form = form; // Store the form on which the blend-out effect will be applied
            this.duration = duration; // Store the total duration of the blend-out effect in milliseconds
            this.steps = steps; // Store the number of steps to achieve the blend-out effect

            timer = new Timer(); // Create a timer to control the animation
            timer.Tick += Timer_Tick; // Add the event handler for the timer's Tick event
        }

        public void Start()
        {
            currentStep = 0; // Set the current step to 0
            int interval = duration / steps; // Calculate the time interval between steps
            opacityStep = 1.0 / steps; // Calculate the step change for the form's Opacity property

            timer.Interval = interval; // Set the timer's interval
            timer.Start(); // Start the timer to begin the blend-out effect
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps)
            {
                timer.Stop(); // Stop the timer when all steps are completed
                form.Visible = false; // Set the visibility of the form to false to hide it
            }
            else
            {
                double opacity = form.Opacity - opacityStep; // Calculate the new opacity based on the current step
                form.Opacity = opacity; // Set the form's Opacity property to the new value
                currentStep++; // Increment the current step
            }
        }
    }
}
