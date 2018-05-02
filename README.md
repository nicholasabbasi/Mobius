# Möbius
Möbius - The time loop

Team: Chandler Bachman, Nicholas Abbasi, Ken Wu

# Tools
Version Control: [Github](https://github.com/chbachman/Mobius)  
Bug Tracker: [Github](https://github.com/chbachman/Mobius/issues)  

How to use: [Git Instructions](Docs/git_instructions.md)


# Vision Statement
Speedrunning. The goal to complete a game as fast as possible. While every game can be completed as fast as possible, some games are more fun to speed run. These are games where RNG takes a back seat, ones that are not too long, ones that have a great deal of control over the character. Games like Super Mario World and Zelda: The Ocarina of Time. Taking notes from the best speed running games and combining the fun of designing a route and optimizing movement is the goal of Möbius. By forcing every player to play the same game multiple times with a fixed time limit, we allow them to do these same actions of optimizing movement and designing a route. By combining a story that revolves around this time limit and puzzles to complete as fast as possible, we hope to make the ultimate speed running game.

The game takes place in a Western Town known as Refuge to its inhabitants. It is unknown outside of the town due to the time repeating bubble surrounding the town. Our hero wakes up at the entrance to the town, having just been thrown in by his captors. He needs to find a way out, and figure out why the town is in the bubble in the first place. As he explores the first time, he hears the clock strike noon and the town and the surrounding desert explode, killing him instantly. He then wakes up in the exact same spot as he did the first time, with the only thing changed is the memories he formed of the previous encounters.

# Audience
This has a specific and general target audience.

### Specific Audience: Speedrunners

Speedrunners are a dedicated fanbase of certain games. They tend to value similar things in a game, specifically movement techniques and a lack of RNG. By having no RNG in the entire game and allowing for a variety of movement, we cater to this audience the most. 

### General Audience: Other

Of course, it is too narrow of a focus to only have one small target audience, especially when it is a target audience that is mostly built off of a few high profile people that might ignore the game entirely. 

So, we look to other games here. We do this by adding a story to the repeating and allowing for character development and puzzles. These things are similar to other games such as Firewatch, where you do a lot of talking and walking, and Zelda, in which you solve puzzles to progress.

### Platform:
PC, with ability to move Multiplatform easily. PC is the home of experimental games and the market that most accepts indie games. With our choice of Unity, we keep the ability to move Multiplatform to PS4, Xbox One (X/S) and Switch if the game is a commercial success.


## Legal
This is based off of The Adventure Zone Podcast, which might have some legal repercussions later on if an agreement isn't struck. However, this can be avoided by changing everything enough that we can claim inspiration without infringing on Trademark.

# Gameplay
* Single Player vs. Game
* Rescue / Escape
* Walking / Jumping / Interaction with NPC / Puzzles

### Movement:
* WASD - Movement
* Left-Click - Interact with Object
* Space - Jump
* Alt - Crouch

### Rules:
* 10 Minute Time Limit
	* If player dies or runs out of time, reset to start point
* Escape by end of time limit
* Bubble around town, trying to escape.

### Resources:
* Time - Short time limit, optimization of movement
* Knowledge - Not tracked, player knowledge
* Currency - Doesn't carry over, but can speed up if used right.

# Story
You have been forced into this time bubble, which is being supported by the Temporal Chalice. This chalice has total control over time. It is being used to loop time within this bubble. At the end of each loop the town is destroyed and everyone within dies.

The game takes place in a Western Town known as Refuge to its inhabitants. It is unknown outside of the town due to the time repeating bubble surrounding the town. Our hero wakes up at the entrance to the town, having just been thrown in by his captors. He needs to find a way out, and figure out why the town is in the bubble in the first place. As he explores the first time, he hears the clock strike noon and the town and the surrounding desert explode, killing him instantly. He then wakes up in the exact same spot as he did the first time, with the only thing changed is the memories he formed of the previous encounters.

He wakes up next to Rowsell, the guardian of the village. If he fails to convince Roswell that he isn't a threat, he will die.

# Character Design
The character design is based off of the description from The Adventure Zone. This is further reinforced from the best aspects that fan artists have designed and publish for general use and appreciation. 

#### Roswell:
A earth elemental golem that was formed when Rick was killed by Isaac in his quest to get the Chalice. The creation also formed around a bird, which became part of Roswell.

#### Isaac:
Sheriff of the town. Killed Rick to get the chalice. Is stuck in the mines, watching over the Chalice, guarding it from others. 

# Level Design
Again, based off of the podcast. This design is mostly centered around a western town that has been solely inhabited by the residents alone for decades. The town was a former diamond mine, but the vein ran out and the town is desperate to find more to bring prosperity back. This, along with the isolation has lead diamonds to become the only currency, and to have as much value as a slice of bread per carat of diamond. 

# AI 
NavMesh on NPC wandering in town. FSM on events (locker puzzle, blade trap, skeleton stopping, bomb open tunnel block). Path finder on mine cart. Flocking for fish in pond. 


# Physics
We use mostly rigid body physics for general movement, but also use some particle physics for explosions, wind/air movement and some bug simulations (Repelled by light). Hinge joint for trap animations, colliders for triggers and orther objects, fix joint to link objects together. 



# Sound
Game review for sound: Legend of Zelda
-Background music in the sewage, castle, when player swing the sword, when the boomerang hits wall/tree. When it is raining, there is raining sound. When player throw a bush or bush.   

-The sword swing helps the visuals to let player feel the motion and power. The background sound in sewage give some horror feeling that the visual can’t present in game, the impact is strong enough to help the visual but not too strong. Same as in the castle, the music made the player feel that he/she needs to be hurry, which visual didn’t present that in game. It is another good patch for visual. The sound effect for breaking a jar is little too weak. The tone is too low and the visual give much bigger impact on the breaking.  

-The background music in the sewage is because it wants the player to have a sense of dangerous and prepare for the battle that can appear anytime. This can’t be done good in visual because the enemy doesn’t appear. The music in castle remind players needs to be hurry because he is going to safe the princess. In visual, it can’t be present easily too. The sword swing, jar breaking and raining are obvious. Those sound are common sense in players’ mind. Therefore, they put those sound effect there.   

-Yes, all those sounds repetitive. Some of them should be that way and won’t be annoying such as sword swing. However, the horror sound in sewage repeat the same soundtrack every second. It became annoying after a while. The game designer can use a few more soundtracks or longer sound track for that. The boomerang hits the wall gives the same sound effect as hit on the tree. That doesn’t make sense. The designer should use two soundtracks, one for hard object and one for soft. 

-For the background music, I think it is a cut form some music used in movies. The sword swing is record with swinging a plastic rope. The raining sound is rubbing a plastic bag. Jar breaking is record from a small brick drop on another brick. Boomerang hitting is use a nail drop on concrete ground. 

-The sounds are mostly balanced. The background music is little loud, but I can still hear all the other sound effect clearly, so it is not really need to adjust them. 

Sound used in our game:
-The background is using the village music. I rejected the actual town music because I want is be softer. The sound effect for the explosion are one of those not really close the real bomb explosion in real life. I rejected that because I think that is not the mind set sound for game explosion. Therefore, I choose one of the lower tone explosion. The rock falling sound effect is a small rock fall to ground. 


# Game Events
Upper level: Player has to get information from NPCs. 
	There are 3 must be done events: 
		1) Get the password for under ground puzzle. 
		2) Get a bomb to bomb open the tunnel blocker for excess to the mine. 
		3) Got an axe and chop a tree to stop skeleton attack under ground.
