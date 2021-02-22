using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HighScoreTextScript : MonoBehaviour
{

  // Start is called before the first frame update
  public Text gameOverText;
  ColliderScript _colliderScript;

  PlayerScript _playerScript;
  void Start()
  {
    GameObject playerHasEnded = GameObject.Find("Cube");
    _playerScript = playerHasEnded.GetComponent<PlayerScript>();
  }

  // Update is called once per frame
  void Update()
  {

    GameObject[] highScoreCollider = GameObject.FindGameObjectsWithTag("collider");

    foreach (var scoreholder in highScoreCollider)
    {
      _colliderScript = scoreholder.GetComponent<ColliderScript>();

    }



    // print("hasEnded?" + _colliderScript.hasEnded);
    // print(_colliderScript.hasEnded);
    if (_playerScript.hasEnded == true)
    {
      //   print("hasEnded?" + _colliderScript.hasEnded);
      //   print(_colliderScript.hasEnded);
      gameOverText.text = "High Score : " + PlayerPrefs.GetInt("SCORE", _colliderScript.highScore).ToString() + "\n Click anywhere to Restart";
      //   print(PlayerPrefs.GetInt("SCORE", _colliderScript.highScore));

      gameOverText.enabled = true;
      if (Input.GetMouseButtonDown(0))
      {
        SceneManager.LoadScene("Main");
      }
    }
    else
    {
      gameOverText.enabled = false;
    }
  }
}
