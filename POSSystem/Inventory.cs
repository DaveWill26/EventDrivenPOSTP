using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void ShowPanel(Panel panelToShow)
        {

            // Hide all panels
            panelList.Visible = false;
            panelList2.Visible = false;
            panelList3.Visible = false;

            // Show the desired panel
            panelToShow.Visible = true;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            string[,] data = {
                { "Regular Coffee", "123456", "15/45", "Jan 2025", "Starbucks" },
                { "Espresso Shot", "789012", "20/60", "Dec 2025", "Lavazza" },
                { "Decaf Coffee", "345678", "10/30", "Feb 2025", "Peet's Coffee" },
                { "Colombian Coffee", "901234", "25/75", "Mar 2025", "Dunkin Donuts" },
                { "French Vanilla Syrup", "567890", "20/60", "May 2025", "Torani" },
                { "Caramel Syrup", "246801", "20/60", "Jun 2025", "Monin" },
                { "Hazelnut Syrup", "135792", "15/45", "Jul 2025", "DaVinci" },
                { "White Mocha Syrup", "314159", "25/75", "Sep 2025", "Ghirardelli" },
                { "Chocolate Syrup", "271828", "20/60", "Oct 2025", "Hershey's" },
                { "Cinnamon Dolce Syrup", "987654", "15/45", "Nov 2025", "Starbucks" },
                { "Peppermint Syrup", "246810", "15/45", "Nov 2025", "Monin" },
                { "Vanilla Powder", "111222", "20/60", "Jan 2025", "Big Train" },
                { "Cocoa Powder", "333444", "15/45", "Feb 2025", "Guitard" },
                { "Chai Tea Powder", "555666", "25/75", "Mar 2025", "Oregon Chai" },
                { "Matcha Green Tea Powder", "777888", "20/60", "Apr 2025", "Ito En" },
                { "Earl Grey Tea", "999000", "20/60", "Jun 2025", "Twinings" },
                { "English Breakfast Tea", "111333", "20/60", "Jun 2025", "Taylors of Harrogate" },
                { "Hot Cocoa Mix", "333555", "20/60", "Aug 2025", "Swiss Miss" },
                { "Swiss Miss", "444777", "20/60", "Sep 2025", "Hills Bros." },
                { "White Hot Chocolate Mix", "666999", "20/60", "Nov 2025", "Stephen's Gourmet" },
                { "Chocolate Muffin", "888111", "20/60", "Nov 2025", "Otis Spunkmeyer" },
                { "Blueberry Muffin", "222333", "20/60", "Dec 2025", "Sara Lee" },
                { "Chocolate Croissant", "444555", "25/75", "Jan 2026", "Pepperidge Farm" }
            };
            DataTable table = new DataTable();

            for (int col = 0; col < data.GetLength(1); col++)
            {
                table.Columns.Add();
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {
                table.Rows.Add(data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4]);
            }
            DataGridView dataGridView = new DataGridView
            {
                DataSource = table,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };
            dataGridView.ColumnHeadersVisible = false;
            panelList.Controls.Clear();
            panelList.Controls.Add(dataGridView);

        }

        private void btnAddOns_Click(object sender, EventArgs e)
        {
            string[,] data1 = {
        { "Boba pearl", "123456", "15/45", "Jan 2025", "Starbucks" },
        { "Grass jelly", "789012", "20/60", "Dec 2025", "Lavazza" },
        { "Aloe vera", "345678", "10/30", "Feb 2025", "Peet's Coffee" },
        { "Pudding", "901234", "25/75", "Mar 2025", "Dunkin Donuts" },
        { "Fruit jelly", "567890", "20/60", "May 2025", "Torani" },
        { "Red bean", "246801", "20/60", "Jun 2025", "Monin" },
        { "Tapioca balls", "135792", "15/45", "Jul 2025", "DaVinci" },
        { "White mocha syrup", "314159", "25/75", "Sep 2025", "Ghirardelli" },
        { "Coconut jelly", "271828", "20/60", "Oct 2025", "Hershey's" },
        { "Mochi", "987654", "15/45", "Nov 2025", "Starbucks" },
        { "Peppermint syrup", "246810", "15/45", "Nov 2025", "Monin" },
        { "Egg pudding", "111222", "20/60", "Jan 2025", "Big Train" },
        { "Rainbow jelly", "333444", "35/105", "Feb 2025", "Guittard" },
        { "Chai Tea Powder", "555666", "25/75", "Mar 2025", "Oregon Chai" },
        { "Lychee jelly", "777888", "20/60", "Apr 2025", "Ito En" },
        { "Mango jelly", "999000", "20/60", "Jun 2025", "Twinings" },
        { "Green apple", "111333", "20/60", "Jun 2025", "Taylors of Harrogate" },
        { "Chocolate", "333555", "20/60", "Aug 2025", "Swiss Miss" },
        { "Caramel", "444777", "20/60", "Sep 2025", "Hills Bros." },
        { "Almond", "666999", "20/60", "Nov 2025", "Stephen's Gourmet" },
        { "Hazelnut", "888111", "20/60", "Nov 2025", "Otis Spunkmeyer" },
        { "Oreo", "222333", "20/60", "Dec 2025", "Sara Lee" },
        { "Honey", "444555", "25/75", "Jan 2026", "Pepperidge Farm" }
      };

            DataTable innerTable = new DataTable();
            for (int col = 0; col < data1.GetLength(1); col++)
            {
                innerTable.Columns.Add(new DataColumn());
            }
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                innerTable.Rows.Add(data1[i, 0], data1[i, 1], data1[i, 2], data1[i, 3], data1[i, 4]);
            }

            DataGridView dataGridView1 = new DataGridView
            {
                DataSource = innerTable,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };

            dataGridView1.ColumnHeadersVisible = false;
            panelList2.Controls.Clear();
            panelList2.Controls.Add(dataGridView1);
        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            string[,] data2 = {
        { "Sealer machine", "123456", "15/45", "Jan 2025", "Starbucks" },
        { "Blender", "789012", "20/60", "Dec 2025", "Lavazza" },
        { "Spoons", "345678", "10/30", "Feb 2025", "Peet's Coffee" },
        { "Disposable cups", "901234", "25/75", "Mar 2025", "Dunkin Donuts" },
        { "Menu board", "567890", "20/60", "May 2025", "Torani" },
        { "White mocha syrup", "246801", "20/60", "Jun 2025", "Monin" },
        { "Cleaning supplies", "135792", "15/45", "Jul 2025", "DaVinci" },
        { "Mochi", "314159", "25/75", "Sep 2025", "Ghirardelli" },
        { "Trash can", "271828", "20/60", "Oct 2025", "Hershey's" },
        { "Recycling bins", "987654", "15/45", "Nov 2025", "Starbucks" },
        { "Storage shelves", "246810", "15/45", "Nov 2025", "Monin" },
        { "Chai tea powder", "111222", "20/60", "Jan 2025", "Big Train" },
        { "Delivery bags", "333444", "15/45", "Feb 2025", "Guitard" },
        { "Mango jelly", "555666", "25/75", "Mar 2025", "Oregon Chai" },
        { "Display cases", "777888", "20/60", "Apr 2025", "Ito En" },
        { "Ice machine", "999000", "20/60", "Jun 2025", "Twinings" },
        { "Caramel", "111333", "20/60", "Jun 2025", "Taylors of Harrogate" },
        { "Tea brewing equipment", "333555", "20/60", "Aug 2025", "Swiss Miss" },
        { "Seating", "444777", "20/60", "Sep 2025", "Hills Bros." },
        { "Water filtration system", "666999", "20/60", "Nov 2025", "Stephen's Gourmet" },
        { "Music system", "888111", "20/60", "Nov 2025", "Otis Spunkmeyer" },
        { "Straws", "222333", "20/60", "Dec 2025", "Sara Lee" },
        { "Spoons", "444555", "25/75", "Jan 2026", "Pepperidge Farm" }
    };

            DataTable innerTable1 = new DataTable();
            for (int col = 0; col < data2.GetLength(1); col++)
            {
                innerTable1.Columns.Add(new DataColumn());
            }
            for (int i = 0; i < data2.GetLength(0); i++)
            {
                innerTable1.Rows.Add(data2[i, 0], data2[i, 1], data2[i, 2], data2[i, 3], data2[i, 4]);
            }

            DataGridView dataGridView2 = new DataGridView
            {
                DataSource = innerTable1,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };

            dataGridView2.ColumnHeadersVisible = false;
            panelList3.Controls.Clear();
            panelList3.Controls.Add(dataGridView2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS pos1 = new POS();
            pos1.Show();
            this.Hide();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {

        }
    }
}
