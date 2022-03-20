namespace SuggestionLibrary.Models
{
	public class BasicUserModel
	{
		public int Id { get; set; }
		public string DisplayName { get; set; }
		public BasicUserModel()
		{

		}
		public BasicUserModel(UserModel user)
		{
			Id = user.Id;
			DisplayName = user.DisplayName;
		}
	}
}
