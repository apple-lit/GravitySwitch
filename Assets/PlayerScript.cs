using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool gravityUp = false;
    // public GameObject stageTop01;
    // public GameObject stageTop02;
    // public GameObject stageTop03;
    // public GameObject stageTop04;
    // public GameObject stageButtom01;
    // public GameObject stageButtom02;
    // public GameObject stageButtom03;
    // public GameObject stageButtom04;
    // public float stageSpeed = 3.0f;

    // // ステージ用の配列
    // GameObject[] stageTopArray = new GameObject[5];
    // GameObject[] stageButtomArray = new GameObject[5];



    // Start is called before the first frame update
    void Start()
    {

    // // ステージをランダムで取得するための変数
    // int stageTopNum = Random.Range(0,6);

    // // 上側のステージ
    // stageTopArray[0] = GameObject.Find("StageTop1");
    // stageTopArray[1] = GameObject.Find("StageTop2");
    // stageTopArray[2] = GameObject.Find("StageTop3");
    // stageTopArray[3] = GameObject.Find("StageTop4");
    // stageTopArray[4] = GameObject.Find("StageTop5");
    // stageTopArray[5] = GameObject.Find("StageTop6");

    // // 下側のステージ
    // stageButtomArray[0] = GameObject.Find("StageButtom1");
    // stageButtomArray[1] = GameObject.Find("StageButtom2");
    // stageButtomArray[2] = GameObject.Find("StageButtom3");
    // stageButtomArray[3] = GameObject.Find("StageButtom4");
    // stageButtomArray[4] = GameObject.Find("StageButtom5");
    // stageButtomArray[5] = GameObject.Find("StageButtom6");
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

            // stageTop01.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageButtom01.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageTop02.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageButtom02.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageTop03.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageButtom03.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageTop04.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);
            // stageButtom04.transform.position += new Vector3(-stageSpeed * Time.deltaTime,0,0);

            // if(stageTop01.transform.position.x <= -24){
            //     stageTop01.transform.position = new Vector3(24,1,-10);
            // }else if(stageTop02.transform.position.x <= -24){
            //     stageTop02.transform.position = new Vector3(24,1,-10);
            // }else if (stageTop03.transform.position.x <= -24){
            //     stageTop03.transform.position = new Vector3(24,1,-10);
            // }else if (stageTop04.transform.position.x <= -24){
            //     stageTop04.transform.position = new Vector3(24,1,-10);
            // }

            // if(stageButtom01.transform.position.x <= -24){
            //     stageButtom01.transform.position = new Vector3(24,-10,-10);
            // }else if(stageButtom02.transform.position.x <= -24){
            //     stageButtom02.transform.position = new Vector3(24,-10,-10);
            // }else if(stageButtom03.transform.position.x <= -24){
            //     stageButtom03.transform.position = new Vector3(24,-10,-10);
            // }else if(stageButtom04.transform.position.x <= -24){
            //     stageButtom04.transform.position = new Vector3(24,-10,-10);
            // }



        // if(Input.GetKey(KeyCode.RightArrow)){
        //     transform.position += new Vector3(1,0,0) * Time.deltaTime;
        // }
    }


}
