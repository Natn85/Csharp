// See https://aka.ms/new-console-template for more information
float RB, GB, RG ;
int[] cent = {200, 100, 50, 20, 10, 5, 2, 1};
Console.WriteLine("Rechnungsbetrag: ");
RB = float.Parse(Console.ReadLine());
Console.WriteLine("Gezahlter Betrag: ");
GB = float.Parse(Console.ReadLine());

RG = GB - RB;
Console.WriteLine("===============");
Console.WriteLine("Rückgeld: "+RG);
Console.WriteLine("===============");

int RGcent = (int)(RG * 100);
Console.WriteLine(RGcent);

for(int i = 0; i < 8; i++)
{
    for (i = i; i < 2; i++)
    {
           Console.WriteLine($"{cent[i] / 100} Euro:  {(RGcent % cent[i]) / 100}");
           if (RGcent > cent[i])
       {
                RGcent = RGcent - cent[i];
            }
        }
    Console.WriteLine("Cent "+cent[i] + ": " + (RGcent % cent[i])/100);
    if (RGcent > cent[i])
    {
        RGcent = RGcent - cent[i];
    }
}