using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VedioRental
{
    public partial class Form1 : Form
    {
        //Folder name.name of the class and created the object
        Database.Database obj_Database = new Database.Database();
        DataTable CustomerTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadDatabaseRental(); 
            loadDatabaseMovie();
            loadDatabaseCustomer();
        }

        public void loadDatabaseCustomer()
        {
            //When click the button make it null
           DGV_Customers.DataSource = null;
           try
            {
                // select the view form the database
                string queryObj = "Select * from Customer order by CustID";
                DGV_Customers.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Customers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object CustomerInsert(string name, string last, string address, string phone)
        {
            throw new NotImplementedException();
        }

        public void loadDatabaseMovie()
        {
            //When click the button make it null
            DGV_Customers.DataSource = null;
            try
            {
                // select the view form the database
                string queryObj = "Select * from Movies order by MovieID";
                DGV_Movies.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Customers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDatabaseRental()
        {
            //When click the button make it null
            DGV_Customers.DataSource = null;
            try
            {
                // select the view form the database
                string queryObj = "Select * from RentedMovies order by RMID";
                DGV_Rentals.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Customers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void datatablecolumns()
        {
        }

        private void Btn_AllMovie_Click_1(object sender, EventArgs e)
        {
            // Data GridView has no datasource (null)
            DGV_Movies.DataSource = null;
            try
            {
                // select the view form the database
                string queryObj = "Select * from allMovie";
                //calling  the FillDGV class
                DGV_Movies.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Movies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Tc_movie_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void Btn_AddCustomer_Click(object sender, EventArgs e)
        {
            if (txt_CustomerFirstName.Text != "" && txt_CustomerLastName.Text != "" && txt_CustomerContact.Text != "" && txt_CustomerAddress.Text != "")
            {
                string message = obj_Database.CustomerInsert(txt_CustomerFirstName.Text, txt_CustomerLastName.Text, txt_CustomerContact.Text, txt_CustomerAddress.Text);
                MessageBox.Show(message);
                txt_CustomerID.Text = "";
                txt_CustomerFirstName.Text = "";
                txt_CustomerLastName.Text = "";
                txt_CustomerContact.Text = "";
                txt_CustomerAddress.Text = "";
                loadDatabaseCustomer();
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to Customer");
            }
        }
        private void Btn_AddMovie_Click(object sender, EventArgs e)
        {
            if (txt_MovieRating.Text != "" && txt_MovieTitle.Text != "" && txt_MovieYear.Text != "" && txt_MovieRentalCost.Text != "" && txt_MovieCopies.Text != "" && txt_MoviePlot.Text != "" && txt_MovieGener.Text != "")
            {
                //Int32 PriceCalculation = obj_Database.rentalPrice(Convert.ToInt32(txt_MovieYear.Text));
                string message = obj_Database.MovieInsert(txt_MovieRating.Text, txt_MovieTitle.Text, txt_MovieYear.Text, txt_MovieRentalCost.Text, txt_MovieCopies.Text, txt_MoviePlot.Text, txt_MovieGener.Text);
                MessageBox.Show(message);
                txt_MovieID.Text = "";
                txt_MovieRating.Text = "";
                txt_MovieTitle.Text = "";
                txt_MovieYear.Text = "";
                txt_MovieRentalCost.Text = "";
                txt_MovieCopies.Text = "";
                txt_MoviePlot.Text = "";
                txt_MovieGener.Text = "";
                loadDatabaseMovie();
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to movie");
            }
        }

        //Select function for the Customer table with rows of the data grid view
        private void DGV_Customers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Customers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                txt_CustomerID.Text = DGV_Customers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_CustomerFirstName.Text = DGV_Customers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_CustomerLastName.Text = DGV_Customers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_CustomerAddress.Text = DGV_Customers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_CustomerContact.Text = DGV_Customers.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        //Select function for the movie table with rows of the data grid view
        private void DGV_Movies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Movies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                txt_MovieID.Text = DGV_Movies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_MovieRating.Text = DGV_Movies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_MovieTitle.Text = DGV_Movies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_MovieYear.Text = DGV_Movies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_MovieRentalCost.Text = DGV_Movies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_MovieCopies.Text = DGV_Movies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_MoviePlot.Text = DGV_Movies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_MovieGener.Text = DGV_Movies.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        private void Btn_rentedOut_Click(object sender, EventArgs e)
        {
            //When click the button make it null
            DGV_Rentals.DataSource = null;
            try
            {
                // select the view form the database
                string queryObj = "Select * from ReturnOuts";
                DGV_Rentals.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Rentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            //Code to delete the Customer by selecting the row
            int CID = Convert.ToInt32(txt_CustomerID.Text);
            string message = obj_Database.CustomerDelete(CID);
            MessageBox.Show(message);
            txt_CustomerID.Text = "";
            txt_CustomerFirstName.Text = "";
            txt_CustomerLastName.Text = "";
            txt_CustomerContact.Text = "";
            txt_CustomerAddress.Text = "";
            loadDatabaseCustomer();
        }
        private void Btn_DeleteMovie_Click(object sender, EventArgs e)
        {
            //Code to delete the movie by selecting the row
            int ID = Convert.ToInt32(txt_MovieID.Text);
            string message = obj_Database.MovieDelete(ID);
                MessageBox.Show(message);
                txt_MovieID.Text = "";
                txt_MovieRating.Text = "";
                txt_MovieTitle.Text = "";
                txt_MovieYear.Text = "";
                txt_MovieRentalCost.Text = "";
                txt_MovieCopies.Text = "";
                txt_MoviePlot.Text = "";
                txt_MovieGener.Text = "";
                loadDatabaseMovie();
        }

        private void Btn_UpadateMovie_Click(object sender, EventArgs e)
        {
            //Update function for Movie
            string message = obj_Database.MovieUpdate(Convert.ToInt32(txt_MovieID.Text), txt_MovieRating.Text, txt_MovieTitle.Text, txt_MovieYear.Text, txt_MovieRentalCost.Text, txt_MovieCopies.Text, txt_MoviePlot.Text, txt_MovieGener.Text);
            MessageBox.Show(message);
            txt_MovieID.Text = "";
            txt_MovieRating.Text = "";
            txt_MovieTitle.Text = "";
            txt_MovieYear.Text = "";
            txt_MovieRentalCost.Text = "";
            txt_MovieCopies.Text = "";
            txt_MoviePlot.Text = "";
            txt_MovieGener.Text = "";
            loadDatabaseMovie();
        }

        private void Btn_UpdateCustomers_Click(object sender, EventArgs e)
        {
            //Update function for Customer
            string message = obj_Database.CustomerUpdate(Convert.ToInt32(txt_CustomerID.Text), txt_CustomerFirstName.Text, txt_CustomerLastName.Text, txt_CustomerContact.Text, txt_CustomerAddress.Text);
            MessageBox.Show(message);
            txt_CustomerID.Text = "";
            txt_CustomerFirstName.Text = "";
            txt_CustomerLastName.Text = "";
            txt_CustomerContact.Text = "";
            txt_CustomerAddress.Text = "";
            loadDatabaseCustomer();
        }

        private void CustomerWithMoerVideo_Click(object sender, EventArgs e)
        {
            DGV_Rentals.DataSource = null;
            try
            {
                string queryObj = "Select * from CustomerWithMoreMovie";
                DGV_Rentals.DataSource = obj_Database.FillDGV(queryObj);
                DGV_Rentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_IssueMovie_Click(object sender, EventArgs e)
        {

        }
    }
}