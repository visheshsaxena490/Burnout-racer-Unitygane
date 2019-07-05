 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Raceover : MonoBehaviour
{
        public GameObject RaceFinish;
        

         void OnTriggerEnter()
      {
                     RaceFinish.SetActive(true);       



        }
        
}