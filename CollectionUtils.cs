namespace Edymtt
{
  public static class CollectionUtils
  {
    public bool IsEmpty<T>(IEnumerable<T> input)
	{
	  return input==null || !input.Any();
	}
  }
}