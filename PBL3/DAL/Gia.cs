using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class Gia
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static Gia instance;

        public static Gia Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new Gia();
                return instance;
            }
           private set => instance = value; 
        }
        private Gia() { }
        public List<Price> getAllPrice()
        {
            var l = db.Prices.Select(p => p);
            return l.ToList();
        }
        public Price getPriceById(int id) 
        {
            var l = db.Prices.Find(id);
            return l;
        }
    }
}
