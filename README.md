### 1 Becoming an Android Developer ###

+ Setup Android Studios.
+ Locating the SDK and JDK.
+ Installing the Android SDK.
+ Enabling your phones developer mode.

### 2 Building an Unity Android Project ###

+ Connecting the SDK to Unity.
+ Installing Unity modules individually.
+ Build the Google Cardboard Demo.
+ Deploy to your Android phone.

### 3 Becoming an iOS Developer ###

+ Setup XCode.
+ Configuring an iOS app to deploy.
+ Signing Identities and Provisioning Profiles
+ Deploying your first app.

### 4 Building an Unity iOS Project ###

+ Setup your environment.
+ Build an empty project.
+ Setting your bundle identifier in Unity.
+ Deploy to your iOS phone.

### 5 Setup a VR Camera ###

+ Create a virtual environment.
+ Overview of the Google VR stack.
+ Add stereoscopic cameras to games.
+ Push to your device.

### 5b How to Use GVR 1.70 + Unity 5.6 ###

+ How to upgrade you GVR plugin.
+ Enabling built in Google VR in Unity 5.6.
+ Changes to the event system.
+ How to detect trigger down.
+ Issues with sound scaling.

### 6 UI in VR Environments ###

+ Setting font size and DPI.
+ Where to scale a Rect Transform.
+ Create UI in VR environments.
+ Position and scale for comfort.

### 7 Interacting with Buttons in VR ###

+ Activating UI with Gaze.
+ Revising event based UI.
+ Revising the scene management.

### 8 Google VR Spatial Audio Sources ###

+ What is spatial audio?
+ How can we use it in a menu scene.
+ The GVR audio listener and source.
+ Enabling the spatializer plugin.

### 9 Avoiding Motion Sickness ###

+ Use physics simulation to hop.
+ Editing terrain in the Unity Editor.
+ Adjust rigidbody mechanics for sickness.
+ Tweak materials for frog behaviour.
+ Introducing physics materials.

### 10 Debugging Vectors in Unity ###

+ Projecting vectors onto planes.
+ Rotating and normalizing vectors.
+ Drawing debug lines in Unity.

### 11 Advanced Vector Manipulation ###

+ Getting the look vector of the camera.
+ Sequencing vector operations.
+ Presenting an easy interface to the designer.

### 12 Jumping Only When Grounded ###

+ Getting trigger input from GVR.
+ Using Physics.Raycast().
+ Preventing jumping unless grounded.

### 13 Tile-based Terrain ###

+ Creating a tile-based level.
+ Importing our assets.
+ Adding materials and textures.

### 14 Procedurally Generated Terrain ###

+ Creating lanes of traffic.
+ Generating random numbers.
+ Randomly selecting terrain.
+ Exposing terrain to the designer.

### 15 Generating Infinite Terrain ###

+ Spawning a random number of trees.
+ Removing code repetition.
+ for and while loops.

### 16 Scaling Down or Up ###

+ How to scale Unity units.
+ Altering gravity acceleration.
+ Copying component values.

### 17 Creating Nested Prefabs ###

+ The problem with nested prefabs.
+ How to work around the problem.
+ Adding a collider to our tree.

### 18 Moving Cars with Kinematic Colliders ###

+ Adding car prefabs to the road.
+ Giving them non-physical velocity.
+ Ensuring they can impact the toad.
+ Understanding Kinematic Colliders.
+ Creating a log prefab.

### 19 Spawning Cars Randomly ###

+ Spawning cars with a time interval.
+ Spawning at a given location.
+ Randomizing the time interval.

### 20 Understanding Bell Curves ###

+ Probability Density Functions
+ Cumulative Distributions Functions
+ How to make any distribution in Unity

### 21 Simulating Random Traffic ###

+ What is a Poisson process.
+ Looking at the Exponential distribution.
+ Implementing the Exponential in Unity.

### 22 Moving Rigidbodies Smoothly ###

+ Overview of FixedUpdate().
+ Understanding the physics engine cycle.
+ Making the logs carry the frog.

### 23 Count-based Grounding Checks ###

+ The issue with trigger-based grounding.
+ Why boolean grounding won’t work.
+ An explanation of count-based grounding.
+ Using this to fix jumping on moving platforms.

### 24 Double and Triple Hop Jumping ###

+ Recap for using arrays.
+ Array constant syntax.
+ Understanding array indexing and length.
+ Implementing multi-hop jumping.

### 25 Understanding 3D Rotation ###

