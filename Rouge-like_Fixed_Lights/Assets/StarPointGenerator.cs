using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPointGenerator : MonoBehaviour
{
    public float XminRange;
    public float YminRange;
    public float XmaxRange;
    public float YmaxRange;

    public GameObject point;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        GenerateField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateField()
    {
        Spawner.transform.position = new Vector3(XminRange, YminRange, 0);
        for (float i = XminRange; i < XmaxRange; i++)
        {
            for (float j = YminRange; j < YmaxRange; j++)
            {
                Spawner.transform.position = new Vector3(i, j, 0);
                Instantiate(point, Spawner.transform.position, Spawner.transform.rotation, gameObject.transform);
            }
        }
    }
}
