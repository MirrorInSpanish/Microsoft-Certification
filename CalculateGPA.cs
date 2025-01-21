// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaGrad = sophia1 + sophia2 + sophia3 + sophia4 + sophia5; 
double sophiaGrade = (double) sophiaGrad / currentAssignments;

int nicolasGrad = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
double nicolasGrade = (double) nicolasGrad / currentAssignments;

int zahirahGrad = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
double zahirahGrade = (double) zahirahGrad / currentAssignments;

int jeongGrad = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
double jeongGrade = (double) jeongGrad / currentAssignments;

char gradeSS;
char gradeNN;
char gradeZZ;
char gradeJJ;

double gradeS = sophiaGrade;

if (gradeS >= 90)
    gradeSS = 'A';
    else if (gradeS < 90 && gradeS >=80)
    gradeSS = 'B';
    else if (gradeS < 80 && gradeS >= 70)
    gradeSS = 'C';
    else if (gradeS < 70 && gradeS >= 60)
    gradeSS = 'D';
    else 
    gradeSS = 'F';

double gradeN = nicolasGrade;

if (gradeN >= 90)
    gradeNN = 'A';
    else if (gradeN < 90 && gradeN >=80)
    gradeNN = 'B';
    else if (gradeN < 80 && gradeN >= 70)
    gradeNN = 'C';
    else if (gradeN < 70 && gradeN >= 60)
    gradeNN = 'D';
    else 
    gradeNN = 'F';

double gradeZ = zahirahGrade;

if (gradeZ >= 90)
    gradeZZ = 'A';
    else if (gradeZ < 90 && gradeZ >=80)
    gradeZZ = 'B';
    else if (gradeZ < 80 && gradeZ >= 70)
    gradeZZ = 'C';
    else if (gradeZ < 70 && gradeZ >= 60)
    gradeZZ = 'D';
    else 
    gradeZZ = 'F';

double gradeJ = jeongGrade;

if (gradeJ >= 90)
    gradeJJ = 'A';
    else if (gradeJ < 90 && gradeJ >=80)
    gradeJJ = 'B';
    else if (gradeJ < 80 && gradeJ >= 70)
    gradeJJ = 'C';
    else if (gradeJ < 70 && gradeJ >= 60)
    gradeJJ = 'D';
    else 
    gradeJJ = 'F';    

Console.WriteLine("Student\t\tGrade");
Console.WriteLine("Sophia\t\t" + sophiaGrade + " " + gradeSS);
Console.WriteLine("Nicolas\t\t" + nicolasGrade + " " + gradeNN);
Console.WriteLine("Zahirah\t\t" + zahirahGrade + " " + gradeZZ);
Console.WriteLine("Jeong\t\t" + jeongGrade + " " + gradeJJ);
