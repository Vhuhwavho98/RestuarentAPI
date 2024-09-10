using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Domain.Entities
{
    public class Restuarent
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string RestuarentType { get; set; }
        public string CityName { get; set; }
        public string CellNumber { get; set; }
        public bool Halaal {  get; set; }

    }
}
