using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite
{
    public partial class Form1 : Form
    {
        List<FoodModel> food = new List<FoodModel>();
        public Form1()
        {
            InitializeComponent();

            LoadFoodList();
        }

        private void LoadFoodList()
        {
            food = SQLiteDataAccess.LoadFood();

            WireUpFoodList();
        }

        private void WireUpFoodList()
        {
            foodGridView.DataSource = null;
            foodGridView.DataSource = food;
            foodGridView.Columns[0].Name = "IDMA";
            foodGridView.Columns[1].Name = "TenMonAn";
            foodGridView.Columns[3].Name = "IDNCC";
        }



        // Event handler for the add button click event.
        // Adds a new food item to the list and saves it to the database.
        private void addBtn_Click(object sender, EventArgs e)
        {
            FoodModel f = new FoodModel();

            f.TenMonAn = foodTxtBox.Text;
            f.IDNCC = idnccTxtBox.Text;

            SQLiteDataAccess.SaveFood(f);

            foodTxtBox.Text = "";
            idnccTxtBox.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        // Event handler for the delete button click event. 
        // Deletes food item from the list and database
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (foodGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = foodGridView.SelectedRows[0];
                FoodModel selectedFood = (FoodModel)selectedRow.DataBoundItem;
                food.Remove(selectedFood);
                SQLiteDataAccess.DeleteFood(selectedFood);
                WireUpFoodList();
            }
        }

        // Event handler for the random button click event.
        // Randomly selects a food item from the list and displays it in the randomTxtBox.
        private void randomBtn_Click(object sender, EventArgs e)
        {
            if (food.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, food.Count);
                FoodModel randomFood = food[randomIndex];
                randomTxtBox.Text = randomFood.TenMonAn;
            }
        }
    }

}
