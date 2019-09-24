using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioRental.Database
{
   public class Database
    {
        // Sql Connection
        private SqlConnection Con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        public string QueryString, constring;

        public Database()
        {
            //connecting with the database
            constring = @"Data Source=DESKTOP-89NTJEN\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            Con.ConnectionString = constring;
            cmd.Connection = Con;
        }
        // methode to fill the data grid view with the class DGV
        public DataTable FillDGV(string querySelect)
        {
            //database class
            DataTable dt = new DataTable();
            //fill by the query
            using (da = new SqlDataAdapter(querySelect, Con))
            {
                Con.Open();
                da.Fill(dt);
                Con.Close();
            }

            return dt;
        }

        public void Add(string queryAddDeleteUpdate)
        {
            using (cmd = new SqlCommand(queryAddDeleteUpdate, Con))
            {
                //open connection
                Con.Open();
                //execute insert query
                cmd.ExecuteNonQuery();
                //close connection
                Con.Close();
            }
        }

        /*  public int RentAmount(int year)
          {
              if ()
              {
                  return 5;
              }
              else
              {
                  return 2;
              }

          }*/
      /*  public int PriceCalculation(int days, int rentalPrice, int rentalPeriod)
        {

            if (days < rentalPeriod)
            {
                int extraPeriod = days - rentalPeriod;
                int overtimePrice = 3;

                return (rentalPeriod * rentalPrice) + (extraPeriod * overtimePrice);
            }
            else
                return days * rentalPrice;
        } */
        public string CustomerInsert(string FirstName, string LastName, string Address, string Phone)
        {
            //This method is used to insert data into movie table
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;

                QueryString = "Insert into Customer(FirstName, LastName, Address, Phone) Values(@FirstName, @LastName, @Address, @Phone)";

                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();

                return "Customer is inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }

            public string MovieInsert(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            //This method is used to insert data into movie table
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;

                QueryString = "Insert into Movies(Rating, Title, Year, Rental_Cost, Plot, Genre,Copies) Values(@Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre, @copies)";

                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                cmd.Parameters.AddWithValue("@Plot", Plot);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@copies", Copies);
                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();

                return "Movie is inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }

        }
        public string CustomerDelete(int CustomerID)
        {//this method is used to delete the movie 
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;
                QueryString = "Delete from Customer where CustID like @CustID";

                cmd.Parameters.AddWithValue("@CustID", CustomerID);

                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();
                return "Customer is deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }
        public string MovieDelete(int MovieID)
        {
            //this method is used to delete the movie 
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;
                QueryString = "Delete from Movies where MovieID like @MovieID";

                cmd.Parameters.AddWithValue("@MovieID", MovieID);

                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();
                return "Movie is deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }
        public string MovieUpdate(int MovieID, string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            //this method is used to update the movie 
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;
                QueryString = "Update Movies Set Rating = @Rating, Title = @Title, Year = @Year, Rental_Cost = @Rental_Cost,  Plot = @Plot, Genre = @Genre, copies = @copies where MovieID = @MovieID";
                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                cmd.Parameters.AddWithValue("@Plot", Plot);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@copies", Copies);

                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();
                return "Movie is Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }
        public string CustomerUpdate(int CustID, string FirstName, string LastName, string Address, string Phone)
        {//this method is used to update the movie 
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Con;
                QueryString = "Update Customer Set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone where CustID = @CustID";

                cmd.Parameters.AddWithValue("@CustID", CustID);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.CommandText = QueryString;

                //connection opened
                Con.Open();

                // Executed query
                cmd.ExecuteNonQuery();
                return "Customer is Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }
    }
}
