using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
 
public class CarC : MonoBehaviour {
public GameObject CarControl1;
public GameObject CarControl2;
public GameObject CarControl3;
public GameObject CarControl4;
public GameObject CarControl5;
public GameObject CarControl6;
public GameObject CarControl7;
public GameObject AICar;

void  Start (){
	CarControl1.GetComponent<CarController>().enabled = true;
	CarControl2.GetComponent<CarController>().enabled = true;
	CarControl3.GetComponent<CarController>().enabled = true;
	CarControl4.GetComponent<CarController>().enabled = true;
	CarControl5.GetComponent<CarController>().enabled = true;
	CarControl6.GetComponent<CarController>().enabled = true;
	CarControl7.GetComponent<CarController>().enabled = true;
	AICar.GetComponent<CarAIControl>().enabled = true;	
}
}