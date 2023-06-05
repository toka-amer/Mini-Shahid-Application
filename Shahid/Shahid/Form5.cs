using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;

namespace Shahid
{
    public partial class Form5 : Form
    {
        string ocdb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection connection;
        CrystalReport2 cr;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
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
                comboBox1.Items.Add(categoriesData[0].ToString());
            }


            


            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            cr.SetParameterValue(1, comboBox2.Text);

            crystalReportViewer1.ReportSource = cr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            connection.Open();

            OracleCommand productionYearCommand = new OracleCommand();
            productionYearCommand.Connection = connection;
            productionYearCommand.CommandText = "select distinct production_year from programs where category=: cat_name";
            productionYearCommand.CommandType = CommandType.Text;
            productionYearCommand.Parameters.Add("cat_name", comboBox1.Text);

            OracleDataReader productionYearData = productionYearCommand.ExecuteReader();
            while (productionYearData.Read())
            {
                comboBox2.Items.Add(productionYearData[0].ToString());
            }
            connection.Close();
        }
    }
}
