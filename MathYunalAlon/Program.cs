using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021___2_CS_acceptance
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool grade_math, study_units, grade_physics, grade_science;
            int math_grade, study_units_math, physics_grade, science_grade;
            Console.WriteLine("enter the student's name: ");
            name = Console.ReadLine();
            Console.WriteLine("enter the student's the amount of the sudent's study unit in math: ");
            study_units_math = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student's grade in math: ");
            math_grade = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student's grade in physics: ");
            physics_grade = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student's grade in the scientific proffesion: ");
            science_grade = int.Parse(Console.ReadLine());

            /*
            if (math_grade >= 85 && math_grade < 101)
            {
                grade_math = true;
            }
            else
            {
                grade_math = false;
            }
            */
            grade_math = ((math_grade >= 85) && (math_grade < 101));

            /*
            if (study_units_math > 3 && study_units_math < 6)
            {
                study_units = true;
            }
            else
            {
                study_units = false;
            }
            */
            study_units = ((study_units_math > 3) && (study_units_math < 6));

            /*
            if (physics_grade >= 85 && physics_grade < 101)
            {
                grade_physics = true;
            }
            else
            {
                grade_physics = false;
            }
            */
            grade_physics = ((physics_grade >= 85) && (physics_grade < 101));

            /*
            if (science_grade >= 85 && science_grade < 101)
            {
                grade_science = true;
            }
            else
            {
                grade_science = false;
            }
            */
            grade_science = ((science_grade >= 85) && (science_grade < 101));



            // if (study_units == true)
            if (study_units)
            {
                // if (grade_math | grade_physics == true)
                if (grade_math || grade_physics)        // Note the || you had | and it is the wrong operator
                {
                    // if (grade_science == true)
                    if (grade_science)
                    {
                        Console.WriteLine("you: " + name + " are accepted");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("you: " + name + " are not accepted");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("you: " + name + " are not accepted");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("you: " + name + " are not accepted");
                Console.ReadLine();
            }
        }
    }
}
