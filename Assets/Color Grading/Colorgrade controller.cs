using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorgradecontroller : MonoBehaviour
{
    
    public ScreenCameraShader3 SCS3;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
          
            SCS3.enabled = false;
          
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SCS3.enabled = true;
        }

     
    }
}
