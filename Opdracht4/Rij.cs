using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class Rij<T>
    {
        private List<T> rij = new List<T>();
        private List<T> kopie = new List<T>();
        public event Form1.Toon toon;
        int teller = -1;
        public Rij()
        {

        }
        public void Toevoegen(T f)
        {

            teller++;
            rij.Add(f);


        }
        public void Verwijderen()
        {
            if (teller >= 0)
            {
                rij.RemoveAt(rij.Count - 1);
                teller--;
            }



        }


        public List<T> Toon()
        {
            return rij;
        }
        public void ZitAchter(int index)
        {
            T teDoen = rij.ElementAt(index);
            rij.RemoveAt(index);
            rij.Add(teDoen);


        }
        public void Verwijder(int index)
        {
            T teDoen = rij.ElementAt(index);
            rij.RemoveAt(index);



        }
        public void Leegmaken()
        {
            rij.Clear();
        }
        public void Copy()
        {
            kopie.Clear();
            foreach (T i in rij)
            {
                kopie.Add(i);
            }
        }
        public void Show(object rij)
        {


            if (toon != null)
            {
                toon(rij);

            }

        }

        public override string ToString()
        {
            string content = "";
            foreach (T i in rij)
                content += i + " ; ";
            return content;
        }

        public Boolean IsEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
