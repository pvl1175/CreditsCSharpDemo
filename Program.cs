using NodeApi;
using System;
using Thrift.Protocol;
using Thrift.Transport;

namespace CreditsCSAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Credits API Simple Demo");

            var publicKey = "5B3YXqDTcWQFGAqEJQJP3Bg1ZK8FFtHtgCiFLT5VAxpe";
            var publicKeyBytes = SimpleBase.Base58.Bitcoin.Decode(publicKey).ToArray();

            using (var transport = new TSocket("169.38.89.217", 9090))
            {
                using (var protocol = new TBinaryProtocol(transport))
                {
                    using (var client = new API.Client(protocol))
                    {
                        transport.Open();

                        var balance = client.WalletBalanceGet(publicKeyBytes);
                        Console.WriteLine($"[{publicKey}] Balance: {balance.Balance.ToString()}");
                    }
                }
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
