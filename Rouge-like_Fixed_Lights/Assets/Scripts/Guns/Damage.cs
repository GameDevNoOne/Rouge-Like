using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private float Damag;
    public GameObject Gun;

    private float FireDamage;
    private float ElectricDamage;
    private float ToxinDamage;
    private float AffinityChance;
    private float CriticalChance;
    private float CriticalMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        Damag = Gun.GetComponent<GunStats>().Damage;
        FireDamage = Gun.GetComponent<GunStats>().FireDamage;
        ElectricDamage = Gun.GetComponent <GunStats>().ElectricDamage;
        ToxinDamage = Gun.GetComponent<GunStats>().ToxinDamage;
        AffinityChance = Gun.GetComponent<GunStats>().AffinityChance;
        CriticalChance = Gun.GetComponent<GunStats>().CriticalChance;
        CriticalMultiplier = Gun.GetComponent<GunStats>().CriticalMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damag);
        }
        if (collision.gameObject.TryGetComponent<BoxScript>(out BoxScript box))
        {
            box.TakeDamage(Damag, FireDamage, ElectricDamage, ToxinDamage, AffinityChance, CriticalChance, CriticalMultiplier);
        }
        Destroy(gameObject);
    }
}
