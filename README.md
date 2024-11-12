# GAME-2D

Jesus Serna
CS583
2D Project 

This project involved building an endless runner game from scratch, focusing on creating an engaging, fast-paced gameplay experience. The player controls a character that automatically moves forward, navigating obstacles and collecting coins to increase their score. The project incorporated various elements such as animations, collision detection, a scoring and health system, a layered background, background music, and responsive controls.
Development Stages

Player Setup and Walking Animation:
Character Design: The project began with designing and adding a player character to the scene. I applied a walking animation to the character, which gave the impression of continuous forward movement. This animation was created by cycling through frames of the character in a walking stance, producing a natural motion.
Preventing Falling: To keep the character from falling off the platform and disappearing from view, I added a Rigidbody2D component to simulate physics and a Box Collider 2D component for collision detection. This ensured the player could stand firmly on the ground without slipping or falling.
Ground Setup: I defined a ground layer, setting the ground objects to this layer so the player’s collider would interact with them properly. By configuring this layer and adjusting the player’s collider size and position, I ensured that the player would maintain consistent contact with the ground.


Adding Obstacles:
Types of Obstacles: To increase difficulty, I introduced various obstacles along the player’s path, such as fire pits, sharp logs, and elevated barriers that required jumping. Each obstacle had a unique design and was strategically placed to challenge the player.
Damage Mechanism: I implemented a health system where collision with an obstacle would decrease the player’s health. This system created a balance between risk and reward, making the player carefully navigate around hazards to avoid health loss.
Collisions and Interaction: Each obstacle was equipped with its own Collider 2D component to detect collisions with the player. I wrote scripts that registered these collisions and applied the appropriate damage to the player's health when contact occurred.


Jumping Mechanic:
Jump Animation: The player character’s jumping animation was created to simulate a smooth upward motion, allowing the character to leap over obstacles. The animation involved altering the player’s position along the y-axis, while maintaining forward momentum.
Jump Control: I scripted the jump function to trigger upon pressing a jump button or tapping the screen, and included checks to ensure the character could only jump when touching the ground. This prevented the player from jumping mid-air, keeping the gameplay realistic.
Fine-Tuning Jump Mechanics: I adjusted parameters such as jump force, gravity, and timing to ensure a natural jump arc. Testing and tweaking these values allowed me to achieve a jump height and duration that felt responsive and intuitive.


Background and Environment:
Layered Backgrounds: To enhance the visual appeal, I created a multi-layered background using several images. Each layer moved at a different speed, achieving a parallax scrolling effect that added depth to the environment and created a sense of progression.
Environmental Themes: The background included varied themes (e.g., forest, mountains) to make the game world feel immersive. I aligned the background elements with the player’s movement speed, ensuring smooth transitions as the player advanced through the game.
Sky and Ground Elements: In addition to the main background layers, I included static elements, such as the sky, and dynamic ground features that matched the game’s theme. This helped create a cohesive and engaging atmosphere.


Coin Collection and Scoring System:
Adding Coins: Coins were scattered along the path for the player to collect. Each coin collected increased the player’s score, rewarding the player for their agility and attention.
Types of Coins: I experimented with different coin types, assigning each type unique values to vary the score increment. For example, some coins had higher point values than others, encouraging players to prioritize certain coins.
Animated Coins: Initially, I aimed to animate the coins with a spinning effect by slicing the coin sprite into frames and creating a rotation animation. However, due to the complexity, I simplified this to static coins that still looked visually appealing.
Power-Ups: I considered adding power-up coins that would grant temporary abilities, such as invincibility or double points, but decided to remove this feature due to challenges in scripting and balance considerations.


Collision-Based Health System:
Health Reduction on Obstacle Contact: When the player collided with an obstacle, their health would decrease. I scripted a system that displayed the player’s health on the UI, giving real-time feedback on their condition.
Game Over Condition: I implemented a health threshold that, when reached, would end the game. This added stakes to the gameplay, requiring players to balance between collecting coins and avoiding obstacles.


Background Music:
Adding Music: To enhance the immersive experience, I added background music that plays continuously as the player progresses through the game. This added an exciting atmosphere and complemented the game’s fast pace.
Audio Settings: I configured the music to loop indefinitely, ensuring that there were no interruptions during gameplay. I also adjusted the volume and balanced it with other sound effects.


Challenges and Final Adjustments:
Coin Animation and Scripting: Animating the coin sprites to simulate rotation was one of the more complex aspects of the project. The initial approach involved sprite slicing and animation loops, but I ultimately simplified this feature to static coins.
Power-Ups Removal: Integrating power-ups required additional scripting logic, which presented challenges in maintaining balance and performance. After experimenting with these features, I decided to remove them, focusing on core gameplay mechanics.
Testing and Tweaks: I repeatedly tested the game, adjusting movement speeds, jump mechanics, obstacle spacing, and collision detection. This iterative process allowed me to refine the gameplay, making it both challenging and enjoyable.


Reflection and Takeaways
Developing this endless runner game taught me valuable skills in Unity, including animation handling, collision management, UI design, audio management, and gameplay scripting. The project also improved my ability to debug and fine-tune game mechanics, creating an experience that is visually engaging and responsive. Despite some challenges, such as working with animated coins and integrating power-ups, the end result was a functional and enjoyable game that serves as a foundation for future development.
