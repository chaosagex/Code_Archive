using System;

public class Class1
{
    public Class1()
    {
//        var identityUrl = builder.Configuration.GetValue<string>("Taxes:IdentityUrl");
//        var callBackUrl = builder.Configuration.GetValue<string>("Taxes:CallBackUrl");
//        //var sessionCookieLifetime = builder.Configuration.GetValue("SessionCookieLifetimeMinutes", 60);
//        builder.Services.AddAuthentication(options =>
//        {
//            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//            //options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//            options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//            options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//            options.DefaultChallengeScheme = "Taxes";
//        })
//.AddCookie().AddOAuth("Taxes", options =>
//{

//    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//    options.AuthorizationEndpoint = identityUrl.ToString();
//    //options.ReturnUrlParameter = callBackUrl.ToString();
//    options.CallbackPath = new PathString("/signin");
//    options.ClientId = builder.Configuration.GetValue<string>("Taxes:ClientId");
//    options.ClientSecret = builder.Configuration.GetValue<string>("Taxes:ClientSecret");
//    options.TokenEndpoint = identityUrl + "/connect/token";
//    options.Events = new OAuthEvents
//    {
//        OnCreatingTicket = async context =>
//        {
//            var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
//            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);

//            var response = await context.Backchannel.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
//            response.EnsureSuccessStatusCode();

//            var user = JsonDocument.Parse(await response.Content.ReadAsStringAsync());

//            context.RunClaimActions(user.RootElement);
//        }
//    };

//});
//        app.UseAuthorization();
    }
}
