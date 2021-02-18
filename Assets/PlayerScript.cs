using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool gravityUp = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            if( gravityUp == false){
                Physics.gravity = new Vector3(0,12,0);
                Debug.Log("Gravity Up Mode");
                gravityUp = true;
                Debug.Log(gravityUp);
            }else if (gravityUp == true){
                Physics.gravity = new Vector3(0,-12,0);
            Debug.Log("Gravity Down Mode");
            gravityUp = false;
            }
        }
    }

}
