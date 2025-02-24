// See https://aka.ms/new-console-template for more information


using SubstringSearcher.Extensions;

string text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
//text = text[..^3];
string search = "";//"ipsum dolor";
int multiplier = 500;

//Console.WriteLine($"TEXT: {text}");
//Console.WriteLine($"SEARCH STRING: {search}");

var watch = new System.Diagnostics.Stopwatch();
IList<int> result = new List<int>();
IList<int> result1 = new List<int>();

text = text.Multiply(multiplier);

search = text + "h";
text = text + "haha";

watch.Start();
result = text.Find(search);
watch.Stop();

Console.WriteLine("\nTIME: " + watch.ElapsedMilliseconds);

watch.Start();
result1 = text.FindSlow(search);
watch.Stop();

if(result.Count != result1.Count)Console.WriteLine("FALSE FALSE FALSE");

for (int i = 0; i < result.Count; i++)
{
    if (result[i] != result1[i])
    {
        Console.WriteLine("ERROR: FALSE FALSE FALSE");
        break;
    }
}


Console.WriteLine("\nTIME: " + watch.ElapsedMilliseconds);
