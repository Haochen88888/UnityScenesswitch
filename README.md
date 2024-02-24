# UnityScenesswitch
Switching between different scenes



1. First create two Scenes, Scene1 and Scene2.

2. Click File—>Build Settings..., drag the scene to Build Settings, and click Build below. Select a folder to save. (It is recommended to package the files into an empty folder)
https://github.com/Haochen88888/UnityScenesswitch/blob/main/1.png
https://github.com/Haochen88888/UnityScenesswitch/blob/main/2.png

3. Add Button (UI) to the scene, right-click on the blank space in the Hierarchy view, and select UI—>Button - TextMeshPro. After adding, modify the appropriate position.
https://github.com/Haochen88888/UnityScenesswitch/blob/main/3.png

4. Use LoadScene.cs code
You can write different statements to choose whether to destroy the previous scene after switching scenes.

 Destroy the previous scene after switching scenes :  SceneManager.LoadScene(index of scene);   Or SceneManager.LoadScene("name of scene"); //English double quotes

Do not destroy the previous scene after switching scenes：  SceneManager.LoadScene(scene index, LoadSceneMode.Additive);    Or SceneManager.LoadScene("name of scene", LoadSceneMode.Additive);

5. Create an empty object (GameObject) and place it under Canvas to mount the script. (Actually, the position of this empty object can be anywhere, it can be placed freely, and the script can be loaded onto the empty object)
https://github.com/Haochen88888/UnityScenesswitch/blob/main/4.png

  6. Select the Button, click the "+" of On Click() in the Inspector, and then drag the GameObject into it. And click No Function to select the method in the script. Since Scene 1 needs to switch to Scene 2, the Scene2() method is selected.
https://github.com/Haochen88888/UnityScenesswitch/blob/main/5.png
https://github.com/Haochen88888/UnityScenesswitch/blob/main/6.png


Through the above steps, we can also transfer Scene2 to Scene1, and can also transfer directly to each other in multiple Scenes.
