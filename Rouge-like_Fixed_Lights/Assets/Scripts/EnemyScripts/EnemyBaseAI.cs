using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseAI : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] int MinPlayerDistance;
    float Distance;
    public Transform Target;
    Transform currentPoint;

    public GameObject AStarGrid;
    public Transform[] AStarPoints;

    // Start is called before the first frame update
    void Start()
    {
        AStarPoints = AStarGrid.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Mathf.Pow((Player.transform.position.x - this.transform.position.x), 2) + Mathf.Pow((Player.transform.position.y - this.transform.position.y), 2);
        FindCurrentLoc();
        Target = SearchNewTarget(currentPoint);
        CreatePath();
        Move();
    }

    Transform SearchNewTarget(Transform currTarget)
    {
        Transform newTarget = currTarget;
        return newTarget;
    }

    public void Move()
    {

    }

    public void CreatePath()
    {

    }

    void FindCurrentLoc()
    {
        foreach (Transform point in AStarPoints)
        {
            if (this.transform.position == point.position)
            {
                currentPoint = point;
            }
        }
    }
}
