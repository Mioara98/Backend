using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AnStudiu
{
    public class AnStudiu
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }  
        public List <Domain.Semestru.Semestru> Semestru { get; set; }

        public string NumeAnStudiu { get; set; }

    }
}
