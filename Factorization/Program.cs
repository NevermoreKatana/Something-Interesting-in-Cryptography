using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;


static BigInteger createBigInteger(BigInteger N)
{
    Random rnd = new Random();
    byte[] bytes = new byte[N.ToByteArray().Length - 1];
    rnd.NextBytes(bytes);

    BigInteger randomBigInt = new BigInteger(bytes) % (N - 2) + 2;
    if (randomBigInt.Sign < 0)
    {
        randomBigInt = BigInteger.Zero - randomBigInt;
    }
    return randomBigInt;
}

static bool is_prime(BigInteger num, BigInteger k)
{
    BigInteger r = num - 1;
    BigInteger s = 0;
    BigInteger x = 0;
    BigInteger a = createBigInteger(num);


    if ((num < 2) || (num % 2 == 0))
    {
        return false;
    }
    while (r % 2 == 0)
    {
        r /= 2;
        s++;
    }
    for (int i = 0; i < k; i++)
    {
        x = BigInteger.ModPow(a, r, num);
        if (x != 1 && x != num - 1)
        {
            for (int j = 1; j < s; j++)
            {
                x = BigInteger.ModPow(x, 2, num);
                if (x == 1)
                {
                    return false;
                }
                if (x == num - 1)
                {
                    break;
                }
            }
            if (x != num - 1)
            {
                return false;
            }
        }
    }
    return true;
}
static List<BigInteger> factrs(BigInteger number)
{
    List<BigInteger> factors = new List<BigInteger>();
    BigInteger divisor = 2;

    while (divisor * divisor <= number)
    {
        if (number % divisor == 0)
        {
            factors.Add(divisor);
            number /= divisor;
        }
        else
        {
            divisor += (divisor == 2) ? 1 : 2;
        }
    }
    if (number > 1)
    {
        factors.Add(number);
    }
    foreach (BigInteger factr in factors)
    {
        Console.WriteLine($"multiplier >>>  {factr}");
    }
    return factors;
}



static void Main()
{
    string pathCsvFile = "factors.csv";
    byte[] randomNumber = new byte[7];

    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
    {
        rng.GetBytes(randomNumber);
    }
    BigInteger N = new BigInteger(randomNumber);
    if (N.Sign < 0)
    {
        N = BigInteger.Zero - N;
    }
    Int16 k = 10;
    List<BigInteger> factors = new List<BigInteger>();

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    if (is_prime(N, k))
    {
        Console.WriteLine($"Number is prime >>> {N}");
        Console.WriteLine($"multipliers >>> 1, {N}");
    }
    else
    {
        Console.Write($"Number isn't prime {N}\n");
        factors = factrs(N);
    }
    stopwatch.Stop();


    Console.WriteLine($"Programm completed in {stopwatch.ElapsedMilliseconds} milliseconds");
}

 Main();



