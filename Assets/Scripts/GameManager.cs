using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int clickCoins = 0;
    public TextMeshProUGUI var_tiempototal;
    private TextMeshProUGUI var_clickcoinstotales;
    private TextMeshProUGUI var_clickcoinsactuales;
    private TextMeshProUGUI var_potenciaclickcoins;

    int seconds = 0;
    int minutes = 0;
    int hours = 0;
    int days = 0;
    // Start is called before the first frame update

    private IEnumerator Start()
    {
        //void Start
        startingcode();

        //Coroutine para augmentar los segundos mientras estas jugando
        while (true)
        {
            yield return new WaitForSeconds(1f);
            TimeUpdate();
        }
    }
    void startingcode()
    {
        //var_tiempototal = transform.Find("var_tiempototal").GetComponent<TextMeshProUGUI>();
        var_clickcoinsactuales = GetComponent<TextMeshProUGUI>();
        var_clickcoinstotales = GetComponent<TextMeshProUGUI>();
        var_potenciaclickcoins = GetComponent<TextMeshProUGUI>();

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
        

    }
}
