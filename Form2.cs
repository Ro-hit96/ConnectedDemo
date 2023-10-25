using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;


namespace ConnectedDemo
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {


                //Write A Query
                String qry = "Select * from Depart";
                //Assign Query to adapter-->will fire tthe query
                da = new SqlDataAdapter(qry, conn);
                //Created Object of DataSet
                ds = new DataSet();
                //Fill()will fire the select query & loaf date in the DS
                //Dept is a name given to the table in dataset
                da.Fill(ds, "Depart");
                cmddid.DataSource = ds.Tables["Depart"];
                cmddid.DisplayMember = "d_name";
                cmddid.ValueMember = "did";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataSet GetEmployees()
        {
            string qry = "select * from Employes";
            //Assign The Query
            da=new SqlDataAdapter(qry, conn);
            //When app load the in Dataset,we need to managae the PK also 
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //SCB will track the Dataset& update quires to data Adapter
            builder=new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "Employes");//this name give to the DataSetTable
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                //Create new record to add record
                DataRow row = ds.Tables["Employes"].NewRow();
                //Assign Value to the row
                row["ename"]=txtname.Text;
                row["email"]=txtEmail.Text;
                row["age"]=txtage.Text;
                row["salary"]=txtsalary.Text;
                row["did"] = cmddid.SelectedValue;
                //Attach this row in dataset table
                ds.Tables["Employes"].Rows.Add(row);
                //Update the chenges from DataSet to db
                int result = da.Update(ds.Tables["Employes"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record Inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                //Find the rows
                DataRow row = ds.Tables["Employes"].Rows.Find(txtempid.Text);
                if(row != null)
                {
                    row["ename"] = txtname.Text;
                    row["email"] = txtEmail.Text;
                    row["age"] = txtage.Text;
                    row["salary"] = txtsalary.Text;
                    row["did"] = cmddid.SelectedValue;
                    //Update the chenges from DataSet to db
                    int result = da.Update(ds.Tables["Employes"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Inserted");
                    } else
                    {
                        MessageBox.Show("Id Not Matched");
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                //Find the rows
                DataRow row = ds.Tables["Employes"].Rows.Find(txtempid.Text);
                if (row != null)
                {
                    //Delete the current rows from DataSet Table
                    row.Delete();
                    //Update the chenges from DataSet to db
                    int result = da.Update(ds.Tables["Employes"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Id Not Matched");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.*, d.d_name from Employes e inner join Depart d on d.did = e.did" ;
                da = new SqlDataAdapter(qry, conn);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds=new DataSet();
                da.Fill(ds, "Employes");
                DataRow row = ds.Tables["Employes"].Rows.Find(txtempid.Text);
                if (row != null)
                {
                    txtname.Text = row["ename"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtage.Text = row["age"].ToString();
                    txtsalary.Text = row["salary"].ToString();
                    cmddid.Text = row["d_name"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                dataGridView1.DataSource = ds.Tables["Employes"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
