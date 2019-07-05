using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour {

    public GameObject Honda;
    public GameObject Lamborghini;
    public GameObject Aston ;
    public GameObject Benzs;
    public GameObject Chev;
    public GameObject Muscle;
    public GameObject Porche;
    public GameObject HondaCAM;
    public GameObject LamborghiniCAM;
    public GameObject AstonCAM ;
    public GameObject BenzsCAM;
    public GameObject ChevCAM;
    public GameObject MuscleCAM;
    public GameObject PorcheCAM;
    public int CarImport; 

   void Start () {
        CarImport = RaceCar.CarType;
        if (CarImport == 1)
        {
            Honda.SetActive(true);
			HondaCAM.SetActive(true);
            Lamborghini.SetActive(false);
            Aston.SetActive(false);
            Benzs.SetActive(false);
            Chev.SetActive(false);
            Muscle.SetActive(false);
            Porche.SetActive(false);
        }
else if (CarImport == 2)
        {
            Lamborghini.SetActive(true);
			LamborghiniCAM.SetActive(true);
        }
else if (CarImport == 3)
        {
            Aston.SetActive(true);
			AstonCAM.SetActive(true);
        }
else if (CarImport == 4)
        {
            Benzs.SetActive(true);
			BenzsCAM.SetActive(true);
        }
else if (CarImport == 5)
        {
            Chev.SetActive(true);
			ChevCAM.SetActive(true);
        }
else if (CarImport == 6)
        {
            Muscle.SetActive(true);
			MuscleCAM.SetActive(true);
        }
else if (CarImport == 7)
        {
            Porche.SetActive(true);
			PorcheCAM.SetActive(true);
        }
   }
}