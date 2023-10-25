using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing.Text;

namespace ConnectedDemo

{

    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Depart> list = new List<Depart>();
                string qry = "Select * from Depart";
                cmd = new SqlCommand(qry, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Depart dept = new Depart();
                        dept.did = Convert.ToInt32(reader["did"]);
                        dept.dname = reader["d_name"].ToString();
                        list.Add(dept);
                    }
                }
                cmddid.DataSource = list;
                cmddid.DisplayMember = "dname";
                cmddid.ValueMember = "did";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into employes values(@ename,@email,@age,@salary,@did)";
                cmd = new SqlCommand(qry, conn);
                //Assign Value to each Parameter
                cmd.Parameters.AddWithValue("@ename", txtname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(cmddid.SelectedValue));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Inserted");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close ();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                string qry = "select e.*, d.d_name from Employes e inner join Depart d on d.did = e.did where e.emp_id=@emp_id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtempid.Text));
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtname.Text = reader["ename"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtage.Text = reader["age"].ToString();
                        txtsalary.Text = reader["salary"].ToString();
                        cmddid.Text = reader["d_name"].ToString();
                    }
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
            finally
            {
                conn.Close();   
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try

            {
                string qry = "update Employes set ename=@ename,email=@email,age=@age,salary=@salary,did=@did where emp_id=@emp_id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@ename", txtname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(cmddid.SelectedValue));
                cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtempid.Text));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employes where emp_id=@emp_id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtempid.Text));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
           
        }
    }
}
