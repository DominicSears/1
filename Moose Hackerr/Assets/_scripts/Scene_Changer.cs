using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor.SceneManagement;

public class Scene_Changer : MonoBehaviour {

    void switch_scene(string nextScene, string switchFrom)
    {
        SceneManager.LoadScene(nextScene);
        Debug.Log (nextScene + ": scene loaded");
        //EditorSceneManager.OpenScene(SceneManager.GetSceneByName(nextScene).path);
        SceneManager.UnloadScene(SceneManager.GetSceneByName(switchFrom));
        Debug.Log (switchFrom + ": scene unloaded");
    }

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ReloadLevel.hackStarted)
        {
            //Debug.Log ("Scene_Changer: hackStarted is true");
            //SceneManager.LoadScene("hack");
            //Debug.Log ("Scene_Changer: Scene changed to \"hack\"");
            //EditorSceneManager.OpenScene(SceneManager.GetSceneByName("hack").path);
            //SceneManager.UnloadScene(SceneManager.GetSceneByName("room1"));

            switch_scene ("hack", "room1");
        }
    }
}
