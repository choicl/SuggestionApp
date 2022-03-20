namespace SuggestionLibrary.Models
{
	public class BasicSuggestionModel
	{
		public int Id { get; set; }
		public string Suggestion { get; set; }
		public BasicSuggestionModel()
		{

		}
		public BasicSuggestionModel(SuggestionModel suggestion)
		{
			Id = suggestion.Id;
			Suggestion = suggestion.Suggestion;
		}
	}
}
