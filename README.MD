<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/rexwulf/TomatoTimer">
    <img src="resources/images/logo.png" alt="Logo" width=45% height=25%>
  </a>
</p>
<p align="center">
  A tangy experience to manage your time effectively!
  <br />
  <a href="https://github.com/rexwulf/TomatoTimer/issues">Report Bug</a>
  ·
  <a href="https://github.com/rexwulf/TomatoTimer/issues">Request Feature</a>
</p>




<!-- TABLE OF CONTENTS -->
## Table of Contents

- [Table of Contents](#table-of-contents)
- [About The Project](#about-the-project)
  - [Inspiration](#inspiration)
- [Screenshot](#screenshot)
- [Features:](#features)
- [Built With](#built-with)
- [Installation](#installation)
- [Usage](#usage)
- [Roadmap](#roadmap)
- [License](#license)



<!-- ABOUT THE PROJECT -->
## About The Project
### Inspiration

In our daily work, when we are looking forward to delivering the best results, we sometimes need a laser-like focus on some tasks.
But, there are other things we need to take care of, such as that email, that presentation. 
And we follow dynamic scheduling subconsciously then do busywork throughout the day.

This a good [post](https://buffer.com/resources/work-less/) on replacing busy work with efficient work.

The [Pomodoro Technique](https://en.wikipedia.org/wiki/Pomodoro_Technique) is a time management method that uses a timer to break down work into intervals, traditionally 25 minutes in length.
The goal of the technique is to reduce the impact of internal and external interruptions on focus and flow.

For enforcing this technique quickly each time, I developed a minimal Taskbar tool that can be instantly started and tracked.

## Screenshot
<p align="center">
<img src="resources\images\TimerView.png" width=50% height=45% alt="product">
</p>

## Features:
1. Supports manual cancellation with accuracy.
2. Message pop-up with beep sound to notify the timer expiry.
3. No pause provided to let the user focus on current task.
4. Minimal interface.
5. Tracking in minutes only.

## Built With
* [Winforms](https://github.com/dotnet/winforms)
* [CSDeskBand](https://github.com/dsafa/CSDeskBand)
* [TPL](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl)

## Installation
1. Download ```TomatoTimer.zip``` from the latest [release](https://github.com/rexwulf/TomatoTimer/releases).
2. Run ```InstallWidget.bat``` as an Administrator.
3. Restart Windows Explorer from the Task Manager (```CTRL+SFT+ESC```).
4. Right-click on Taskbar, go to Toolbars, and select "Tomato Timer".



<p align="center">
<img src="resources\images\EnableInTaskBar.png" width=50% height=45% alt="Enable in Taskbar">
</p>

## Usage
1. Right-click the clock icon in the Taskbar.
2. Select a time window out of the given options.
   <p align="center">
   <img src="resources\images\MenuOptions.png" width=20% height=13% alt="Menu options">
   </p>
3. Now a live counter of no. of minutes remaining will be displayed besides the clock icon.
4. To stop or reset the timer (not pause), select the ```Stop``` option from the menu.
5. Once the timer expires or the user cancels it, a message popup will notify the user.
   
   <p align="center">
   <img src="resources\images\MessageBox.png" width=40% height=35% alt="Notification message">
   </p>


<!-- ROADMAP -->
## Roadmap
See the [open issues](https://github.com/othneildrew/Best-README-Template/issues) for a list of proposed features (and known issues).


<!-- LICENSE -->
## License
Distributed under the GPL License. See `LICENSE` for more information.