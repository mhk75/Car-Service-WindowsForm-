using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    public class Car
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string Owner { get; set; }
        public CarService CarService { get; set; } = new CarService();
        public string CarTag { get; set; }
        public string Status()
        {
            var result = string.Format("CarName: {0}\r\nCarModel: {1}\r\nOwner: {2}\r\nCarTag: {3}\r\nkilometrfeli: {4}\r\ntarikh: {5}\r\ntaviz filterroghan: {6}\r\ntaviz filterhava: {7}\r\ntaviz filtercabin: {8}\r\ntaviz safibenzin: {9}\r\nservice vaskazin: {10}\r\nkilometr service badi: {11}\r\noil name: {12}\r\noil type: {13}\r\n",
                CarName, CarModel, Owner, CarTag, CarService.KilometrFeli, CarService.Tarikh, CarService.TavizFilterRoghan, CarService.TavizFilterHava, CarService.TavizFilterCabin, CarService.TavizSafiBenzin, CarService.ServiceVaskazin, CarService.KilometrServiceBadi, CarService.oil.Name, CarService.oil.Type);

            return result;
        }

        public string CarWriteData()
        {
            return string.Format("insert into car(name,model,owner,tag) values('{0}','{1}','{2}','{3}')",
                CarName, CarModel, Owner, CarTag);
        }
        public string ServiceWriteData()
        {
            return string.Format("insert into carservice(cartag,tarikh,kilometrfeli,filterroghan,filterhava,filtercabin,safibenzin,servicevaskazin,kilometrservicebadi) values(  '{0}','{1}',{2},{3},{4},{5},{6},'{7}',{8})",
                CarTag, CarService.Tarikh, CarService.KilometrFeli, CarService.TavizFilterRoghan, CarService.TavizFilterHava, CarService.TavizFilterCabin, CarService.TavizSafiBenzin, CarService.ServiceVaskazin.ToString(), CarService.KilometrServiceBadi);
        }
        public void ServiceStatus()
        {
            Console.WriteLine(string.Format("CarTag: {0}\nkilometrfeli: {1}\ntarikh: {2}\ntaviz filterroghan: {3}\ntaviz filterhava: {4}\ntaviz filtercabin: {5}\ntaviz safibenzin: {6}\nservice vaskazin: {7}\nkilometr service badi: {8}\nOil Name:{9}\nOil Type:{10}\n",
                CarTag, CarService.KilometrFeli, CarService.Tarikh, CarService.TavizFilterRoghan, CarService.TavizFilterHava, CarService.TavizFilterCabin, CarService.TavizSafiBenzin, CarService.ServiceVaskazin, CarService.KilometrServiceBadi,CarService.oil.Name,CarService.oil.Type));
        }
        public string ServiceUpdateData()
        {
            return string.Format("UPDATE carservice SET tarikh = '{0}', kilometrfeli = {1}, filterroghan = {2}, filterhava = {3}, filtercabin = {4}, safibenzin = {5}, servicevaskazin = '{6}', kilometrservicebadi = {7} WHERE cartag = '{8}'",
                CarService.Tarikh, CarService.KilometrFeli, CarService.TavizFilterRoghan, CarService.TavizFilterHava, CarService.TavizFilterCabin, CarService.TavizSafiBenzin, CarService.ServiceVaskazin.ToString(), CarService.KilometrServiceBadi, CarTag);
        }
        public string DeleteCar()
        {
            return string.Format("DELETE FROM car  WHERE tag = '{0}'",
                CarTag);
        }
    }
}
