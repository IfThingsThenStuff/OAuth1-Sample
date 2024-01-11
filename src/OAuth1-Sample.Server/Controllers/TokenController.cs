//using DevDefined.OAuth.Consumer;
//using DevDefined.OAuth.Framework;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;

//[Route("api/token")]
//[ApiController]
//public class TokenController : ControllerBase
//{
//    private static readonly Dictionary<string, string> RequestTokenStorage = new Dictionary<string, string>();

//    // Replace these with your actual consumer key and secret
//    private const string ConsumerKey = "your_consumer_key";
//    private const string ConsumerSecret = "your_consumer_secret";

//    private static readonly ServiceProvider ServiceProvider = new ServiceProvider("http://localhost:5000/api/request_token", "http://localhost:5000/api/access_token", "http://localhost:5000/api/authorize");

//    private static readonly OAuthConsumerContext ConsumerContext = new OAuthConsumerContext
//    {
//        ConsumerKey = ConsumerKey,
//        ConsumerSecret = ConsumerSecret,
//        SignatureMethod = SignatureMethod.HmacSha1,
//        UseHeaderForOAuthParameters = true
//    };
//}
