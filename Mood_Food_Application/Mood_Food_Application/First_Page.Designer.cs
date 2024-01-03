namespace Mood_Food_Application
{
    partial class First_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewDetails = new System.Windows.Forms.Button();
            this.comboBoxAllergy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPortionSize = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.comboBoxMoodAfterEating = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMoodBeforeEating = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFoodTime = new System.Windows.Forms.ComboBox();
            this.comboBoxFoodType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Get_Recommendation = new System.Windows.Forms.Button();
            this.textBoxRecommendedFood = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewDetails
            // 
            this.ViewDetails.BackColor = System.Drawing.Color.White;
            this.ViewDetails.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetails.Location = new System.Drawing.Point(714, 359);
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(164, 45);
            this.ViewDetails.TabIndex = 15;
            this.ViewDetails.Text = "View Details";
            this.ViewDetails.UseVisualStyleBackColor = false;
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // comboBoxAllergy
            // 
            this.comboBoxAllergy.BackColor = System.Drawing.Color.White;
            this.comboBoxAllergy.FormattingEnabled = true;
            this.comboBoxAllergy.Items.AddRange(new object[] {
            "Peanut Allergy",
            "Nuts Allergy",
            "Lactos Allergy",
            "Gluten Allergy",
            "None"});
            this.comboBoxAllergy.Location = new System.Drawing.Point(17, 69);
            this.comboBoxAllergy.Name = "comboBoxAllergy";
            this.comboBoxAllergy.Size = new System.Drawing.Size(293, 31);
            this.comboBoxAllergy.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enter Your Allergy Type:";
            // 
            // textBoxPortionSize
            // 
            this.textBoxPortionSize.Location = new System.Drawing.Point(17, 368);
            this.textBoxPortionSize.Name = "textBoxPortionSize";
            this.textBoxPortionSize.Size = new System.Drawing.Size(289, 30);
            this.textBoxPortionSize.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.White;
            this.Submit.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(1025, 591);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(161, 45);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // comboBoxMoodAfterEating
            // 
            this.comboBoxMoodAfterEating.FormattingEnabled = true;
            this.comboBoxMoodAfterEating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxMoodAfterEating.Location = new System.Drawing.Point(17, 654);
            this.comboBoxMoodAfterEating.Name = "comboBoxMoodAfterEating";
            this.comboBoxMoodAfterEating.Size = new System.Drawing.Size(293, 31);
            this.comboBoxMoodAfterEating.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rate Your Mood After Eating the Food:";
            // 
            // comboBoxMoodBeforeEating
            // 
            this.comboBoxMoodBeforeEating.FormattingEnabled = true;
            this.comboBoxMoodBeforeEating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxMoodBeforeEating.Location = new System.Drawing.Point(20, 560);
            this.comboBoxMoodBeforeEating.Name = "comboBoxMoodBeforeEating";
            this.comboBoxMoodBeforeEating.Size = new System.Drawing.Size(293, 31);
            this.comboBoxMoodBeforeEating.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rate Your Mood Before Eating the Food:";
            // 
            // comboBoxFoodTime
            // 
            this.comboBoxFoodTime.FormattingEnabled = true;
            this.comboBoxFoodTime.Items.AddRange(new object[] {
            "Morning",
            "Noon",
            "Evening",
            "Night"});
            this.comboBoxFoodTime.Location = new System.Drawing.Point(20, 455);
            this.comboBoxFoodTime.Name = "comboBoxFoodTime";
            this.comboBoxFoodTime.Size = new System.Drawing.Size(289, 31);
            this.comboBoxFoodTime.TabIndex = 5;
            // 
            // comboBoxFoodType
            // 
            this.comboBoxFoodType.FormattingEnabled = true;
            this.comboBoxFoodType.Items.AddRange(new object[] {
            "Fruits",
            "Vegetables",
            "Non-Veg",
            "Spicy Meals",
            "Snacks",
            "Beverages"});
            this.comboBoxFoodType.Location = new System.Drawing.Point(20, 161);
            this.comboBoxFoodType.Name = "comboBoxFoodType";
            this.comboBoxFoodType.Size = new System.Drawing.Size(290, 31);
            this.comboBoxFoodType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter the Time when You eat This Food:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter the Portion Size of Food you eat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Types of Food You eat:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 727);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage1.Controls.Add(this.textBoxFoodName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.ViewDetails);
            this.tabPage1.Controls.Add(this.Submit);
            this.tabPage1.Controls.Add(this.comboBoxAllergy);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBoxFoodType);
            this.tabPage1.Controls.Add(this.textBoxPortionSize);
            this.tabPage1.Controls.Add(this.comboBoxMoodAfterEating);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxMoodBeforeEating);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxFoodTime);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Food&Mood_Input ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 242);
            this.dataGridView1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.buttonExit);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.Get_Recommendation);
            this.tabPage2.Controls.Add(this.textBoxRecommendedFood);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suggestions";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Get_Recommendation
            // 
            this.Get_Recommendation.BackColor = System.Drawing.Color.White;
            this.Get_Recommendation.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Recommendation.Location = new System.Drawing.Point(445, 357);
            this.Get_Recommendation.Name = "Get_Recommendation";
            this.Get_Recommendation.Size = new System.Drawing.Size(222, 77);
            this.Get_Recommendation.TabIndex = 4;
            this.Get_Recommendation.Text = "Get Recommendation";
            this.Get_Recommendation.UseVisualStyleBackColor = false;
            this.Get_Recommendation.Click += new System.EventHandler(this.Get_Recommendation_Click);
            // 
            // textBoxRecommendedFood
            // 
            this.textBoxRecommendedFood.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecommendedFood.Location = new System.Drawing.Point(397, 265);
            this.textBoxRecommendedFood.Name = "textBoxRecommendedFood";
            this.textBoxRecommendedFood.Size = new System.Drawing.Size(330, 30);
            this.textBoxRecommendedFood.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(497, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Try this food based on your current mood:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your Current Mood?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(409, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 31);
            this.comboBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter the food name:";
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(24, 260);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(289, 30);
            this.textBoxFoodName.TabIndex = 18;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1058, 608);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 77);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // First_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 751);
            this.Controls.Add(this.tabControl1);
            this.Name = "First_Page";
            this.Text = "First_Page";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ViewDetails;
        private System.Windows.Forms.ComboBox comboBoxAllergy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPortionSize;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox comboBoxMoodAfterEating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMoodBeforeEating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFoodTime;
        private System.Windows.Forms.ComboBox comboBoxFoodType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Get_Recommendation;
        private System.Windows.Forms.TextBox textBoxRecommendedFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
    }
}