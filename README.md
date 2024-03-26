# GobblingGator

This game was created solely by Matthew Mahan for CSC 477.

## Design

All assets for this game were created solely by me. 

### Models

Models were created using Blender with some advice from an outside friend. The board has a gator design was made in Aseprite and is related to a missed feature. All other materials are basic flat color albedo materials. Some parts of the frame were exported in pieces to create collision meshes for it. 

### Sounds 

The song is titled "ink jet toner" and was created using LMMS last year. The sound effect for the bouncers was mixed in HitFilm and constructed from multiple recordings using my phone and objects in my shed. It is borrowed from a previous project which needed a similar sound effect. 

### Missed features 

I originally envisioned a rail going from the gator's mouth and up its tail that the ball could be launched into for extra points.

I originally wanted to add the ability to bump/tilt the machine using Space like you can with real pinball machines. 

## Scripting

For scripting, everything is event-driven and controlled by physics. 

### InputHandler

There is a dedicated GameObject called InputHandler for listening to user input and sending signals when there is a change. 

### Board and Ball

The board and ball are simple physics objects that can collide with each other. The ball has a bouncy physics material. The board has a child object which is just a trigger box that teleports the ball to the launch tube when it falls into the pit. There is also an invisible "glass" box over the top to prevent the ball from escaping. 

### Launcher

The launcher listens for the DownArrow key to be pressed down or released from the InputHandler. On press, a force is continuously applied to the launcher downwards. On release, the force is released. 

The launcher is also attached to the board by a spring joint, so releasing the down arrow allows all of the stored energy in the spring to be released all at once. 

### Paddles

At first, I attempted to manually set the rotation of the paddles according to a duration, but this failed to interact with the ball correctly.

Instead, the paddles are physics objects which can rotate around a pivot. The tip of the paddles are attached to a spring which holds them down. 

When the InputHandler sends a left or right arrow key down signal, the associated paddle has a torque applied to it to raise it up quickly. On release, the torque is removed, and the spring joint brings it back to resting position. There is also a physics material to make them slightly bouncy. 

I wish I had time to refactor these scripts because there's little reason that they should be separate at all. 

### Bouncers 

The bouncers have two colliders. One collider is for physics which has a bouncy material applied for the ball to ricochet off of. The other collider is a trigger for detecting a hit. 

When a hit is detected, a sound is played, and a signal is emitted. The signal is received by the UI which updates the text on the score board. 

## Challenges

### Collision

I did not anticipate colliders needing to be convex, so re-exporting many pieces of the frame was tedious. 

Unity seems to treat position and rotation globally than Godot, which is where I am coming from. In Godot, all transforms and other world-related components in scripting are local by default. Conversely, in Unity, the opposite is true. To get global rotation in degrees, you ask for `transform.eulerAngles`, and to get the local rotation, you ask for `transform.localEulerAngles`. This caused me a lot of grief while scripting the paddles. 
