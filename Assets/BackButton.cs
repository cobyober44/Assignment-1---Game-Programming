using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    void GoBack()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive); 
    }
}


