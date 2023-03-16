using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;  //Binary serialization
using System.Runtime.Serialization.Formatters.Soap;  //SOAP serialization
using System.Xml.Serialization;                        //XML serialization
using System.Text.Json;                                //JSON serialization
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //BinaryWrite btn
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
        
            catch(Exception ex)
              {
                MessageBox.Show(ex.Message);
              }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptBinary.dat", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dept=(Department)binaryFormatter.Deserialize(fs);
                txtDeptId.Text= dept.Id.ToString();
                txtDeptName.Text= dept.Name;
                txtLocation.Text=dept.Location; 
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelDepartmentId_Click(object sender, EventArgs e)
        {

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptxml.xml", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                XmlSerializer xmlserializer=new XmlSerializer(typeof(Department));
                xmlserializer.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptxml.xml", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Department));
                dept = (Department)xmlserializer.Deserialize(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptSoap.soap", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptSoap.soap", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptJson.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptJson.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
              
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
