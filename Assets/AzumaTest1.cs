using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzumaTest1 : MonoBehaviour
{
  // Start is called before the first frame update
  public string myName;
  public Transform targetTransform;

  void Start()
  {
    BoxCollider boxCollider = GetComponent<BoxCollider>();
    Debug.Log("I am alive! size: " + boxCollider.size);

    Debug.Log("target position: " + targetTransform.position);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
