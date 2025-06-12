using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expScript : MonoBehaviour
{
    public float value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerActions>(out PlayerActions player))
        {
            Destroy(gameObject);
        };
    }
}
