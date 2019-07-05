using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class RaceFinish : MonoBehaviour {

                  public GameObject MyCar1;
                  public GameObject MyCar2;
                  public GameObject MyCar3;
                  public GameObject MyCar4;
                  public GameObject MyCar5;
                  public GameObject MyCar6;
                  public GameObject MyCar7;
	              public GameObject FinishCam1;
                  public GameObject FinishCam2;
                  public GameObject FinishCam3;
                  public GameObject FinishCam4;
                  public GameObject FinishCam5;
                  public GameObject FinishCam6;
                  public GameObject FinishCam7;
                  public GameObject ViewModes1;
                  public GameObject ViewModes2;
                  public GameObject ViewModes3;
                  public GameObject ViewModes4;
                  public GameObject ViewModes5;
                  public GameObject ViewModes6;
                  public GameObject ViewModes7;
	              public GameObject LevelMusic;
	              public GameObject Timeclock;
	              public AudioSource FinishMusic;
                  public int CarImport;
				 

	void OnTriggerEnter () {
		
                          CarImport = RaceCar.CarType;
                             if (CarImport == 1)
		{
                                    Time.timeScale = 1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar1.SetActive (false);
		MyCar1.GetComponent<CarController> ().enabled = false;
		MyCar1.GetComponent<CarUserControl> ().enabled = false;
		MyCar1.SetActive (true);
		FinishCam1.SetActive (true);
		ViewModes1.SetActive (false);
                                   }

                             if (CarImport == 2)
                            {      
                                    Time.timeScale =1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar2.SetActive (false);
		MyCar2.GetComponent<CarController> ().enabled = false;
		MyCar2.GetComponent<CarUserControl> ().enabled = false;
		MyCar2.SetActive (true);
		FinishCam2.SetActive (true);
		ViewModes2.SetActive (false);
                             }

                             if (CarImport == 3)
                            {      Time.timeScale =1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar3.SetActive (false);
		MyCar3.GetComponent<CarController> ().enabled = false;
		MyCar3.GetComponent<CarUserControl> ().enabled = false;
		MyCar3.SetActive (true);
		FinishCam3.SetActive (true);
		ViewModes3.SetActive (false);
                             }
                             if (CarImport == 4)
                            {      Time.timeScale= 1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar4.SetActive (false);
		MyCar4.GetComponent<CarController> ().enabled = false;
		MyCar4.GetComponent<CarUserControl> ().enabled = false;
		MyCar4.SetActive (true);
		FinishCam4.SetActive (true);
		ViewModes4.SetActive (false);
                             }                       
                                    if (CarImport == 5)
                            {      Time.timeScale =1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar5.SetActive (false);
		MyCar5.GetComponent<CarController> ().enabled = false;
		MyCar5.GetComponent<CarUserControl> ().enabled = false;
		MyCar5.SetActive (true);
		FinishCam5.SetActive (true);
		ViewModes5.SetActive (false);
                             }

                             if (CarImport == 6)
                            {      Time.timeScale=1f;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar6.SetActive (false);
		MyCar6.GetComponent<CarController> ().enabled = false;
		MyCar6.GetComponent<CarUserControl> ().enabled = false;
		MyCar6.SetActive (true);
		FinishCam6.SetActive (true);
		ViewModes6.SetActive (false);
                             }
                                                              
                                     if (CarImport == 7)
                            {      Time.timeScale=1f ;
                                    this.GetComponent<BoxCollider> ().enabled = false;
		MyCar7.SetActive (false);
		MyCar7.GetComponent<CarController> ().enabled = false;
		MyCar7.GetComponent<CarUserControl> ().enabled = false;
		MyCar7.SetActive (true);
		FinishCam7.SetActive (true);
		ViewModes7.SetActive (false);
                             }

		FinishMusic.Play ();
        LevelMusic.SetActive (false);
		Timeclock.SetActive (false);
	}

}