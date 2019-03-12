using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fakeLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void loadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Start()
    {
        Invoke("loadMainMenu", 5);
    }
}
