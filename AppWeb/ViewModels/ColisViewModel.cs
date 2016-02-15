using ClassLibrary;
using System;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.ViewModels
{
    public class ColisViewModel
    {

        
        [DisplayName("Code Colis")]
        public int Colisid { get; set; }

        [DisplayName("Details")]
        public string detailsColis { get; set; }

        [DisplayName("Type")]
        public int typecolisid { get; set; }

        [DisplayName("Nature")]
        public int naturecolisid { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [DisplayName("Prix")]
        public decimal prixColis { get; set; }

        [DisplayName("État")]
        public string etatColis { get; set; }

        [DisplayName("Localisation")]
        public string localisation { get; set; }


        public DateTime date { get; set; }

        [DisplayName("Client")]
        public int clientid { get; set; }

        [DisplayName("Nom destinateire")]
        public string nomDestinateire { get; set; }

        [MaxLength(13, ErrorMessage = "Maximum {0} caractères")]
        [DisplayName("Téléphone destinateire")]
        public string telDestinataire { get; set; }

        [DisplayName("Adresse destinateire")]
        public string adresseDestinaraire { get; set; }

        [DisplayName("Ville de depart")]
        public int villeDepartColisid { get; set; }

        [DisplayName("Ville d'arrive")]
        public int villeArriveColisid { get; set; }
        
        [DisplayName("Date Depart")]
        public string dateDepartColis { get; set; }

        
        [DisplayName("Date Arrivé")]
        public string dateArriveColis { get; set; }

        [DisplayName("Voie de transmission")]
        public int voietransmissionid { get; set; }

        public virtual TypeColis Type { get; set; }
        public virtual Client Client { get; set; }
        public virtual NatureColis Nature { get; set; }
        public virtual VoieTransmission Voie { get; set; }
        public virtual Ville villeArriveColis { get; set; }
        public virtual Ville villeDepartColis { get; set; }

        /*
        
        [Key]
        [DisplayName("Code Colis")]
        public int Colisid { get; set; }

        [DisplayName("Details")]
        [MaxLength(150, ErrorMessage = "Maximum {0} caractères")]
        public string detailsColis { get; set; }

        [DisplayName("Type")]
        [Required(ErrorMessage = "Rempliez le champ Type")]
        public int typecolisid { get; set; }

        [DisplayName("Nature")]
        [Required(ErrorMessage = "Rempliez le champ Nature")]
        public int naturecolisid { get; set; }


        [DisplayName("Prix")]
        [Required(ErrorMessage = "Rempliez le champ Prix")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal prixColis { get; set; }

        [DisplayName("État")]
        [Required(ErrorMessage = "Rempliez le champ Etat")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        public string etatColis { get; set; }

        [DisplayName("Localisation")]
         [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        public string localisation { get; set; }


        [ScaffoldColumn(false)]
        public DateTime date { get; set; }

        [DisplayName("Client")]
        [Required(ErrorMessage = "Rempliez le champ Client")]
        public int clientid { get; set; }

        [DisplayName("Nom destinateire")]
        [Required(ErrorMessage = "Rempliez le champ le Nom du Destinateire")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        public string nomDestinateire { get; set; }

        [DisplayName("Téléphone destinateire")]
        [Required(ErrorMessage = "Rempliez le champ Téléphone du Destinateire")]
        [MaxLength(13, ErrorMessage = "Maximum {0} caractères")]
        public string telDestinataire { get; set; }

        [DisplayName("Adresse destinateire")]
        [Required(ErrorMessage = "Rempliez le champ l'Adresse du Destinateire")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        public string adresseDestinaraire { get; set; }

        [DisplayName("Ville de depart")]
        public int villeDepartColisid { get; set; }

        [DisplayName("Ville d'arrive")]
        public int villeArriveColisid { get; set; }
        
        [DisplayName("Date Depart")]
        public string dateDepartColis { get; set; }

        
        [DisplayName("Date Arrivé")]
        public string dateArriveColis { get; set; }

        [DisplayName("Voie de transmission")]
        public int voietransmissionid { get; set; }

        */

    }
}

