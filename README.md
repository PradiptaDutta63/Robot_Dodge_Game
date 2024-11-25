# Robot Dodge Game

## Project Overview
**Robot Dodge** is a Windows-based 2D game built using C# and the **SplashKit SDK**. The player controls a character that must dodge various robots appearing on the screen. The robots move towards the player, and the game ends when the player collides with any robot. The game also includes:
- Randomly spawning robots with different shapes and styles.
- Player movement within defined window bounds.
- A simple game loop for rendering and updating gameplay.

---

## Features
1. **Player Control**:
   - Use the arrow keys to move the player.
   - Escape key to quit the game.
   - The player wraps around the screen edges when crossing boundaries.
   
2. **Robot Types**:
   - **Boxy Robots**: Square robots with distinct facial features.
   - **Roundy Robots**: Circular robots with eyes and a mouth.
   - **Frag Robots**: Smaller square robots with unique designs.

3. **Randomized Robot Spawn**:
   - Robots spawn randomly on screen edges.
   - Robots move towards the player.

4. **Collision Detection**:
   - Ends the game if the player collides with a robot.

5. **Dynamic Gameplay**:
   - Robots are continually added over time, increasing difficulty.

---

## How to Play
1. **Controls:**

    - Arrow Keys: Move the player in four directions.
    - ESC: Quit the game.

2. **Objective:**

    - Dodge incoming robots and survive as long as possible.

3. **Game Rules:**

    - The game ends if the player collides with any robot.
    - Robots spawn randomly from the edges and move towards the player.

---

## Installation

**Prerequisites**

- Visual Studio with C# development support.
- SplashKit SDK installed and configured.

**Steps**

1. Clone this repository:

```bash
git clone https://github.com/pradiptadutta63/robot-dodge-game.git
cd robot-dodge-game
```

2. Open the solution file (`RobotDodge.sln`) in Visual Studio.

3. Build and run the project.

## Features in Action

- Player Movement

- Robot Spawning

## Future Enhancements
1. Power-Ups:
- Add collectibles that temporarily slow down robots or stop them.
2. Scoring System:
- Display how long the player survived.
3. Additional Robot Types:
- Introduce robots with unique behaviors (e.g., teleportation or splitting).
4. Audio Effects:
- Add background music and collision sounds.

## Contributors
Pradipta Dutta - Data Scientist
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/pradiptadutta63)