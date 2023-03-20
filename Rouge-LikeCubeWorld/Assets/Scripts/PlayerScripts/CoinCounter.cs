using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] public TMP_Text coinCounter;
    private float Money;

    // Update is called once per frame
    void Update()
    {
        Money = GetComponent<PlayerActions>().Money;
        string MoneyOut = Money.ToString();
        coinCounter.text = (MoneyOut);
    }
}
