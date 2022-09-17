string FromMtoN(int m, int n)
{
    if (m < n)
    {
        return $"{m} {FromMtoN(m + 1, n)}";
    }
    else if (m == n) return Convert.ToString(n);
    else return $"{m} {FromMtoN(m - 1, n)}";
}
Console.WriteLine(FromMtoN(10, 20));
Console.Write(FromMtoN(20, 10));
