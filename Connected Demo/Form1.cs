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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace Connected_Demo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            con = new
SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                List<Dept> list = new List<Dept>();
                string qry = "select * from Depart";
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dept dept = new Dept();
                        dept.Did = Convert.ToInt32(reader["did"]);
                        dept.Dname = reader["dname"].ToString();
                        list.Add(dept);
                    }
                }
                // display dname & on selection of dname we need did
                cmbDepartment.DataSource = list;
                cmbDepartment.DisplayMember = "Dname";
                cmbDepartment.ValueMember = "Did";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Emp6 values(@ename, @email, @eage, @salary, @did)";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@ename", textName.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@eage",
                Convert.ToInt32(textAge.Text));
                cmd.Parameters.AddWithValue("@salary",
                Convert.ToInt32(textSalary.Text));
                cmd.Parameters.AddWithValue("@did",
                Convert.ToInt32(cmbDepartment.SelectedValue));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
           string qry = "select e.*, d.dname from Emp6 e inner join Depart d on d.did = e.did where e.eid = @eid";
cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@eid",
                Convert.ToInt32(textId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        textName.Text = reader["ename"].ToString();
                        textEmail.Text = reader["email"].ToString();
                        textAge.Text = reader["eage"].ToString();
                        textSalary.Text = reader["salary"].ToString();
                        cmbDepartment.Text = reader["dname"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Emp6 set ename = @ename,email = @email,eage = @eage,salary = @salary,did = @did where eid = @eid";
cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@ename", textName.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@eage",
                Convert.ToInt32(textAge.Text));
                cmd.Parameters.AddWithValue("@salary",
                Convert.ToInt32(textSalary.Text));
                cmd.Parameters.AddWithValue("@did",
                Convert.ToInt32(cmbDepartment.SelectedValue));
                cmd.Parameters.AddWithValue("@eid",
                Convert.ToInt32(textId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Emp6 where eid=@eid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@eid",
                Convert.ToInt32(textId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
       // using System.Data;
private void GetAllEmps()
    {
        string qry = "select e.*, d.dname from Emp6 e inner join Depart d on d.did = e.did";
cmd = new SqlCommand(qry, con);
        con.Open();
        reader = cmd.ExecuteReader();
        DataTable table = new DataTable();
        table.Load(reader);
        dataGridView1.DataSource = table; 
con.Close();
    }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            GetAllEmps();
        }
        private void ClearFields()
        {
            textId.Clear();
            textName.Clear();
            textSalary.Clear();
            textEmail.Clear();
            textAge.Clear();
            cmbDepartment.ResetText();
        }
    }
}
