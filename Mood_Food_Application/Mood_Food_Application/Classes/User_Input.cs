using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food_Application.Classes
{
    public class User_Input
    {
        //Field
        private Food_Item foodItem = new Food_Item();
        private string portionSize;
        private int moodBeforeEating;
        private int moodAfterEating;
        private Food_Time time;

        //Default Constructor
        public User_Input() { }

        //Full Constructor
        public User_Input(Food_Item foodItem, string portionSize, int moodBeforeEating, int moodAfterEating, Food_Time time)
        {
            this.foodItem = foodItem;
            this.portionSize = portionSize;
            this.moodBeforeEating = moodBeforeEating;
            this.moodAfterEating = moodAfterEating;
            this.Time = time;
        }

        //Data Encapsulation
        public string PortionSize { get => portionSize; set => portionSize = value; }
        public int MoodBeforeEating { get => moodBeforeEating; set => moodBeforeEating = value; }
        public int MoodAfterEating { get => moodAfterEating; set => moodAfterEating = value; }
        public Food_Time Time { get => time; set => time = value; }
        public Food_Item FoodItem { get => foodItem; set => foodItem = value; }
    } 
}
