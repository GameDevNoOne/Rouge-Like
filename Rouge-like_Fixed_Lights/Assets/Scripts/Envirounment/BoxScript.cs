using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float Health;

    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health -= collision.gameObject.GetComponentInParent<GunStats>().Damage;
        }
    }

    void CheckHealth()
    {
        if (Health <= Health * 3 / 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        if (Health <= Health / 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        if (Health <= Health / 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
        }
        if (Health <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
            gameObject.GetComponent<SpriteRenderer>().renderingLayerMask = 2;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
