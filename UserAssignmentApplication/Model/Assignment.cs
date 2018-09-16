using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAssignmentApplication.Model
{
    public class Assignment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string AssignmentName { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public User User { get; set; }


    }
}
