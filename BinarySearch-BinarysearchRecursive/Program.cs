// See https://aka.ms/new-console-template for more information
using BinarySearch_BinarysearchRecursive;
using static BinarySearch_BinarysearchRecursive.delegateTest;




static int linearSearch(int[] a1, int sum)
{
    for(int i = 0; i < a1.Length; i++)
    {
        if (a1[i]==sum)
        {
            return i;
        }
    }
    return -1;
}

int resultLinear = linearSearch(a1, 10);
Console.WriteLine(result);


//Abstrakt klasse
Class1TryAbstract p1 = new Class1TryAbstract(5);

Console.WriteLine(p1.func2(5));

//Delegate test anonym delegate btw
del d = x => Console.WriteLine(x);
d.Invoke(Book.ToString());




//Observable pattern
ObservablePattern o = new ObservablePattern();
ObservablePattern2 o2 = new ObservablePattern2("Hans");

o2.Subscribe(o);
//o2.Unsubscribe();

o.EndTransmission();

// - Test søndag
int[] array1 = {1,2,3,4,5,6,7,8,9,10};

static int findTalletFunktion1(int[] a1, int sum)
{
    for(int i = 0; i < a1.Length; i++)
    {
        if (sum == a1[i])
        {
            return i;
        }
    }
    return -1;
}
Console.WriteLine("søndagstest");
Console.WriteLine(findTalletFunktion1(array1, 5));

static int[] findNegativeTal(int[] a1)
{
    int[] negativeTal = new int[a1.Length];
    int optælling = 0;
    for (int i = 0; i < a1.Length-1; i++)
    {
        if (a1[i]%2 != 0)
        {
            negativeTal[optælling] = a1[i];
            optælling++;
        }
    }
    return negativeTal;
}
Console.WriteLine("   ");
int[] nytarray = findNegativeTal(array1);
for(int i = 0; i < nytarray.Length; i++)
{
    Console.WriteLine(nytarray[i]);
}

Console.WriteLine("        ");

static int findBinarySearchStandard(int[] a1, int sum)
{
    int min = 0;
    int max = a1.Length - 1;

    while(min <= max)
    {
        int mid = (min+max)/2;
        if (sum == a1[mid])
        {
            return mid;
        }
        else if (a1[mid] > sum)
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;

}

Console.WriteLine(findBinarySearchStandard(array1, 10));

static int findBinarySearchRecursive(int[] a1, int sum, int min, int max)
{
    int mid = (min + max) / 2;
    if (sum == a1[mid])
    {
        return mid;
    }
    else if (a1[mid] > sum)
    {
        return findBinarySearchRecursive(a1, sum, min, max-1);
    }
    else
    {
        return findBinarySearchRecursive(a1, sum, min+1, max);
    }
}

Console.WriteLine("        ");
Console.WriteLine(findBinarySearchRecursive(a1,9,0,a1.Length-1));