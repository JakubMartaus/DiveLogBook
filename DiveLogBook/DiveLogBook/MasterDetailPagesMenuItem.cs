using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveLogBook
{

    public class MasterDetailPagesMenuItem
    {
        public MasterDetailPagesMenuItem()
        {
            TargetType = typeof(MasterDetailPagesDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}