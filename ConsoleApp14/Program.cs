using System.Linq;

class combination
{
	public static List<List<int>> combinations(List<int> arr)
	{
		if (arr.Count == 0)
			return new List<List<int>>() { new List<int> { } };
		int first = arr[0];
		List<int> rest =(arr.Count>1)? arr.Skip(1).ToList():new List<int>() { };
		List<List<int>> combswithoutFirst = combinations(rest);
		List<List<int>> combswithfirst = new() { };
		foreach(var i in combswithoutFirst)
		{
			var combwithfirst = i.ToList<int>();
			combwithfirst.Add(first);
			combswithfirst.Add(combwithfirst);
		}
		return combswithfirst.Concat(combswithoutFirst).ToList();
	}
	public static void Main(string[] args)
	{
		List<int> arr = new List<int>() { 1, 2, 3};
		List<List<int>> res=combinations(arr);
		Console.WriteLine(res.Count);
	}
}