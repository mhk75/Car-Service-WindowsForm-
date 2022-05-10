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
        Oil oil;
        string pathProgram = Environment.CurrentDirectory;
        Car mycar;


        private void Form1_Load(object sender, EventArgs e)
        {
            writer = new FileWriter(pathProgram);
            cars = new List<Car>();
            oils = new List<Oil>();
            cars = writer.ReadDataCar();
            cars = writer.ReadDataService(cars);
            oils = writer.ReadDataOil();
            foreach (var item in oils)
            {
                cmbRoghan.Items.Add(item.Name + "-" + item.Type);
            }
            cmbRoghan.SelectedIndex = 0;
            cmbVaskazin.Items.Add("full");
            cmbVaskazin.Items.Add("takmil");
            cmbVaskazin.Items.Add("taviz");
            cmbVaskazin.SelectedIndex = 0;

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
                dataGridView1.DataSource = writer.ReadDataOil();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Count == 3)
            {
                txbOilID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                txbCarTag.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void cmbVaskazin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVaskazin.SelectedIndex==0)
            {
                cmbRoghan.Enabled = false;
            }
            else
            {
                cmbRoghan.Enabled = true;
            }
        }

        private Car GetExistingCar(string temp, List<Car> cars)
        {
            Car TempCar = new Car();
            foreach (Car i in cars)
            {
                if (i.CarTag == temp)
                {
                    TempCar = i;
                    break;
                }

            }
            return TempCar;
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            //writer = new FileWriter(pathProgram);
            if (txbCarTag.Text != "")
            {
                try
                {
                    mycar = GetExistingCar(txbCarTag.Text, cars);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("something went wrong with car selection!" + ex.Message);
                    throw;
                }
                
                GetNewService(mycar, oils);
                writer.WriteData(mycar.ServiceUpdateData());
            }
            else
            {
                MessageBox.Show("you Have Not Selected Any Car");
            }
        }

        private void GetNewService(Car mycar, List<Oil> oils)
        {
            try
            {
                mycar.CarService.Tarikh = txbTarikh.Text;
                mycar.CarService.KilometrFeli = Convert.ToInt32(txbKilometrfeli.Text);
                mycar.CarService.TavizFilterRoghan = Convert.ToBoolean(chbFilterRoghan.Checked);
                mycar.CarService.TavizFilterHava = Convert.ToBoolean(chbFilterHava.Checked);
                mycar.CarService.TavizFilterCabin = Convert.ToBoolean(chbFliterCabin.Checked);
                mycar.CarService.TavizSafiBenzin = Convert.ToBoolean(chbSafiBenzin.Checked);
                mycar.CarService.KilometrServiceBadi = Convert.ToInt32(txbKilometrbadi.Text);
                mycar.CarService.ServiceVaskazin = writer.ConvertServiceVaskazin(cmbVaskazin.SelectedIndex.ToString());
                if (mycar.CarService.ServiceVaskazin != CarService.Service_Vaskazin.FULL)
                {
                    mycar.CarService.oil = getOilObject(cmbRoghan.SelectedItem.ToString());
                    MessageBox.Show(mycar.CarService.oil.ID.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong while trying to get your update car data\r\n" + ex.Message);
                throw;
            }
        }

        private Oil getOilObject(string str)
        {
            oil = new Oil();
            string[] temp = str.Split('-');
            foreach(Oil i in oils)
            {
                if(i.Name == temp[0] && i.Type == temp[1])
                {
                    oil = i;
                }
            }
            return oil;
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            if( txbOwner.Text != "" && txbTarikh.Text != "" && txbCarName.Text != "" && txbCarModel.Text != "" && txbCarTagNew.Text != "" && txbKilometrbadi.Text != "" && txbKilometrfeli.Text != "")
            {
                try
                {

                    mycar = GetNewCar(oils);
                    cars.Add(mycar);
                    MessageBox.Show("NewCar Added Successfully");
                }
                catch 
                {
                    MessageBox.Show("pls check your input data");
                }
            }
            else
            {
                MessageBox.Show("pls fill (carname,owner,model,tarikh,kilometrfeli,kilometrbadi,cartagnew) boxes");
            }
        }

        private Car GetNewCar(List<Oil> oils)
        {
            //writer = new FileWriter(pathProgram);
            mycar = new Car();
            try
            {
                mycar.CarName = txbCarName.Text;
                mycar.CarModel = txbCarModel.Text;
                mycar.Owner = txbOwner.Text;
                mycar.CarTag = txbCarTagNew.Text;
                mycar.CarService.Tarikh = txbTarikh.Text;
                mycar.CarService.KilometrFeli = Convert.ToInt32(txbKilometrfeli.Text);
                mycar.CarService.TavizFilterRoghan = Convert.ToBoolean(chbFilterRoghan.Checked);
                mycar.CarService.TavizFilterHava = Convert.ToBoolean(chbFilterHava.Checked);
                mycar.CarService.TavizFilterCabin = Convert.ToBoolean(chbFliterCabin.Checked);
                mycar.CarService.TavizSafiBenzin = Convert.ToBoolean(chbSafiBenzin.Checked);
                mycar.CarService.KilometrServiceBadi = Convert.ToInt32(txbKilometrbadi.Text);
                mycar.CarService.ServiceVaskazin = writer.ConvertServiceVaskazin(cmbVaskazin.SelectedIndex.ToString());
                if (mycar.CarService.ServiceVaskazin != CarService.Service_Vaskazin.FULL)
                {
                    mycar.CarService.oil = getOilObject(cmbRoghan.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong while trying to get your create car data\r\n" + ex.Message);
                throw;
            }
            writer.WriteData(mycar.CarWriteData());
            writer.WriteData(mycar.ServiceWriteData());
            return mycar;
        }

        private void btnNewOil_Click(object sender, EventArgs e)
        {
            if( txbOilName.Text != "" && txbOilType.Text != "")
            {
                oil = GetNewOil();
                oils.Add(oil);
                MessageBox.Show("New Oil Added Successfully");
            }
            else
            {
                MessageBox.Show("pls fill oil type and oil name boxes");
            }
        }

        private Oil GetNewOil()
        {
            oil = new Oil();
            oil.Type = txbOilType.Text;
            oil.Name = txbOilName.Text;
            writer.WriteData(oil.OilWriteData());
            oil.ID = writer.GetOilID(oil);
            return oil;
        }

        private void btnRemoveOil_Click(object sender, EventArgs e)
        {
            if(txbOilID.Text != "")
            {
                oil = new Oil();
                oil.ID = Convert.ToInt32(txbOilID.Text);
                try
                {
                    writer.WriteData(oil.DeleteOilData());  
                    var itemToRemove = oils.Single(r => r.ID == oil.ID);
                    oils.Remove(itemToRemove);
                    MessageBox.Show("Oil Removed Successfully!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("smth went wrong with oils list!\r\n"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("pls select an oil!");
            }
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            if(txbCarTag.Text != "")
            {
                mycar = new Car();
                mycar.CarTag = txbCarTag.Text;
                try
                {
                    writer.WriteData(mycar.DeleteCar());
                    writer.WriteData(mycar.DeleteService());
                    var itemToRemove = cars.Single(r => r.CarTag == mycar.CarTag);
                    cars.Remove(itemToRemove);
                    MessageBox.Show("Car Removed Successfully!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("smth went wrong with cars list!\r\n"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("pls select a car!");
            }
        }
    }
}
