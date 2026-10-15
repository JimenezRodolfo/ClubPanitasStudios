
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int initializationCount = 0;


private void Start()
{
    Initialize();
    Debug.Log("GameManager inicializado correctamente");
}


    public void Initialize()
    {
        initializationCount++;

        Debug.Log("Initialize ejecutado: " + initializationCount);

        if (initializationCount > 1)
        {
            Debug.LogError("ERROR: Inicializacion duplicada");
        }
    }
}
