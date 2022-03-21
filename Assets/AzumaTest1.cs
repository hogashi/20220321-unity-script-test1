using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzumaTest1 : MonoBehaviour
{
  // Start is called before the first frame update
  public string myName;
  public GameObject targetCube;

  void Start()
  {
    BoxCollider boxCollider = GetComponent<BoxCollider>();
    Debug.Log("I am alive! size: " + boxCollider.size);

    Debug.Log("target position: " + targetCube.transform.position);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
