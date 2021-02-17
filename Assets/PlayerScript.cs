using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool gravityUp = false;
    public GameObject stageTop01;
    public GameObject stageTop02;
    public GameObject stageTop03;
    public GameObject stageTop04;
    public GameObject stageButtom01;
    public GameObject stageButtom02;
    public GameObject stageButtom03;
    public GameObject stageButtom04;
    public float stageSpeed = 3.0f;
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

            stageTop01.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageButtom01.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageTop02.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageButtom02.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageTop03.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageButtom03.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageTop04.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            stageButtom04.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);

            if(stageTop01.transform.position.x <= -24){
                stageTop01.transform.position = new Vector3(24,1,-10);
            }else if(stageTop02.transform.position.x <= -24){
                stageTop02.transform.position = new Vector3(24,1,-10);
            }else if (stageTop03.transform.position.x <= -24){
                stageTop03.transform.position = new Vector3(24,1,-10);
            }else if (stageTop04.transform.position.x <= -24){
                stageTop04.transform.position = new Vector3(24,1,-10);
            }

            if(stageButtom01.transform.position.x <= -24){
                stageButtom01.transform.position = new Vector3(24,-10,-10);
            }else if(stageButtom02.transform.position.x <= -24){
                stageButtom02.transform.position = new Vector3(24,-10,-10);
            }else if(stageButtom03.transform.position.x <= -24){
                stageButtom03.transform.position = new Vector3(24,-10,-10);
            }else if(stageButtom04.transform.position.x <= -24){
                stageButtom04.transform.position = new Vector3(24,-10,-10);
            }



        // if(Input.GetKey(KeyCode.RightArrow)){
        //     transform.position += new Vector3(1,0,0) * Time.deltaTime;
        // }
    }


}
