using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyjo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int t = 0;
        string c = "";
        string [] word ={"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};

        while (t < 7)
        {
            c = c + word [Random.Range(0,9)] + " ";
            t++;
        }
        Debug.Log(c);
    }

        
  
}
