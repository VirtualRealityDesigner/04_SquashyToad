### Section 4 Introduction & Notes ###

+ We’ll build a Crossy Road clone.
+ We will call our clone Squashy Toad!
+ Understand a basic VR camera.
+ Simple one-button VR movement.
+ Overview the Game Design Document (GDD).
+ Download your section notes and assets.

### Setting up for Android development ###

+ Setup your environment
+ Build the Google Cardboard Demo
+ Deploy to your Android phone

### Setting up for iOS development ###

+ Setup your environment
+ Build the Google Cardboard Demo
+ Deploy to your iOS phone

### How to Access Source Code ###



### Setup a VR Camera b ###

+ Create a virtual environment.
+ Add stereoscopic cameras to games.
+ Push to your device.

### VR Gaze Tracking ###

+ Learn about gaze tracking.
+ Test prototypes in Unity.

### UI in VR Environments b ###

+ Create UI in VR environments.
+ Position and scale for comfort.
+ Updating UI programmatically.

### Handling OnTrigger Events ###

+ Handle OnTrigger Events.
+ Use it to manipulate the environment.

### Building for the GearVR ###

+ Build settings for Unity VR.
+ Using the ADB.
+ Obtaining an Oculus Signature (OSIG).
+ Deploying to the GearVR.

### Converting a Scene to GearVR ###

+ How to preview without a Rift.
+ Removing the Cardboard SDK.
+ Converting from Cardboard to GearVR.

### Previewing Gaze in GearVR ###

+ Using scripts to emulate Gaze.
+ Reusing other people’s code.

### Gaze Tracking in GearVR ###

+ How VR manipulates the camera.
+ Getting a gaze vector from our camera.
+ Applying quaternion rotations.

### GearVR Touchpad Input ###

+ How to access the GearVR Touchpad.
+ Revision of GetAxis.
+ Revision of GetButtonDown.

### Adding Physics to VR Cameras ###

+ Use physics simulation to hop.
+ Adjust rigidbody mechanics for sickness.
+ Tweak materials for frog behaviour.

### Natural Jumping in VR ###

+ Expose jumping angles to the game designer.
+ Reduce motion sickness in acceleration.
+ Stop the toad from flying.

### Scaling Down to Toad Size ###

+ Challenges of small VR heads
+ Preventing near culling in Google Cardboard
+ Changing the neck model scale
+ Scaling the physics

### Procedurally generating terrain ###

+ Creating lanes of traffic.
+ Exposing terrain to the designer.

### Generating Infinite Terrain b ###

+ Spawning lanes up to a horizon.
+ Generating new lanes after movement.
+ Randomly selecting terrain.

### Checking a Rigidbody is Grounded ###

+ Problems with current approach
+ Review various solutions
+ Evaluate their various merits

### Creating a Froggy Inferno ###

+ Learn to make fire! [Read with caveman voice]
+ Create infinitely wide particle systems.
+ Mirror the players movements

### Motivating the Player to Move ###

+ Make the fire creep forward naturally.
+ Tweak the fire to be engrossing.

### Creating a VR Splash Screen ###

+ Create an all encompassing splash screen.
+ Use your gaze to control the UI.

### Loading the Game ###

+ Fix contention between input systems.
+ Make the button load the main scene.
+ Workaround for LoadLevel() changing lighting.

### In-Game Menus in VR ###

+ Set up an in-game menu.
+ Include buttons to reset and go back.
+ Recap EventSystem setup in VR.

### Resetting the Game ###

+ Creating an object to manage game state.
+ How to reset the game.
+ Hook up the buttons to these actions.

### Creating a Head-up Display ###

+ Create a head-up display.
+ Follow the player’s rotation and translation.
+ Prevent clipping with the floor.

### Killing Off the Frog ###

+ How to detect that the game is over.
+ Accessing that state from other objects.
+ Displaying the game over message.

### Spawning the Vehicles ###

+ Creating van and car prefabs.
+ Instantiating at run-time.
+ Positioning them relative to a parent.
+ Configuring their offsets.

### Halting the Game Mechanics ###

+ Holding the state where the player died.
+ Pausing the fire’s progression.
+ Preventing the player jumping.

### Making the Vehicles Move ###

+ Adding speed to the vehicles.
+ Making the speed a property of lanes.
+ Exposing lane speed to the designer.

### Destroying Used Cars ###

+ Destroying the vehicles at the end of lanes.
+ Allowing the designer to configure length.

### Randomly Spawning Vehicles ###



### Cusps and Glitches ###

+ We investigate a glitch.
+ How cusps cause collision issues.
+ Solve the glitch.

### Squashy Car Death ###

+ How to squash a toad.
+ A revision of dynamic vs static colliders.
+ Excluding certain collisions programmatically.

### Debugging Graphical Issues ###

+ Hypothesis generation and testing.
+ Fixing hard to Google graphical bugs.
+ Fixing a graphical bug on the Galaxy Note 4.

### Finding The Performance Ceiling ###

+ Benchmarking your device.
+ Basic performance tooling.

### Using the Profiler on Mobile ###

+ Understanding profiler traces.
+ Attaching the profiler to mobile devices.
+ Tweaking build settings for performance.

### Improving Scene Performance ###

+ Debugging performance issues in a scene.
+ Using the profiler to inform our guesses.
+ Making our game run at >40FPS.

### Including the Assets ###

+ Import the Squashy Toad asset pack.
+ Apply a texture to our road.
+ Replace our vehicles with models.

### Creating a Splash Screen ###

+ Adding a static splash screen.
+ Using better scene naming.
+ Loading scenes by build order.
+ Loading scenes after a delay.

### Sharing Code Between Scenes ###

+ Renaming classes with Visual Studio.
+ Centralise the scene loading logic.
+ Generalising the SceneLoader.
+ Using the SceneLoader in all scenes.

### Sharing State Between Scenes ###

+ Sharing state between scenes.
+ Avoiding the singleton anti-pattern.
+ Updating UI text to display dynamic data.
+ Using getters and setters in C#.

### Destroying Burnt Lanes ###

+ Clearing up for better performance.
+ Revising Rigidbody Trigger Colliders.

### Section 4 Wrap-Up ###

+ CONGRATULATIONS on a huge section
+ You're really getting into VR development now
+ Please vary the game and make it your own
+ Start the next section right away!

---
Find out more about our [Virtual Reality Designer Course](https://www.udemy.com/vrcourse/?couponCode=GitHubDiscount).
