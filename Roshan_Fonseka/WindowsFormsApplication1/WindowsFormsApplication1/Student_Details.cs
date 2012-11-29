using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Student_Details : Form
    {
        private SqlCommand com;
        private SqlConnection con;

        public Student_Details()
        {
            InitializeComponent();
        }

       

        private void Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Registration_SystemDataSet.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.student_Registration_SystemDataSet.Registration);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(Program.constr);
                com = new SqlCommand("Save_Registration", con);

                com.CommandType = CommandType.StoredProcedure;
               
                con.Open();

              //  com.Parameters.AddWithValue("@StudentId", studentIdTextBox.Text);
                com.Parameters.AddWithValue("@Name", nameTextBox.Text);
                com.Parameters.AddWithValue("@DOB", dOBDateTimePicker.Value);
                com.Parameters.AddWithValue("@GradePointAvg", gradePointAvgTextBox.Text);
                com.Parameters.AddWithValue("@Active", activeCheckBox.Checked);

                com.ExecuteNonQuery();

                MessageBox.Show("You have add successfully");

            }
           catch (SqlException)
                {
               MessageBox.Show("You have inserted these student ID before");
                }
            con.Close();

            this.registrationTableAdapter.Fill(this.student_Registration_SystemDataSet.Registration);
            this.registrationDataGridView.Refresh();




        }

      

        private void registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Registration_SystemDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
