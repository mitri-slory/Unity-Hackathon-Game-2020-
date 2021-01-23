using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public Object Scene;

    void OnTriggerEnter()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(Scene.name);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().restarted = true;
        
    }
}
