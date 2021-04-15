using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class nameScript : MonoBehaviour
{
    private int currentScene;
    private TextMeshProUGUI slideName;
    // Start is called before the first frame update
    void Start()
    {
    currentScene = SceneManager.GetActiveScene().buildIndex;
    slideName = gameObject.GetComponent<TextMeshProUGUI> ();
    slideName.text = "-0"+ SceneManager.GetActiveScene().buildIndex;   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
