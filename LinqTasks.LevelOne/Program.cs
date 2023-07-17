//Methods to use:
//  String:
//      string.Join, string.Concat, new string
//      string.Split,
//		Contains, StartsWith, EndsWith
//	Linq:
//		Select, Where, Skip[While], Take[While],
//      Min, Max, Sum, Average, Count,
//      Reverse,
//      All, Any, Contains
//	    First[OrDefault], Last[OrDefault], Single[OrDefault],
//	    Range, Repeat,
//      ToArray, ToList

Console.WriteLine("1. Print all numbers from 10 to 50 separated by commas");
Console.WriteLine(string.Join(',', Enumerable.Range(10, 50 - 10 + 1)));
Console.WriteLine();

Console.WriteLine("2. Print only that numbers from 10 to 50 that can be divided by 3");
Console.WriteLine(string.Join(' ', Enumerable.Range(10, 50 - 10 + 1).Where(number => number % 3 == 0)));
Console.WriteLine();

Console.WriteLine("3. Output word \"Linq\" 10 times");
Console.WriteLine(string.Join('\n', Enumerable.Repeat("Linq", 10)));
Console.WriteLine();

Console.WriteLine("4. Output all words with letter 'a' in string \"aaa;abb;ccc;dap\"");
Console.WriteLine(string.Join(',', "aaa;abb;ccc;dap".Split(';').Where(word => word.Contains('a'))));
Console.WriteLine();

Console.WriteLine("5. Output number of letters 'a' in the words with this letter in string \"aaa;abb;ccc;dap\" separated by comma");
Console.WriteLine(string.Join(',', "aaa;abb;ccc;dap".Split(';')
    .Where(word => word.Contains('a')).Select(word => word.Count(letter => letter == 'a'))));
Console.WriteLine();

Console.WriteLine("6. Output true if word \"abb\" exists in line \"aaa;xabbx;abb;ccc;dap\", otherwise false");
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Contains("abb"));
Console.WriteLine();

Console.WriteLine("7. Get the longest word in string \"aaa;xabbx;abb;ccc;dap\"");
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').MaxBy(word => word.Length));
// Rewrite without using MaxBy? ^___^
//Console.WriteLine("aaa;xabbx;abb;ccc;dSADap".Split(';').First(item => item.Length == "aaa;xabbx;abb;ccc;dSADap".Split(';').Max(f => f.Length)));
Console.WriteLine();

Console.WriteLine("8. Calculate average length of word in string \"aaa;xabbx;abb;ccc;dap\"");
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Average(word => word.Length));
Console.WriteLine();

Console.WriteLine("9. Print the shortest word reversed in string \"aaa;xabbx;abb;ccc;dap;zh\"");
Console.WriteLine(new string("aaa;xabbx;abb;ccc;dap;zh".Split(';').MinBy(word => word.Length)!.Reverse().ToArray()));
// Rewrite without using MinBy? ^___^
//Console.WriteLine("baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';').First(item => item.Length == "baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';').Min(f => f.Length)))...;
Console.WriteLine();

Console.WriteLine("10. Print true if in the first word that starts from \"aa\" all letters are 'b' otherwise false \n\"baaa;aabb;aaa;xabbx;abb;ccc;dap;zh\"");
Console.WriteLine(string.Join(',', "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';')
    .Select(word => word.StartsWith("aa") && word[2..].All(letter => letter == 'b'))));
Console.WriteLine();

Console.WriteLine("11. Print last word in sequence that, excepting first two elements, that ends with \"bb\" \"baaa;aabb;aaa;xabbx;abb;ccc;dap;zh\"");
Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';')[1..].Where(word => word.EndsWith("bb")).LastOrDefault());