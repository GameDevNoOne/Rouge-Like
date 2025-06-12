using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    public BoxCollider2D trigger;
    public Sprite openChest;
    public GameObject rewardPool;
    List<GameObject> rewards;
    bool hasSpawned;
    // Start is called before the first frame update
    void Start()
    {
        rewardPool = GameObject.FindGameObjectWithTag("RewardPool");
        rewards = rewardPool.GetComponent<RewardPool>().rewards;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasSpawned)
            {
                float playerLevel = collision.gameObject.GetComponent<PlayerStats>().Level;
                OpenChest(playerLevel);
                hasSpawned = true;
            }
        }
    }

    void OpenChest(float playerLevel)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
        SummonRewards(playerLevel);
    }

    void SummonRewards(float playerLevel)
    {
        int i = Random.Range(0, 100);
        if (i >= rewards.Count/2)
        {
            Instantiate(rewards[0], gameObject.transform.position, gameObject.transform.rotation);
        }
        else
        {
            Instantiate(rewards[1], gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
