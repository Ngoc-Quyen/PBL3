using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class ThongKe
    {
        TestPbl3Entities db = new TestPbl3Entities();

        private static ThongKe instance;
        private ThongKe() { }

        public static ThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKe();
                return instance;
            }
            set => instance = value;
        }
        public int getCountIdCustomer(DateTime start, DateTime end)
        {
            int count = db.Bills.Where(s => s.TimeThanhToan >= start && s.TimeThanhToan <= end).Select(s => s.IdCustomer).Count();
            return count;
        }
        public double getSumPrice(DateTime start, DateTime end)
        {
            double? total = Convert.ToDouble(db.Bills.Where(s => s.TimeThanhToan >= start && s.TimeThanhToan <= end).Sum(s => s.GiaThanhToan));
            return (double)total;
        }

        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public decimal TotalRevenue { get; set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<CarByDate> carByDateList { get; private set; }
        //private void GetOrder()
        //{
        //    GrossRevenueList = new List<RevenueByDate>();
        //    var resultTable = db.Bills.Where(s => s.TimeThanhToan >= startDate && s.TimeThanhToan <= endDate)
        //        .GroupBy(s => s.TimeThanhToan)
        //        .Select(p => new KeyValuePair<DateTime, decimal>((DateTime)p.Key, (decimal)p.Sum(s => s.GiaThanhToan)))
        //        .ToList();
        //    TotalRevenue = (decimal)resultTable.Sum(p => p.Value);

        //    GrossRevenueList = resultTable.AsEnumerable()
        //        .GroupBy(s => numberDays <= 1 ?
        //            new DateTime(s.TimeThanhToan.Year,
        //                         s.TimeThanhToan.Month,
        //                         s.TimeThanhToan.Day,
        //                         s.TimeThanhToan.Hour,
        //                         s.TimeThanhToan.Minute,
        //                         s.TimeThanhToan.Second) :
        //            numberDays <= 30 ?
        //            new DateTime(s.TimeThanhToan.Year, s.TimeThanhToan.Month, s.TimeThanhToan.Day) :
        //            numberDays <= 92 ?
        //            startDate.AddDays(Math.Floor((s.TimeThanhToan - startDate).TotalDays / 7.0) * 7) :
        //            numberDays <= (365 * 2) ?
        //            new DateTime(s.TimeThanhToan.Year, s.TimeThanhToan.Month, 1) :
        //            new DateTime(s.TimeThanhToan.Year, 1, 1))
        //        .Select(g => new RevenueByDate
        //        {
        //            Date = numberDays <= 92 ? "Week " + g.Key.ToString() : g.Key.ToString(),
        //            TotalAmout = (decimal)g.Sum(s => s.GiaThanhToan)
        //        }).ToList();
        //}
        public void getRevenue()
        {
            //var resultTable = db.Bills.Where(s => s.TimeThanhToan >= startDate && s.TimeThanhToan <= endDate)
            //    .GroupBy(s => numberDays <= 1 ?
            //       ((DateTime) s.TimeThanhToan).ToString("hh tt") :
            //        numberDays <= 30 ?
            //        ((DateTime)s.TimeThanhToan).ToString("dd MM") :
            //        numberDays <= 92 ?
            //        CultureInfo.CurrentCulture.Calendar.GetWeekOfYear((DateTime)s.TimeThanhToan,
            //            CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString() :
            //        numberDays <= (365 * 2) ?
            //        ((DateTime)s.TimeThanhToan).ToString("MM yyyy").Substring(0, numberDays <= 365 ?
            //          ((DateTime)s.TimeThanhToan).ToString("MM yyyy").IndexOf(" ") : ((DateTime)s.TimeThanhToan).ToString("MM yyyy").Length) :
            //        ((DateTime)s.TimeThanhToan).ToString("yyyy"))
            //    .Select(g => new RevenueByDate
            //    {
            //        Date = numberDays <= 92 ? "Week " + g.Key.ToString() : g.Key.ToString(),
            //        TotalAmout = (decimal)g.Sum(s => s.GiaThanhToan)
            //    }).ToList();

            //var resultTable = db.Bills.Where(s => s.TimeThanhToan >= startDate && s.TimeThanhToan <= endDate)
            //    .GroupBy(s => numberDays <= 1 ?
            //        DbFunctions.CreateTime(((DateTime)s.TimeThanhToan).Hour, ((DateTime)s.TimeThanhToan).Minute, ((DateTime)s.TimeThanhToan).Second) :
            //        numberDays <= 30 ?
            //        //DbFunctions.CreateDateTime(((DateTime)s.TimeThanhToan).Year, ((DateTime)s.TimeThanhToan).Month, ((DateTime)s.TimeThanhToan).Day, 0, 0, 0) :
            //        DbFunctions.TruncateTime(((DateTime)s.TimeThanhToan)) :
            //        numberDays <= 92 ?
            //        DbFunctions.DiffDays(startDate, ((DateTime)s.TimeThanhToan)) / 7 :
            //        numberDays <= (365 * 2) ?
            //        DbFunctions.CreateDateTime(((DateTime)s.TimeThanhToan).Year, ((DateTime)s.TimeThanhToan).Month, 1, 0, 0, 0) :
            //        DbFunctions.CreateDateTime(((DateTime)s.TimeThanhToan).Year, 1, 1, 0, 0, 0))
            //    .Select(g => new RevenueByDate
            //    {
            //        Date = numberDays <= 92 ? "Week " + g.Key.ToString() : g.Key.ToString(),
            //        TotalAmout = g.Sum(s => s.GiaThanhToan)
            //    }).ToList();

            var resultTable = db.Bills.Where(s => s.TimeThanhToan >= startDate && s.TimeThanhToan <= endDate)
                .AsEnumerable()
                .GroupBy(s => numberDays <= 1 ?
                    new DateTime(((DateTime)s.TimeThanhToan).Year, ((DateTime)s.TimeThanhToan).Month, ((DateTime)s.TimeThanhToan).Day,
                    ((DateTime)s.TimeThanhToan).Hour, ((DateTime)s.TimeThanhToan).Minute, ((DateTime)s.TimeThanhToan).Second) :
                    numberDays <= 30 ?
                    new DateTime(((DateTime)s.TimeThanhToan).Year, ((DateTime)s.TimeThanhToan).Month, ((DateTime)s.TimeThanhToan).Day) :
                    numberDays <= 92 ?
                    startDate.AddDays(Math.Floor((((DateTime)s.TimeThanhToan) - startDate).TotalDays / 7.0) * 7) :
                    numberDays <= (365 * 2) ?
                    new DateTime(((DateTime)s.TimeThanhToan).Year, ((DateTime)s.TimeThanhToan).Month, 1) :
                    new DateTime(((DateTime)s.TimeThanhToan).Year, 1, 1))
                .Select(g => new RevenueByDate
                {
                    Date = numberDays <= 92 ? "Week " + g.Key.ToString() : g.Key.ToString(),
                    TotalAmount = (decimal)g.Sum(s => s.GiaThanhToan)
                }).ToList();



        }
        public void getRevenue12()
        {
            GrossRevenueList = new List<RevenueByDate>();
            var resultTable = db.Bills.Where(s => s.TimeThanhToan >= startDate && s.TimeThanhToan <= endDate)
                .GroupBy(s => s.TimeThanhToan)
                .Select(p => new
                {
                    Date = (DateTime)p.Key,
                    TotalAmout = (decimal)p.Sum(s => s.GiaThanhToan)
                }).ToList();
            TotalRevenue = resultTable.Sum(s => s.TotalAmout);
            if (numberDays <= 1)
            {
                GrossRevenueList = resultTable.GroupBy(s => s.Date.ToString("hh:tt"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(s => s.TotalAmout)
                    }).ToList();
            }
            else
                if (numberDays <= 30)
            {
                GrossRevenueList = resultTable.GroupBy(s => s.Date.ToString("dd/MM"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(s => s.TotalAmout)
                    }).ToList();
            }
            else
                if (numberDays <= 92)
            {
                GrossRevenueList = resultTable
                    .GroupBy(s => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        s.Date, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                    .Select(p => new RevenueByDate
                    {
                        Date = "Week " + p.Key,
                        TotalAmount = p.Sum(s => s.TotalAmout)
                    }).ToList();
            }
            else
                if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = resultTable.GroupBy(s => s.Date.ToString("MM/yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
                        TotalAmount = g.Sum(s => s.TotalAmout)
                    }).ToList();
            }
            else
            {
                GrossRevenueList = resultTable.GroupBy(s => s.Date.ToString("yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(s => s.TotalAmout)
                    }).ToList();
            }
        }
        //public void getCarByDate()
        //{
        //   // carByDateList = new List<CarByDate>();
        //    carByDateList = db.Bills
        //        .Join(db.Cars,
        //             bill => bill.IdCar,
        //             car => car.IdCar,
        //             (bill, car) => new { bill, car })
        //        .Where(s => s.bill.TimeThanhToan >= startDate && s.bill.TimeThanhToan <= endDate)
        //        .GroupBy(s => new { s.car.ChoNgoi })
        //        .Select(g => new CarByDate
        //         {
        //            CarType = (int)g.Key.ChoNgoi,
        //            Count = (int)g.Sum(s => DbFunctions.DiffDays(startDate, endDate) + 1)
        //         })
        //        .ToList();
        //}

       // public void getCarByDate12()
       // {
       //     carByDateList = db.Bills
       //.Join(db.Cars,
       //     bill => bill.IdCar,
       //     car => car.IdCar,
       //     (bill, car) => new { bill, car })
       //.Where(s => s.bill.TimeThanhToan >= startDate && s.bill.TimeThanhToan <= endDate)
       //.GroupBy(s => new { s.car.ChoNgoi })
       //.Select(g => new { CarType = g.Key.ChoNgoi, Count = g.Sum(s => DbFunctions.DiffDays(startDate, endDate) + 1) })
       //.ToList()
       //.Select(x => new CarByDate(x.CarType, x.Count))
       //.ToList();
       // }
        public bool LoadData(DateTime start, DateTime end)
        {
            end = new DateTime(end.Year, end.Month, end.Day,
                end.Hour, end.Minute, 59);
            if (start != this.startDate || end != this.endDate)
            {
                this.startDate = start;
                this.endDate = end;
                this.numberDays = (end - start).Days;
                getRevenue12();
                //getCarByDate12();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public struct CarByDate
    {
        private int? carType;
        private int? count;

        public CarByDate(int? carType, int? count) : this()
        {
            this.carType = carType;
            this.count = count;
        }

        public int CarType { get; set; }
        public int Count { get; set; }
    }
}
