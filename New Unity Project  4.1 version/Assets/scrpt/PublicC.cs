using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;

public class PublicC : MonoBehaviour {
public GameObject CarControl1;
public GameObject CarControl2;

void OnTriggerEnter () {

	CarControl1.GetComponent<CarAIControl>().enabled = true;
	CarControl2.GetComponent<CarAIControl>().enabled = true;

}

}