using cars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_WindowsForm_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        public FileWriter writer;
        List<Car> cars;
        List<Oil> oils;

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathProgram = Environment.CurrentDirectory;
            writer = new FileWriter(pathProgram);
            Car mycar = new Car();
            Oil oil = new Oil();
            int flag, Temp;
            string temp;
            cars = new List<Car>();
            oils = new List<Oil>();
            cars = writer.ReadDataCar();
            cars = writer.ReadDataService(cars);
            oils = writer.ReadDataOil();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            DataTable tblCars = new DataTable();
            DataColumn clmnId = new DataColumn("rowId");
            DataColumn clmnOilId = new DataColumn("OilId");
            DataColumn clmnType = new DataColumn("Type");
            DataColumn clmnName= new DataColumn("Name");
            tblCars.Columns.Add(clmnId);
            tblCars.Columns.Add(clmnOilId);
            tblCars.Columns.Add(clmnType);
            tblCars.Columns.Add(clmnName);
            dataGridView1.DataSource = writer.ReadDataAll();

            int count = 1;
            foreach (Car i in cars)
            {
                //Console.WriteLine("");
                //Console.WriteLine(count);
                //i.Status();
                //count++;
                //Console.WriteLine("");
                txbResult.AppendText(count.ToString()+"\r\n");
                txbResult.AppendText(i.Status()+"\r\n");
                count++;
                txbResult.AppendText("\r\n");
            }
        }

        private void ShowOilData_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = writer.ReadDataOil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
