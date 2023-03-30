using RickAndBobLib;



IRickAndBob sharedLib = new RickAndBob();
var result = sharedLib.GetRickAndBobifiedList(100);

//  The Console.WriteLine() was not included in the class library to eliminate dependencies allowing each project to deal with the output in it's own way.
//  We could also modify this method to take additional parameters such as counts other than 100 or new inputs(Name, Number) instead of hardcoding Ricky-3 and Bobby-5 but this was not specified
//  Publishing to private Nuget server is a great way to share class libraries across projects

foreach (var item in result)
{
    Console.WriteLine(item);
}


Console.ReadKey();




