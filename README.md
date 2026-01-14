[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
### Player
- SpriteRenderer: the penguin sprite
- Collider: non-trigger collider to prevent player from dropping through the ground. Selected capsule collider for best fitting shape.
- Rigidbody: dynamic body to support jump feature.

#### Player script
attributes: 
- jump force strength (float)
- text updater UI (object that is an instance of the class TextUpdater)
- collider and rigidbody
- points (int)
- is the player grounded / isGrounded (bool; to prevent double-jumping)

functions:
- Start(): initializes the attributes, and updates the initial points to the text UI.
- Update(): listens for player input: if the player presses the space key (keydown) AND isGrounded is true, it will make the player jump by giving the rigidbody an upward force, while setting isGrounded to false. Also constantly updates the points UI text.
- OnCollisionEnter2D(): checks collision with ground to update the status of isGrounded. If the player comes in contact with the ground's collider, it will set isGrounded to true.
- OnTriggerEnter2D(): checks collision with a coin. If the player's collider comes in contact with a coin, the points value increases by 1.

### UI (canvas)

- TMP text for the prefix "Points: " and the actual points text to display the integer.
- UI script (method to update the points display on the TMP text.)

### Ground

- SpriteRenderer (square)
- box collider 2D (non-trigger)

### Coins (prefab)

- SpriteRenderer (coin sprite)
- capsule collider 2D (trigger)

#### Coin script

- attribute: speed - the speed which the coin moves left.
- function: Update() - moves the coin left with transform.Translate().
- function: OnTriggerEnter2D(): checks collision with player. If the collision happens, the coin destroys itself.

### Coin manager
- empty GameObject
- transform

#### coin manager script

attributes:

- transform: its own position
- coin prefab: serialized field to put the coin prefab in
- empty integer value to be filled in with randomizer later

functions:

- Update(): generates a random number between 0 and 99 every frame the game runs, and if this value is less than 1, a coin prefab instantiates at the coin manager's transform's position.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites