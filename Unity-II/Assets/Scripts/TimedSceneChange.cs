using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedSceneChange : MonoBehaviour
{

    public float sceneChangeDelay;

    public int sceneToLoad = 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneChange", sceneChangeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
