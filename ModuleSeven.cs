using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Module Five Assignment

In this assignment, you need to convert your objects for the application into class files.
 * Create a class file for:
A Student
A Teacher
A UProgram (C# uses Program as the name of the class that contains Main() so we must use a different class name here)
A Degree
A Course
Transfer the variables you created in Module 1 into these class files.  Ensure that you encapsulate
 your member variables in the class files using properties.

The Course object should contain
 * an array of Student objects so ensure that you create 
 * an array inside the Course object to hold Students as well as
 * an array to contain Teacher objects as each course may have more than one teacher or TAs.
 
 For this assignment,
  * create arrays of size 3 for students and the same for teachers.
  * The UProgram object should be able to contain degrees and the degrees should be able to contain courses
as well but for the purposes of this assignment,
  * just ensure you have a single variable in UProgram to hold
a Degree and single variable in Degree to hold a Course.  
 * Add a static class variable to the Student class to track the number of students currently enrolled in a school. 
 * Increment a student object count every time a Student is created.

  *In the Main() method of Program.cs:

--Instantiate three Student objects.
--Instantiate a Course object called Programming with C#.
--Add your three students to this Course object.
--Instantiate at least one Teacher object.
--Add that Teacher object to your Course object
--Instantiate a Degree object, such as Bachelor.
--Add your Course object to the Degree object.
--Instantiate a UProgram object called Information Technology.
--Add the Degree object to the UProgram object.
--Using Console.WriteLine statements, output the following information to the console window:
--The name of the program and the degree it contains
--The name of the course in the degree
--The count of the number of students in the course.
 * */


namespace ModuleSeven
{
    class CreateClassesInfo
    {
        static void Main(string[] args)
        {

            // Instanciate Student
            var student1 = new Student("Faïza", "Harbi", "faiza.harbi@mic.edu", new DateTime(1982, 3, 6), "797 code Avenue",
                "Residence bar", "Montpellier", "Hérault", "34070", "FRANCE", 'F', 3.9f, 100.02m, 4);
            Stack<double>Grades = new Stack<double>();
            List<double> g = new List<double>();
            var tmp = student1.generateListOfStudGrades(g);
            Grades = student1.listToArrGrades(Grades);
            student1.addStudentGrades(Grades);

 
            //grades = stud;
            // Create ArrayList of Student objects
            var students = new ArrayList();
            // instanciate a Course object
            var crse = new Course("", "", 80, students);
            
            // Adds student1 to the ArrayList of Student
            crse.addStudentInArrayList(student1);

            // Instanciate Student
            var student2 = new Student("Julien", "Mazet", "julien.mazet@mic.edu", new DateTime(1982, 3, 6), "797 code Avenue",
                "Residence bar", "Montpellier", "Hérault", "34070", "FRANCE", 'F', 3.9f, 100.02m, 4);
            
            // Adds student2 to the ArrayList of Student
            crse.addStudentInArrayList(student2);
            
            // Instanciate Student
            var student3 = new Student("Ivan", "Joule", "ivan.joule@foo.edu", new DateTime(1982, 9, 24), "2 Main Street",
                    "", "Stropia", "", "0407", "MACEDONIA", 'M', 3.8f, 500.60m, 3);
            
            // Adds student3 to the ArrayList of Student
            crse.addStudentInArrayList(student3);
            
            // Instanciate Student
            var student4 = new Student("Ana", "Blake", "ana.blake@foo.edu", new DateTime(1989, 4, 17), "24 Bazinga Road", "Residence Cooper", "Moscow", "", "101000", "RUSSIA",
                    'F', 3.9f, 300.20m, 3);

            // Adds student4 to the ArrayList of Student
            crse.addStudentInArrayList(student4);

            
            crse.ListStudents();

           /* int c = Student.Counter;

            var teacher1 = new Teacher("Julien", "Mazet", "julien.mazet@cs.mic.edu", new DateTime(1981, 3, 7), "33 Oxford Street",
                "Building 50", "Cambridge", "MA", "3143",
                "USA", 'M', "Computer Science DEV204", 80);

            var teachers = new List<Teacher>();
            teachers.Add(teacher1);

            var course1 = new Course("Programming with C#", "Computer Science DEV204", 80, students);
            var courses = new List<Course>();
            courses.Add(course1);

            var degree1 = new Degree("Bachelor Of Science", "Computer Science", 80, courses);
            var degrees = new List<Degree>();
            degrees.Add(degree1);

            var uprogram1 = new UProgram("Information Technology", "Dean Winchester", degrees);

            WriteProgramInfo(uprogram1, courses);
            Console.WriteLine("Press a key to continue.....");
            Console.ReadKey();*/
        }

        //method displaying the informations asked
        private static void WriteProgramInfo(UProgram uprogram1, List<Course> courses)
        {

            try
            {
                var deg = uprogram1.UDegreesProposed.First();
                var crs = courses.First().Cname;
                Console.WriteLine("The {0} contains the {1} degree.{2}", uprogram1.Uname, deg.Dname, Environment.NewLine);
                Console.WriteLine("The {0} degree contains the course {1}.{2}", deg.Dname, crs, Environment.NewLine);
                Console.WriteLine("The {0} course contains {1} student(s).{2}", crs, Student.Counter, Environment.NewLine);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Invalid type operation", ioe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("No input", ane.Message);
            }
        }

        #region dedicated to the abstract class Person inherited by the classes Student and Teacher
        abstract internal class Person
        {

            // this is the type of the encapsulated getter setter related to the first name
            private string first;
            public string First
            {
                get
                {
                    return first;
                }
                set
                {
                    if (value != null)
                        first = value;
                }
            }

            // this is the type of the encapsulated getter setter related to the last name same for below
            private string last;
            public string Last
            {
                get
                {
                    return last;
                }
                set
                {
                    if (value != null)
                        last = value;
                }
            }

            private string email;
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if (value != null)
                        email = value;
                }
            }

            private DateTime birthdate;

            public DateTime Birthdate
            {
                get
                {
                    return birthdate;
                }

                private set
                {
                    if (value != null)
                        birthdate = value;
                }
            }


            private string addressLine1;
            public string AddressLine1
            {
                get
                {
                    return addressLine1;
                }
                set
                {
                    if (value != null)
                        addressLine1 = value;
                }
            }

            private string addressLine2;
            public string AddressLine2
            {
                get
                {
                    return addressLine2;
                }
                set
                {
                    if (value != null)
                        addressLine2 = value;
                }
            }

            private string city;
            public string City
            {
                get
                {
                    return city;
                }
                private set
                {
                    if (value != null)
                        city = value;
                }
            }

            private string stateOrProvince;
            public string StateOrProvince
            {
                get
                {
                    return stateOrProvince;
                }
                set
                {
                    if (value != null)
                        stateOrProvince = value;
                }
            }

            private string zipPostal;
            public string ZipPostal
            {
                get
                {
                    return zipPostal;
                }
                set
                {
                    if (value != null)
                        zipPostal = value;
                }
            }

            private string country;
            public string Country
            {
                get
                {
                    return country;
                }
                set
                {
                    if (value != null)
                        country = value;
                }
            }

            private char gender;
            public char Gender
            {
                get
                {
                    return gender;
                }
                set
                {
                    if (value != '\0')
                        gender = value;
                }
            }

            internal Person(string first, string last, string email, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender)
            {
                this.First = first;
                this.Last = last;
                this.Email = email;
                this.Birthdate = birthdate;
                this.AddressLine1 = addressLine1;
                this.AddressLine2 = addressLine2;
                this.City = city;
                this.StateOrProvince = stateOrProvince;
                this.ZipPostal = zipPostal;
                this.Country = country;
                this.Gender = gender;
            }

            public override string ToString()
            {
                return String.Format("{0}{1} {2}", Environment.NewLine, First, Last);
            }


        }
        #endregion
        //create and initialize the number of students counter
        #region dedicated to the class Student
        internal class Student : Person
        {
            private static int counter = 0;
            public static int Counter
            {
                get
                {
                    return counter;
                }
                set
                {
                    counter = value;
                }
            }

            private float OverallGPA;
            public float overallGPA
            {
                get
                {
                    return OverallGPA;
                }
                set
                {
                    if (value > 0.0)
                        OverallGPA = value;
                }
            }

            private Decimal AccountBalance;
            public Decimal accountBalance
            {
                get
                {
                    return AccountBalance;
                }
                set
                {
                    AccountBalance = value;
                }
            }

            private int NumCoursesTaken;
            public int numCoursesTaken
            {
                get
                {
                    return NumCoursesTaken;
                }
                set
                {
                    if (value >= 0)
                        this.NumCoursesTaken = value;
                }
            }

            
            // Stack of grades per student (LIFO)
            private Stack<double> Grades = new Stack<double>();
           
            
            // Method adding 5 grades to a Student
            public void addStudentGrades(Stack<double> StudGrades)
            {
                
                foreach (double g in StudGrades)
                {
                    this.Grades.Push(g);
                    Console.Write("{0:f2}",this.Grades.Peek()+", ");
                }
            }

            private List<double> listOfStudGrades = new List<double>();
            
            // Generates using the Random Object 5 grades of type double between 40 and 100 and stores them in a List of type double named listOfStudGrades 
            public List<double> generateListOfStudGrades(List<double> listOfStudGrades)
            { 
                int i;
                double g;
                for (i = 0; i < 5; i++)
                {
                    // Will allow to have int grades betwin the minValue 40 and maxValue 100
                    Random rand = new Random();
                    g = Math.Round(rand.NextDouble() *((100 - 50) + 50), 2);
                    this.listOfStudGrades.Add(g);
                }
                return (this.listOfStudGrades);
            }

            public Stack<double> listToArrGrades(Stack<double> StudGrades)
            {
                int i = 0;
                if (this.listOfStudGrades.Capacity != 0)
                {
                    foreach (double listg in this.listOfStudGrades)
                    {
                        StudGrades.Push(this.listOfStudGrades[i]);
                    }
                }
                return StudGrades;
            }

            // takes the generated grades from the listOfStudGrades and affects them to the Stack Object Grades and outputs them.
            /*public void affectGradesToStackOfGrades()
            {
                foreach(double grde in this.listOfStudGrades)
                {
                    Grades.Push(grde);
                    Console.Write(Grades.Peek()+", ");
                }
            }
            */
            internal Student(string first, string last, string email, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender, float overallGPA, Decimal accountBalance, int numCoursesTaken)
                : base(first, last, email, birthdate, addressLine1, addressLine2, city, stateOrProvince,
                    zipPostal, country, gender)
            {
                this.AccountBalance = accountBalance;
                this.OverallGPA = overallGPA;
                this.NumCoursesTaken = numCoursesTaken;
                // increment the number of Student instanciated
                counter++;
            }


            // override methode to output the proper fields according the class being handled
            public override string ToString()
            {
                return String.Format(
                "email: {0}{1}" +
                "Address  {2}{1}" + "{3}{1}" +
                "{4}, {5}{1}" +
                "{6}, {7}{1}{1}" +
                "------------{1}" +
                "Overall GPA: {8}{1}" +
                "Account Balance: {9}{1}" +
                "Gender: {10}{1}" +
                "Number of courses taken: {11}{1}" +
                "{1}Courses taken: {12}{1}{1}",
                Email, Environment.NewLine, AddressLine1, AddressLine2, City, StateOrProvince, ZipPostal, Country,
                overallGPA, accountBalance, Gender, numCoursesTaken
                );
            }
        }
        #endregion

        #region Dedicated to the class Teacher
        internal class Teacher : Person
        {
            private string pField;
            public string Pfield
            {
                get
                {
                    return pField;
                }
                set
                {
                    if (value != null)
                        pField = value;
                }
            }

            private int pNumOfCourses;
            public int PnumOfCourses
            {
                get
                {
                    return pNumOfCourses;
                }
                set
                {
                    if (value > 0)
                        pNumOfCourses = value;
                }
            }

            internal Teacher(string first, string last, string email, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender, string pField, int pNumOfCourses)
                : base(first, last, email, birthdate, addressLine1, addressLine2, city, stateOrProvince,
                    zipPostal, country, gender)
            {
                this.Pfield = pField;
                this.PnumOfCourses = pNumOfCourses;
            }

        }
        #endregion

        #region Dedicated to the class Course
        internal class Course
        {
            private string cName; // i.e. "DEV204x"
            public string Cname
            {
                get
                {
                    return cName;
                }
                set
                {
                    if (value != null)
                        cName = value;
                }
            }

            private string cField; // i.e. "Computer Science and Programming; Data processing" 
            public string Cfield
            {
                get
                {
                    return cField;
                }
                set
                {
                    if (value != null)
                        cField = value;
                }
            }

            
                        
            private int cCredits;
            public int Ccredits
            {
                get
                {
                    return cCredits;
                }
                set
                {
                    if (value > 0)
                        cCredits = value;
                }
            }

            private double cGrade;
            public double Cgrade
            {
                get
                {
                    return cGrade;
                }
                set
                {
                    if (value >= 0)
                        this.cGrade = value;
                }
            }

            
            #region ArrayList of Students and the ListStudents method
            
            private ArrayList cStuds = new ArrayList();
            public ArrayList Cstuds 
            { 
                get
                {
                    return cStuds;
                }
                set
                {
                    if(Cstuds != null && value != null)
                        this.cStuds = value;
                }
            }

            public void addStudentInArrayList(Student stud)
            {
                this.cStuds.Add(stud);
            }

            public void ListStudents()
            {
                Console.WriteLine("Press a key to start{0}",Environment.NewLine);
                Console.ReadKey();
                if (this.cStuds == null)
                    Console.WriteLine("The list of students is not initialized");
                else if (this.cStuds.Count == 0)
                    Console.WriteLine("The list of students is empty");
                else
                {
                    foreach (Object St in this.cStuds)
                    {
                        Student tmp = (Student)St;
                        Console.WriteLine(tmp.First + " " + tmp.Last);
                    }
                }
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
            }
            #endregion

            private List<Teacher> professorsArray = new List<Teacher>();

            public List<Teacher> getProfList()
            {
                return professorsArray;
            }

            public void setProfList(List<Teacher> professorsArray)
            {
                this.professorsArray = professorsArray;
            }

            public void addProfessorToProfessorsArray(Teacher teacher)
            {
                professorsArray.Add(teacher);
            }

            internal Course(string cName, string cField, int cCredits, ArrayList cStuds)
            {
                this.Cname = cName;
                this.Cfield = cField;
                this.Ccredits = cCredits;
                this.Cstuds = cStuds;
            }

            public override string ToString()
            {
                return String.Format("{0}Course's name: {1}" + "{0}Course's Field: {2}" + "{0}Number of credits needed: {3}{0}", Environment.NewLine,
                    Cname, Cfield, Ccredits);
            }
        }
        #endregion

        #region Dedicated to the class Degree
        internal class Degree
        {
            private string dName;
            public string Dname
            {
                get
                {
                    return dName;
                }
                set
                {
                    if (value != null)
                        dName = value;
                }
            }

            private string dField;
            public string Dfield
            {
                get
                {
                    return dField;
                }
                set
                {
                    if (value != null)
                        dField = value;
                }
            }

            private int dCredits;
            public int Dcredits
            {
                get
                {
                    return dCredits;
                }
                set
                {
                    if (value >= 0)
                        dCredits = value;
                }
            }

            private List<Course> dCourses = new List<Course>();
            public List<Course> Dcourses = new List<Course>();

            public List<Course> getCourseList()
            {
                return Dcourses;
            }
            public void setCourseList(List<Course> dCourses)
            {
                if (dCourses != null)
                    this.Dcourses = dCourses;
            }


            internal Degree(string dName, string dField, int dCredits, List<Course> dCourses)
            {
                this.Dname = dName;
                this.Dfield = dField;
                this.Dcredits = dCredits;
                this.Dcourses = getCourseList();
            }

            public void addCourseToDegree(Course course)
            {
                Dcourses.Add(course);
            }

            public override string ToString()
            {
                return String.Format("{0}Name of the degree: {1}" + "{0}Degree's field: {2}" +
                    "{0}Number of credits needed:  {3}" + "{0}List Of Courses: {4}", Environment.NewLine, Dname, Dfield, Dcredits, Dcourses);
            }

        }
        #endregion

        #region Dedicated to the class UProgram
        internal class UProgram
        {
            private string uName;
            public string Uname
            {
                get
                {
                    return uName;
                }
                set
                {
                    if (value != null)
                        uName = value;
                }
            }

            private string uDean;
            public string Udean
            {
                get
                {
                    return uDean;
                }
                set
                {
                    if (value != null)
                        uDean = value;
                }
            }

            private List<Degree> uDegreesProposed = new List<Degree>();
            public List<Degree> UDegreesProposed = new List<Degree>();
            List<Degree> getUDegreesProposed()
            {
                return uDegreesProposed;
            }

            public void setUDegrees(Degree degree)
            {
                UDegreesProposed.Add(degree);
            }

            public UProgram(string uName, string uDean, List<Degree> uDegreesProposed)
            {
                this.Uname = uName;
                this.Udean = uDean;
                this.UDegreesProposed = uDegreesProposed;
            }


            /*public override string ToString()
            {
                return String.Format("{0}University name: {1}"+"{0}University Dean: {2}"+
                    "{0}Degrees available: {3}", Environment.NewLine, Uname, Udean, UDegreesProposed);
            }*/
        }
        #endregion
    }

}
