namespace _12_MVC_FutbolOrnek.Controllers
{
    public class Futbolcu
    {
        public int ID {  get; set; }    
        public string Adı {  get; set; }    
        public int Yas {  get; set; }   
        public int TakimID {  get; set; }   
        public Takim Takim { get; set; }   
        public int MevkiID {  get; set; }   
        public Mevki Mevki { get; set; }    

    }
}
