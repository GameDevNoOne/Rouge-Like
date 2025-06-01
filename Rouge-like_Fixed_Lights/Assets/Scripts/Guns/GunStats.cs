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

    BoxCollider2D weaponCollider;

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void ApplyAffinitiesAndBonuses()
    {
        //Bonuses bonuses = gameObject.GetComponentInChildren<>();
    }
}
