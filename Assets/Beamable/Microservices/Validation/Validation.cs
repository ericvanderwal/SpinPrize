using System;
using System.Security.Cryptography;
using Beamable.Common;
using Beamable.Server;


namespace Beamable.Microservices
{
    [Microservice("Validation")]
    public class Validation : Microservice
    {
        [ClientCallable]
        public bool ValidateHash(string walletAddress, string message, string transactionHash)
        {
          //  var signer = new EthereumMessageSigner();
            // var addressRecovered = signer.EncodeUTF8AndEcRecover(message, transactionHash);
            // return string.Equals(addressRecovered, walletAddress, StringComparison.OrdinalIgnoreCase);

            return true;
        }
    }
}