// See https://aka.ms/new-console-template for more information


double[,] doubles = { { 9.49,9.5,9.51},
                      {10.49, 10.5, 10.51},
                      {11.49, 11.5, 11.51},
                      {12.49, 12.5, 12.51},
                      {-12.49, -12.5, -12.51 },
                      {-11.49, -11.5, -11.51},
                      {-10.49, -10.5, -10.51},
                      {-9.49,-9.5,-9.51}};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");

for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]), 7} ");
    }
    WriteLine("|");
}
WriteLine();