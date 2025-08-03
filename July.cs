using Microsoft.VisualBasic.Devices;
/*Radhiya Isaacs
08/2025
Usage Restrictions:

This code may not be copied, modified, or submitted by others as part of their own coursework or assignments.

Unauthorized use or distribution for academic submission or commercial purposes is strictly prohibited.

You may view and learn from this repository for personal educational purposes only.
**/
namespace HorseRace
{
    public class July
    {
        private List<Horse> horses;

        public July()
        {
            horses = new List<Horse>();
        }

        public List<Horse> getHorses()
        {
            return horses;
        }

        public void AddHorse(Horse horse)
        {
            horses.Add(horse);
        }

        public void DisplayRoster(TextBox txtbox)
        {
            txtbox.Clear();

            txtbox.AppendText(
    "******************************************************************" + Environment.NewLine +
    "         Roster for next race            " + Environment.NewLine +
    "******************************************************************" + Environment.NewLine + Environment.NewLine);


            foreach (Horse horse in horses)
            {
                txtbox.AppendText(horse.HorseDetails() + Environment.NewLine);
            }
        }

        public Horse Favourite()
        {
            if (horses.Count == 0)
            {
                return null;
            }

            Horse fav_horse = horses[0];

            double bestAverageTime = fav_horse.AverageTime();

            foreach (Horse horse in horses)
            {
                double currentAverage = horse.AverageTime();
                if (currentAverage < bestAverageTime)
                {
                    bestAverageTime = currentAverage;
                    fav_horse = horse;
                }
            }
            return fav_horse;
        }


    }

}
