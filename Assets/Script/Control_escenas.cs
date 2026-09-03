using UnityEngine;
public class Control_escenas:MonoBehaviour
{
    public string QueEscena;
    public string EscenaActual;

    public void CargarEscena(string queEscena)
    {
        print("Escena cargada");
    }

    public void EscenaSiguiente()
    {
        print("Escena siguiente");
    }

    public void EscenaAnterior()
    {
        print("Escena anterior");
    }
}
