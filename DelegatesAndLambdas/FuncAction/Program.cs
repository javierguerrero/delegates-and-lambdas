using System.Diagnostics;

//var watch = Stopwatch.StartNew();
//CountToNearlyInfinity(); // Method to benchmark
//watch.Stop();
//Console.WriteLine(watch.Elapsed);

MeasureTime(() => CountToNearlyInfinity());
Console.WriteLine($"The result is {MeasureTimeFunc(() => CalculateSomeResult())}");


void MeasureTime(Action a)
{
    var watch = Stopwatch.StartNew();
    a();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

int MeasureTimeFunc(Func<int> f)
{
    var watch = Stopwatch.StartNew();
    var result = f();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
    return result;
}

void CountToNearlyInfinity()
{
    for (int i = 0; i < 1000000000; i++) ;
}

int CalculateSomeResult()
{
    // Simulate some interesting calculation
    for (int i = 0; i < 1000000000; i++) ;

    // Return the result
    return 42;
}