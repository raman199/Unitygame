using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startController : MonoBehaviour
{
    public void OnStartButton_Click()
   {
       SceneManager.LoadScene("Main");
   }
    public void OnInstructionButton_Click()
   {
       SceneManager.LoadScene("Instruction");
   }
}
