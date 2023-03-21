using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float Health;
    public GameObject player;
    public float Money;
    private float value;

    // Start is called before the first frame update
    void Start()
    {
        Health = player.GetComponent<PlayerStats>().Health;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<CoinScript>(out CoinScript CoinValue))
        {
            value = CoinValue.GetComponent<CoinScript>().value;
            Money += value;
        }
    }


}
