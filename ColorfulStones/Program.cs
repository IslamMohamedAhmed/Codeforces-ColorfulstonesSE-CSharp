string str1, str2;
int count = 0,indicator = 0;
str1 = Console.ReadLine();
str2 = Console.ReadLine();
for(int i = 0; i < str2.Length; i++)
{
    if (str1[indicator] != str2[i])
    {
        count++;
    }
    else
    {
        indicator++;

    }
}
Console.WriteLine(indicator+1);