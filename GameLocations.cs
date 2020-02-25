using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameLocations
    {
        int[] roomsWithBats = new int[2];
        int[] roomsWithBottomlessPits = new int[2];
        int roomWithWumpus = 0;

        public GameLocations()
        {
            // sets new rooms in an array, and 
            // assigns hazards to rooms randomly
        }

        public bool movePlayer(int newRoom)
        {
            // moves player to new room, returns bool if succesful
            // if player tries to move to a room that is non existant reslolves
            //alternatively, take away players ability to move to rooms out of bounds
            return true;
        }

        public bool wakeWumpus()
        {
            //determines status of Wumpus, returns true if Awake,
            //false if asleep, 
            return true;
        }

        public bool moveWumpus(int newRoom)
        {   
            // uses wumpus status (awake/asleep) 
            // to determine if Wumpus moves
            // moves Wumpus to new room
            return true;
        }

        public bool testForHazards()
        {
            // returns true if hazard
            // is in room
            return true;
        }
    }
}
