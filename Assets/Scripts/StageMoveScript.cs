﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMoveScript : MonoBehaviour
{
  // Start is called before the first frame update
  public float speed = 3.0f;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    // print(speed);
  }


}
