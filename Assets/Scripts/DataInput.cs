using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataInput : MonoBehaviour
{
    public void SelectGuest(){
        SceneManager.LoadSceneAsync("Guest");
    }
    public void SelectStudent(){
        SceneManager.LoadSceneAsync("Student");
    }
}
