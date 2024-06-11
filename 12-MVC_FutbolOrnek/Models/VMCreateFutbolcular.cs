using _12_MVC_FutbolOrnek.Controllers;

namespace _12_MVC_FutbolOrnek.Models
{
    public class VMCreateFutbolcular
    {
        public Futbolcu Futbolcu { get; set; }
        public List<Mevki>Mevkiler { get; set; }
        public List<Takim> Takimlar { get; set; }   

    }
}
