using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLib
{
    public struct NutritionInfo
    {
        public double Protein { get; set; }
        public double Lipids { get; set; }
        public double Carbohydrates { get; set; }
        public double Calories { get; set; }

        public NutritionInfo(double protein, double lipids, double carbohydrates, double calories)
        {
            Protein = protein;
            Lipids = lipids;
            Carbohydrates = carbohydrates;
            Calories = calories;
        }
    }
}
