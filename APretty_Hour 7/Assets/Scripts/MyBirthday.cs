using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int month = 1;
    int day = 1;
    void Update()
    {
        for(int i = 0; month <= 12; month++){
                
                if(month != 7){
                    print(month);
                }


               else if(month == 7){
                  print("Its my Birthday!");

                    for(int z = 0; day <= 31; day++){
                        if(day == 20){
                           print("    Its My Birthday!");
                        }
                        else{
                            print("    " + day);
                        }
                }
            }


        }
    }
}
