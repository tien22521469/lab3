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

using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;

namespace SQLite
{
    public partial class Form1 : Form
    {
        private TcpListener _listener;

        public void StartListening(int port)
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            _listener.Start();

            while (true)
            {
                var client = _listener.AcceptTcpClient();
                var clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                var buffer = new byte[1024];
                var stream = client.GetStream();
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var request = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Handle the request
                HandleRequest(request);
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Always close the client, even if an error occurred
                client.Close();
            }
        }

        private void HandleRequest(string request)
        {
            // Parse the request into a FoodModel
            var food = JsonConvert.DeserializeObject<FoodModel>(request);

            // Update the database
            SQLiteDataAccess.SaveFood(food);
        }




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
                //Random random = new Random();
                //int randomIndex = random.Next(0, food.Count);
                //FoodModel randomFood = food[randomIndex];
                //randomTxtBox.Text = randomFood.TenMonAn;

                var randomFood = SQLiteDataAccess.GetRandomFood();
                // Display the random food in the UI
                randomTxtBox.Text = randomFood?.TenMonAn;

            }
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            Form2 client = new Form2();
            client.Show();
        }

        private void foodGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error
            Console.WriteLine($"DataError event occurred. Column: {e.ColumnIndex}, Row: {e.RowIndex}, Error: {e.Exception.Message}");

            // Prevent the error message from being displayed
            e.ThrowException = false;

        }
    }

}
