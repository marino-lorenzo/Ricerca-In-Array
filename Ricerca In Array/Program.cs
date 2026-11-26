int ind = Random.Shared.Next(1, 101), j = 0, sce = 0, pos = -1, nOcc = 0;
int[] v = new int[ind];
bool c = false;
for (int i = 0; i < v.Length; i++)
{
    v[i] = Random.Shared.Next(1, 101);
    Console.WriteLine(v[i]);
}
do
{
    Console.WriteLine("Quale tipo di ricerca vuoi fare?\n[1]True/False\n[2]Posizione\n[3]Numero Occorenze\n[4]Posizione Occorenze");
    sce = Convert.ToInt16(Console.ReadLine());
    if (sce < 1 || sce > 4)
    {
        Console.WriteLine("Invalido, riprova");
    }
} while (sce < 1 || sce > 4);
Console.WriteLine("Inserire l'elemento da cercare nell'array(int)");
int n = Convert.ToInt16(Console.ReadLine());
if (sce == 1 || sce == 2) //scelte 1 e 2(insieme perche usano entrambe il while)
{
    while (j < v.Length && c != true && pos == -1)
    {
        if (v[j] == n)
        {
            if (sce == 1)
            {
                c = true;
            }
            else
            {
                pos = j;
            }
        }
        j++;
    }
    if (sce == 1)
    {
        Console.WriteLine(c);
    }
    else
    {
        if (pos != -1)
        {
            Console.WriteLine($"La posizione è {pos}");
        }
        else
        {
            Console.WriteLine("L'elemento non è presente");
        }
    }  
}
else //scelte 3 e 4(insieme perche usano entrambe il for)
{
    if (sce == 4)
    {
        Console.WriteLine("Le posizioni delle occorrenze sono:");
    }
    for (int k = 0; k < v.Length; k++)
    {
        if (v[k] == n)
        {
            if (sce == 3)
            {
                nOcc++;
            }    
            else
            {
                Console.WriteLine(k);
            }
        }
    }
    if(sce == 3)
    {
        Console.WriteLine($"Il numero {n} appare {nOcc} volte");
    }
}
        

    


