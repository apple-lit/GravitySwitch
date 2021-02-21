using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTextManager : MonoBehaviour
{

  public GameObject startText;
  public bool hasStarted = false;
  // Start is called before the first frame update

  void Awake()
  {
    startText = GameObject.Find("StartText");
  }
  void Start()
  {


  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      startText.gameObject.SetActive(false);
      hasStarted = true;
    }
  }
}
