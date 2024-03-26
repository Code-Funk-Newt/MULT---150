using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    int count = 22;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
          while(count <= 100){

                 if (count % 2 == 0){
                    print(count); }
            
            count = count + 1;
            
        }
    }
}
