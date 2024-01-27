using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTime : MonoBehaviour
{
    public float timeStart;
    public float timeEnd;

    public string nameScene;

    public GameObject objetoScena;
    private ChangeSceneGame changeScene;
    private RegularVolumen regularVolumen;



    public void Start()
    {
        changeScene = objetoScena.GetComponent<ChangeSceneGame>();
        regularVolumen = objetoScena.GetComponent <RegularVolumen>();
    }


    private void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart >= timeEnd)
        {
            regularVolumen.DetenerSonido();
            changeScene.ChangeScene(nameScene);
        }
    }
}
