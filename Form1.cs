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

       // public string constring { get; private set; }
       // public SqlConnection Con { get; private set; }

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
            try
            {
                string Addquery = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
                obj_Database.command1.Parameters.AddWithValue("@FirstName", txt_CustomerFirstName.Text);
                obj_Database.command1.Parameters.AddWithValue("@LastName", txt_CustomerLastName.Text);
                obj_Database.command1.Parameters.AddWithValue("@Address", txt_CustomerAddress.Text);
                obj_Database.command1.Parameters.AddWithValue("@Phone", txt_CustomerContact.Text);

                obj_Database.AddDeleteUpdate(Addquery);
                MessageBox.Show("Sucessfully insert");
                //After inserting the new row reload the data grid view
                loadDatabaseCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_Movies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}