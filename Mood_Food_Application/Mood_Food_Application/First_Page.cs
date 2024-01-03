using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mood_Food_Application.Classes;

namespace Mood_Food_Application
{
    public partial class First_Page : Form
    {
        List<User_Input> userInputs = new List<User_Input>();
        public First_Page()
        {
            InitializeComponent();
        }
        //Submit Button
        private void Submit_Click(object sender, EventArgs e)
        {

            User_Input userInput = new User_Input();
            userInput.FoodItem.FoodName = textBoxFoodName.Text;
            userInput.FoodItem.Allergy = comboBoxAllergy.Text;
            userInput.FoodItem.FoodType = comboBoxFoodType.Text;
            userInput.PortionSize = textBoxPortionSize.Text;
            //using Enum
            if (comboBoxFoodTime.SelectedIndex == 0)
            {
                userInput.Time = Food_Time.Morning;
            }
            else if (comboBoxFoodTime.SelectedIndex == 1)
            {
                userInput.Time = Food_Time.Noon;
            }
            else if (comboBoxFoodTime.SelectedIndex == 2)
            {
                userInput.Time = Food_Time.Evening;
            }
            else
            {
                userInput.Time = Food_Time.Night;
            }

            userInput.MoodBeforeEating = Convert.ToInt32(comboBoxMoodBeforeEating.Text);
            userInput.MoodAfterEating = Convert.ToInt32(comboBoxMoodAfterEating.Text);

            // Add userInput to the userInputs list
            //userInputs.Add(userInput);
            userInputs.Add(userInput);

            clearText();
        }
        
        //display user details in dataGridView
        public void displayUserDetails()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Food Name");
            dt.Columns.Add("Allergy Type");
            dt.Columns.Add("Food Type");
            dt.Columns.Add("Portion Size");
            dt.Columns.Add("Time");
            dt.Columns.Add("Rating Before Eating");
            dt.Columns.Add("Rating After Eating");

            foreach (User_Input userInput in userInputs)
            {
                dt.Rows.Add(userInput.FoodItem.FoodName,userInput.FoodItem.Allergy, userInput.FoodItem.FoodType, userInput.PortionSize, userInput.Time, userInput.MoodBeforeEating, userInput.MoodAfterEating);
            }
            dataGridView1.DataSource = dt;
        }

        //clear input fields
        public void clearText()
        {
            comboBoxAllergy.Text = string.Empty;
            comboBoxFoodType.Text = string.Empty;
            comboBoxFoodTime.Text = string.Empty;
            textBoxPortionSize.Text = string.Empty;
            comboBoxMoodBeforeEating.Text = string.Empty;
            comboBoxMoodAfterEating.Text = string.Empty;
            textBoxFoodName.Text = string.Empty;
            textBoxRecommendedFood.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        //view details button
        private void ViewDetails_Click(object sender, EventArgs e)
        {
            displayUserDetails();
            clearText();
        }

        //Get recommendation button
        private void Get_Recommendation_Click(object sender, EventArgs e)
        {
            User_Input suggestedFood = new User_Input();
            suggestedFood.MoodAfterEating = 0;

            int currentMood = comboBox1.SelectedIndex + 1;
            foreach (User_Input userInput in userInputs)
            {
                if (currentMood < userInput.MoodAfterEating && suggestedFood.MoodAfterEating < userInput.MoodAfterEating)
                {
                    suggestedFood = userInput;
                }
            }

            if (suggestedFood.MoodAfterEating == 0)
            {
                MessageBox.Show("No suggestion found.");
                return;
            }
            else
            {
                textBoxRecommendedFood.Text = suggestedFood.FoodItem.FoodName;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            textBoxRecommendedFood.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        //Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
