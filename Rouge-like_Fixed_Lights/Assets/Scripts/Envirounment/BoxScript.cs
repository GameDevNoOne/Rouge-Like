using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float Health;

    public Sprite[] sprites;
    public BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
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

    public void TakeDamage(float damage, float fireDamage, float electricDamage, float toxinDamage,float affinityChance, float criticalChance, float criticalMultiplier)
    {
        Health -= damage;
    }
}
