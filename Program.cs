using ListeDeCourse.model;
using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("début");
            
            ProduitTest pT = new ProduitTest();
            pT.creerProduit();

            CourseTest cT = new CourseTest();
            cT.CreerCourse();

            ListeCourseTest lCT = new ListeCourseTest();
            lCT.CreerListeCourse();
            lCT.UtilisationListeCourse();

            Console.WriteLine("fin");

        }
    }
}
