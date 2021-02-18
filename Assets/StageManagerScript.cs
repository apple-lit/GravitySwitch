using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManagerScript : MonoBehaviour
{

  public GameObject stageTop01;
  public GameObject stageTop02;
  public GameObject stageTop03;
  public GameObject stageTop04;
  public GameObject stageTop05;
  public GameObject stageTop06;
  public GameObject stageButtom01;
  public GameObject stageButtom02;
  public GameObject stageButtom03;
  public GameObject stageButtom04;
  public GameObject stageButtom05;
  public GameObject stageButtom06;
  public float stageSpeed = 3.0f;

  private float countDown = 4.0f;


  // ステージ用の配列
  GameObject[] stageTopArray = new GameObject[6];
  GameObject[] stageButtomArray = new GameObject[6];

  // Start is called before the first frame update
  void Start()
  {
    // ステージをランダムで取得するための変数
    // int stageTopNum = Random.Range(0, 6);
    // int stageButtomNum = Random.Range(0, 6);

    // 上側のステージ
    stageTopArray[0] = stageTop01;
    stageTopArray[1] = stageTop02;
    stageTopArray[2] = stageTop03;
    stageTopArray[3] = stageTop04;
    stageTopArray[4] = stageTop05;
    stageTopArray[5] = stageTop06;

    // 下側のステージ
    stageButtomArray[0] = stageButtom01;
    stageButtomArray[1] = stageButtom02;
    stageButtomArray[2] = stageButtom03;
    stageButtomArray[3] = stageButtom04;
    stageButtomArray[4] = stageButtom05;
    stageButtomArray[5] = stageButtom06;

    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(-36, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(-24, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(-12, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(0, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(12, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(24, 1, -10), Quaternion.identity);
    Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(36, 1, -10), Quaternion.identity);

    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(-36, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(-24, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(-12, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(0, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(12, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(24, -10, -10), Quaternion.identity);
    Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(36, -10, -10), Quaternion.identity);

  }

  // Update is called once per frame
  void Update()
  {
    countDown -= 1.0f * Time.deltaTime;
    if (countDown <= 0.0f)
    {
      Instantiate(stageTopArray[Random.Range(0, 6)], new Vector3(36, 1, -10), Quaternion.identity);
      Instantiate(stageButtomArray[Random.Range(0, 6)], new Vector3(36, -10, -10), Quaternion.identity);
      countDown = 4.0f;
    }

  }
}
