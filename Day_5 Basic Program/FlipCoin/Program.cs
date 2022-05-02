int loopCount = 1;
double numFlips = 50;
double result;
int heads = 0;
int tails = 0;
int heads_count = 0;
int tails_count = 0;
while (loopCount <= numFlips)
{
    Random obj = new Random();
    result = obj.NextDouble() * (1-0)+0;
    result = Math.Round(result, 1);
    if (result <= 0.5)
    {
        Console.WriteLine("coin flipped:- Head");
        heads++;
    }
    else
    {
        Console.WriteLine("coin flipped:- Tails");
        tails++;
    }
    loopCount++;    

}
double percentageHeads = (heads / numFlips) * 100;
percentageHeads=Math.Round(percentageHeads, 2);
double percentageTails = (tails / numFlips) * 100;
percentageTails=Math.Round(percentageTails, 2);
Console.WriteLine("\ncount :");
Console.WriteLine("total head count: " + heads);
Console.WriteLine("total tail count: " + tails);
Console.WriteLine("\npercentages:");
Console.WriteLine("percentage of heads occur: " +percentageHeads + "%");
Console.WriteLine("percentage of tails occur: " +percentageTails + "%");