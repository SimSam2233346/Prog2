using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNamespace
{
    public class Chien
    {
        private string nomChien;
        private string humeurChien;
        private string amiChien;

        public Chien(string nomChien)
        {
            this.nomChien = nomChien;
        }

        public string GetNomChien() { return nomChien; }

        public string GetAmiChien() { return amiChien; }
        public void SetAmiChien(string amiChien) { this.amiChien = amiChien; }

        public string GetHumeurChien() { return humeurChien;}
        public void SetHumeurChien(string humeur) { this.humeurChien = humeur; }
    }
}
