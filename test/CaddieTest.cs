using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class CaddieTest
    {
        public Caddie caddie;

        public CaddieTest()
        {
            caddie = new Caddie();
        }

        public bool UtilisationListeCourse()
        {

            caddie.AjouterCourse(new Course(42, new Produit(01, "saumon", 25)));
            if ((caddie.getListeCourse()[0].getQuantite() != 42) && caddie.getListeCourse()[0].getProduit().getId() != 01)
            { Console.WriteLine("La course n'est pas bonne KO"); return false; }

            caddie.SupprimerCourse("test");
            if (caddie.getListeCourse().Count() == 0)
            { Console.WriteLine("Les course ce font supprimer pour rien KO"); return false; }

            caddie.SupprimerCourse("saumon");
            if (caddie.getListeCourse().Count() != 0)
            { Console.WriteLine("La course n'a pas été supprimé KO"); return false; }

            Console.WriteLine("Ajout et suppréssion d'une course dans une liste de course : OK");
            return true;
        }
    }
}
