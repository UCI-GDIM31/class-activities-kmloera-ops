# in-class-activities
## Devlogs
### W1
"Hello World!"

### W2
The r, g, and b variables are floats instead of the others because we need a number not a string or bool. Then the reason we use floats instead of integers is because rgb variables will not always be whole numbers so to use fractional amounts we use a float instead. The reason the _bounce variable is an integer instead of a bool and string is because it is a number. Then the reason it is an integer instead of a float is because it is only adding 1 and not anything else that makes it float/decimal/fraction. In step 4, it showed that the operations will absolutely not work unless you add a semi-colon after the operation.

### W3
Group 18
Void SetLightDimness (float x)
{
	Float Light_level = 100 * x;
}

1. A metaphor for classes and components is Russian nesting dolls. This is due to the hierarchy such as the first being a scene, then inside is the game objects, then components, then scripts, then monobehavior, then classes, and finally member variables and methods inside the classes. Each is nested within each other, and to access something outside of itself it needs to be connected to it like a class accessing a component.
2. I think the reason they get extremely bright is because there is no limit on how bright they can get so they just keep going until they can’t go further.

### W4
Table 18
Line 17: _isgrounded is a member variable with a boolean type which is true if the character is grounded and false if they aren’t. This will allow or stop the player from jumping.
Line 28: This if statement says that it should run the code within it if the space bar is being pressed and _isgrounded is true.
Line 32: This changes the _isgrounded variable to false showing that the character is no longer on the ground, therefore the player cannot jump until the variable is true again.

1. The objects I gave rigid bodies to was the cat and soccerball and I turned the trigger on for the goal.
2. What I originally had to fix was that I was trying to reset the Time.deltaTime variable to 0 hoping that by assigning my time_since variable would also be reset on a goal but instead I had to reset my time_since variable and add the Time.deltaTime variable so that it could just add the time. So in my MadeGoal method it resets time_since and the Update method adds the time passed from the last frame which helped my timer work correctly.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 