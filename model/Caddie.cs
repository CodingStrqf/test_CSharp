using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class Caddie : ListeCourseAbstract
    {
        private List<Course> caddie;

        public Caddie()
        {
            this.caddie = new List<Course>();
        }

        public void AfficherListeCourse()
        {
            foreach (Course course in caddie)
            {
                Console.WriteLine(course.ToString());
            }
        }

        public bool AjouterCourse(Course c)
        {
            caddie.Add(c);
            return true;
        }

        public bool SupprimerCourse(string nomProduit)
        {
            foreach (Course course in caddie)
            {
                if (course.getProduit().getNom() == nomProduit)
                {
                    caddie.Remove(course);
                    return true;
                }
            }
            return false;
        }

        public List<Course> getListeCourse()
        {
            return caddie;
        }
    }
}
