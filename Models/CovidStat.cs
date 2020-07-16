namespace stopcovid.Models
{
    using System;
    public class CovidStat
    {
        public DateTime Date { get; set; }
        public int Cas { get; set; }
        public int Morts{ get; set; }
        public int Guerisons { get; set; }
    }

}
