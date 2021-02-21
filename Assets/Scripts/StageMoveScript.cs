using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageMoveScript : MonoBehaviour
{
  // Start is called before the first frame update
  public float speed = 3.0f;
  StartTextManager _startTextManager;
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
      transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
      // print(speed);
    }
  }


}
