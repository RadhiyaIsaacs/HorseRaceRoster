using Microsoft.VisualBasic.Devices;
using System.Drawing.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*Radhiya Isaacs
08/2025
Usage Restrictions:

This code may not be copied, modified, or submitted by others as part of their own coursework or assignments.

Unauthorized use or distribution for academic submission or commercial purposes is strictly prohibited.

You may view and learn from this repository for personal educational purposes only.
**/

namespace HorseRace
{
    public partial class Workshop1_ISCRAD001 : Form
    {

        private July julyMeet = new July();

        public Workshop1_ISCRAD001()
        {
            InitializeComponent();
            //private Collections <Horse> ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Horse favHorse = julyMeet.Favourite();

                if (favHorse == null)
                {
                    MessageBox.Show("No horses have been added yet.");
                    return;
                }

                // Show favourite horse details in a MessageBox
                MessageBox.Show("The next winner will probably be:\n\n" + favHorse.HorseDetails(),
                                "Next Winner Prediction \n\n" +
                                "Average run : " + favHorse.AverageTime(),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error predicting favourite horse: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nametxt.Text;
                int age = int.Parse(agetxt.Text);
                int height = int.Parse(heighttxt.Text);

                double t1 = double.Parse(time1.Text);
                double t2 = double.Parse(time2.Text);
                double t3 = double.Parse(time3.Text);

                List<double> times = new List<double> { t1, t2, t3 };



                Horse newHorse = new Horse(name, age, height, times);
                julyMeet.AddHorse(newHorse);
                julyMeet.DisplayRoster(rostertxt);
                //MessageBox.Show("Horse added successfully!");
                nametxt.Clear();
                agetxt.Clear();
                heighttxt.Clear();
                time1.Clear();
                time2.Clear();
                time3.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding horse: " + ex.Message);
            }

        }

        private void time1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rostertxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}

