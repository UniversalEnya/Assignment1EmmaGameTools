# Space Battle Project
For this assignment I intend on recreating parts of the huge space battle from the last episode of Gundam Build Fighters.

[Full Episode for Reference](https://www.youtube.com/watch?v=ZTGoBVP9Q_k)
~~Roughly scene from 5:43 to 10:19~~

![Storyboard](https://raw.githubusercontent.com/UniversalEnya/GamesEngines2/master/Space%20Battle%20Storyboard.jpg)

### Description of the assignment
I space battle scene from the final episode "Promise" of the series Gundam Build Fighters. 
My final submission is moreso a condensed verson of the scenes between 5:23 and 7:01 in the video linked above. 

### Instructions
The project will play automatically when you open the file. 

### How it works
- Models with the "protag" tag (Short for protaganist) have a seek script attached, their target is the center of the giant enemy fortess (0,0,0).
- The scene manager has a camera change script attached to it which uses a coroutine to change which camera is active after a few seconds.
- The enemy ships, the ones with the "mock" tag, will persue a random protag sorted into a list by the scene manager, (this code doesn't work properly, I think that might be because they both start at the same time). 
- If a protaganist ship with "fight" set to true is near a mock it will start shooting. Mocks will blow up when hit. 

### What I am most proud of in the assignment
It looks nice. 

