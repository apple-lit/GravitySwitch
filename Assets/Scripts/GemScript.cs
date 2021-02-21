using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemScript : MonoBehaviour
{

  public GameObject gem;
  StartTextManager _startTextManager;

  public float count = 4.0f;
  public float speed = 3.0f;
  // Start is called before the first frame update
  void Start()
  {
    GameObject startTextObject = GameObject.Find("StartText");
    _startTextManager = startTextObject.GetComponent<StartTextManager>();
    Instantiate(gem, new Vector3(12, Random.Range(-1.0f, 5.0f), 0), Quaternion.identity);
    Instantiate(gem, new Vector3(24, Random.Range(-1.0f, 5.0f), 0), Quaternion.identity);
    print(this.transform.position);
  }

  // Update is called once per frame
  void Update()
  {
    if (_startTextManager.hasStarted == true)
    {
      count -= 1.0f * Time.deltaTime; ;
      if (count <= 0)
      {
        Instantiate(gem, new Vector3(24.0f, Random.Range(-3.0f, 5.0f), 0), Quaternion.identity);
        count = 4.0f;
      }


      GameObject[] findGem = GameObject.FindGameObjectsWithTag("gem");

      foreach (var gems in findGem)
      {

        gems.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

      }
    }
  }



}
