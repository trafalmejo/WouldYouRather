using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCanvasScript : MonoBehaviour
{

    public Button next;
    public Button previous;
    public Button home;
    public Button start;

    private LevelLoaderScript levelLoader;

    private Camera maincamera;

    // Start is called before the first frame update
    void Start()
    {
        levelLoader = GameObject.Find("LevelLoader").GetComponent<LevelLoaderScript>();
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        next.onClick.AddListener(nextScene);
        previous.onClick.AddListener(previousScene);
        home.onClick.AddListener(homeScene);
        start.onClick.AddListener(nextScene);
        Canvas controlcanvas =  gameObject.GetComponent<Canvas>();
        controlcanvas.renderMode = RenderMode.ScreenSpaceCamera;
        controlcanvas.worldCamera = maincamera;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    	void nextScene(){
levelLoader.LoadNextScene();
	}
    
    	void previousScene(){
levelLoader.LoadPreviousScene();	}
    
    	void homeScene(){
levelLoader.LoadHomeScene();	}
}
