using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class ListeCourseTest
    {
        public ListeCourse listeCourse;

        public ListeCourseTest()
        {

        }

        public bool CreerListeCourse()
        {
            listeCourse = new ListeCourse("liste de mardi");
            if (listeCourse.getNom() != "liste de mardi") { Console.WriteLine("Le nom n'est pas bon KO"); return false; }

            Console.WriteLine("Création d'une liste de course : OK");
            return true;
        }

        public bool UtilisationListeCourse() 
        {

            listeCourse.AjouterCourse(new Course(42, new Produit(01, "saumon", 25)));
            if ((listeCourse.getListeCourse()[0].getQuantite() != 42) && listeCourse.getListeCourse()[0].getProduit().getId() != 01) 
                { Console.WriteLine("La course n'est pas bonne KO"); return false; }

            listeCourse.SupprimerCourse("test");
            if (listeCourse.getListeCourse().Count() == 0) 
                { Console.WriteLine("Les course ce font supprimer pour rien KO"); return false; }

            listeCourse.SupprimerCourse("saumon");
            if (listeCourse.getListeCourse().Count() != 0) 
                { Console.WriteLine("La course n'a pas été supprimé KO"); return false; }

            Console.WriteLine("Ajout et suppréssion d'une course dans une liste de course : OK");
            return true;
        }
    }
}
