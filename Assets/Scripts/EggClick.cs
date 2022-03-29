using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EggClick : MonoBehaviour
{
    private int clickCoins = 0;
    public TextMeshProUGUI txt_clickcoins;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        clickCoins = PlayerPrefs.GetInt("ClickCoins");
        txt_clickcoins.text = clickCoins.ToString() + " ClickCoins";
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Clicked");
        clickCoins++;
        PlayerPrefs.SetInt("ClickCoins", clickCoins);
        txt_clickcoins.text = clickCoins.ToString() + " ClickCoins";
        Debug.Log(this.gameObject.name);

        //subimos el valor de las clickcoins totales a 1 más
        PlayerPrefs.SetInt("totalClickCoins", PlayerPrefs.GetInt("totalClickCoins") + 1);
    }
}
