using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

[System.Serializable]
public class ImagePair
{
    public SpriteRenderer silhouetteRenderer;
    public SpriteRenderer imageRenderer;
}

public class ImageReveal : MonoBehaviour
{
    public Button revealButton;
    public ImagePair imagePair;

    public AudioSource suspenso;
    public AudioSource suspensoInc;

    void Start()
    {
        suspenso.Play();

        // Ocultar la imagen y mostrar la silueta al inicio
        imagePair.imageRenderer.gameObject.SetActive(false);
        imagePair.silhouetteRenderer.gameObject.SetActive(true);

        // Asignar el método OnClick al botón
        revealButton.onClick.AddListener(RevealNextPair);
    }

    void RevealNextPair()
    {
        suspenso.Pause();
        suspensoInc.Play();


        // Ocultar la silueta
        imagePair.silhouetteRenderer.gameObject.SetActive(false);

        // Mostrar la imagen
        imagePair.imageRenderer.gameObject.SetActive(true);

        // Esperar un momento antes de cambiar de escena
        StartCoroutine(WaitAndLoadScene());

    }

    IEnumerator WaitAndLoadScene()
    {
        // Esperar un momento antes de cambiar de escena
        yield return new WaitForSeconds(5f);

        // Cambiar de escena
        SceneManager.LoadScene(0);
    }
}
