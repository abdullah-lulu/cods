using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Exercise 1

        int a = 1;
        
        while(a <= 20)
        {
         int b = Random.Range(1 , 20);
         if(b == 5) {continue;}
         Debug.Log (b);
         a++;
         if(b == 15) {break;}
    }

    
}
}