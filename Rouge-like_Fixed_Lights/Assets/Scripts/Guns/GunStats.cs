using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunStats : MonoBehaviour
{
    public float Damage;
    public int MagSize;
    public float Price;
    public float Recoil;
    public float FireDamage;
    public float ElectricDamage;
    public float ToxinDamage;
    public float AffinityChance;
    public float CriticalChance;
    public float CriticalMultiplier;
    bool onChangeDetected;
    bool critHit;

    BoxCollider2D weaponCollider;

    private void Update()
    {


        if (onChangeDetected)
        {
            int randNum = Random.Range(0, 100);
            if (randNum <= CriticalChance)
            {
                critHit = true;
            }
            if (critHit)
            {
                Damage += CriticalMultiplier * (Damage + FireDamage + ElectricDamage + ToxinDamage);
                critHit= false;
            }
            else
            {
                Damage += Damage + FireDamage + ElectricDamage + ToxinDamage;
            }
            onChangeDetected= false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void ApplyAffinitiesAndBonuses()
    {
        //Bonuses bonuses = gameObject.GetComponentInChildren<>();
    }
}
