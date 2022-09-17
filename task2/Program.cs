int SumNumbersMN(int m, int n)
{
    if (m < n)
    {
        return  m + SumNumbersMN(m+1,n);
    }
    else if ( m > n)
    {
        return n + SumNumbersMN(m,n+1);
    }
    else return n;
}
Console.WriteLine(SumNumbersMN(1,10));
Console.WriteLine(SumNumbersMN(10,1));
