using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour{

    public static bool GameIsPaused = false;
     
    public GameObject PauseMenuUI;
	public GameObject TimeManager;

    void Update(){
                   if(Input.GetKeyDown(KeyCode.Escape))
                     { 
                           if (GameIsPaused)
                              {        Resume();
                               } else
                               {
                                       Pause();
                                }
                 }
}
                 public void Resume ()

          {
                     PauseMenuUI.SetActive(false);
                     Time.timeScale = 1f;
                      GameIsPaused = false;
					  TimeManager.SetActive(true);
         }

       void  Pause ()
        {
              PauseMenuUI.SetActive(true);
              Time.timeScale =0f;
               GameIsPaused =true;
			   TimeManager.SetActive(false);
         }
           public void LoadMenu ()
          {
            Time.timeScale = 1f;
			SceneManager.LoadScene(1);
           }

         public void QuitGame()
         {
               Debug.Log("Quitting Game ......"); 
               Application.Quit();
         }
}