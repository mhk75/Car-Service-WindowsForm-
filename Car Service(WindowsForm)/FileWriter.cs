using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;


namespace cars
{
    public class FileWriter
    {
       
        #region Constructor
        public FileWriter(string PathProgram)
        {
            DataBaseLocation = @"URI=file:" + PathProgram + @"\Data\database.db";
        }

        public FileWriter(string PathProgram, string name)
        {

        }
        #endregion
        // = @"URI=file:H:\projects\c#\Console\test\car-v2\cars\database.db"
        #region Properties
        private string DataBaseLocation ;
        public string Query { set; get; }
        #endregion



        public byte[] ObjectToByteArray(object obj)
        {
            // proper way to serialize object
            var objToString = System.Text.Json.JsonSerializer.Serialize(obj);
            // convert that that to string with ascii you can chose what ever encoding want
            return System.Text.Encoding.ASCII.GetBytes(objToString);
        }


        public object ByteArrayToObject(byte[] bytes)
        {
            // make sure you use same type what you use chose during conversation
            var stringObj = System.Text.Encoding.ASCII.GetString(bytes);
            // proper way to Deserialize object
            return System.Text.Json.JsonSerializer.Deserialize<object>(stringObj);
        }


        public void AppendAllBytes(string path, byte[] bytes)
        {
            //argument-checking here.

            using (var stream = new FileStream(path, FileMode.Append))
            {
                stream.Write(bytes, 0, bytes.Length);

            }
        }


        public void WriteData(string query)
        {
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();
                SQLiteCommand Command = new SQLiteCommand(query, Connection);
                string answer = Convert.ToString(Command.ExecuteNonQuery());
                Console.WriteLine(answer);
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }


        public List<Car> ReadDataCar()
        {
            
            string query = "select * from car";
            int count = 0;
            List<Car> File_Cars = new List<Car>();
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();             
                SQLiteCommand Command = new SQLiteCommand(query, Connection);
                SQLiteDataReader answer = Command.ExecuteReader();
                while (answer.Read())
                {
                    File_Cars.Add(new Car());
                    File_Cars[count].CarName = answer["name"].ToString();
                    File_Cars[count].CarModel = answer["model"].ToString();
                    File_Cars[count].Owner = answer["owner"].ToString();
                    File_Cars[count].CarTag = answer["tag"].ToString();

                    count++;
                }
                
                
                return File_Cars;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }
               
            }
        }



        public List<Car> ReadDataService(List<Car> File_Cars)
        {
            DataTable dt = new DataTable();
            string query = "select * from carservice inner join Oil on Oil.OilID = carservice.OilID inner join Car on car.tag = carservice.cartag";
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();                
                SQLiteCommand Command = new SQLiteCommand(query, Connection);
                SQLiteDataReader answer = Command.ExecuteReader();
                while (answer.Read())
                {
                    foreach (Car car in File_Cars)
                    {
                        if (car.CarTag == answer["cartag"].ToString())
                        {
                            car.CarService.Tarikh = answer["tarikh"].ToString();
                            car.CarService.ServiceVaskazin = ConvertServiceVaskazin(answer["servicevaskazin"].ToString());
                            car.CarService.TavizFilterRoghan = Convert.ToBoolean(answer["filterroghan"]);
                            car.CarService.TavizFilterHava = Convert.ToBoolean(answer["filterhava"]);
                            car.CarService.TavizFilterCabin = Convert.ToBoolean(answer["filtercabin"]);
                            car.CarService.TavizSafiBenzin = Convert.ToBoolean(answer["safibenzin"]);
                            car.CarService.KilometrFeli = Convert.ToInt32(answer["kilometrfeli"]);
                            car.CarService.KilometrServiceBadi = Convert.ToInt32(answer["kilometrservicebadi"]);
                            car.CarService.oil.ID = Convert.ToInt32(answer["OilID"]);
                            car.CarService.oil.Name = answer["name"].ToString();
                            car.CarService.oil.Type = answer["type"].ToString();
                        }
                    }
                }
                return File_Cars;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }

        public List<Oil> ReadDataOil()
        {
            string query = "select * from Oil";
            int count = 0;
            List<Oil> File_oils = new List<Oil>();
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();
                SQLiteCommand Command = new SQLiteCommand(query, Connection);
                SQLiteDataReader answer = Command.ExecuteReader();
                while (answer.Read())
                {
                    File_oils.Add(new Oil());
                    File_oils[count].Name = answer["name"].ToString();
                    File_oils[count].Type = answer["type"].ToString();
                    File_oils[count].ID = Convert.ToInt32(answer["OilID"]);
                    count++;
                }
                return File_oils;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }

        public DataTable ShowOilData()
        {
            DataTable dt = new DataTable();
            string query = "";
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();
                SQLiteDataAdapter answer = new SQLiteDataAdapter(query, Connection);
                answer.Fill(dt);
                return dt;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }
        //carname,model,owner,cartag,tarikh,kilometrfeli,kilometrservicebadi,filterroghan,filterhava,filtercabin,safibenzin,servicevaskazin,oilname,oiltype
        public DataTable ReadDataAll()
        {
            DataTable dt = new DataTable();
            string query = "select car.name as carname,car.model as model,car.owner as owner,car.tag as cartag,carservice.tarikh as tarikh,carservice.kilometrfeli as kilometrfeli,carservice.filterroghan as filterroghan," +
                "carservice.filterhava as filterhava,carservice.filtercabin as filtercabin,carservice.safibenzin as safibenzin,carservice.servicevaskazin as servicevaskazin,carservice.kilometrservicebadi as kilometrservicebadi " +
                ",oil.name as oilname,oil.type as oiltype from carservice inner join Oil on Oil.OilID = carservice.OilID inner join Car on car.tag = carservice.cartag";
            SQLiteConnection Connection = null;
            try
            {
                Connection = new SQLiteConnection(DataBaseLocation);
                Connection.Open();
                SQLiteDataAdapter answer = new SQLiteDataAdapter(query, Connection);
                answer.Fill(dt);
                return dt;
            }
            catch (SQLiteException)
            {

                throw;
            }
            finally
            {

                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }

        public CarService.Service_Vaskazin ConvertServiceVaskazin(string v)
        {
            if (v == "FULL" || v == "full" || v == "0")
            {
                return CarService.Service_Vaskazin.FULL;
            }
            else if (v == "TAKMIL_SHOD" || v == "takmil" || v == "1")
            {
                return CarService.Service_Vaskazin.TAKMIL_SHOD;
            }
            else
            {
                return CarService.Service_Vaskazin.TAVIZ_SHOD;
            }
        }
    }
}
