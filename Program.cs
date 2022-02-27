using Lab31LinqPart2Students;

List<Student> students = new List<Student>();
students.Add(new Student("Jimmy", 13));
students.Add(new Student("Hannah", 21));
students.Add(new Student("Justin", 30));
students.Add(new Student("Sarah", 53));
students.Add(new Student("Hannibal", 15));
students.Add(new Student("Phillip", 16));
students.Add(new Student("Maria", 63));
students.Add(new Student("Abe", 33));
students.Add(new Student("Curtis", 10));

// Printing the whole list.
Console.WriteLine("Here's the full list:\nStudent, Age");
foreach (Student x in students)
    Console.WriteLine($"{ x.Name}, {x.Age}");

// 21 and older students
Console.WriteLine("\nHere are students 21 years old or older:");
var studentEnum = students.Where(x => x.Age >=21);
foreach (var x in studentEnum)
    Console.WriteLine($"{x.Name}, {x.Age}");


// Oldest student
var studentOldest = students.Max(x => x.Age);
var studentOldestName = students.First(x => x.Age == studentOldest).Name;
Console.WriteLine($"\n{studentOldestName} is the oldest student at age {studentOldest}.");

// Youngest student
var studentYoungest = students.Min(x => x.Age);
var studentYoungestName = students.First(x => x.Age == studentYoungest).Name;
Console.WriteLine($"\n{studentYoungestName} is the youngest student at age {studentYoungest}.");

// over 21 with even ages
Console.WriteLine("\nHere are students over 21 with an age that is an even number:");
var studentEnumEvenAge = students.Where(x => (x.Age > 21) && (x.Age %2 == 0));
foreach (var x in studentEnumEvenAge)
    Console.WriteLine($"{x.Name}, {x.Age}");

// teenage students (13-19 inclusive)
Console.WriteLine("\nHere are the teenage students:");
var studentTeen = students.Where(x => (x.Age >= 13) && (x.Age <= 19));
foreach (var x in studentTeen)
    Console.WriteLine($"{x.Name}, {x.Age}");

Console.WriteLine("\nHere are students whose name starts with a vowel:");
string[] vowels = { "a","e","i","o","u" };
foreach (var vowel in vowels)
{
    var studentVowelName = students.Where(x => x.Name.ToLower().StartsWith(vowel));
    foreach (var x in studentVowelName)
        Console.WriteLine($"{x.Name}");
}