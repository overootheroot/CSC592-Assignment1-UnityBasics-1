# CSC 592 Assignment 1 – Unity Basics

**Student:** Jatin Repalli
**Course:** CSC 592 – Virtual Reality
**Assignment:** Assignment 1 – Unity Basics
**Unity Version:** Unity 6.3 LTS
**Template:** Universal 3D (URP)

## Project Overview

This Unity project demonstrates basic Unity scene creation, materials, character movement, camera control, and a 360-degree VR environment. The project contains three scenes and one graduate-student bonus feature.

## Scene 1 – Unity Primitives

This scene contains three different 3D primitives:

* Red cube
* Blue sphere
* Green capsule
* Floor plane

Three separate materials were created and applied to the objects:

* `Mat_Red`
* `Mat_Blue`
* `Mat_Green`

![Scene 1](https://github.com/overootheroot/CSC592-Assignment1-UnityBasics-1/blob/main/Assets/Assigments/Unity%20Basics/Screenshots/Scene1_Primitives.png)

## Scene 2 – Maze

This scene contains a playable maze built using Unity cube objects. The maze includes:

* Outer boundary walls
* Interior maze walls
* A maze exit
* A third-person player character
* Character Controller
* Top-down camera

The Starter Assets Third Person Character Controller and Cinemachine packages are used in this scene.

![Scene 2](https://github.com/overootheroot/CSC592-Assignment1-UnityBasics-1/raw/refs/heads/main/Assets/Assignments/Unity%20Basics/Screenshots/Scene2_Maze.png)

## Scene 3 – 360 VR Environment

This scene displays a 360-degree panoramic environment using a panoramic skybox material. It includes:

* A 360-degree HDRI image
* A panoramic skybox material
* XR Origin
* XR Interaction Manager
* OpenXR and XR Interaction Toolkit support

When viewed using a compatible VR headset, the user can look around the complete 360-degree environment.

![Scene 3](https://github.com/overootheroot/CSC592-Assignment1-UnityBasics-1/raw/refs/heads/main/Assets/Assignments/Unity%20Basics/Screenshots/Scene3_VR360.png)

## Graduate Bonus – Runtime Color Change

The graduate-student bonus feature changes an object's material color while the application is running. The feature is implemented using the `ColorChanger.cs` script.

![Bonus Color Change](https://github.com/overootheroot/CSC592-Assignment1-UnityBasics-1/raw/refs/heads/main/Assets/Assignments/Unity%20Basics/Screenshots/Bonus1_ColorChange.png)

## Controls

* Use the keyboard movement controls to move the character through the maze.
* Use the mouse or camera controls to view the maze.
* A compatible VR headset can be used to look around the 360-degree scene.

## Packages Used

* Starter Assets – Third Person Character Controller
* Cinemachine
* XR Plug-in Management
* OpenXR Plugin
* XR Interaction Toolkit
* Input System

## Asset Credit

The 360-degree HDRI environment image was obtained from Poly Haven.

## Scene Files

The project scenes are located in:

`Assets/Assignments/Unity Basics/Scenes`

* `Scene1_UnityPrimitives.unity`
* `Scene2_Maze.unity`
* `Scene3_VR360.unity`
