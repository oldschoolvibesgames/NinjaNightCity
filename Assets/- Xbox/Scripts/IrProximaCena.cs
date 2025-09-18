using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrProximaCena : MonoBehaviour
{
    [SerializeField] private string nomeCena = "Menu";
    [SerializeField] private float tempoEspera = 1f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ProximaCenaEnum());
    }

    // Chamar na fun��o da anima��o

    public void ProximaCena()
    {
        SceneManager.LoadScene(nomeCena);
    }

    IEnumerator ProximaCenaEnum()
    {
        yield return new WaitForSeconds(tempoEspera);
        SceneManager.LoadScene(nomeCena);
    }

}
