using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAnimation : MonoBehaviour
{
    private Text text;
    private string currentText = "Loading";
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = currentText;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter += 1;
        if (counter % 30 == 0)
        {
            if (currentText.Length == 10)
            {
                currentText = "Loading";
                text.text = currentText;
            }
            else
            {
                currentText = currentText + ".";
                text.text = currentText;
            }
            
        }
    }
}
