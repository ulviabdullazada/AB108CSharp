string text = "SaSSSalam Aleykumi. Allah sizi qorusun";
string acharsoz = "SSalam";
int keyI = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == acharsoz[keyI])
    {
        if (keyI == acharsoz.Length - 1)
        {
            Console.WriteLine(true);
            break;
        }
        keyI++;
    }
    else
    {
        if(keyI != 0)
        {
            if (i > 0) i-=keyI;
        }
        keyI = 0;
    }
}
Console.WriteLine(keyI);