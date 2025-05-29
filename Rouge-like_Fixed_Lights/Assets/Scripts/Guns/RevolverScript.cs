using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RevolverScript : MonoBehaviour
{
    public Sprite revolver1;
    public Sprite revolver2;
    int cycle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnShootChanged();
    }

    void OnShootChanged()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (cycle == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = revolver1;
                cycle = 0;
            }
            if (cycle == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = revolver2;
                cycle = 1;
            }
           
        }
    }
}
