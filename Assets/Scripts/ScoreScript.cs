using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

  public Text scoreText;

  public int score = 0;
  // Start is called before the first frame update
  void Start()
  {
    print(score);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {

    if (other.CompareTag("Player"))
    {
      score += 1;
      print(score);
      scoreText.text = "Score\t : " + score.ToString();
    }
  }
}
