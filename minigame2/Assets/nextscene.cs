using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour {
    public int sceneNum;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 40), "Load Scene: " + sceneNum))
        {
            SceneManager.LoadScene(sceneNum);
        }
    }

}


