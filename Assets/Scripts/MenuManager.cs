using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BotonSalir()
    {
        Debug.Log("Aplicacion cerrada");
        Application.Quit();
    }

}
