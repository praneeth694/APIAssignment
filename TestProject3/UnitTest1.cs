namespace TestProject3;

using Newtonsoft.Json.Linq;
using RestSharp;

[TestClass]
public class UnitTest1
{


    [TestMethod]
    public void TestMethod1()
    {
        var client = new RestClient("https://petstore.swagger.io/v2/user/");


        //First Question ------> Create a new User
        var postRequest = new RestRequest("/resource/", Method.Post);

        postRequest.AddJsonBody(new
        {
            id = "43433",
            username = "323243431qw",
            firstName = "RRRR",
            lastName = "LLL",
            email = "we@gmail.com",
            password = "23dwewe",
            phone = "2324433",
            userStatus = "0"
        });


        var userAdded = client.Execute(postRequest);

        Console.WriteLine(userAdded.Content);


        //Second Question ----> Retrieve the User

        var request = new RestRequest("getCatalog?token={token}", Method.Get);

        var executeRequest = client.Execute(request);

        var responseJson = executeRequest.Content.ToString();

        JObject json = JObject.Parse(responseJson);

        Console.WriteLine(json);

        Console.WriteLine();
        Console.WriteLine();






    }

}

