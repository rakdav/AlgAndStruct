using System.ComponentModel;

int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
int MinimumTwo(int a, int b) => (a < b) ? a : b;
int LevenshtainDistance(string firstword, string secondword)
{
    var n = firstword.Length + 1;
    var m = secondword.Length + 1;
    var matrixD = new int[n, m];
    const int deleteCost = 1;
    const int insertionCost = 1;
    for (int i = 0; i < n; i++)
    {
        matrixD[i, 0] = i;
    }
    for (int j = 0; j < m; j++)
    {
        matrixD[0, j] = j;
    }
    for(var i = 1; i < n; i++)
    {
        for (var j = 1; j < m; j++)
        {
            var substractionCost = (firstword[i - 1] == secondword[j - 1]) ? 0 : 1;
            matrixD[i, j] = Minimum(matrixD[i - 1, j] + deleteCost,
                matrixD[i, j - 1] + insertionCost, matrixD[i-1,j-1]+substractionCost);
        }
    }
    return matrixD[n - 1, m - 1];
}

int DamerauLevenshtainDistance(string firstword, string secondword)
{
    var n = firstword.Length + 1;
    var m = secondword.Length + 1;
    var matrixD = new int[n, m];
    const int deleteCost = 1;
    const int insertionCost = 1;
    for (int i = 0; i < n; i++)
    {
        matrixD[i, 0] = i;
    }
    for (int j = 0; j < m; j++)
    {
        matrixD[0, j] = j;
    }
    for (var i = 1; i < n; i++)
    {
        for (var j = 1; j < m; j++)
        {
            var substractionCost = (firstword[i - 1] == secondword[j - 1]) ? 0 : 1;
            matrixD[i, j] = Minimum(matrixD[i - 1, j] + deleteCost,
                matrixD[i, j - 1] + insertionCost, matrixD[i - 1, j - 1] + substractionCost);

            if (i > 1 && j > 1 && firstword[i - 1] == secondword[j - 2] && firstword[i - 2] == secondword[j-1])
            {
                matrixD[i, j] = MinimumTwo(matrixD[i, j], matrixD[i-2,j-2]+substractionCost);
            }
        }
    }
    return matrixD[n - 1, m - 1];
}


Console.WriteLine("Введите первое слово:");
string first = Console.ReadLine()!;
Console.WriteLine("Введите второе слово:");
string second = Console.ReadLine()!;
Console.WriteLine("Левенштен:"+LevenshtainDistance(first,second));
Console.WriteLine("Дамерау-Левенштейна:"+DamerauLevenshtainDistance(first,second));

