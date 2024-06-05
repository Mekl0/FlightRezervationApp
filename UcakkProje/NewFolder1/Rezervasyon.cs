using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm.NewFolder1
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int AirplaneId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int SeatNumber { get; set; }
        public string Status { get; set; }
    }
}
