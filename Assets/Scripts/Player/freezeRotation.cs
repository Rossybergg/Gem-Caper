using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeRotation : MonoBehaviour
{
    Quaternion fixedRotation;
  
  private void Awake() {
     fixedRotation = transform.rotation;
  }
  private void Update() {
      transform.rotation = fixedRotation;
  }

}