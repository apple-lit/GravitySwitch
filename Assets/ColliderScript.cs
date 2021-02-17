using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

  public GameObject particleObject;
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
    if (GameObject.FindWithTag("collider"))
    {
      Debug.Log("GameOver");
      Instantiate(particleObject, this.transform.position, Quaternion.identity);
      Destroy(this.gameObject);
    }
  }
}
