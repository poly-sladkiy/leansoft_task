using PersonSerialization.Models;
using PersonSerialization.Repository;
using PersonSerialization.Service;

const int personCount = 10000;
const string fileName = "Persons.json";

var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
var desktopFilePath = Path.Combine(desktopPath, fileName);

// Task 1: create random persons
var persons = PersonRepository.GenerateRandomPersons(personCount);
// Task 2: Serialize persons
var personJson = JsonSerializerService.SerializeToJson(persons);

// Task 3: write persons data to current user desktop directory
FileService.WriteToFile(desktopFilePath, personJson);
// Task 4: clear memory with person collection data
persons.Clear();

// Task 5: read data from file
var personsFromFile = FileService.ReadFromFile(desktopFilePath);
var personDeserializationFromFile = JsonSerializerService.DeserializeFromJson<List<Person>>(personsFromFile)
	?? throw new NullReferenceException("Error person deserialization");

var personStatistic = PersonRepository.CalculatePersonStatistic(personDeserializationFromFile);

// Task 6: print to console persons count, persons credit card count, the average value of child age
Console.WriteLine($"Persons Count: {personStatistic.personsCount}");
Console.WriteLine($"Credit Card Count: {personStatistic.creditCardCount}");
Console.WriteLine($"Average Child Age: {personStatistic.averageChildAge:F2} years");

Console.ReadKey();
