using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    // Start is called before the first frame update
    public void Startbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
    public void mados4button()
    {
        SceneManager.LoadScene(2);
    }
    public void Menubutton()
    {
        SceneManager.LoadScene(0);
    }
    public void Againbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

}
