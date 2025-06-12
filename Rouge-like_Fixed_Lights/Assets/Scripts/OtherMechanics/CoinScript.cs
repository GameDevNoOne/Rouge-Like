using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider>().CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
