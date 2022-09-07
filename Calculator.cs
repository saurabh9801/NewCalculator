using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Calculator
    {
        int Id;

        //public static int calculator { get; set; }

        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public int CalculatorId { get; set; }

        //public int _Id { get; set; }


        //public int CalculatorId { get; set; }

        public int FirstNum { get; set; }
        
        public int SecondNum { get; set; }
        
        public string Operator { get; set; }
        
        public int Result { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}
