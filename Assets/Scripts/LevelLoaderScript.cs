using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{

    public Animator transition;
    public float transitionTime;

    private int sceneCount;

    private int currentScene;
    // Start is called before the first frame update

    void Start()
    {
      sceneCount = SceneManager.sceneCountInBuildSettings - 1;
      currentScene = SceneManager.GetActiveScene().buildIndex;
      Debug.Log("Current Scene: " + currentScene + " / " + sceneCount);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void LoadHomeScene(){
            StartCoroutine(LoadScene(0));
    }
    public void LoadNextScene(){
        if( currentScene < sceneCount)
            StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadPreviousScene(){
        if(currentScene > 0)
            StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadScene(int index){
        //Play animation
        transition.SetTrigger("start");
        //Wait
        yield return new WaitForSeconds(transitionTime);
        //Load Scene
        SceneManager.LoadScene(index);
    }

}
