using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

  public GameObject particleObject;
  //   StageMoveScript _stageStop;
  StageMoveScript _stageMoveScript;
  StageManagerScript _stageManagerScript;
  public Text gameOverText;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
  void OnCollisionEnter(Collision collision)
  {
    if (this.gameObject.transform.position.x > -24)
    {
      Debug.Log("GameOver");
      Instantiate(particleObject, this.transform.position, Quaternion.identity);
      //   _stageStop = GameObject.FindWithTag("stage").GetComponent<StageMoveScript>();
      //   _stageStop.speed = 0;
      GameObject[] stop = GameObject.FindGameObjectsWithTag("stage");
      GameObject noMoreStage = GameObject.Find("StageManager");
      _stageManagerScript = noMoreStage.GetComponent<StageManagerScript>();
      _stageManagerScript.countDown = 200000;

      foreach (var stage in stop)
      {
        _stageMoveScript = stage.GetComponent<StageMoveScript>();
        _stageMoveScript.speed = 0;
      }

      Destroy(this.gameObject);
      GameObject childParticle = GameObject.Find("ParticleOnPlayer");
      Destroy(childParticle);
      gameOverText = SetActive(true);
    }
  }
}
