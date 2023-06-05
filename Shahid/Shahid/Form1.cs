using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Shahid
{
    public partial class Form1 : Form
    {
        string ocdb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection connection;
        bool check = false;
        int userID, programID;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ocdb);
            connection.Open();

            //Select all categories into 1st combobox [4. Multiple rows with stored procedure]
            OracleCommand categoriesCommand = new OracleCommand();
            categoriesCommand.Connection = connection;
            categoriesCommand.CommandText = "SELECT_CATEGORIES";
            categoriesCommand.CommandType = CommandType.StoredProcedure;
            categoriesCommand.Parameters.Add("categories_cursor", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader categoriesData = categoriesCommand.ExecuteReader();
            while (categoriesData.Read())
            {
                CategoriesComboBox.Items.Add(categoriesData[0].ToString());
            }

            connection.Close();
        }

        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamesComboBox.Items.Clear();
            NamesComboBox.Text = "";
            UserRateTxt.Text = "";
            TotalRateTxt.Text = "";

            connection.Open();
            //[1. Select multiple rows with bind variables]
            OracleCommand namesCommand = new OracleCommand();
            namesCommand.Connection = connection;
            namesCommand.CommandText = "select NAME from PROGRAMS where CATEGORY=:cat_name";
            namesCommand.CommandType = CommandType.Text;
            namesCommand.Parameters.Add("cat_name", CategoriesComboBox.Text);

            OracleDataReader namesData = namesCommand.ExecuteReader();
            while (namesData.Read())
            {
                NamesComboBox.Items.Add(namesData[0].ToString());
            }
            
            connection.Close();
        }


        private void NamesBomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();


            OracleCommand programIDCommand = new OracleCommand();
            programIDCommand.Connection = connection;
            programIDCommand.CommandText = "select ID from PROGRAMS where NAME=: prog_name";
            programIDCommand.Parameters.Add("prog_name", NamesComboBox.Text);
            OracleDataReader progIDData = programIDCommand.ExecuteReader();

            //Get the program ID
            if (progIDData.Read())
                programID = Convert.ToInt32(progIDData[0].ToString());


            //View Program total rate [select single row with bind variables]
            Calc_Rate();


            //Check username & password [1. Select single rows with bind variables]
            OracleCommand userCheckCommand = new OracleCommand();
            userCheckCommand.Connection = connection;
            userCheckCommand.CommandText = "select ID from REGISTERED_USER where USER_NAME=: userName and PASSWORD=: userPassword";
            userCheckCommand.Parameters.Add("userName", UserNameTxt.Text);
            userCheckCommand.Parameters.Add("userPassword", PasswordTxt.Text);
            OracleDataReader userCheckData = userCheckCommand.ExecuteReader();

            //If he had registered
            if (userCheckData.Read())
            {
                //Get the user ID
                userID = Convert.ToInt32(userCheckData[0].ToString());

                //Search for user's previous rate with specific program [3. Select single row with stored procedure]
                OracleCommand userRateCommand = new OracleCommand();
                userRateCommand.Connection = connection;
                userRateCommand.CommandText = "USERRATE";
                userRateCommand.CommandType = CommandType.StoredProcedure;
                userRateCommand.Parameters.Add("userID", userID);
                userRateCommand.Parameters.Add("prog_name", NamesComboBox.Text);
                userRateCommand.Parameters.Add("userRate", OracleDbType.Int32, ParameterDirection.Output);

                try
                {
                    userRateCommand.ExecuteNonQuery();

                    //Write user's rate in Rate field
                    UserRateTxt.Text = userRateCommand.Parameters[2].Value.ToString();
                }
                catch
                {
                    //User had not rated this program before
                    UserRateTxt.Text = "";
                }
            }
            else
            {
                UserRateTxt.Text = "";
            }

            connection.Close();
        }

        private void RateButton_Click(object sender, EventArgs e)
        {
            
            if (UserNameTxt.Text == "")
            {
                MessageBox.Show("Username must be provided");
            }
            else if(PasswordTxt.Text == "")
            {
                MessageBox.Show("Password must be provided");
            }
            else if(NamesComboBox.Text == "")
            {
                MessageBox.Show("Name must be provided");
            }
            else if(UserRateTxt.Text == "")
            {
                MessageBox.Show("Rate must be provided");
            }
            //Check Username & Password
            else if(UserNameTxt.Text != "" && PasswordTxt.Text != "")
            {
                connection.Open();

                OracleCommand userCheckCommand = new OracleCommand();
                userCheckCommand.Connection = connection;
                userCheckCommand.CommandText = "select ID from REGISTERED_USER where USER_NAME=: userName and PASSWORD=: userPassword";
                userCheckCommand.Parameters.Add("userName", UserNameTxt.Text);
                userCheckCommand.Parameters.Add("userPassword", PasswordTxt.Text);
                OracleDataReader userCheckData = userCheckCommand.ExecuteReader();

                if (userCheckData.Read())
                {
                    check = true;
                    userID = Convert.ToInt32(userCheckData[0].ToString());
                }
                else
                {
                    MessageBox.Show("Username or password is not correct !");
                }
                
            }
            
            if(check)
            {
                //Rate checking
                if (Convert.ToInt32(UserRateTxt.Text) >= 0 && Convert.ToInt32(UserRateTxt.Text) <= 10)
                {
                    //Search for user's previous rate with this program
                    OracleCommand userRateCommand = new OracleCommand();
                    userRateCommand.Connection = connection;
                    userRateCommand.CommandText = "USERRATE";
                    userRateCommand.CommandType = CommandType.StoredProcedure;
                    userRateCommand.Parameters.Add("userID", userID);
                    userRateCommand.Parameters.Add("prog_name", NamesComboBox.Text);
                    userRateCommand.Parameters.Add("userRate", OracleDbType.Int32, ParameterDirection.Output);

                    try
                    {
                        userRateCommand.ExecuteNonQuery();

                        //User had rated this program before (update rate) [Select single row with bind variables]
                        OracleCommand updateCommand = new OracleCommand();
                        updateCommand.Connection = connection;
                        updateCommand.CommandText = "update RATE set RATE=:rate where USER_ID=:id and PROGRAM_ID=:prog_id";
                        updateCommand.Parameters.Add("rate", UserRateTxt.Text);
                        updateCommand.Parameters.Add("id", userID);
                        updateCommand.Parameters.Add("prog_id", programID);

                        updateCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        //Insert the new rate for the user to the program [2. Insert row without using procedure]
                        OracleCommand insertCommand = new OracleCommand();
                        insertCommand.Connection = connection;
                        insertCommand.CommandText = "insert into Rate values (:rate,:id,:prog_id)";
                        insertCommand.Parameters.Add("rate", UserRateTxt.Text);
                        insertCommand.Parameters.Add("id", userID);
                        insertCommand.Parameters.Add("prog_id", programID);

                        insertCommand.ExecuteNonQuery();


                    }
                    MessageBox.Show("Your Rate has been recorded !");
                }
                else
                {
                    MessageBox.Show("Rate must be between 0 and 10 !");
                }
                Calc_Rate();
                check = false;

                
            }

            connection.Close(); ;
        }
        public OracleDataReader Calc_Rate()
        {
            //Calculate Total rate for the program
            //Select all rates for the program [Select multiple rows with stored procedure using cursor]
            OracleCommand totalRateCommmand = new OracleCommand();
            totalRateCommmand.Connection = connection;
            totalRateCommmand.CommandType = CommandType.StoredProcedure;
            totalRateCommmand.CommandText = "CALC_RATE";
            totalRateCommmand.Parameters.Add("prog_id", programID);

            totalRateCommmand.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader rates = totalRateCommmand.ExecuteReader();

            int counter = 0;
            double sum = 0.0;
            //Calculate average rate
            while (rates.Read())
            {
                sum += Convert.ToDouble(rates[0].ToString());
                counter++;
            }
            try
            {
                sum /= counter;
            }
            catch
            {

            }

            //Show updated Total rate on txt box
            TotalRateTxt.Text = sum.ToString();
            return rates;
        }
    }
}
