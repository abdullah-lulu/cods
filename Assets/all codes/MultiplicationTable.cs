using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
       for( int g = 1 ; g <= 10 ; g++ )
       
        {
            
            for(int h = 5; h==5;)
         {
           int s = Multiply(g,h);
            Debug.Log(s);
            break;
         }

         
        }




    }

    int Multiply (int h,int g)
    {
        int drb = h * g;
        return drb;
        
    }


    
}