Under Ground: Player has to sovle puzzle to reach the room with the Chalice to spawn a teleportor. 
	Puzzels:
		1) Use the switch to operate the mine cart to destroy the blade trap. 
		2) Use the password from NPCs unpper ground to open correct locker doors to find the key to unlock a gate
		3) Go in the final room to click on the Chalice to spawn the teleportor without being attacked by skeleton


# Wrap-Up
### What you are most proud of about your game?
The thing I think works the best and is the closest to the original design is the dialog system. Making something with easily editable dialog was not a simple challenge and led to a lot of good design principles being used. It also allowed for rapid prototyping of any dialog changes we wanted to make.
### What changes you made to your original game design for technical reasons and why?
We had to make some large changes when it came to the scope of the game. We didn't have the technical ability to do a chase scene at the end. There was also the removal of intelligent NPCs since we don't have enough time to individually model/code paths for each NPC. 
### What changes you made to your original game design for playability reasons and why?
There was originally supposed to be a room in between deaths to punish players more for death, but since the player dies so often it was too punishing to keep in the game. Especially when we didn't add save points to the game, walking back to where you died is punishment enough.
### What did you learn from your playtesters? What changes did you make to your game as a result of the playtesting?
Besides bug fixes that needed to be done (Talking to a NPC after dying would fail), we found that the timer took too long. This led to players easily being able to complete without feeling much of a time pressure. 

We also had 
### What you would do next if you had more time?
More NPC work and more puzzles in the underground. Each NPC should feel like a character in the town with an individual character, instead of the non-developed spoon-feeding dialogue we have now. The puzzles should be long enough that the game takes the full 10 minutes but only with good routing and puzzle solving.
### What you would do differently next time?
Less focus on the puzzling aspect in the actual game world, make the game dialogue based with puzzles on who to talk to and where to go would be a lot easier to work on while keeping a lot of the knowledge searching in the game. This would allow for more puzzles more easily while keeping the spirit of the game interesting, with pathing to NPC and talking through the dialog easy.
