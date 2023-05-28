using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLBaoCao
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static QLBaoCao instance;

        public static QLBaoCao Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLBaoCao();
                return instance;
            }
            set => instance = value;
        }
        private QLBaoCao()
        {

        }
        public double GetDoanhthuByDay(DateTime time)
        {
            return BaoCao.Instance.GetDoanhthuByDay(time);
        }
    }
}
