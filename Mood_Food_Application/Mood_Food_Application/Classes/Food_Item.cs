using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food_Application.Classes
{
    public class Food_Item
    {
        //field
        private string foodName;
        private string foodType;
        private string allergy;

        //Default Constructor
        public Food_Item() { }

        //Full Constructor
        public Food_Item(string foodItem, string foodType, string allergy)
        {
            this.foodName = foodItem;
            this.foodType = foodType;
            this.allergy = allergy;
        }

        //Data Encapsulation
        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodType { get => foodType; set => foodType = value; }
        public string Allergy { get => allergy; set => allergy = value; }
    }
}
