using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu_principal : MonoBehaviour
{
    public void PlayNivel ()
    {
        SceneManager.LoadScene("Nivel_1");
    }

     public void PlayCreativo ()
    {
        SceneManager.LoadScene("Nivel_creativo");
    }

     public void ayuda_normal ()
    {
        SceneManager.LoadScene("ayuda_normal");
    }

    public void ayuda_creativo ()
    {
        SceneManager.LoadScene("ayuda_creativo");
    }

    public void MenuPrincipal ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
