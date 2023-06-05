using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace Shahid
{
    public partial class Form2 : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }
        


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User ID = hr; Password = hr;";
            string cmdstr = "";


            if (radioButton1.Checked)
            {
                cmdstr = "select * from PROGRAMS where S_P = 'series'";
            }
            if (radioButton2.Checked)
            {
                cmdstr = "select * from PROGRAMS where S_P = 'show'";
            }

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new OracleCommandBuilder(adapter);

                adapter.Update(ds.Tables[0]);
                MessageBox.Show("The data has been updated.");
            }
            catch (OracleException)
            {

                MessageBox.Show("Please Check the entered data.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
