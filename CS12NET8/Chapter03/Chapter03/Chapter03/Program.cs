int max = 500;
for(byte i=0; i<max; i++)
{
    if(max > byte.MaxValue)
    {
        Console.WriteLine("The value of max exceeds the max value of byte. Cannot continue ");
        return;
    }
    else
    {
        Console.WriteLine(i);
    }
}