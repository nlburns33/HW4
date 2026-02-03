# HW4
## Devlog
The model-view-controller pattern is ///. The Player class controls the control side. It detects when the player collides with the pipes, handles the jumping and score, and contains the majority of logic. The UI Updater and Audio Controller classes control the view side. They handle playing the various sounds and updating the UI's text. The Player class creates events for the other classes to use. There is a PointsChanged event with an int parameter and Ender and Jump events without parameters. The singleton, the Locator class, contains a reference to the Player class. The other classes use the Locator singleton to subscribe to the events, allowing them to be decoupled from the Player.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [Bird Sprites with Animations](https://carysaurus.itch.io/bird-sprites) - bird sprites
- [Industrial Pipe Platformer Tileset](https://carysaurus.itch.io/bird-sprites) - pipe sprites