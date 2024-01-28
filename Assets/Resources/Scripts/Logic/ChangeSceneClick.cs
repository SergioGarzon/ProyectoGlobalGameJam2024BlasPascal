using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ChangeSceneClick : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject panelGame;

    private bool control;

    public float timeStart;
    public float timeEnd;

    public AudioSource audio;


    public void Start()
    {
        float volumen = PlayerPrefs.GetFloat("ValorSlider", 0);
        audio.volume = volumen;


        videoPlayer.enabled = false;
        control = false;
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            panelGame.SetActive(false);
            videoPlayer.enabled = true;
            videoPlayer.Play();

            audio.Play();

            control = true;
        }

        
        if(control)
        {
            timeStart += Time.deltaTime;

            if (timeStart >= timeEnd)
            {
                audio.Stop();
                SceneManager.LoadScene("FrogerScene4");
            }
        }    

    }
}
