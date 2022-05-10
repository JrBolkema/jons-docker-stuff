var fileName = "someText.txt";
var current = 0;
var path = Path.Join("data",fileName);

if(File.Exists(path)){
    var content = File.ReadAllText(path);
    current = int.Parse(content);
}
Console.WriteLine( $"Current is {current}");

while (true)
{
    Thread.Sleep(300);
    current = ++current;
    File.WriteAllText(path,current.ToString());
    System.Console.WriteLine(  $"Wrote {current} at {DateTime.Now}");
}