using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int CoinsToAdd;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)

            return;

        ItemManager.AddCoins(CoinsToAdd);
        Destroy(gameObject);
    }
}
