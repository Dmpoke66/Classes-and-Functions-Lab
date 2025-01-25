using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_FunctionsLab
{
   
    
    // Relation class
    public class Relation
        {
     // Attribute
     public string RelationshipType { get; set; }

            // Constructor
    public Relation(string relationshipType)
        {
             RelationshipType = relationshipType;
         }

     // ShowRelationShip method
    public void ShowRelationShip(Person person1, Person person2)
         {
             Console.WriteLine($"{person1.FirstName} {person1.LastName} is the {RelationshipType} of {person2.FirstName} {person2.LastName}.");
         }
        }
    }

