using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
  bool gravityUp = false;
  public Text scoreText;
  public int score;

  public bool hasEnded = false;

  Rigidbody _rb;

  StartTextManager _startTextManager;
  // Start is called before the first frame update
  void Start()
  {
    GameObject startTextObject = GameObject.Find("StartText");
    _startTextManager = startTextObject.GetComponent<StartTextManager>();
  }
  // Update is called once per frame
  void Update()
  {
    if (_startTextManager.hasStarted == true)
    {
      _rb = this.GetComponent<Rigidbody>();
      _rb.useGravity = true;

      if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
      {
        if (gravityUp == false)
        {
          Physics.gravity = new Vector3(0, 12, 0);
          Debug.Log("Gravity Up Mode");
          gravityUp = true;
          Debug.Log(gravityUp);
        }
        else if (gravityUp == true)
        {
          Physics.gravity = new Vector3(0, -12, 0);
          Debug.Log("Gravity Down Mode");
          gravityUp = false;
        }
      }
    }
  }


  void OnTriggerEnter(Collider other)
  {

    if (other.CompareTag("gem"))
    {
      score += 1;
      scoreText.text = score.ToString();
      Destroy(other.gameObject);
    }
    // }


  }

}
