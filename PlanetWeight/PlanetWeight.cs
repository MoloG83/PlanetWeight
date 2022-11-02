using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlanetWeights
{
    /*
     * List of Planets
     */
    public enum Planets
    {
        [Display(Name = "Mercury")] mercury,
        [Display(Name = "Venus")] venus,
        [Display(Name = "The Moon")] moon,
        [Display(Name = "Mars")] mars,
        [Display(Name = "Jupiter")] jupiter,
        [Display(Name = "Saturn")] saturn,
        [Display(Name = "Uranus")] uranus,
        [Display(Name = "Neptune")] neptune,
        [Display(Name = "Pluto")] pluto
    }

    //Class to present to the Internet
    public class PlanetWeight
    {
        private List<double> planetsSurfaceGravity = new List<double> { 0.378, 0.907, 0.166, 0.377, 2.36, 0.916, 0.889, 1.12, 0.071 };
        private List<double> planetSurfaceHeight = new List<double> { 1.1, 0.777, 3.2, 2.445, 0.9, 3.87, 5.33, 1.209, 7.3 };

        public const int weightMin = 1;
        public const int WeightMax = 500;
        public const int heightMin = 1;
        public const int heightMax = 400;

        [Range(weightMin, WeightMax, ErrorMessage = "Invalid weight - Only Available from 1 to 500 lbs")]
        [DisplayName("Enter Your Weight (LBs):")]
        public double weight { get; set; }

        [Range(heightMin, heightMax, ErrorMessage = "Invalid height - Only Available from 1 to 400 cms")]
        [DisplayName("Enter Your Height (CMs):")]
        public double height { get; set; }

        [DisplayName("Select A Planet:")]
        public Planets planet { get; set; }

        // calculate weight mercury
        [DisplayName("Your Weight on that Planet:")]
        public double weightOnPlanet
        {
            get
            {
                double weightConverted = this.weight;

                if (planet.Equals(Planets.mercury))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.mercury];
                }
                else if (planet.Equals(Planets.venus))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.venus];
                }
                else if (planet.Equals(Planets.moon))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.moon];
                }
                else if (planet.Equals(Planets.mars))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.mars];
                }
                else if (planet.Equals(Planets.jupiter))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.jupiter];
                }
                else if (planet.Equals(Planets.saturn))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.saturn];
                }
                else if (planet.Equals(Planets.uranus))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.uranus];
                }
                else if (planet.Equals(Planets.neptune))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.neptune];
                }
                else if (planet.Equals(Planets.pluto))
                {
                    weightConverted = this.weight * planetsSurfaceGravity[(int)Planets.pluto];
                }
                return Math.Round(weightConverted,2);
            }
        }

        [DisplayName("Your Height on that Planet:")]
        public double heightOnPlanet
        {
            get
            {
                double heightConverted = this.height;

                if (planet.Equals(Planets.mercury))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.mercury];
                }
                else if (planet.Equals(Planets.venus))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.venus];
                }
                else if (planet.Equals(Planets.moon))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.moon];
                }
                else if (planet.Equals(Planets.mars))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.mars];
                }
                else if (planet.Equals(Planets.jupiter))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.jupiter];
                }
                else if (planet.Equals(Planets.saturn))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.saturn];
                }
                else if (planet.Equals(Planets.uranus))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.uranus];
                }
                else if (planet.Equals(Planets.neptune))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.neptune];
                }
                else if (planet.Equals(Planets.pluto))
                {
                    heightConverted = this.height * planetSurfaceHeight[(int)Planets.pluto];
                }
                return Math.Round(heightConverted,2);
            }
        }
    }
}