using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICounters : MonoBehaviour
{
    [SerializeField] public TMP_Text coinCounter;
    private float Money;
    [SerializeField] public TextMeshProUGUI bulletCounter;
    private float bullets;
    private GameObject Weapon;

    // Update is called once per frame
    void Update()
    {
        Coincounter();
    }

    public void Coincounter()
    {
        Money = GetComponent<PlayerActions>().Money;
        string MoneyOut = Money.ToString();
        string moneyOut = (MoneyOut);
        coinCounter.text = moneyOut;
    }
}
