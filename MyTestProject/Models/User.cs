//namespace MyApplication.Models
namespace Models
{
	public class User : object
	//public class User : System.Object
	{
		public User() : base()
		{
		}

		public int Id { get; set; }

		public string Username { get; set; }
		//public string UserName { get; set; }

		public string Password { get; set; }
		//public string PassWord { get; set; }

		public string FullName { get; set; }

		//public string IP { get; set; }

		//public System.DateTime RegisterDateTime { get; set; }
	}
}
