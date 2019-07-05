using System.Collections;
 
using System.Collections.Generic;
 
using UnityEngine;
 
 
 
public class MenuCam : MonoBehaviour {
 
 
 
public Transform currentmount;
 
public Camera cam;
 
public float speedfactor;
 
public float zoomfactor;
 
public Vector3 lastposition;
 

 
void Start()
 
{
 
lastposition = transform.position;
 
}
 
 
void Update()
 
{
 
cam.transform.position = Vector3.Lerp(transform.position, currentmount.position, speedfactor);
 
cam.transform.rotation = Quaternion.Slerp(transform.rotation, currentmount.rotation, speedfactor);
 
 
 
 
 
float velocity = Vector3.Magnitude(transform.position - lastposition);
 
cam.fieldOfView = 60 + velocity * zoomfactor;
 
 
 
lastposition = transform.position;
 
}
 
 
 
public void setmount(Transform newmount)
 
{
 
currentmount = newmount;
 
}
 
}