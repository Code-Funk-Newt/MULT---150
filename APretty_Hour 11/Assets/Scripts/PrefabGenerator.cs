using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
      public GameObject prefab;

        
      void Start(){
            int x = 0;
            

            for(int i = 0; i < 10; i++){
                x =- 2;

                transform.position = transform.position + new Vector3(x,0,0);
                
                Instantiate(prefab, transform.position, transform.rotation);
            }
        }

      void Update()
      {

          if (Input.GetKeyDown(KeyCode.B)){
               Instantiate(prefab);
          }

          if (Input.GetKeyDown(KeyCode.Space))
          {

               Instantiate(prefab, new Vector3(1,0,-5), transform.rotation);
          }
      }

}