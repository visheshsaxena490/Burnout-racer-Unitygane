using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuC : MonoBehaviour {
public Transform currentmount;
public float speedFactor = 0.1f;
 
void Start (){
}

void Update () {

     transform.position = Vector3.Lerp(transform.position, currentmount.position, speedFactor);
     transform.rotation = Quaternion.Slerp(transform.rotation,currentmount.rotation,speedFactor);
}
public void setmount(Transform newmount){
      currentmount = newmount;
}
}