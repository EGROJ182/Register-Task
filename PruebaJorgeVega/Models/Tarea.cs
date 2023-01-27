using System.Timers;

namespace PruebaJorgeVega.Models
{
    public class Tarea
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public String user { get; set; }
        public String area { get; set; }
        public String dependence { get; set; }
        public TimeSpan time { get; set; }
    }
}
