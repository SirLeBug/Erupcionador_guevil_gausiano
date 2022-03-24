using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI var_tiempototal;
    public TextMeshProUGUI var_clickcoinstotales;
    public TextMeshProUGUI var_clickcoinsactuales;
    public TextMeshProUGUI var_potenciaclickcoins;

    public Slider slider_master;
    public Slider slider_music;
    public Slider slider_effects;

    //public TextMeshProUGUI

    int seconds = 0;
    int minutes = 0;
    int hours = 0;
    int days = 0;
    // Start is called before the first frame update

    private IEnumerator Start()
    {
        //void Start
        startingcode();
        setaudio();

        //Coroutine para augmentar los segundos mientras estas jugando
        while (true)
        {
            yield return new WaitForSeconds(1f);
            TimeUpdate();
        }
    }
    void startingcode()
    {

        //tiempo total
        System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
        int cur_time = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds;
        seconds = 0;
        minutes = 0;
        hours = 0;
        days = 0;
        if (PlayerPrefs.HasKey("firstLogin"))
        {
            seconds = cur_time - PlayerPrefs.GetInt("firstLogin");
            while (seconds >= 60 || minutes >= 60 || hours >= 24)
            {
                if (seconds >= 60)
                {
                    seconds = seconds - 60;
                    minutes++;
                }
                if (minutes >= 60)
                {
                    minutes = minutes - 60;
                    hours++;
                }
                if (hours >= 24)
                {
                    hours = hours - 24;
                    days++;
                }
                var_tiempototal.text = days + "d " + hours + "h " + minutes + "m";
            }
        } else
        {
            PlayerPrefs.SetInt("firstLogin", cur_time);
            var_tiempototal.text = days + "d " + hours + "h " + minutes + "m";
        }

        //Total ClickCoins obtenidas
        if (PlayerPrefs.HasKey("totalClickCoins"))
        {
            var_clickcoinstotales.text = PlayerPrefs.GetInt("totalClickCoins") + " CC";
        } else
        {
            PlayerPrefs.SetInt("totalClickCoins", PlayerPrefs.GetInt("ClickCoins"));
            var_clickcoinstotales.text = PlayerPrefs.GetInt("totalClickCoins") + " CC";
        }

        if (PlayerPrefs.HasKey("ClickCoins"))
        {
            var_clickcoinsactuales.text = PlayerPrefs.GetInt("ClickCoins") + " CC";
        }
        else
        {
            PlayerPrefs.SetInt("ClickCoins", 0);
            var_clickcoinsactuales.text = PlayerPrefs.GetInt("ClickCoins") + " CC";
        }
    }

    void setaudio()
    {
        slider_master.value = PlayerPrefs.GetFloat("masterVolume");
        slider_music.value = PlayerPrefs.GetFloat("musicVolume");
        slider_effects.value = PlayerPrefs.GetFloat("effectsVolume");
    }

    private void TimeUpdate()
    {
        seconds++;
        while (seconds >= 60 || minutes >= 60 || hours >= 24)
        {
            if (seconds >= 60)
            {
                seconds = seconds - 60;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = minutes - 60;
                hours++;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
                days++;
            }
            var_tiempototal.text = days + "d " + hours + "h " + minutes + "m";
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Esta información se refresca cada frame
        var_clickcoinstotales.text = PlayerPrefs.GetInt("totalClickCoins") + " CC";
        var_clickcoinsactuales.text = PlayerPrefs.GetInt("ClickCoins") + " CC";
    }
}
