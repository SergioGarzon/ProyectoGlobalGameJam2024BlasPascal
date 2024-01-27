using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public Image imagePrefab;
    public float countdownTime;

    public VideoHandler videoHandler;

    void Start()
    {
        if (timerText != null)
        {
            StartCoroutine(StartCountdown());
        }
        else
        {
            Debug.LogError("Timer Text is not assigned!");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Input.mousePosition;

            ShowImageAtPosition(clickPosition);
        }
    }

    IEnumerator StartCountdown()
    {
        float currentTime = countdownTime;

        while (currentTime > 0)
        {
            UpdateTimerText(currentTime);
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        videoHandler.StartVideo(); // Inicia la reproducción del video cuando termina el tiempo
    }

    void UpdateTimerText(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void ShowImageAtPosition(Vector2 position)
    {
        Vector3 currentPos = imagePrefab.transform.position;

        imagePrefab.transform.position = new Vector3(position.x, position.y, currentPos.z);

        imagePrefab.gameObject.SetActive(true);

        StartCoroutine(HideImage(imagePrefab));
    }

    IEnumerator HideImage(Image imageObject)
    {
        yield return new WaitForSeconds(2f);

        if (imageObject != null)
        {
            imagePrefab.gameObject.SetActive(false);
        }
    }

    public void DisableAllComponents()
    {
        timerText.gameObject.SetActive(false);
        imagePrefab.gameObject.SetActive(false);
    }
}
