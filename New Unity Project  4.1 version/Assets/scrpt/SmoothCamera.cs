using UnityEngine;
using System.Collections;
public class SmoothCamera : MonoBehaviour
{
     public Transform target;
	 
	 public float distance;
	 public float height;
	 public float rotationDamping;
	 public float heightDamping;
	 public float zoomRatio;
	 public float defaultFOV;
	 private float rotation_vector;
	 
	 void FixedUpdate ()
	 {
	   Vector3 local_velocity = target.InverseTransformDirection (target.GetComponent<Rigidbody> ().velocity);
	   if (local_velocity.z <=0.5f )
	   {
		   rotation_vector=target.eulerAngles.y+100;
	   }
	   else{
		   rotation_vector=target.eulerAngles.y;
	   }
	 
	 float accelaration = target.GetComponent<Rigidbody>().velocity.magnitude;
	 Camera.main.fieldOfView = defaultFOV + accelaration * zoomRatio * Time.deltaTime;
	 }
	 void LateUpdate()
	 {
		 float wantesAngle = rotation_vector;
		 
		 float wantesHeight = target.position.y+height;
		 float myAngle = transform.eulerAngles.y;
		 float myHeight = transform.position.y;
		 
		 myAngle = Mathf.LerpAngle (myAngle, wantesAngle, rotationDamping * Time.deltaTime);
		 myHeight = Mathf.LerpAngle (myHeight, wantesHeight, heightDamping * Time.deltaTime);
		 
		 Quaternion currentRotation = Quaternion.Euler (0,myAngle,0);
		 
		 transform.position = target.position;
		 transform.position -=currentRotation*Vector3.forward *distance;
		 
		 Vector3 temp = transform.position;
		 temp.y =myHeight;
		 transform.position =temp;
		 
		 transform.LookAt (target);
	 }
}
