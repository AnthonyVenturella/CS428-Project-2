# CS428-Project-2

## Built using:
-	[Unity 2019.4.1f1](https://unity3d.com/unity/whats-new/2019.4.1)
-	[Vuforia 9.4.6](https://developer.vuforia.com/downloads/sdk)

Above are the supported versions for code within this project.

The playset and collisions are controlled by unique mars database fiducial markers (astronaut, drone, oxygen) and the goundplane can be viewed with a groundplane marker or with the android app, (found in MARKERS folder) They can be printed out or displayed on a device (printed for best results).

###### To Run Both Playset+Collisions and Ground Plane on PC/Laptop:
>Requires Unity 2019.4.1f1 (or compatible) to be installed on device to view and edit project
    (linked below). Vuforia 9.4.6 is installed and setup already in the project so there is no
    need to install it. To run the playset and the collisions open the project up in unity and
    make sure you are in scene “MainScene”. You will need a webcam attached to your pc and
    image targets printed out from below (Astronaut, Drone, Oxygen) click on the play button
    to run in editor. Bring the image targets up to the webcam and you should see a desk playset
    popup with the astronaut marker, desk collisions will be created with the drone marker (use
    space to toggle visualization), and a bonus “secret room” can be visualized with the oxygen
    marker. This last one was created more for fun and isn’t a deliverable for this project.
    To visualize the life-size ground plane tracker version, switch scene to “GroundPlane” and
    using a printed out ground plane marker (link below) on the floor bring it into the cameras
    view and click on the marker in the unity editor. This will cause the playset to appear life
    size over the marker.

###### To Run Ground Plane App on Android:
>Included with the git repo is an .apk file in the “Android Build” folder. Install this on
    your android device and run. You will not need any of the image targets printed out, instead
    bring your devices camera over a clearing in your floor and tap on the ground where you’d
    like to see the playset spawned. To rebuild go to File > Build settings select platform
    Android (android module must be installed and setup for your unity version) and select build.
    It will build you an .apk file to a location you chose, transfer that to your device and run.


## Resources:
###### sound used:
- http://soundbible.com/464-Typing-On-Keyboard.html

###### assets used:
- https://assetstore.unity.com/packages/3d/props/low-poly-ultimate-pack-54733
