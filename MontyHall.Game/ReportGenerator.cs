using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall.Game
{
    public  class ReportGenerator
    {
      public static string MontyReport(decimal trueGuess,decimal wrongGuess, decimal gamesNo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("True Guesses:{0}  Percent:{1}{2}",trueGuess,(int)Math.Round((100*trueGuess)/gamesNo),"%"));
            stringBuilder.AppendLine(string.Format(""));
            stringBuilder.AppendLine(string.Format("Wrong Guesses:{0}  Percent:{1}{2}", wrongGuess, (int)Math.Round((100 * wrongGuess) / gamesNo),"%"));
            return stringBuilder.ToString();

        }
    }
}
