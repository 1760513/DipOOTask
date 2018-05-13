///////////////////////////////////////////////////////////
//  Person.cs
//  Implementation of the Class Person
//  Generated by Enterprise Architect
//  Created on:      11-May-2018 8:24:45 PM
//  Original author: STUDENT
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// Person is an ABSTRACT Class
/// 
/// Notes:
/// 
/// The property on Gender is deliberately omitted to enable a meaningful GetGender
/// Method
/// 
/// The GetOccupation Method is deliberately included without an 'Occupation'
/// attribute, because the method is used to demonstrate polymorhism.
/// </summary>
public abstract class Person {

	private string Fname;
	private string Gender;
	private string Lname;

	public Person(){

	}

	~Person(){

	}

	/// <summary>
	/// Overloaded Constructor
	/// 
	/// Expected Operation: Populates Fname, Lname and Gender from parameters
	/// 
	/// Gender MUST be either M or F and other entry into gender should raise an
	/// exception with the message
	/// 
	/// "Invalid Gender Passed to Person Constructor"
	/// </summary>
	/// <param name="pFName"></param>
	/// <param name="pLName"></param>
	/// <param name="pGender"></param>
	public Person(string pFName, string pLName, string pGender){

	}

	/// <summary>
	/// Overloaded Constructor
	/// 
	/// Gender MUST be either M or F and other entry into gender should raise an
	/// exception with the message
	/// 
	/// "Invalid Gender Passed to Person Constructor"
	/// 
	/// 
	/// If Gender is M  name is populated as Fname = John lName = Doe
	/// If Gender is F  name is populated as Fname = Jane lName = Doe
	/// </summary>
	/// <param name="pGender"></param>
	public Person(string pGender){

	}

	public string Fname{
		get{
			return Fname;
		}
		set{
			Fname = value;
		}
	}

	/// <summary>
	/// returns the gender attribute
	/// </summary>
	public string GetGender(){

		return "";
	}

	/// <summary>
	/// A Virtual Method
	/// 
	/// The default implementation must return  "Unemployed"
	/// </summary>
	public virtual string GetOccupation(){

		return "";
	}

	public string Lname{
		get{
			return Lname;
		}
		set{
			Lname = value;
		}
	}

	/// <summary>
	/// abstract method, no implementation
	/// </summary>
	public abstract string Work();

}//end Person