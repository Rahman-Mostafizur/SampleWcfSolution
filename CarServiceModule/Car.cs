using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceModule
{
    [DataContract]
    public class Car
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string RegNo { get; set; }
        [DataMember(Order = 3)]
        public string ModelName { get; set; }
        [DataMember(Order = 4)]
        public string Brand { get; set; }
        [DataMember(Order = 6)]
        public string EnginCapacity { get; set; }
        [DataMember(Order = 5)]
        public string Color { get; set; }
    }


    public class CarContext : DbContext
    {
        public  CarContext() : base("CarContext")
        {
        }

        public DbSet<Car> Cars { get; set; }

    }
}
