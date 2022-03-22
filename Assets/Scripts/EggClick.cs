using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggClick : MonoBehaviour
{
    private int clickCoins = 0;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        clickCoins = PlayerPrefs.GetInt("ClickCoins");
        txt.text = clickCoins.ToString() + " ClickCoins";
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{ // if left button pressed...
            //Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            //if (Physics.Raycast(ray, out hit))
            //{
                //Debug.Log(hit.transform);
                // the object identified by hit.transform was clicked
                // do whatever you want
            //}
        //}
    }

    private void OnMouseDown()
    {
        clickCoins++;
        PlayerPrefs.SetInt("ClickCoins", clickCoins);
        txt.text = clickCoins.ToString() + " ClickCoins";
        Debug.Log(this.gameObject.name);
    }
}
