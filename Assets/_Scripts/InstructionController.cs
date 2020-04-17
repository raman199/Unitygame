using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{
     public void OnBackButton_Click()
   {
       SceneManager.LoadScene("Start");
   }
}
