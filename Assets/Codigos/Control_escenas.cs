using UnityEngine;
using UnityEngine.SceneManagement;
public class Control_escenas:MonoBehaviour
{
    private void Awake()
    {
        print("Control de escenas - Activado");
    }

    public string QueEscena;
    public string EscenaActual;

    public void CargarEscena()
    {
        SceneManager.LoadScene("inicio");
    }

    public void CargarEscenaInicio()
    {
        SceneManager.LoadScene("inicio");
    }

    public void CargarEscenaNivel()
    {
        SceneManager.LoadScene("Lvl 1");
    }
    
   
}
