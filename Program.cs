using System.Numerics;
using Nethereum.Contracts.Standards.ERC721.ContractDefinition;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;

Console.WriteLine("Hello, World!");

var privateKey = "0xb5b1870957d373ef0eeffecc6e4812c0fd08f554b37b233526acc331bf1544f7";
var account = new Account(privateKey);

var web3 = new Web3(account,"https://bsc.publicnode.com/");

var contractAddress = "0x53607C4a966f79d3ab1750180E770B0bFD493f46";

var balanceOfFunctionMessage = new BalanceOfFunction()
{
    Owner = "0x854102Fa4d35d1f240a9CBD8755491555Bad2c7B"
};

var balanceHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
var balance = await balanceHandler.QueryAsync<BigInteger>(contractAddress, balanceOfFunctionMessage);

var balanceFromWei =  Web3.Convert.FromWei(balance);

Console.WriteLine($"Balance is : {balanceFromWei}");