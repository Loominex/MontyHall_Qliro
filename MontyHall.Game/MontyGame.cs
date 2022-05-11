using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall.Game
{
    public class MontyGame
    {
        private const int doorCount = 3;
        public GameResult Run(decimal simulationNo,bool changeDoor)
        {
            if (simulationNo == 0)
            {
                new GameResult();
            }
            decimal trueGuess=0, wrongGuess = 0;

            var random=new Random();


            for (int i = 1; i <= simulationNo; i++)
            {
                #region select a door
                //each time a random door is selected.
                var selected = random.Next(1, doorCount + 1);

                #endregion

                var openedDoor = selected;

                #region set prize door randomly

                var prizeDoor = random.Next(1, doorCount + 1);

                #endregion
                //monty opens a door that has not prize behind and it's not selected.
                #region opening a goat door

                //here monty wants to open a goat door, but one that is not prize or selected, for example prize and selected
                // doors are door number 1, monty can open either 2 or 3, he chooses first one.
                openedDoor = Enumerable.Range(1, doorCount).First(x => x != prizeDoor && x != selected);

                #endregion
                
                #region switch the door

                if (changeDoor)
                {
                    var newSelected = random.Next(1, doorCount + 1);

                    //switch the door to closed door.
                    //randomly chooses a door that is not opened or selected.
                    while (newSelected==selected || newSelected==openedDoor)
                    {
                          newSelected = random.Next(1, doorCount + 1);
                    }
                    selected= newSelected;
                }

                #endregion

                #region set guess result

                if (prizeDoor == selected)
                {
                    trueGuess++;
                }
                else
                {
                    wrongGuess++;
                }

                #endregion

            }

            return new GameResult() { TrueGuess=trueGuess,WrongGuess=wrongGuess};
        }
    }
}
