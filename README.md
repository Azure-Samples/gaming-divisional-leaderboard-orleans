# Orleans Divisional Leaderboard

This is a sample implementation of a divisional leaderboard implementation usually used in games. In this sample we can have many divisions of different division level with a relation to each other. The Number of players that can get promoted and demoted in one division level is always equal. On promotion and demotion players will get distributed to a random new league in their appropriate Division Level.

                    +---------------+
                    |               |
                    |  Leaderboard  +------+
  Division Level 1  |       1       |      |
                    +-----+---+-----+      +-------+
                          |   |       2    |       |
                          |   +----+---+---+       |
                          |        |   |     N     |
                          |        |   +------+----+
                          |        |          |
                          |        |          |
+-----------------------------------------------------+
                          |        |          |
                    +-----+--------++         |
                    |               |         |
  Division Level 2  |  Leaderboard  +---------+
                    |       1       |
                    +---------------+


## Features

This sample shows the following:

* Adding new players to leaderboards
* Promotion / Demotion of players
* Get realtime position of player in leaderboard
* Get specific leaderboard in specific division

## Getting Started

### Prerequisites

- Windows / Linux / Mac
- .NET Core 2.0 /.NET Standard 2.0
- Orleans 2.0.3

### Installation

//TODO

### Quickstart
(Add steps to get up and running quickly)

1. git clone [repository clone url]
2. cd [respository name]
3. ...

## Resources

(Any additional resources or related projects)

- [Orleans](https://dotnet.github.io/orleans/)
