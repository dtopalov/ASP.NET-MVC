namespace MvcEssentialsHw.Areas.CustomArea
{
    using System.Web.Mvc;
    public class CustomAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "CustomArea";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "CustomArea_default",
                url: "CustomArea/{controller}/{action}/{id}",
                defaults: new { controller = "NewArea", action = "Index", id = UrlParameter.Optional },
                constraints: new { /*controller = @"^(Admin)"*/ }
            );
        }
    }
}