# HW4
## Devlog
The model-view-controller pattern is utilized through separating logic and aesthetics into different classes. The Player class controls the control side. It detects when the player collides with the pipes and adjusts score through OnTriggerEnter2D, handles the jumping in Update, and contains the majority of logic. The UI Updater and Audio Controller classes control the view side. They handle playing the various sounds and updating the UI's text. The Player class creates events for the other classes to use. There is a PointsChanged event with an int parameter and Ender and Jump events without parameters. The singleton, the Locator class, contains a reference to the Player class. The other classes (the aesthetics/view) use the Locator singleton's Player reference to subscribe to the events, allowing them to avoid using direct references and method calls and be decoupled from the Player (the logic/controller).

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [Bird Sprites with Animations](https://carysaurus.itch.io/bird-sprites) - bird sprites
- [Industrial Pipe Platformer Tileset](https://carysaurus.itch.io/bird-sprites) - pipe sprites