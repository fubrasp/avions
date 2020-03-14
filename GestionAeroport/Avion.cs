using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport
{
    [Table("Avion")]
    public class Avion
    {
        public Avion(int id, string immatriculation, int capaciteCarburant, int vitesseMaximum, int vitesseCourante, int nombreSiege)
        {
            Id = id;
            Immatriculation = immatriculation;
            CapaciteCarburant = capaciteCarburant;
            VitesseMaximum = vitesseMaximum;
            VitesseCourante = vitesseCourante;
            this.nombreSiege = nombreSiege;
        }

        [Key]
        public int Id { get; set; }

        public string Immatriculation { get; set; }
        public int CapaciteCarburant { get; set; }
        public int VitesseMaximum { get; set; }
        public int VitesseCourante { get; set; }
        public int nombreSiege { get; set; }

        public void Decoller()
        {
            this.VitesseCourante = this.VitesseMaximum;
        }

        public void Atterir()
        {
            this.VitesseCourante = 150;
        }
    }
}
