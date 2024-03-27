using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reading in User Input
        
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if(hVal != 0)
            print("Horizontal movement selected: "+ hVal);
            
        if(vVal != 0)
            print("Vertical movement selected: "+ vVal);
        

        // Reading Specific Key Presses

        if(Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down");
        
        if(Input.GetKeyDown(KeyCode.O))
            print("The 'O' key was pressed");

        //Reading Mouse Movement

        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if(mxVal != 0)
            print("Mouse X movement selected: "+ mxVal);
        if(myVal != 0)
            print("Mouse Y movement seletcted: "+ myVal);
    }
}
