using NodeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace CreditsCSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicKey = "5B3YXqDTcWQFGAqEJQJP3Bg1ZK8FFtHtgCiFLT5VAxpe";
            var publicKeyBytes = SimpleBase.Base58.Bitcoin.Decode(publicKey).ToArray();

            try
            {
                using (var transport = new TSocket("127.0.0.1", 9090))
                {
                    using (var protocol = new TBinaryProtocol(transport))
                    {
                        using (var client = new API.Client(protocol))
                        {
                            transport.Open();

                            var balance = client.WalletBalanceGet(publicKeyBytes);
                            Console.WriteLine($"[{publicKey}] Balance Integral: {balance.Balance.Integral}");
                            Console.WriteLine($"[{publicKey}] Balance Fraction: {balance.Balance.Fraction}");
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
