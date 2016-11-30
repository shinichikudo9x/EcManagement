using GUI_Maker_ECManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Maker_ECManagement
{
    public class Category
    {
        private readonly ObservableListSource<HocVien> _HocViens =
                new ObservableListSource<HocVien>();

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ObservableListSource<HocVien> HocViens { get { return _HocViens; } }
    }
}
