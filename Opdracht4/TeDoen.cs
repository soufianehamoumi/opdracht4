using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
        delegate void ToonMij(string titel, string inhoud, Boolean dringend);
        public int ID
        {
            get { _volgnummer++; return _volgnummer; }
            set { _volgnummer = value; }
        }
        private int _volgnummer = 0;
        public DateTime? Tijdstip = null;
        public string Titel { get; set; }
        public string[] Informatie { get; set; }
        public TeDoen()
        {

        }
        public TeDoen(string titel, string[] informatie)
        {
            Titel = titel;
            Informatie = informatie;
        }
        public TeDoen(string titel, string[] informatie, DateTime tijdstip)
        {
            Titel = titel;
            Tijdstip = tijdstip;
            Informatie = informatie;
        }
        public override string ToString()

        {
            string text = "";

            foreach (string line in Informatie)
            {
                text += line.ToString() + "\n";

            }

            if (Tijdstip == null)
            {
                return "id" + ID + "\n title : " + Titel + "\n informatie : " + text;
            }
            else
            {
                return "id" + ID + " \n tijdstip: " + Tijdstip + "\n title : " + Titel + "\n informatie : " + text;
            }


        }
    }
}
