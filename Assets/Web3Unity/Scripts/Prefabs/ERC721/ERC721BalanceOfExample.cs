using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC721BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x88B48F654c30e99bc2e4A1559b4Dcf1aD93FA656";
        string account = "0x05099B0DB63fD592E09eE8Bc376D8E64A4c6d129";

        int balance = await ERC721.BalanceOf(chain, network, contract, account);
        print(balance);
    }
}
