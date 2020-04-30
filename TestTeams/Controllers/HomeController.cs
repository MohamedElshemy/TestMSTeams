using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace TestTeams.Controllers
{
    public class HomeController : Controller
    {
        //public static IPublicClientApplication IdentityClientApp = PublicClientApplicationBuilder
        //                 .Create("ecd591b4-f51a-46d7-ac54-f83cc857881c")
        //                 .WithTenantId("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
        //                 .Build();

        public async System.Threading.Tasks.Task<ActionResult> IndexAsync()
        {
                    var scope= "https://graph.microsoft.com/.default";
                    IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                    .Create("ecd591b4-f51a-46d7-ac54-f83cc857881c")
                    .WithTenantId("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
                    .WithClientSecret("]2y:7LqQIwAL8@fnMYwLvkRcG.t438Cw")
                    .Build();
                    ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication,scope);
                    GraphServiceClient graphClient = new GraphServiceClient(authProvider);

                    var onlineMeeting = new OnlineMeeting
                    {
                        StartDateTime = DateTimeOffset.Parse("2020-07-12T21:30:34.2444915+00:00"),
                        EndDateTime = DateTimeOffset.Parse("2020-07-12T22:00:34.2464912+00:00"),
                        Subject = "User Token Meeting",
                        //ChatInfo = new ChatInfo { ThreadId = "f8cdef31-a31e-4b4a-93e4-5f571e91255a" }
                    };

                    var s = await graphClient.Me.OnlineMeetings
                         .Request()
                         .AddAsync(onlineMeeting);
                    return View();
            //GraphServiceClient graphClient = new GraphServiceClient(
            //        "https://graph.microsoft.com/v1.0",
            //        new DelegateAuthenticationProvider(
            //             (requestMessage) =>
            //            {
            //                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer",await "");
            //            }));

            //return await graphClient.Me.Request().GetAsync();




            //var authentication = new
            //{
            //    Authority = "https://graph.microsoft.com",
            //    Directory = "4999ebad-131b-49f8-836b-cfe343676765",
            //    Application = "ecd591b4-f51a-46d7-ac54-f83cc857881c",
            //    ClientSecret = "]2y:7LqQIwAL8@fnMYwLvkRcG.t438Cw"
            //};
            //var confidentialClientApplication = ConfidentialClientApplicationBuilder.Create(authentication.Application)
            //    .WithClientSecret(authentication.ClientSecret)
            //    .WithTenantId("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
            //    //.WithAuthority(AzureCloudInstance.AzurePublic, authentication.Directory)
            //    .Build();


            //ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication);
            // var DelegateAuthenticationProvider = new DelegateAuthenticationProvider();
            // (requestMessage) =>
            //{
            //    requestMessage.Headers.Authorization =
            //        new AuthenticationHeaderValue("Bearer", "");
            //}));
            // var requestMessage = new AuthenticationHeaderValue("","");
            // var DelegateAuthenticationProvider = new DelegateAuthenticationProvider(requestMessage.);

            // var graphClient = new GraphServiceClient(de)
            // //await graphClient.Me.Request().GetAsync();
            //GraphServiceClient graphClient = new GraphServiceClient(authProvider);

            //var onlineMeeting = new OnlineMeeting
            //{
            //    StartDateTime = DateTimeOffset.Parse("2020-07-12T21:30:34.2444915+00:00"),
            //    EndDateTime = DateTimeOffset.Parse("2020-07-12T22:00:34.2464912+00:00"),
            //    Subject = "User Token Meeting",
            //    //ChatInfo = new ChatInfo { ThreadId = "f8cdef31-a31e-4b4a-93e4-5f571e91255a" }
            //};

            //var s = await graphClient.Me.OnlineMeetings
            //     .Request()
            //     .AddAsync(onlineMeeting);


            // GraphServiceClient graphClient = new GraphServiceClient(authenticationProvider);

            // var onlineMeeting = new OnlineMeeting
            // {
            //     StartDateTime = DateTimeOffset.Parse("2019-07-12T21:30:34.2444915+00:00"),
            //     EndDateTime = DateTimeOffset.Parse("2019-07-12T22:00:34.2464912+00:00"),
            //     Subject = "User Token Meeting",
            //     ChatInfo = new ChatInfo { ThreadId = "f8cdef31-a31e-4b4a-93e4-5f571e91255a" }
            // };

            //var s= await graphClient.Me.OnlineMeetings
            //     .Request()
            //     .AddAsync(onlineMeeting);

            //public string TenantID = "f8cdef31-a31e-4b4a-93e4-5f571e91255a"; // Tenant for Custom Translator
            ////static string ClientID = ConfigurationManager.AppSettings["ClientID"]; // Enter your ClientID that you created in https://apps.dev.microsoft.com 
            //public string authorityUri = "https://login.microsoftonline.com/{TenantID}/oauth2/v2.0";
            //string[] Scopes = "User.Read, Sites.ReadWrite.All".Split(',');

            //IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
            //                 .Create("ecd591b4-f51a-46d7-ac54-f83cc857881c")
            //                 .WithTenantId("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
            //                 .Build();


            //GraphServiceClient graphClient = new GraphServiceClient(
            //                "https://graph.microsoft.com/v1.0",
            //                new DelegateAuthenticationProvider(
            //                    async (requestMessage) =>
            //                    {
            //    var token = await GetTokenForUserAsync();
            //    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            //    // This header has been added to identify our sample in the Microsoft Graph service.  If extracting this code for your project please remove.
            //    requestMessage.Headers.Add("SampleID", "MSGraphConsoleApp");

            //}));
            //return graphClient;
            //IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
            //    .Create("14b78153-0017-41fb-a1ee-0cd4e9d7082a")
            //    //.WithTenantId("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
            //    .WithRedirectUri("https://TestAPP")
            //    .WithClientSecret("]2y:7LqQIwAL8@fnMYwLvkRcG.t438Cw")
            //    .Build();
            //IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
            //     .Create("ecd591b4-f51a-46d7-ac54-f83cc857881c")
            //    .Build();
            //InteractiveAuthenticationProvider authenticationProvider = new InteractiveAuthenticationProvider(publicClientApplication, Scopes);

        }
        //public async Task<string> GetTokenForUserAsync()
        //{
        //    AuthenticationResult authResult;
        //        var TokenForUser = "";
        //        DateTimeOffset Expiration;
        //        IEnumerable<string> Scopes = "User.Read, Sites.ReadWrite.All".Split(',');
        //        try
        //        {
        //                 authResult = IdentityClientApp.AcquireTokenSilentAsync(Scopes, IdentityClientApp.GetAccountsAsync().Result.First());
        //                  TokenForUser = authResult.AccessToken;
        //        }

        //        catch (Exception)
        //        {
        //            if (TokenForUser == null )
        //            {
        //                authResult = await IdentityClientApp.AcquireTokenAsync(Scopes);

        //                TokenForUser = authResult.AccessToken;
        //                Expiration = authResult.ExpiresOn;
        //            }
        //        }

        //        return TokenForUser;
        //}
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //static void Main(string[] args)
        //{
        //    GetDataAsync().GetAwaiter().GetResult();
        //    Console.ReadKey();
        //}

        //static async Task GetDataAsync()
        //{
        //    Console.WriteLine("Display user details");

        //    Microsoft.Identity.Client.PublicClientApplication clientApp = new Microsoft.Identity.Client.PublicClientApplication(ConfigurationManager.AppSettings["clientId"].ToString());

        //GraphServiceClient graphClient = new GraphServiceClient(
        //            "https://graph.microsoft.com/v1.0",
        //            new DelegateAuthenticationProvider(
        //                async (requestMessage) =>
        //                {
        //                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", await GetTokenAsync(clientApp));
        //                }));

        //var currentUser = await graphClient.Me.Request().GetAsync();
        //Console.WriteLine(currentUser.DisplayName);
        //}

        //static async Task<string> GetTokenAsync(Microsoft.Identity.Client.PublicClientApplication clientApp)
        //{
        //    //need to pass scope of activity to get token
        //    string[] Scopes = { "User.Read" };
        //    string token = null;

        //    AuthenticationResult authResult = await clientApp.AcquireTokenInteractive(Scopes);
        //    token = authResult.AccessToken;

        //    return token;
        //}
    }
}