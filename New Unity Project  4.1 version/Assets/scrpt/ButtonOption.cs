using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

	public void Credits () {
		SceneManager.LoadScene (2);
	}

	public void Track01 () {
		SceneManager.LoadScene (3);
	}

	public void Track02 () {
		SceneManager.LoadScene (4);
	}

	public void Track03 () {
		SceneManager.LoadScene (5);
	}

	public void Track04 () {
		SceneManager.LoadScene (6);
	}

	public void Track05 () {
		SceneManager.LoadScene (7);
	}
                   public void QuitGame()
         {
               Application.Quit();
         }

}

