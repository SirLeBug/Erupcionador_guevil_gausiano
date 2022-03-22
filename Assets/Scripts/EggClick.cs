using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggClick : MonoBehaviour
{
    private int clickCoins;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        clickCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }

    private void OnMouseDown()
    {
        clickCoins++;
        txt.text = clickCoins.ToString() + " ClickCoins";
        Debug.Log(clickCoins.ToString());
    }
}
