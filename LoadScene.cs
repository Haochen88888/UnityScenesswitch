using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Call the UI function in UnityEngine
using UnityEngine.UI;
//Call SceneManagement function
using UnityEngine.SceneManagement;
 
public class LoadScene : MonoBehaviour
{
    //Function for scene switching
    public void Scene1()
    {
        SceneManager.LoadScene(0); //Destroy the previous scene after switching scenes
        //SceneManager.LoadScene(0, LoadSceneMode.Additive);//Do not destroy the previous scene after switching scenes
    }
    public void Scene2()
    {
        SceneManager.LoadScene(1);  //Destroy the previous scene after switching scenes
        //SceneManager.LoadScene(1, LoadSceneMode.Additive);//Do not destroy the previous scene after switching scenes
    }
       //Exit function
    public void myExit()
    {
        Application.Quit();
    }
}

