using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food_Application.Classes
{
    public class Food_Recommendation
    {
        //creating a dictionary Key (mood) value (foodItem) 
        private Dictionary<int, Food_Item> moodFoodDictionary = new Dictionary<int, Food_Item>();


        //Encapsulating the dictionary
        public Dictionary<int, Food_Item> MoodFoodDictionary { get => moodFoodDictionary; set => moodFoodDictionary = value; }

        public Food_Recommendation()
        {
            InitializeMoodFoodDictionary();
        }

        private void InitializeMoodFoodDictionary()
        {
            /*moodFoodDictionary = new Dictionary<int, Food_Item>
            {
                { 3, new Food_Item("Chocolate")},
                { 2, new Food_Item("Salmon")},
                { 1, new Food_Item("Berries")},
                { 4, new Food_Item("Soda")},
                { 5, new Food_Item("Fast Food")},
                { 6, new Food_Item("Green Tea")},
                { 7, new Food_Item("Grilled Chicken")},
                { 8, new Food_Item("Nuts")},
                { 9, new Food_Item("Vegetables")},
                { 10, new Food_Item("Fruits")},
                { -1, new Food_Item("Yogurt")},
                { -2, new Food_Item("Ice Cream")},
                { -3, new Food_Item("Pizza")},
                { -4, new Food_Item("Coffee")},
                { -5, new Food_Item("Oatmeal")},
                { -6, new Food_Item("Fish")},
                { -7, new Food_Item("Eggs")},
                { -8, new Food_Item("Whole Grains")},
                { -9, new Food_Item("Dark Chocolate")},
                { -10, new Food_Item("Tea")},
            };*/
        }

        // Function to suggest food
        public void SuggestFood(int mood)
        {
            Food_Item recommendedFood = GetRecommendedFood(mood);

            if (recommendedFood != null)
            {
                MessageBox.Show($"Based on your mood, you might like {recommendedFood.FoodName}.", "Food Recommendation");
            }
            else
            {
                MessageBox.Show("No recommendation available for the given mood.", "Food Recommendation");
            }
        }

        private Food_Item GetRecommendedFood(int mood)
        {
            // Using dictionary to get food item for recommendation based on mood value
            if (moodFoodDictionary.TryGetValue(mood, out Food_Item foodItem))
            {
                return foodItem;
            }

            return null;
        }
    }
}
