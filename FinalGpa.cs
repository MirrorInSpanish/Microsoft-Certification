//initializing variables for student and course names
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//initializing variables for credit hours
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//initializing grade values 
int gradeA = 4;
int gradeB = 3;
int graceC = 2;
int gradeD = 1;
int gradeF = 0;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//calculating GPA and converting to float to retrieve full decimal average.
int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
int course1Gpa = course1Grade * course1Credit;
int course2Gpa = course2Grade * course2Credit;
int course3Gpa = course3Grade * course3Credit;
int course4Gpa = course4Grade * course4Credit;
int course5Gpa = course5Grade * course5Credit;
float finalGpa = (float)(course1Gpa + course2Gpa + course3Gpa + course4Gpa + course5Gpa) / totalCreditHours;

//formating the decimal output
int leadingDigit = (int) finalGpa; //converts to int to retrieve the number before the decimal
int firstDigit = (int) (finalGpa * 10) % 10; //retrieves first decimal digit
int secondDigit = (int) (finalGpa * 100 ) % 10; // retrieves second decimal digit

Console.WriteLine("Student: " + studentName);
Console.WriteLine("\nCourse\t\t\t\tGrade \tCredit Hours");
Console.WriteLine($"{course1Name} \t\t {course1Grade} \t\t {course1Credit}");
Console.WriteLine($"{course2Name} \t\t {course2Grade} \t\t {course2Credit}");
Console.WriteLine($"{course3Name} \t\t {course3Grade} \t\t {course3Credit}");
Console.WriteLine($"{course4Name} \t {course4Grade} \t\t {course4Credit}");
Console.WriteLine($"{course5Name} \t\t {course5Grade} \t\t {course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
