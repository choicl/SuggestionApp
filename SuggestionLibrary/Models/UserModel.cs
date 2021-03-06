namespace SuggestionLibrary.Models
{
	public class UserModel
	{
		public int Id { get; set; }	
		public string ObjectIdentifier { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DisplayName { get; set; }
		public string EmailAddress { get; set; }
		public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();
		public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();

	}
}
