using copilot.link; 

// See https://aka.ms/new-console-template for more information

List<Student> students = new List<Student> {
    new Student {First = "Svetlana", Last = "Omelchenko", Id = 111, Scores = new List<int> {97, 92, 81, 60}},
    new Student {First = "Claire", Last = "O’Donnell", Id = 112, Scores = new List<int> {75, 84, 91, 39}},
    new Student {First = "Sven", Last = "Mortensen", Id = 113, Scores = new List<int> {88, 94, 65, 91}},
    new Student {First = "Cesar", Last = "Garcia", Id = 114, Scores = new List<int> {97, 89, 85, 82}},
    new Student {First = "Debra", Last = "Garcia", Id = 115, Scores = new List<int> {35, 72, 91, 70}},
    new Student {First = "Fadi", Last = "Fakhouri", Id = 116, Scores = new List<int> {99, 86, 90, 94}},
    new Student {First = "Hanying", Last = "Feng", Id = 117, Scores = new List<int> {93, 92, 80, 87}},
    new Student {First = "Hugo", Last = "Garcia", Id = 118, Scores = new List<int> {92, 90, 83, 78}},
    new Student {First = "Lance", Last = "Tucker", Id = 119, Scores = new List<int> {68, 79, 88, 92}},
    new Student {First = "Terry", Last = "Adams", Id = 120, Scores = new List<int> {99, 82, 81, 79}},
    new Student {First = "Eugene", Last = "Zabokritski", Id = 121, Scores = new List<int> {96, 85, 91, 60}},
    new Student {First = "Michael", Last = "Tucker", Id = 122, Scores = new List<int> {94, 92, 91, 91}},
    //generate a new student with a different last, first name and id
    new Student {First = "John", Last = "Doe", Id = 123, Scores = new List<int> {94, 92, 91, 91}}

};

//create a list of students whose score is greater than 85
var studentQuery1 =
    from student in students
    where student.Scores[0] > 85
    //orderby student first score descending
    orderby student.Scores[0] descending
    select student;


    //execute the query to print out the student's information
foreach (Student student in studentQuery1)
{
    //Console.WriteLine($"Last: {student.Last}, First: {student.First}, ID: {student.Id} ScoresCount: {student?.Scores?.Count()}");
    //print out the student name and test score
    Console.WriteLine($"Last: {student.Last}, First: {student.First}, ID: {student.Id} Score: {student.Scores?[0]}");
};

/* foreach (Student student in students)
{
    Console.WriteLine($"Last: {student.Last}, First: {student.First}, ID: {student.Id} ScoresCount: {student?.Scores?.Count()}");
};
 */
