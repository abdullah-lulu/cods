using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomeee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    int times = 0;
    
    
    while (times < 20)
    {
        int num = Random.Range(1,20);
        Debug.Log(num);
        times++;

        if (num == 5)
        {
            continue;

        }

        
        if (num == 15)
        {
            break;

        }
    }

    
    }
}
