using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http;
using System.Security.Claims;

[assembly: OwinStartup(typeof(WebApiTokenİşlemleri.App_Start.Startup))]

namespace WebApiTokenİşlemleri.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //öncelikle bir tane config nesnesine ihtiyacımız var.httpconfig içinde

            HttpConfiguration config = new HttpConfiguration();

            //
            ConfigureOAuth(app);

            //Daha sonra Bir web api config den register üretip bu config ayarını register içerisine yerleştirmemiz gerekiyor.
            WebApiConfig.Register(config);
            app.UseWebApi(config);
  
        }
        //bir diger yapmamı gereken ayar oauth yani security kısmındaki config ayarlarını yapmalıyız.
        public void ConfigureOAuth(IAppBuilder app)
        {
            //bu metot içerisinde tokenin yapısını ve pathini belirleyebiliriz.
            //path için:
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true,
                Provider = new SimpleAuthorizationServerProvider() //bu nesneyi daha sonra üretecegiz.
            };
            //Artık OAuthServerOptions 'u AuthorizationServer içerisine yerleştirebiliriz.
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());//token tipini belirttik.
        }

        //OAuthAuthorizationServerOptions ayarları nasıl oluştur ve bir provider ı nasıl olusturacagımızı inceleyelim:
        public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
        {
            public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
            {
                context.Validated();
                return Task.FromResult<object>(null);
            }

            public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
            {
                //kullanıcı adı ve paralomızı belirledigimiz alan:
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                //bu işlemden sonra contextin içerisinde username ve password ayarlayabiliriz.
                if (context.UserName=="OGS" && context.Password=="123")
                {
                    //eger dogru ise bir tane identity üretmem gerekir ve sonrada contexti bu identity e göre validated yapmamız gerekir.
                    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                    identity.AddClaim(new Claim("sub", context.UserName));//verecegimiz ismi belirttik
                    identity.AddClaim(new Claim("role", "user"));//rolü ayarladık.

                    context.Validated(identity);
                }
                else
                {
                    context.SetError("invalid_grant", "Hatalı Giriş");
                }

                return Task.FromResult<object>(null);

            }
        }
    }
}
