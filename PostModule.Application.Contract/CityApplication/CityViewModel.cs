using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.CityApplication
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Tehran { get; set; }
        public bool Center { get; set; }
        public string CreateDate { get; set; }
    }
}
