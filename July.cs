using Microsoft.VisualBasic.Devices;

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