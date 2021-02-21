using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderScript : MonoBehaviour
{

  public GameObject particleObject;
  GameObject Cube;
  //   StageMoveScript _stageStop;
  StageMoveScript _stageMoveScript;
  StageManagerScript _stageManagerScript;

  GemScript _gemScript;
  PlayerScript _playerScript;

  public bool hasEnded = false;

  public int highScore = 0;

  Rigidbody _rb;

  // Start is called before the first frame update
  void Start()
  {
    // highScore = PlayerPrefs.GetInt("SCORE", 0);

  }

  // Update is called once per frame
  void Update()
  {
    print(highScore);
  }
  void OnCollisionEnter(Collision collision)
  {
    if (this.gameObject.transform.position.x > -24)
    {
      Debug.Log("GameOver");
      hasEnded = true;
      // print(hasEnded);
      Instantiate(particleObject, this.transform.position, Quaternion.identity);
      GameObject[] stop = GameObject.FindGameObjectsWithTag("stage");
      GameObject noMoreStage = GameObject.Find("StageManager");
      _stageManagerScript = noMoreStage.GetComponent<StageManagerScript>();
      _stageManagerScript.countDown = 200000;

      GameObject[] gemsStop = GameObject.FindGameObjectsWithTag("gem");
      GameObject gemManager = GameObject.Find("GemManager");

      Destroy(collision.gameObject);
      foreach (var gems in gemsStop)
      {
        _gemScript = gemManager.GetComponent<GemScript>();
        _gemScript.speed = 0;
        _gemScript.count = 200000;
      }

      foreach (var stage in stop)
      {
        _stageMoveScript = stage.GetComponent<StageMoveScript>();
        _stageMoveScript.speed = 0;
      }

      // Destroy(this.gameObject);
      GameObject childParticle = GameObject.Find("ParticleOnPlayer");
      Destroy(childParticle);
      _rb = GameObject.Find("Cube").GetComponent<Rigidbody>();
      _rb.useGravity = false;


      GameObject cubeScore = GameObject.Find("Cube");
      _playerScript = cubeScore.GetComponent<PlayerScript>();


      if (highScore < _playerScript.score)
      {
        highScore = _playerScript.score;

        PlayerPrefs.SetInt("SCORE", highScore);
        PlayerPrefs.Save();

      }

      // print("your highscore: " + highScore);

      print(PlayerPrefs.GetInt("SCORE", highScore));


    }



  }
}
