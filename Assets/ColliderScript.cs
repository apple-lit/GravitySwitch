using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

  public GameObject particleObject;
  StageMoveScript _stageStop;

  // Start is called before the first frame update
  void Start()
  {
    _stageStop = GameObject.FindWithTag("stage").GetComponent<StageMoveScript>();
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
      _stageStop.speed = 0;
      Destroy(this.gameObject);

    }
  }
}
