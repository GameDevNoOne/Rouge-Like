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

    public GameObject spawnHandler;

    public Transform[] boxPoints;
    public Transform[] ChestPoints;
    public Transform[] wallPoints;
    private bool generate = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        boxPoints = spawnHandler.GetComponent<SpawnEnvirounment>().boxSpawnLocs;
        ChestPoints = spawnHandler.GetComponent<SpawnEnvirounment>().chestSpawnLocs;
        wallPoints = spawnHandler.GetComponent<SpawnEnvirounment>().wallSpawnLocs;
        if (generate)
        {
            GenerateField();
        }
    }

    public void GenerateField()
    {
        Spawner.transform.position = new Vector3(XminRange, YminRange, 0);
        for (float i = XminRange; i < XmaxRange; i++)
        {
            for (float j = YminRange; j < YmaxRange; j++)
            {
                Spawner.transform.position = new Vector3(i, j, 0);
                if (CheckGenerationPossibility(boxPoints, i, j))
                {
                    if (CheckGenerationPossibility(ChestPoints, i, j))
                    {
                        if (CheckGenerationPossibility(wallPoints, i, j))
                        {
                            Instantiate(point, Spawner.transform.position, Spawner.transform.rotation, gameObject.transform);
                        }
                    }
                }
            }
        }
        generate = false;
    }

    bool CheckGenerationPossibility(Transform[] points, float xCoordinate, float yCoordinate)
    {
        bool canGenerate = true;
        for (int i = 0; i < points.Length; i++)
        {
            if (xCoordinate == points[i].position.x)
            {
                if (yCoordinate == points[i].position.y)
                {
                    canGenerate = false;
                }
            }
        }
        return canGenerate;
    }
}
