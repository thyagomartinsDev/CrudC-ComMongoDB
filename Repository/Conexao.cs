using MongoDB.Bson;
using MongoDB.Driver;

namespace Repository
{
    public class Conexao
    {       

        public void ConexaMongoDB()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://userAPI:digital1231@cluster0.9ushz.gcp.mongodb.net/crudcsharp?retryWrites=true&w=majority");
            var database = dbClient.GetDatabase("crudcsharp");
            var collection = database.GetCollection<BsonDocument>("appcsharp");
        }
    }
}
