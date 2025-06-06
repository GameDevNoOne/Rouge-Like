using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    public BoxCollider2D trigger;
    public Sprite openChest;
    public GameObject rewardPool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float playerLevel = collision.gameObject.GetComponent<PlayerStats>().Level;
            OpenChest(playerLevel);
        }
    }

    void OpenChest(float playerLevel)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
        SummonRewards(playerLevel);
    }

    void SummonRewards(float playerLevel)
    {
        Debug.Log("Chest opened");
    }
}
