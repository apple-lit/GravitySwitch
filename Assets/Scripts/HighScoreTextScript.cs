using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreTextScript : MonoBehaviour
{

  GameObject highScoreTextObject;

  //   ColliderScript _colliderScript;
  // Start is called before the first frame update
  void Start()
  {
    // highScoreTextObject = GameObject.Find("HighScoreText");
    // GameObject[] endScore = GameObject.FindGameObjectsWithTag("collider");

    // foreach (var ended in endScore)
    // {
    //   _colliderScript = ended.GetComponent<ColliderScript>();

    // }

  }

  // Update is called once per frame
  void Update()
  {

    // if (_colliderScript.hasEnded = true)
    // {
    //   print(_colliderScript.hasEnded);
    // highScoreTextObject.text = highScore.ToString();
    highScoreTextObject.gameObject.SetActive(true);
    // }
  }
}
