using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("Help");
    }
    private IEnumerator Help()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
}
