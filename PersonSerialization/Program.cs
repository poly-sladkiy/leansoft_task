using PersonSerialization.Models;
using PersonSerialization.Repository;
using PersonSerialization.Service;

const int personCount = 10000;
const string fileName = "Persons.json";

var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
var desktopFilePath = Path.Combine(desktopPath, fileName);

var persons = PersonRepository.GenerateRandomPersons(personCount);
var personJson = JsonSerializerService.SerializeToJson(persons);

FileService.WriteToFile(desktopFilePath, personJson);
persons.Clear();

var personsFromFile = FileService.ReadFromFile(desktopFilePath);
var personDeserializationFromFile = JsonSerializerService.DeserializeFromJson<List<Person>>(personsFromFile)
	?? throw new NullReferenceException("Error person deserialization");

var personStatistic = PersonRepository.CalculatePersonStatistic(personDeserializationFromFile);

Console.WriteLine($"Persons Count: {personStatistic.personsCount}");
Console.WriteLine($"Credit Card Count: {personStatistic.creditCardCount}");
Console.WriteLine($"Average Child Age: {personStatistic.averageChildAge:F2} years");

Console.ReadKey();
