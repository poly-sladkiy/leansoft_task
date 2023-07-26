namespace PersonSerialization.Models;

/// <summary>
/// Person
/// </summary>
public class Person
{
	/// <summary>
	/// Id
	/// </summary>
	public Int32 Id { get; set; }
	
	/// <summary>
	/// Transport id
	/// </summary>
	public Guid TransportId { get; set; }
	
	/// <summary>
	/// First name
	/// </summary>
	public String FirstName { get; set; }
	
	/// <summary>
	/// Last name
	/// </summary>
	public String LastName { get; set; }
	
	/// <summary>
	/// Sequence id
	/// </summary>
	public Int32 SequenceId { get; set; }
	
	/// <summary>
	/// Person`s credit card number
	/// </summary>
	public String[] CreditCardNumbers { get; set; }
	
	/// <summary>
	/// Age
	/// </summary>
	public Int32 Age { get; set; }
	
	/// <summary>
	/// Phones
	/// </summary>
	public String[] Phones { get; set; }
	
	/// <summary>
	/// Birth date
	/// </summary>
	public Int64 BirthDate { get; set; }
	
	/// <summary>
	/// Salary
	/// </summary>
	public Double Salary { get; set; }
	
	/// <summary>
	/// Is married
	/// </summary>
	public Boolean IsMarried { get; set; }
	
	/// <summary>
	/// Gender
	/// </summary>
	public Gender Gender { get; set; }
	
	/// <summary>
	/// Children
	/// </summary>
	public Child[] Children { get; set; }	
}