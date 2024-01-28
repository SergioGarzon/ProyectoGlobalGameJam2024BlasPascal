using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class OpenPanelVideoFrogger : MonoBehaviour
{
    public float timeStart;
    public float timeEnd;

    public GameObject panel;

    public VideoPlayer video;
    public VideoPlayer video2;
    public VideoPlayer video3;

    public float timeStart2;
    public float timeEnd2;

    private bool control0;
    private bool control;
    private bool control2;

    public float timeStart3;
    public float timeEnd3;

    public GameObject audioPrincipio;
    public GameObject audioJugabilidad;
    public GameObject audioPisada;
    public GameObject audioCadaver;

    //public AudioSource audioPrincipio;
    //public AudioSource audioPisada;
    //public AudioSource audioCadaver;

    private void Start()
    {
        control = false;
        control2 = false;
        control0 = false;

        audioPrincipio.SetActive(true);
    }


    private void Update()
    {
        if (!control)
        {
            if (timeStart < timeEnd)
                timeStart += Time.deltaTime;

            if (timeStart >= timeEnd)
            {
                audioPrincipio.SetActive(false);
                video.Stop();
                panel.SetActive(true);
                control0 = true;
                audioJugabilidad.SetActive(true);
            }
        }        

        if(panel.activeSelf && control0)
        {
            if (Input.GetMouseButtonDown(0) && !control)
            {
                panel.SetActive(false);
                audioJugabilidad.SetActive(false);
                video2.Play();

                audioPisada.SetActive(true);

                control = true;
            }
        }

        if (!(panel.activeSelf) && control)
        {
            if (timeStart2 < timeEnd2) 
                timeStart2 += Time.deltaTime;

            if (timeStart2 >= timeEnd2)
            {
                audioPisada.SetActive(false);
                video2.Stop();

                audioCadaver.SetActive(true);

                video3.Play();

                control2 = true;
            }
        }

        if (control2)
        {
            if (timeStart3 < timeEnd3)
                timeStart3 += Time.deltaTime;

            if (timeStart3 >= timeEnd3)
            {
                audioCadaver.SetActive(false);
                video3.Stop();
                SceneManager.LoadScene(0);
            }
        }
    }
}
