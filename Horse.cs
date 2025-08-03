using System;
using System.Collections.Generic;
/*Radhiya Isaacs
08/2025
Usage Restrictions:

This code may not be copied, modified, or submitted by others as part of their own coursework or assignments.

Unauthorized use or distribution for academic submission or commercial purposes is strictly prohibited.

You may view and learn from this repository for personal educational purposes only.
**/
namespace HorseRace{

    public class Horse
    {
        private String name;
        private int age;
        private int height;
        private List<double> times = new List<double>();

        public Horse(String name, int age, int height, List<double> time)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.times = time;
        }

        public String getName()
        {
            return name;
        }


        public int getAge()
        {
            return age;
        }

        public int getHeight()
        {
            return height;
        }

        public List<double> getTime()
        {
            return times;
        }

        public double AverageTime()
        {
            if (times.Count < 3) throw new Exception("Not enough times.");
            return (times[^1] + times[^2] + times[^3]) / 3;
        }


        public string HorseDetails()
        {
            double avg = AverageTime();
            return $"Name: {name}\tAge: {age} years \tHeight: {height} hands \tAverage run: {avg:F2} seconds";
        }

    }
}

