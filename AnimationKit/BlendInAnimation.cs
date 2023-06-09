using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationKit
{
    public class BlendInAnimation
    {
        private Timer timer;
        private Form form;
        private int duration;
        private int steps;
        private int currentStep;
        private double opacityStep;

        public BlendInAnimation(Form form, int duration, int steps)
        {
            this.form = form; // Store the form on which the blend-in effect will be applied
            this.duration = duration; // Store the total duration of the blend-in effect in milliseconds
            this.steps = steps; // Store the number of steps to achieve the blend-in effect

            timer = new Timer(); // Create a timer to control the animation
            timer.Tick += Timer_Tick; // Add the event handler for the timer's Tick event
        }

        public void Start()
        {
            currentStep = 0; // Set the current step to 0
            int interval = duration / steps; // Calculate the time interval between steps
            opacityStep = 1.0 / steps; // Calculate the step change for the form's Opacity property

            form.Visible = true; // Set the visibility of the form to true

            timer.Interval = interval; // Set the timer's interval
            timer.Start(); // Start the timer to begin the blend-in effect
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps)
            {
                timer.Stop(); // Stop the timer when all steps are completed
            }
            else
            {
                double opacity = form.Opacity + opacityStep; // Calculate the new opacity based on the current step
                form.Opacity = Math.Min(opacity, 1.0); // Set the form's Opacity property to the new value, ensuring it doesn't exceed 1.0

                currentStep++; // Increment the current step
            }
        }
    }
}
