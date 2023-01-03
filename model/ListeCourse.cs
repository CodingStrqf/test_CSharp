using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class ListeCourse : ListeCourseAbstract
    {
        private String nom;
        private List<Course> listeCourses;

        public ListeCourse(string nom)
        {
            this.nom = nom;
            this.listeCourses = new List<Course>();
        }

        public void AfficherListeCourse()
        {
            foreach(Course course in listeCourses)
            {
                Console.WriteLine(course.ToString());
            }
        }

        public bool AjouterCourse(Course c)
        {
            listeCourses.Add(c);
            return true;
        }

        public bool SupprimerCourse(string nomProduit)
        {
            foreach (Course course in listeCourses)
            {
                if( course.getProduit().getNom() == nomProduit)
                {
                    listeCourses.Remove(course);
                    return true;
                }
            }
            return false;
        }
        public string getNom()
        {
            return nom;
        }

        public List<Course> getListeCourse()
        {
            return listeCourses;
        }
    }
}
