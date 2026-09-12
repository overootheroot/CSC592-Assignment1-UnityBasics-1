# CSC 461/592 - Assignment 1 Unity Basics

**Student:** Jatin Repalli  
**Course:** CSC 592  
**Unity Version:** 6000.3.22f1 LTS  
**Project Template:** Universal 3D  

## Scene 1 - Unity Primitives

This scene demonstrates basic 3D environment creation with a cube,
sphere, and capsule placed on a plane. Each shape uses a different
material: red, blue, and green.

![Scene 1](Assets/Assignments/Unity%20Basics/Screenshots/Scene1_Primitives.png)

## Bonus 1 - Runtime Material Color Change

As the required master's-level bonus, I implemented a C# MonoBehaviour
script that changes the sphere's material color automatically at runtime.
A new random color is applied every second.

![Bonus 1](Assets/Assignments/Unity%20Basics/Screenshots/Bonus1_ColorChange.png)

## Scene 2 - Maze with Character Controller

This scene contains a functional maze created from cube primitives.
The Starter Assets Third Person Character Controller allows the player
to navigate through the maze. The walls have colliders, and the camera
follows the player from a top-down perspective.

![Scene 2](Assets/Assignments/Unity%20Basics/Screenshots/Scene2_Maze.png)

## Scene 3 - VR 360 Scene

This scene displays a 360-degree equirectangular HDR image using Unity's
Panoramic Skybox shader. It contains an XR Origin and is configured with
XR Plug-in Management and OpenXR for viewing on a compatible VR headset.
The panoramic environment was verified in Unity's Game view.

![Scene 3](Assets/Assignments/Unity%20Basics/Screenshots/Scene3_VR360.png)

## Controls

- W, A, S, D: Move through the maze
- VR headset movement: Look around the 360-degree environment

## Bonus Completed

- Bonus 1: Runtime material color change

## Packages Used

- Starter Assets Character Controllers
- Cinemachine
- XR Plug-in Management
- OpenXR Plugin
- XR Interaction Toolkit

## 360 Image Credit

Bloem Field Sunrise HDRI from Poly Haven:  
https://polyhaven.com/a/bloem_field_sunrise