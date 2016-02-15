using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Colis
    {
        public int Colisid { get; set; }
        public int villeDepartColisid { get; set; }
        public int villeArriveColisid { get; set; }
        public string nomDestinateire { get; set; }
        public string adresseDestinaraire { get; set; }
        public int telDestinataire { get; set; }
        public string dateDepartColis { get; set; }
        public string dateArriveColis { get; set; }
        public decimal prixColis { get; set; }
        public string detailsColis { get; set; }
        public string etatColis { get; set; }
        public string localisation { get; set; }
        public DateTime date { get; set; }
        public int typecolisid { get; set; }
        public int naturecolisid { get; set; }
        public int clientid { get; set; }
        public int voietransmissionid { get; set; }

        public virtual TypeColis Type { get; set; }
        public virtual Client Client { get; set; }
        public virtual NatureColis Nature { get; set; }
        public virtual VoieTransmission Voie { get; set; }
        public virtual Ville villeArriveColis { get; set; }
        public virtual Ville villeDepartColis { get; set; }


    }
}
