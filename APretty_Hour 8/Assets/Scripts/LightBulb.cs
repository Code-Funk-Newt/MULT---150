using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{   
    Light lightComponent;
    

    // Start is called before the first frame update
    void Start()
    {
       lightComponent = GetComponent<Light>();
       lightComponent.enabled = true;  

    }

    // Update is called once per frame
    void Update()
    {   



        
       
            
            

            lightComponent.enabled = Input.GetKey(KeyCode.L);   

            

        
        
        
    }
}
