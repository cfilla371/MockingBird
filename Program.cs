using System.Security.Cryptography;

string input = Console.ReadLine();

string res;

bool caps = true;

if (Char.IsUpper(input[0]))
{
  caps = false;
}

res = input[0].ToString();

for (int i = 1; i < input.Length; i++)
{
    if (caps == false)
    {
        res = res + Char.ToLower(input[i]);
        caps = true;
    } else if (caps == true)
    {
        res = res + Char.ToUpper(input[i]);
        caps = false;
    }
}

Console.WriteLine(res);
