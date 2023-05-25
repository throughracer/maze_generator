using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracker : MonoBehaviour
{
    public test t;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(t.RAWS / 2,35,t.RAWS/2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
