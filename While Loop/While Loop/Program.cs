int i = 0;
int j = 0;

while(i<10)
{
    while(j<10)
    {
        Console.WriteLine("i: " + i +" " + "j:" + j);
        j++;
    }
    j = 0;
    i++;
}