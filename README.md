# Orleans Divisional Leaderboard

This is a sample implementation of a divisional leaderboard implementation usually used in games. In this sample we can have many divisions of different division level with a relation to each other. The Number of players that can get promoted and demoted in one division level is always equal. On promotion and demotion players will get distributed to a random new league in their appropriate Division Level.
```
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
```

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

- [Orleans](https://dotnet.github.io/orleans/)

## License
 MIT License

    Copyright (c) Microsoft Corporation. All rights reserved.

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE
