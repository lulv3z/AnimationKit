using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationKit
{
    /// <summary>
    /// Represents a blend-in animation that gradually increases the opacity of a form.
    /// </summary>
    public class BlendInAnimation
    {
        private Timer timer;
        private Form form;
        private int duration;
        private int steps;
        private int currentStep;
        private double opacityStep;

        /// <summary>
        /// Initializes a new instance of the BlendInAnimation class.
        /// </summary>
        /// <param name="form">The form on which the blend-in effect will be applied.</param>
        /// <param name="duration">The total duration of the blend-in effect in milliseconds.</param>
        /// <param name="steps">The number of steps to achieve the blend-in effect.</param>
        public BlendInAnimation(Form form, int duration, int steps)
        {
            this.form = form; // Store the form on which the blend-in effect will be applied
            this.duration = duration; // Store the total duration of the blend-in effect in milliseconds
            this.steps = steps; // Store the number of steps to achieve the blend-in effect

            timer = new Timer(); // Create a timer to control the animation
            timer.Tick += Timer_Tick; // Add the event handler for the timer's Tick event
        }

        /// <summary>
        /// Starts the blend-in animation.
        /// </summary>
        public void Start()
        {
            currentStep = 0; // Set the current step to 0
            int interval = duration / steps; // Calculate the time interval between steps
            opacityStep = 1.0 / steps; // Calculate the step change for the form's Opacity property

            timer.Interval = interval; // Set the timer's interval
            timer.Start(); // Start the timer to begin the blend-in effect
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps)
            {
                timer.Stop(); // Stop the timer when all steps are completed
                // Animation completed
            }
            else
            {
                double opacity = form.Opacity + opacityStep; // Calculate the new opacity based on the current step
                form.Opacity = opacity; // Set the form's Opacity property to the new value

                currentStep++; // Increment the current step
            }
        }
    }
}
