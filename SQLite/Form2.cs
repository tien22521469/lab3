using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Library;
using System.Net.Http;


namespace SQLite
{
    public partial class Form2 : Form
    {
        private TcpClient _client;

        public void Connect(string server, int port)
        {
            _client = new TcpClient(server, port);
        }

        public void SendData(string data)
        {
            var stream = _client.GetStream();
            var buffer = Encoding.UTF8.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
        }

        List<FoodModel> food = new List<FoodModel>();
        public Form2()
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            FoodModel f = new FoodModel();

            f.TenMonAn = foodTxtBox.Text;
            f.IDNCC = idnccTxtBox.Text;

            SQLiteDataAccess.SaveFood(f);

            foodTxtBox.Text = "";
            idnccTxtBox.Text = "";
        }

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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            var randomFood = SQLiteDataAccess.GetRandomFood();
            // Display the random food in the UI
            randomTxtBox.Text = randomFood?.TenMonAn;

        }

        private void foodGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error
            Console.WriteLine($"DataError event occurred. Column: {e.ColumnIndex}, Row: {e.RowIndex}, Error: {e.Exception.Message}");

            // Prevent the error message from being displayed
            e.ThrowException = false;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            _client?.Close();
        }
    }
}
