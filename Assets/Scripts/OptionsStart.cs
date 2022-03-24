using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsStart : MonoBehaviour
{
    public Button buttonUsed;
    public Button buttonNotUsed1;
    public Button buttonNotUsed2;
    public GameObject gameObjectUsed;
    public GameObject gameObjectNotUsed1;
    public GameObject gameObjectNotUsed2;
    public bool activation;
    // Start is called before the first frame update
    void Start()
    {
        activation = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClickedFirstTime()
    {

        buttonUsed.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
        buttonNotUsed1.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
        buttonNotUsed2.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;

        gameObjectUsed.SetActive(true);
        gameObjectNotUsed1.SetActive(false);
        gameObjectNotUsed2.SetActive(false);

        buttonUsed.Select();


        
    }
}
