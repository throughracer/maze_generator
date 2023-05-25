using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class test : MonoBehaviour
{
    public GameObject gr;
    public GameObject up;
    public GameObject right;
    public int RAWS;
    public string y;
    // Start is called before the first frame update
    void Start()
    {
        maze(RAWS);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void maze(int x) {
       
        for(int i = 1; i<= x*x; i++)
        {
            if(Random . value > 0.5f)
            {
                y = y + "1";
            }
            else
            {
                y = y + "0";
            }
        }
        for(int w = 0;w<x;w++)
        {
            for( int h = 0; h<x;h++)
            {

                Vector3 v = new Vector3(w,0,h);
                Instantiate(gr, v, Quaternion.identity);

                if (y[w*x+h] == '0')
                {
                    Instantiate(up, v, Quaternion.identity);

                }
                if (y[w*x+h] == '1')
                {
                    Instantiate(right, v, Quaternion.identity);

                }

            }
        }
    }

}
