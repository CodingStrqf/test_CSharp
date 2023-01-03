    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal interface ListeCourseAbstract
    {
        void AfficherListeCourse();
        bool AjouterCourse(Course c);
        bool SupprimerCourse(string nomProduit);
        
    }
}
