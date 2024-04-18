using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoal : MonoBehaviour
{
   int x = 0;
   public bool chaosWins = false;
   void OnTriggerEnter (Collider chaosball)
   {
        GameObject collidedWith = chaosball.gameObject;
        if(collidedWith.tag == gameObject.tag)
        {
            x += 1;
            Destroy (collidedWith);
        }

        if(x >= 4){
            GetComponent<Light>().enabled = false;
             chaosWins = true;
        }

   }
}
