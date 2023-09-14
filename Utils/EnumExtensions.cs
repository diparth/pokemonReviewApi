namespace pokemonReviewApp.Utils
{
  public static class StringExtensions
  {

    public static string DisplayCount(this string value)
    {
      if (value == null)
      {
        return "null value";
      }
      else
      {
        return $"Length of {value}: {value.Length}";
      }
    }
  }
}