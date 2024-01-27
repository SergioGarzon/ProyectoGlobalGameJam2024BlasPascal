using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSoundRuleta : MonoBehaviour
{

    public AudioSource startRuleta;
    public AudioSource endRuleta;

    private int flagValue;

    public void Start()
    {
        float volumen = PlayerPrefs.GetFloat("ValorSlider", 0);
        flagValue = 0;        
        startRuleta.volume = volumen;
        endRuleta.volume = volumen;
    }


    public void StartSound()
    {
        if(flagValue == 0)
        {
            startRuleta.Play();
            endRuleta.Stop();
            flagValue = 1;
        } else
        {
            endRuleta.Play();
            startRuleta.Stop();
            flagValue = 0;
        }        
    }

    public void StopSound()
    {
        if (flagValue == 1)
        {
            startRuleta.Stop();
            flagValue = 1;
        }
        else
        {
            endRuleta.Stop();
            flagValue = 0;
        }
        
    }

}
