//This is the code to transfer Scene2 to Scene1, modify some settings, and repeat the previous scene setup steps in unity,
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;
 
public class Scene1toScene2 : MonoBehaviour
{
   
    public void Scene2()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }
    public void Scene1()
    {
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void myExit()
    {
        Application.Quit();
    }
}
