using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    /// <summary>
    /// Same as Podatak model, but holds PostalCode as string instead of integer
    /// for easier interaction with view.
    /// </summary>
    public class PodatakViewModel
    {
        // used when saving data to database to skid entries with invalid postal code
        // TODO: can this be done better?
        public const string INVALID_POSTAL_CODE = "INVALID";

        //private Podatak _podatak; -- we don't need it
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String PostanskiBroj { get; set; }
        public String Grad { get; set; }
        public String Telefon { get; set; }

        public PodatakViewModel(String pBr)
        {
            // poku�aj parsirati po�tanski broj kao integer
            // ukoliko ne uspije, proglasi ga nevaljanim
            int _pom;
            PostanskiBroj = Int32.TryParse(pBr, out _pom) ? pBr : INVALID_POSTAL_CODE;
        }
    }
}
