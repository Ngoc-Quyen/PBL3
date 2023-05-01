﻿using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class QLXe1
    {
        TestPbl3Entities1 db = new TestPbl3Entities1();
        private static QLXe1 instance;

        public static QLXe1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLXe1();
                return instance;
            }
            private set => instance = value;
        }
        private QLXe1() { }
        public Car getItem(string id)
        {
            return db.Cars.FirstOrDefault(x => x.IdCar == id);
        }
        public List<Car> getList()
        {
            return db.Cars.ToList();
        }
        public List<Car> GetAllCar()
        {
            var data = db.Cars.Select(p => p);
            return data.ToList();
        }
        public Car GetCarBy(string id)
        {
            Car xe = new Car();
            xe = db.Cars.Find(id);
            return xe;
        }
        public void Add(Car car)
        {
            try
            {
                if (Check(car.IdCar))
                {
                    MessageBox.Show("Xe đã có trong hệ thống!");
                }
                else
                {
                    db.Cars.Add(car);
                    db.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Edit(Car car)
        {
            try
            {
                var _car = db.Cars.Find(car.IdCar);
                _car.IdCar = car.IdCar;
                _car.NameCar = car.NameCar;
                _car.ColorCar = car.ColorCar;
                _car.ChoNgoi = car.ChoNgoi;
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Delete(string Id)
        {
            try
            {
                if (Check(Id))
                {
                    var _car = db.Cars.Find(Id);
                    db.Cars.Remove(_car);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Xe không có trong hệ thống!");
                }

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
        public List<Car> GetCarBySearch(string txt)
        {
            var l = db.Cars.Where(p => p.IdCar.Contains(txt)).ToList();
            return l;
        }
        public bool Check(string Id)
        {
            bool c = false;
            foreach (Car i in GetAllCar())
            {
                if (i.IdCar == Id)
                {
                    c = true;
                }
            }
            return c;
        }
        //public List<Car> GetCarBySearch(string txt)
        //{
        //    if(txt == "All")
        //    {
        //        return GetAllCar();
        //    }
        //    else
        //    {
        //        var l = db.Cars.Where(p => p.)
        //    }
        //}
    }
}