+ Rotations in Unity.
+ Euler angle definition of rotation.
+ Angle axis rotations.
+ The importance of rotation order.

### 26 Creating Rotations from Vectors ###

+ An overview of the Quaternion class.
+ Creating rotations between 2 vectors.
+ Keeping the horizon level with LookRotation.
+ Rotating a cube to hover in-front of us.

### 27 HUD UI and Level Reload ###

+ How to reload the current level.
+ Setting up the HUD UI.
+ Revising UI button binding.

### 28 Lethal Objects and Death Notification ###

+ Finding objects from anywhere in the scene.
+ How to notify death.
+ Fixing out multi-hop bug.

### 29 Pausing Game Mechanics ###

+ Disabling movement on death.
+ Adding a safe starting point.
+ Enabling/disabling the reticule.

### 30 Garbage Collecting GameObjects ###

+ Debugging performance slow downs.
+ Destroying old vehicles.
+ Triggers vs Colliders.

### 31 Enums for Labeled Numbers ###

+ How to label “magic” numbers.
+ Preventing runs of dangerous lanes.
+ Enum types and when to use them.

### 32 Locking the Cursor ###

+ Using our Enum knowledge.
+ The Cursor API in Unity.
+ Locking the cursor to the screen.

### 33 Basic Performance Benchmarking ###

+ Introduction to the performance cycle.
+ How to display FPS in our game.
+ Getting a benchmark for performance.
+ Cutting down our game.
+ Disabling VSync.

### 34 Performance Optimization Loop ###

+ Common optimisations to try.
+ Using the iterative process.
+ Unity quality settings.

### 35 Unity Profiler on Mobile ###

+ Using the Unity Profiler.
+ Profiler hierarchies.
+ Profiler timeline.
+ Diagnosing script issues.

### 36 Challenge - Add Level Audio ###

+ Revising spatial audio.
+ Creating immersive sound.
+ Adding audio to our level.

### 37 Spawning and Destroying Lanes ###

+ Using a foreach loop.
+ How to get child transforms.
+ Spawning new lanes with a buffer.
+ Destroying lanes with a buffer.
+ Ideas for continuing the game.

### 38 Generating Infinite Terrain b ###

+ Spawning lanes up to a horizon.
+ Generating new lanes after movement.
+ Randomly selecting terrain.

### 39 Creating a Froggy Inferno ###

+ Learn to make fire! [Read with caveman voice]
+ Create infinitely wide particle systems.
+ Mirror the players movements

### 40 Motivating the Player to Move ###

+ Make the fire creep forward naturally.
+ Tweak the fire to be engrossing.

### 41 Creating a VR Splash Screen ###

+ Create an all encompassing splash screen.
+ Use your gaze to control the UI.

### 42 In-Game Menus in VR ###

+ Set up an in-game menu.
+ Include buttons to reset and go back.
+ Recap EventSystem setup in VR.

### 43 Resetting the Game ###

+ Creating an object to manage game state.
+ How to reset the game.
+ Hook up the buttons to these actions.

### 44 Creating a Head-up Display ###

+ Create a head-up display.
+ Follow the player’s rotation and translation.
+ Prevent clipping with the floor.

### 45 Killing Off the Frog ###

+ How to detect that the game is over.
+ Accessing that state from other objects.
+ Displaying the game over message.

### 46 Spawning the Vehicles ###

+ Creating van and car prefabs.
+ Instantiating at run-time.
+ Positioning them relative to a parent.
+ Configuring their offsets.

### 47 Halting the Game Mechanics ###

+ Holding the state where the player died.
+ Pausing the fire’s progression.
+ Preventing the player jumping.

### 48 Making the Vehicles Move ###

+ Adding speed to the vehicles.
+ Making the speed a property of lanes.
+ Exposing lane speed to the designer.

### 49 Destroying Used Cars ###

+ Destroying the vehicles at the end of lanes.
+ Allowing the designer to configure length.

### 50 Randomly Spawning Vehicles ###



### 51 Cusps and Glitches ###

+ We investigate a glitch.
+ How cusps cause collision issues.
+ Solve the glitch.

### 52 Squashy Car Death ###

+ How to squash a toad.
+ A revision of dynamic vs static colliders.
+ Excluding certain collisions programmatically.

### 53 Debugging Graphical Issues ###

+ Hypothesis generation and testing.
+ Fixing hard to Google graphical bugs.
+ Fixing a graphical bug on the Galaxy Note 4.
