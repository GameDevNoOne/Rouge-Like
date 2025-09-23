using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculation : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Mathf.Pow((Player.transform.position.x - this.transform.position.x), 2) + Mathf.Pow((Player.transform.position.y - this.transform.position.y), 2);
    }
}
