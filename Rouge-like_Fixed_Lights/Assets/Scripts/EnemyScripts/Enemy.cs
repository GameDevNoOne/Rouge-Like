using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("BaseStatsAndDrops")]
    private float Health;
    private float RemainingHealth;
    public GameObject MoneyDrop;
    public Transform MoneyDropPos;
    public GameObject expDrop;
    public Transform expDropPos;
    private float FireResistance;
    private float ElectricResistance;
    private float ToxinResistance;
    private float localFireDamage;
    private float localElectricDamage;
    private float localToxinDamage;

    [Header("Statuses")]
    public bool isOnFire;
    public bool isOnElectric;
    public bool isOnToxin;
    private float StatusDuration;
    // Start is called before the first frame update
    void Start()
    {
        Health = gameObject.GetComponent<EnemyStats>().Life;
        FireResistance = gameObject.GetComponent<EnemyStats>().FireResistance;
        ElectricResistance = gameObject.GetComponent<EnemyStats>().ElectricResistance;
        ToxinResistance = gameObject.GetComponent<EnemyStats>().ToxinResistance;
        StatusDuration = gameObject.GetComponent<EnemyStats>().StatusDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnFire)
        {
            OnFire();
        }
        if (isOnElectric)
        {
            OnElectric();
        }
        if (isOnToxin) 
        {
            OnToxin();
        }
    }

    public void TakeDamage(float damage, float fireDamage, float electricDamage, float toxinDamage, float criticalChance, float criticalMultiplier, float affinityChance)
    {
        localFireDamage = fireDamage;
        localElectricDamage = electricDamage;
        localToxinDamage = toxinDamage;

        float calculatedDamage = damage + fireDamage * (FireResistance/100) + electricDamage * (ElectricResistance/100) + toxinDamage * (ToxinResistance/100);
        float crit = Random.Range(0, 100);
        float affinity = Random.Range(0, 100);
        if (crit <= criticalChance)
        {
            calculatedDamage *= criticalMultiplier;
        }
        if (fireDamage != 0)
        {
            if (affinity <= affinityChance * FireResistance/100)
            {
                isOnFire = true;
            }
        }
        if (electricDamage != 0)
        {
            if (affinity <= affinityChance * ElectricResistance/100)
            {
                isOnElectric = true;
            }
        }
        if (toxinDamage != 0)
        {
            if (affinity <= affinityChance * ToxinResistance/100)
            {
                isOnToxin = true;
            }
        }
        Health -= calculatedDamage;
        if (Health >= 0)
        {
            int numberOfCoins = Random.Range(0, 6);
            for (var i = 0;i < numberOfCoins; i++)
            {
                Instantiate(MoneyDrop, gameObject.transform.position, gameObject.transform.rotation);
            }
            Instantiate(expDrop, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnFire()
    {
        float startStatusDuration = StatusDuration;
        while (StatusDuration >= 0)
        {
            TakeDamage(0, localFireDamage, localElectricDamage, localToxinDamage, 0, 0, 0);
            StatusDuration -= Time.deltaTime;
        }
        isOnFire = false;
        StatusDuration = startStatusDuration;
    }

    void OnElectric()
    {
        float startStatusDuration = StatusDuration;
        while (StatusDuration >= 0)
        {
            TakeDamage(0, localFireDamage, localElectricDamage, localToxinDamage, 0, 0, 0);
            StatusDuration -= Time.deltaTime;
        }
        isOnElectric = false;
        StatusDuration = startStatusDuration;
    }


    void OnToxin()
    {
        float startStatusDuration = StatusDuration;
        while (StatusDuration >= 0)
        {
            TakeDamage(0, localFireDamage, localElectricDamage, localToxinDamage, 0, 0, 0);
            StatusDuration -= Time.deltaTime;
        }
        isOnToxin = false;
        StatusDuration = startStatusDuration;
    }
}
