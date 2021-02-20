using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ColliderScript : MonoBehaviour
{

  public GameObject particleObject;
  GameObject Cube;
  //   StageMoveScript _stageStop;
  StageMoveScript _stageMoveScript;
  StageManagerScript _stageManagerScript;

  GemScript _gemScript;
  PlayerScript _playerScript;

  // public int highScore;
  // public List<int> highScoreList = new List<int>();


  Rigidbody _rb;
  //   public Text gameOverText;

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
      GameObject[] stop = GameObject.FindGameObjectsWithTag("stage");
      GameObject noMoreStage = GameObject.Find("StageManager");
      _stageManagerScript = noMoreStage.GetComponent<StageManagerScript>();
      _stageManagerScript.countDown = 200000;

      GameObject[] gemsStop = GameObject.FindGameObjectsWithTag("gem");
      GameObject gemManager = GameObject.Find("GemManager");


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

      Destroy(this.gameObject);
      GameObject childParticle = GameObject.Find("ParticleOnPlayer");
      Destroy(childParticle);
      _rb = GameObject.Find("Cube").GetComponent<Rigidbody>();
      _rb.useGravity = false;


      // GameObject highScore = GameObject.Find("Cube");
      // _playerScript = highScore.GetComponent<PlayerScript>();

      // highScoreList.Add(_playerScript.score);

      // highScore = highScoreList.Max();

      // print(highScore);
    }
  }
}
