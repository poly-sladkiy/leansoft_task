namespace PersonSerialization.Models;

/// <summary>
/// Child class
/// </summary>
public class Child
{
	/// <summary>
	/// Id
	/// </summary>
	public Int32 Id { get; set; }
	
	/// <summary>
	/// Firstname
	/// </summary>
	public String FirstName { get; set; }
	
	/// <summary>
	/// Lastname
	/// </summary>
	public String LastName { get; set; }
	
	/// <summary>
	/// Birth date
	/// </summary>
	public Int64 BirthDate { get; set; }
	
	/// <summary>
	/// Gender
	/// </summary>
	public Gender Gender { get; set; }
}