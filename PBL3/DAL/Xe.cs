using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class Xe
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static Xe instance;

        public static Xe Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new Xe();
                return instance;
            }
            private set => instance = value; 
        }
        private Xe() { }
        public Car getItem(string id)
        {
            return db.Cars.FirstOrDefault(x => x.IdCar == id);
        }
        public List<Car> getList()
        {
            return db.Cars.ToList();
        }
        public Car Add(Car car)
        {
            try
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return car;
            }
            catch(Exception ex) 
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            } 
        }
        public Car Edit(Car car)
        {
            try
            {
                var _car = db.Cars.FirstOrDefault(x => x.IdCar == car.IdCar);
                _car.NameCar = car.NameCar;
                _car.ColorCar = car.ColorCar;
                _car.ChoNgoi = car.ChoNgoi;
                db.SaveChanges();

                return _car;
            }

            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public Car Delete(string Id)
        {
            try
            {
                var _car = db.Cars.FirstOrDefault(x => x.IdCar == Id);
                db.Cars.Remove(_car);
                db.SaveChanges();
                return _car;
            }

            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public object LoadCar()
        {
            var result = from c in db.Cars select c;
            return result.ToList();
        }

    }
}
