using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleButton : MonoBehaviour
{
    public string nextLevel;


    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextLevel);
    }
}