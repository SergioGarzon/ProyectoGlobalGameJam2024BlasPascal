using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject videoTexture;

    //Aqui edito
    public GameObject objetoEliminar;
    public AudioSource audioEliminar;

    public CountdownTimer countdownTimer;

    private float startTime = 0;
    private float endTime;

    void Start()
    {
        audioEliminar = objetoEliminar.GetComponent<AudioSource>(); 
        objetoEliminar.SetActive(false);

        audioEliminar.Stop();
        endTime = (float)videoPlayer.length;
    }

    void Update()
    {
        startTime += Time.deltaTime;

        if(startTime >= endTime)
        {
            StartCoroutine(ChangeScene());
        }
    }

    public void StartVideo()
    {
        countdownTimer.enabled = false;

        videoPlayer.Play(); // Inicia la reproducción del video
        videoPlayer.gameObject.SetActive(true);
        videoTexture.SetActive(true);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0); // Carga la escena cuando termina el video
    }
}
