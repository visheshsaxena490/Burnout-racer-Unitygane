using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioTrack: MonoBehaviour
{
    public GameObject Track1;
    public GameObject Track2;
    public GameObject Track3;
    public GameObject Track4;	
	public int Music;
	
    void Update()
    {
        if (Input.GetButtonDown("Sound"))
        {
            if (Music == 3)
            {
                Music = 0;
            }
            else
            {
                Music += 1;
            }
            StartCoroutine(ModeChange());
        }
    }
	IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (Music == 0)
        {
            Track1.SetActive(true);
            Track4.SetActive(false);
        }
        if (Music == 1)
        {
            Track2.SetActive(true);
            Track1.SetActive(false);
        }
        if (Music == 2)
        {
            Track3.SetActive(true);
            Track2.SetActive(false);
        }
		if (Music == 3)
        {
            Track4.SetActive(true);
            Track3.SetActive(false);
        }

    }
}