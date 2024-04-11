using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{

    private float itemScale = 1;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Input.GetAxis("Horizontal") * .5F, 0F, Input.GetAxis("Vertical") * .5F);
		transform.Rotate(Input.GetAxis("Mouse Y") * 3F, -Input.GetAxis("Mouse X") * 3F, 0F);
		if(Input.GetKey(KeyCode.N))
			itemScale -= .1F;
		else if(Input.GetKey(KeyCode.M))
			itemScale += .1F;
		transform.localScale = new Vector3(itemScale, itemScale, itemScale);
	
    }
}
