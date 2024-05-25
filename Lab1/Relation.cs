using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation
    {
        private readonly string? _relationshipType;
        public string? RelationshipType 
        {
            get { return _relationshipType; }
        }
        public Relation(string? relationshipType)
        {
            if (relationshipType != null && relationshipType != "Sister" && relationshipType != "Mother" && 
                relationshipType != "Brother" && relationshipType != "Father")
            {
                throw new ArgumentException("Invalid relationship type.");
            }
            _relationshipType = relationshipType;
        }


        public string? ShowRelationShip(Person p1, Person p2)
        {
            string rStatus = _relationshipType == "Sister" ? "Sisterhood" :
                _relationshipType == "Mother" ? "Motherhood" :
                _relationshipType == "Brother" ? "Brotherhood" :
                _relationshipType == "Father" ? "Fatherhood" :
                "Unknown";
            return $"Relationship between {p1.FirstName} and {p2.FirstName} is: {rStatus}";
        }
    }
}
