using System.Numerics;

static BigInteger PowMod(BigInteger x,BigInteger y, BigInteger n)
{
    BigInteger r = 1;
    while (y != 0)
    {
        if ((y & 0x01) == 1)
        {
            r = (r * x) % n;
        }
        x = (x * x) % n;
        y >>= 1;
    }
    return r;
}

static void Main()
{
    BigInteger result = PowMod(2, 25, 81613123);
    Console.WriteLine($"{result}");
}
Main();
