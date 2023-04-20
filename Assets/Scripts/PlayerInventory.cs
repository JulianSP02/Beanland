using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int coinNumber;

    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinCollected()
    {
        coinNumber++;
        OnCoinCollected.Invoke(this);
    }
}
