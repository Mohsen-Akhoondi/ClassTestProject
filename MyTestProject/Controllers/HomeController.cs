namespace MyTestProject.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route
        (template: Infrastructure.RouterConstants.Controller)]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public HomeController() : base()
        {
        }

        public string Index()
        {
            return "Hi I'm Mohsen Akhoondi";
        }
        [Microsoft.AspNetCore.Mvc.HttpGet(template: "GetSomeUser")]
        public Models.User SomeUser()
        {
            Models.User user =
                new Models.User
                {
                    Id = 1,
                    Username = "moh3n-akhoondi",
                    Password = "8855",
                    FullName = "mohsen akhondi",
                };

            return user;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost(template: "SetSomeUser")]
        public bool SetSomeUser(Models.User AUser)
        {
            Models.User user = AUser;

            return true;
        }
    }
}
