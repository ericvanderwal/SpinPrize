using UnityEngine;
using Beamable;
using Beamable.Server.Clients;
using Nethereum.Signer;

public class ValidateLogin : MonoBehaviour
{
    public string walletAddress = "0xd2667348b7c1372c0d5cfd301a65ffa19c5cd949";
    public string message = "Sign in to verify wallet";
    public string transactionHash =
        "0x260f40481c82e30d9e7097acd89f30922cea8c0cd7173db9f9f6bfd2fae34c511e73a3aa665cc32df02a679e0684177c1a2373621c3942caf042375bd55d76e31b";

    // Start is called before the first frame update
    void Start()
    {

      // EthECKey ecKey = EthECKey.GenerateKey();

    }

    public async void ValidateHash()
    {
        Debug.Log("Micro Connecting");

        var ctx = BeamContext.Default;
        await ctx.OnReady;
        var result = await ctx.Microservices().Validation().ValidateHash(walletAddress, message, transactionHash);

        Debug.Log($"Result:{result}");
    }

}