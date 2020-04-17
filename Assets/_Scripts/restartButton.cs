using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartButton : MonoBehaviour
{
   public void OnRestartButton_Click()
   {
       SceneManager.LoadScene("Main");
   }
}
