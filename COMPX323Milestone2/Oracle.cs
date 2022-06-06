using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;

namespace COMPX323Milestone2

{
    class Oracle
    {
        
        
        public static void RegisterPersonOracle(string username, string password, string email, string firstname, string lastname)
        {
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tk229;Password=ora192394;";
            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Person values ('" + username + "','" + email + "','" + password + "','" + firstname + "','" + lastname + "')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Dispose();
        }

        public static void RegisterOrganiserOracle(string username, string organisation, string phone)
        {
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tk229;Password=ora192394;";
            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Organizer values ('" + username + "','" + organisation + "','" + phone + "')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Dispose();
        }

       


        public static void RegisterPersonMongoDB(string username, string password, string email, string firstname, string lastname)
        {
            // Connect MOngo DB, Enter username and password
            MongoClient dbClient = new MongoClient("mongodb://tk229:iHRV4zRqMA@mongodb.cms.waikato.ac.nz:27017");
            // Database name(username)
            IMongoDatabase db = dbClient.GetDatabase("tk229");
            // Collection's name
            var things = db.GetCollection<BsonDocument>("test3");

            BsonDocument personDoc = new BsonDocument();
            
            BsonElement personUsernameElement = new BsonElement("username", username);           
            BsonElement personEmailElement = new BsonElement("email", email);
            BsonElement personPasswordElement = new BsonElement("password", password);
            BsonElement personNameElement = new BsonElement("name", firstname + " " + lastname);
            
            personDoc.Add(personUsernameElement);
            personDoc.Add(personEmailElement);
            personDoc.Add(personPasswordElement);
            
            personDoc.Add(personNameElement);
            

            things.InsertOne(personDoc);
        }

        public static void RegisterOrganiserMongoDB(string username, string email, string password, string firstname, string lastname, string organisation, string phone)
        {
            // Connect MOngo DB, Enter username and password
            MongoClient dbClient = new MongoClient("mongodb://tk229:iHRV4zRqMA@mongodb.cms.waikato.ac.nz:27017");
            // Database name(username)
            IMongoDatabase db = dbClient.GetDatabase("tk229");
            // Collection's name
            var things = db.GetCollection<BsonDocument>("test3");

            BsonDocument personDoc = new BsonDocument();

            BsonElement personUsernameElement = new BsonElement("username", username);
            BsonElement personEmailElement = new BsonElement("email", email);
            BsonElement personPasswordElement = new BsonElement("password", password);
            BsonElement personNameElement = new BsonElement("name", firstname + " " + lastname);

            BsonElement personOrganizationElement = new BsonElement("organization", organisation);
            BsonElement personPhoneElement = new BsonElement("phone", phone);

            personDoc.Add(personUsernameElement);
            personDoc.Add(personEmailElement);
            personDoc.Add(personPasswordElement);
            personDoc.Add(personNameElement);
            personDoc.Add(personOrganizationElement);
            personDoc.Add(personPhoneElement);

            things.InsertOne(personDoc);
        }

        public static void TestDeleteMongoDB()
        {
            MongoClient dbClient = new MongoClient("mongodb://tk229:iHRV4zRqMA@mongodb.cms.waikato.ac.nz:27017");
            IMongoDatabase db = dbClient.GetDatabase("tk229");
            var things = db.GetCollection<BsonDocument>("test");

            BsonDocument findAnotherPersonDoc = new BsonDocument(new BsonElement("PersonFirstName", "Sankhojjal"));

            things.FindOneAndDelete(findAnotherPersonDoc);
        }
    }
}
