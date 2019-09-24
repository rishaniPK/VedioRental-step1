namespace VedioRental
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TC_MovieRental = new System.Windows.Forms.TabControl();
            this.Tc_customers = new System.Windows.Forms.TabPage();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.Btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomers = new System.Windows.Forms.Button();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_CustomerContact = new System.Windows.Forms.TextBox();
            this.txt_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_CustomerLastName = new System.Windows.Forms.TextBox();
            this.tc_movie = new System.Windows.Forms.TabPage();
            this.txt_MovieCopies = new System.Windows.Forms.TextBox();
            this.txt_MovieGener = new System.Windows.Forms.TextBox();
            this.txt_MovieRating = new System.Windows.Forms.TextBox();
            this.btn_AllMovie = new System.Windows.Forms.Button();
            this.txt_MovieYear = new System.Windows.Forms.TextBox();
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.txt_MovieRentalCost = new System.Windows.Forms.TextBox();
            this.btn_UpadateMovie = new System.Windows.Forms.Button();
            this.txt_MovieTitle = new System.Windows.Forms.TextBox();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.txt_MoviePlot = new System.Windows.Forms.TextBox();
            this.btn_DeleteMovie = new System.Windows.Forms.Button();
            this.DGV_Movies = new System.Windows.Forms.DataGridView();
            this.Tc_rentals = new System.Windows.Forms.TabPage();
            this.btn_rentedOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_IssueMovie = new System.Windows.Forms.Button();
            this.DTP_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_RentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Rentals = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerWithMoerVideo = new System.Windows.Forms.Button();
            this.TC_MovieRental.SuspendLayout();
            this.Tc_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.tc_movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movies)).BeginInit();
            this.Tc_rentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentals)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_MovieRental
            // 
            this.TC_MovieRental.Controls.Add(this.Tc_customers);
            this.TC_MovieRental.Controls.Add(this.tc_movie);
            this.TC_MovieRental.Controls.Add(this.Tc_rentals);
            this.TC_MovieRental.Location = new System.Drawing.Point(22, 51);
            this.TC_MovieRental.Name = "TC_MovieRental";
            this.TC_MovieRental.SelectedIndex = 0;
            this.TC_MovieRental.Size = new System.Drawing.Size(593, 442);
            this.TC_MovieRental.TabIndex = 1;
            this.TC_MovieRental.Tag = "";
            // 
            // Tc_customers
            // 
            this.Tc_customers.BackColor = System.Drawing.Color.Transparent;
            this.Tc_customers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tc_customers.BackgroundImage")));
            this.Tc_customers.Controls.Add(this.DGV_Customers);
            this.Tc_customers.Controls.Add(this.btn_deleteCustomer);
            this.Tc_customers.Controls.Add(this.Btn_AddCustomer);
            this.Tc_customers.Controls.Add(this.btn_UpdateCustomers);
            this.Tc_customers.Controls.Add(this.txt_CustomerID);
            this.Tc_customers.Controls.Add(this.txt_CustomerContact);
            this.Tc_customers.Controls.Add(this.txt_CustomerFirstName);
            this.Tc_customers.Controls.Add(this.txt_CustomerAddress);
            this.Tc_customers.Controls.Add(this.txt_CustomerLastName);
            this.Tc_customers.Location = new System.Drawing.Point(4, 22);
            this.Tc_customers.Name = "Tc_customers";
            this.Tc_customers.Padding = new System.Windows.Forms.Padding(3);
            this.Tc_customers.Size = new System.Drawing.Size(585, 416);
            this.Tc_customers.TabIndex = 0;
            this.Tc_customers.Text = "Customer";
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Location = new System.Drawing.Point(3, 6);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.Size = new System.Drawing.Size(582, 335);
            this.DGV_Customers.TabIndex = 0;
            this.DGV_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customers_CellContentClick_1);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Location = new System.Drawing.Point(256, 347);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(99, 27);
            this.btn_deleteCustomer.TabIndex = 1;
            this.btn_deleteCustomer.Text = "Delete Customer";
            this.btn_deleteCustomer.UseVisualStyleBackColor = true;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.Btn_deleteCustomer_Click);
            // 
            // Btn_AddCustomer
            // 
            this.Btn_AddCustomer.Location = new System.Drawing.Point(6, 347);
            this.Btn_AddCustomer.Name = "Btn_AddCustomer";
            this.Btn_AddCustomer.Size = new System.Drawing.Size(77, 56);
            this.Btn_AddCustomer.TabIndex = 1;
            this.Btn_AddCustomer.Text = "Add Customer";
            this.Btn_AddCustomer.UseVisualStyleBackColor = true;
            this.Btn_AddCustomer.Click += new System.EventHandler(this.Btn_AddCustomer_Click);
            // 
            // btn_UpdateCustomers
            // 
            this.btn_UpdateCustomers.Location = new System.Drawing.Point(136, 347);
            this.btn_UpdateCustomers.Name = "btn_UpdateCustomers";
            this.btn_UpdateCustomers.Size = new System.Drawing.Size(101, 27);
            this.btn_UpdateCustomers.TabIndex = 2;
            this.btn_UpdateCustomers.Text = "Update Customer";
            this.btn_UpdateCustomers.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomers.Click += new System.EventHandler(this.Btn_UpdateCustomers_Click);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(89, 347);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(37, 20);
            this.txt_CustomerID.TabIndex = 6;
            this.txt_CustomerID.Text = "ID";
            // 
            // txt_CustomerContact
            // 
            this.txt_CustomerContact.Location = new System.Drawing.Point(408, 380);
            this.txt_CustomerContact.Name = "txt_CustomerContact";
            this.txt_CustomerContact.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerContact.TabIndex = 1;
            this.txt_CustomerContact.Text = "Phone Number";
            // 
            // txt_CustomerFirstName
            // 
            this.txt_CustomerFirstName.Location = new System.Drawing.Point(89, 382);
            this.txt_CustomerFirstName.Name = "txt_CustomerFirstName";
            this.txt_CustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerFirstName.TabIndex = 7;
            this.txt_CustomerFirstName.Text = "First Name";
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.Location = new System.Drawing.Point(302, 380);
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerAddress.TabIndex = 9;
            this.txt_CustomerAddress.Text = "Address";
            // 
            // txt_CustomerLastName
            // 
            this.txt_CustomerLastName.Location = new System.Drawing.Point(196, 381);
            this.txt_CustomerLastName.Name = "txt_CustomerLastName";
            this.txt_CustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerLastName.TabIndex = 8;
            this.txt_CustomerLastName.Text = "Last Name";
            // 
            // tc_movie
            // 
            this.tc_movie.Controls.Add(this.txt_MovieCopies);
            this.tc_movie.Controls.Add(this.txt_MovieGener);
            this.tc_movie.Controls.Add(this.txt_MovieRating);
            this.tc_movie.Controls.Add(this.btn_AllMovie);
            this.tc_movie.Controls.Add(this.txt_MovieYear);
            this.tc_movie.Controls.Add(this.btn_AddMovie);
            this.tc_movie.Controls.Add(this.txt_MovieRentalCost);
            this.tc_movie.Controls.Add(this.btn_UpadateMovie);
            this.tc_movie.Controls.Add(this.txt_MovieTitle);
            this.tc_movie.Controls.Add(this.txt_MovieID);
            this.tc_movie.Controls.Add(this.txt_MoviePlot);
            this.tc_movie.Controls.Add(this.btn_DeleteMovie);
            this.tc_movie.Controls.Add(this.DGV_Movies);
            this.tc_movie.Location = new System.Drawing.Point(4, 22);
            this.tc_movie.Name = "tc_movie";
            this.tc_movie.Padding = new System.Windows.Forms.Padding(3);
            this.tc_movie.Size = new System.Drawing.Size(585, 416);
            this.tc_movie.TabIndex = 1;
            this.tc_movie.Text = "Movies";
            this.tc_movie.UseVisualStyleBackColor = true;
            this.tc_movie.Click += new System.EventHandler(this.Tc_movie_Click);
            // 
            // txt_MovieCopies
            // 
            this.txt_MovieCopies.Location = new System.Drawing.Point(433, 378);
            this.txt_MovieCopies.Name = "txt_MovieCopies";
            this.txt_MovieCopies.Size = new System.Drawing.Size(59, 20);
            this.txt_MovieCopies.TabIndex = 27;
            this.txt_MovieCopies.Text = "Copies";
            // 
            // txt_MovieGener
            // 
            this.txt_MovieGener.Location = new System.Drawing.Point(498, 378);
            this.txt_MovieGener.Name = "txt_MovieGener";
            this.txt_MovieGener.Size = new System.Drawing.Size(81, 20);
            this.txt_MovieGener.TabIndex = 26;
            this.txt_MovieGener.Text = "Genre";
            // 
            // txt_MovieRating
            // 
            this.txt_MovieRating.Location = new System.Drawing.Point(181, 338);
            this.txt_MovieRating.Name = "txt_MovieRating";
            this.txt_MovieRating.Size = new System.Drawing.Size(75, 20);
            this.txt_MovieRating.TabIndex = 25;
            this.txt_MovieRating.Text = "Rating";
            // 
            // btn_AllMovie
            // 
            this.btn_AllMovie.Location = new System.Drawing.Point(247, 375);
            this.btn_AllMovie.Name = "btn_AllMovie";
            this.btn_AllMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_AllMovie.TabIndex = 24;
            this.btn_AllMovie.Text = "All Movie";
            this.btn_AllMovie.UseVisualStyleBackColor = true;
            this.btn_AllMovie.Click += new System.EventHandler(this.Btn_AllMovie_Click_1);
            // 
            // txt_MovieYear
            // 
            this.txt_MovieYear.Location = new System.Drawing.Point(377, 339);
            this.txt_MovieYear.Name = "txt_MovieYear";
            this.txt_MovieYear.Size = new System.Drawing.Size(82, 20);
            this.txt_MovieYear.TabIndex = 23;
            this.txt_MovieYear.Text = "Year";
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.Location = new System.Drawing.Point(19, 338);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(89, 20);
            this.btn_AddMovie.TabIndex = 16;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.UseVisualStyleBackColor = true;
            this.btn_AddMovie.Click += new System.EventHandler(this.Btn_AddMovie_Click);
            // 
            // txt_MovieRentalCost
            // 
            this.txt_MovieRentalCost.Location = new System.Drawing.Point(344, 377);
            this.txt_MovieRentalCost.Name = "txt_MovieRentalCost";
            this.txt_MovieRentalCost.Size = new System.Drawing.Size(82, 20);
            this.txt_MovieRentalCost.TabIndex = 22;
            this.txt_MovieRentalCost.Text = "Rent Cost";
            // 
            // btn_UpadateMovie
            // 
            this.btn_UpadateMovie.Location = new System.Drawing.Point(130, 376);
            this.btn_UpadateMovie.Name = "btn_UpadateMovie";
            this.btn_UpadateMovie.Size = new System.Drawing.Size(101, 23);
            this.btn_UpadateMovie.TabIndex = 18;
            this.btn_UpadateMovie.Text = "Update Movie";
            this.btn_UpadateMovie.UseVisualStyleBackColor = true;
            this.btn_UpadateMovie.Click += new System.EventHandler(this.Btn_UpadateMovie_Click);
            // 
            // txt_MovieTitle
            // 
            this.txt_MovieTitle.Location = new System.Drawing.Point(272, 339);
            this.txt_MovieTitle.Name = "txt_MovieTitle";
            this.txt_MovieTitle.Size = new System.Drawing.Size(92, 20);
            this.txt_MovieTitle.TabIndex = 20;
            this.txt_MovieTitle.Text = "Title";
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Location = new System.Drawing.Point(130, 338);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(35, 20);
            this.txt_MovieID.TabIndex = 19;
            this.txt_MovieID.Text = "ID";
            // 
            // txt_MoviePlot
            // 
            this.txt_MoviePlot.Location = new System.Drawing.Point(474, 339);
            this.txt_MoviePlot.Name = "txt_MoviePlot";
            this.txt_MoviePlot.Size = new System.Drawing.Size(81, 20);
            this.txt_MoviePlot.TabIndex = 21;
            this.txt_MoviePlot.Text = "Plot";
            // 
            // btn_DeleteMovie
            // 
            this.btn_DeleteMovie.Location = new System.Drawing.Point(19, 376);
            this.btn_DeleteMovie.Name = "btn_DeleteMovie";
            this.btn_DeleteMovie.Size = new System.Drawing.Size(89, 23);
            this.btn_DeleteMovie.TabIndex = 17;
            this.btn_DeleteMovie.Text = "Delete Movie";
            this.btn_DeleteMovie.UseVisualStyleBackColor = true;
            this.btn_DeleteMovie.Click += new System.EventHandler(this.Btn_DeleteMovie_Click);
            // 
            // DGV_Movies
            // 
            this.DGV_Movies.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGV_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movies.Location = new System.Drawing.Point(6, 7);
            this.DGV_Movies.Name = "DGV_Movies";
            this.DGV_Movies.Size = new System.Drawing.Size(586, 326);
            this.DGV_Movies.TabIndex = 0;
            this.DGV_Movies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Movies_CellContentClick);
            // 
            // Tc_rentals
            // 
            this.Tc_rentals.Controls.Add(this.CustomerWithMoerVideo);
            this.Tc_rentals.Controls.Add(this.btn_rentedOut);
            this.Tc_rentals.Controls.Add(this.button1);
            this.Tc_rentals.Controls.Add(this.btn_IssueMovie);
            this.Tc_rentals.Controls.Add(this.DTP_ReturnDate);
            this.Tc_rentals.Controls.Add(this.DTP_RentDate);
            this.Tc_rentals.Controls.Add(this.label2);
            this.Tc_rentals.Controls.Add(this.label1);
            this.Tc_rentals.Controls.Add(this.DGV_Rentals);
            this.Tc_rentals.Location = new System.Drawing.Point(4, 22);
            this.Tc_rentals.Name = "Tc_rentals";
            this.Tc_rentals.Padding = new System.Windows.Forms.Padding(3);
            this.Tc_rentals.Size = new System.Drawing.Size(585, 416);
            this.Tc_rentals.TabIndex = 2;
            this.Tc_rentals.Text = "Rentals";
            this.Tc_rentals.UseVisualStyleBackColor = true;
            // 
            // btn_rentedOut
            // 
            this.btn_rentedOut.Location = new System.Drawing.Point(293, 373);
            this.btn_rentedOut.Name = "btn_rentedOut";
            this.btn_rentedOut.Size = new System.Drawing.Size(75, 23);
            this.btn_rentedOut.TabIndex = 7;
            this.btn_rentedOut.Text = "Rented Out";
            this.btn_rentedOut.UseVisualStyleBackColor = true;
            this.btn_rentedOut.Click += new System.EventHandler(this.Btn_rentedOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_IssueMovie
            // 
            this.btn_IssueMovie.Location = new System.Drawing.Point(293, 332);
            this.btn_IssueMovie.Name = "btn_IssueMovie";
            this.btn_IssueMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_IssueMovie.TabIndex = 5;
            this.btn_IssueMovie.Text = "Issue Movie";
            this.btn_IssueMovie.UseVisualStyleBackColor = true;
            this.btn_IssueMovie.Click += new System.EventHandler(this.Btn_IssueMovie_Click);
            // 
            // DTP_ReturnDate
            // 
            this.DTP_ReturnDate.Location = new System.Drawing.Point(23, 387);
            this.DTP_ReturnDate.Name = "DTP_ReturnDate";
            this.DTP_ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_ReturnDate.TabIndex = 4;
            // 
            // DTP_RentDate
            // 
            this.DTP_RentDate.Location = new System.Drawing.Point(23, 335);
            this.DTP_RentDate.Name = "DTP_RentDate";
            this.DTP_RentDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_RentDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rent Date";
            // 
            // DGV_Rentals
            // 
            this.DGV_Rentals.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.DGV_Rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rentals.Location = new System.Drawing.Point(3, 3);
            this.DGV_Rentals.Name = "DGV_Rentals";
            this.DGV_Rentals.Size = new System.Drawing.Size(586, 305);
            this.DGV_Rentals.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Watch It Movie Rental Shop";
            // 
            // CustomerWithMoerVideo
            // 
            this.CustomerWithMoerVideo.Location = new System.Drawing.Point(389, 373);
            this.CustomerWithMoerVideo.Name = "CustomerWithMoerVideo";
            this.CustomerWithMoerVideo.Size = new System.Drawing.Size(152, 23);
            this.CustomerWithMoerVideo.TabIndex = 8;
            this.CustomerWithMoerVideo.Text = "Customer With Moer Video";
            this.CustomerWithMoerVideo.UseVisualStyleBackColor = true;
            this.CustomerWithMoerVideo.Click += new System.EventHandler(this.CustomerWithMoerVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TC_MovieRental);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TC_MovieRental.ResumeLayout(false);
            this.Tc_customers.ResumeLayout(false);
            this.Tc_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.tc_movie.ResumeLayout(false);
            this.tc_movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movies)).EndInit();
            this.Tc_rentals.ResumeLayout(false);
            this.Tc_rentals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC_MovieRental;
        private System.Windows.Forms.TabPage Tc_customers;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.TabPage tc_movie;
        private System.Windows.Forms.DataGridView DGV_Movies;
        private System.Windows.Forms.TabPage Tc_rentals;
        private System.Windows.Forms.DataGridView DGV_Rentals;
        private System.Windows.Forms.Button Btn_AddCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomers;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.TextBox txt_CustomerFirstName;
        private System.Windows.Forms.TextBox txt_CustomerLastName;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.TextBox txt_CustomerContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_IssueMovie;
        private System.Windows.Forms.DateTimePicker DTP_ReturnDate;
        private System.Windows.Forms.DateTimePicker DTP_RentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AllMovie;
        private System.Windows.Forms.TextBox txt_MovieYear;
        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.TextBox txt_MovieRentalCost;
        private System.Windows.Forms.Button btn_UpadateMovie;
        private System.Windows.Forms.TextBox txt_MovieTitle;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.TextBox txt_MoviePlot;
        private System.Windows.Forms.Button btn_DeleteMovie;
        private System.Windows.Forms.Button btn_rentedOut;
        private System.Windows.Forms.TextBox txt_MovieGener;
        private System.Windows.Forms.TextBox txt_MovieRating;
        private System.Windows.Forms.TextBox txt_MovieCopies;
        private System.Windows.Forms.Button CustomerWithMoerVideo;
    }
}

