
<a name="readme-top"></a>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/lulv3z/AnimationKit">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">AnimationKit Library</h3>

  <p align="center">
    The AnimationKit library is a collection of animation effects for WinForms applications. <br>
    It provides various animation options to enhance the visual appeal of your forms and user interfaces.
    <br />
    <a href="https://github.com/lulv3z/AnimationKit"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/lulv3z/AnimationKit/releases/latest">Download</a>
    ·
    <a href="https://github.com/lulv3z/AnimationKit/issues/new/choose">Report Bug</a>
    ·
    <a href="https://github.com/lulv3z/AnimationKit/issues/new/choose">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS 
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#features">Features</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>
-->




<!-- ABOUT THE PROJECT -->
## About The Project

<!-- [![Product Name Screen Shot][product-screenshot]](https://example.com) --->

AnimationKit is a powerful library that provides a collection of animation effects for WinForms applications. Whether you're building a desktop application or a custom user interface, AnimationKit offers an easy way to incorporate visually appealing animations to enhance the user experience.

### Features

- **Pre-built Animation Effects:** AnimationKit comes with a wide range of pre-built animation effects such as fade in, slide in, bounce, zoom, and more. These effects can be easily applied to various UI elements, including forms, controls, and images.

- **Customizable Animations:** In addition to the pre-built effects, AnimationKit allows you to create custom animations by defining your own keyframes, easing functions, and duration. This gives you full control over the animation behavior and enables you to create unique and tailored effects.

- **Event-driven Animation Triggers:** AnimationKit supports event-driven animation triggers, allowing you to trigger animations based on specific user interactions or application events. For example, you can animate a button when it is clicked or show a sliding panel when a certain condition is met.

- **Integration with WinForms:** AnimationKit seamlessly integrates with WinForms, making it easy to add animations to your existing projects. It provides a simple API and a set of extension methods that can be used directly on WinForms controls.


<!-- GETTING STARTED -->
### Getting Started

To get started with AnimationKit, please refer to the [Installation](#installation) and [Usage](#usage) sections of this README. There you will find instructions on how to install the library and examples on how to use it in your WinForms application.

We hope AnimationKit will help you bring your WinForms applications to life with captivating animations. If you have any questions, issues, or feature requests, please don't hesitate to [create an issue](https://github.com/glulv3z/AnimationKit/issues). We appreciate your feedback and contributions!


<!-- USAGE EXAMPLES -->
## Usage

To use the AnimationKit library in your WinForms project, follow these steps:

1. Import the relevant namespaces into your form:
```csharp
using AnimationKit;
```
   
2. Create an instance of the desired animation class in your form:
```csharp
private BlendOutAnimation blendOutAnimation;
```
  
3. Initialize the animation object in your form's constructor or load event:
```csharp
blendOutAnimation = new BlendOutAnimation(this, 1000, 50);
```
  
4. Start the animation when needed, for example, on a button click event:
```csharp
private void btnAnimate_Click(object sender, EventArgs e)
{
  blendOutAnimation.Start();
}
```
  
Make sure to adjust the values for duration and steps according to your requirements. <br>
Repeat the above steps for other animation effects in the AnimationKit library.
   

<!-- Examples -->
## Examples
Here are a few examples of how you can use the AnimationKit library in your WinForms project:
```csharp
using System;
using System.Windows.Forms;
using AnimationKit;

namespace MyWinFormsApp
{
    public partial class MainForm : Form
    {
        private BlendOutAnimation blendOutAnimation;

        public MainForm()
        {
            InitializeComponent();

            blendOutAnimation = new BlendOutAnimation(this, 1000, 50);
        }

        private void btnBlendOut_Click(object sender, EventArgs e)
        {
            blendOutAnimation.Start();
        }
    }
}

```

<!-- ROADMAP -->
## Roadmap

- [X] Animations
    - [X] BlendOutAnimation
    - [X] BlendInAnimation
    - [X] SlideAnimation

more Animations coming soon...

See the [open issues](https://github.com/lulv3z/AnimationKit/issues) for a full list of proposed features (and known issues).




<!-- CONTRIBUTING -->
## Contributing

Contributions to the AnimationKit library are welcome! <br>
If you find any issues or have suggestions for new animation effects or improvements, please open an issue or submit a pull request.




<!-- LICENSE -->
## License

The AnimationKit library is licensed under the MIT License. See `LICENSE.txt` for more information.




<!-- CONTACT -->
## Contact

lulv3z - [@lulv3z](https://twitter.com/lulv3z) - lulv3z.contact@gmail.com

Project Link: [https://github.com/lulv3z/AnimationKit](https://github.com/lulv3z/AnimationKit)