This file documents my refactoring and design journey while working through in this kata.

NOTES:
- At this stage, I assume that when we're not supposed to change Item or Items, we shouldn't just ignore them and create a parallel object types to use (that include the different DailyUpdate behaviours).
- This code and requirements were simple enough that I could have created the final version, or at least a massive refactoring immediately.
  However, I wanted to experience and demonstrate the refactoring process by small steps that can be just as easily applied to more complex code.


## My refactoring steps:
1. Added full test coverage drawing from the requirements and the existing 30 days texttest test.<br>
Some of the tests failed due to bugs I discovered in the code/existing tests (e.g. relying on exact name instead of the mentioned "code word"). 
I decorated these tests with `[Ignore]` until I get to a stage in the refactoring where I can easily fix the issues and re-introduce the tests.   
2. small refactorings of the UpdateQuality() method to make it more readable and separate the different (unrelated) handling of the different types.<br>
3. Extract Increasing/Decreasing Quality into a method.<br>  
It feels like Quality should have been a TinyType that manages its own limits. However, since we're not allowed to change Item, I'm just extracting a method.



This is the state of the code now


