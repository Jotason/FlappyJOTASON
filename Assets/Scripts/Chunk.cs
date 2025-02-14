using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] List<Transform> pivote = new List<Transform>();
    [SerializeField] List<GameObject> obstaculosInstanciados = new List<GameObject>();

    private void Start()
    {
        GenerarObstaculos();
    }

    public void GenerarObstaculos() {

        DestruirObstaculos();

        for (int i = 0; i < pivote.Count; i++)
        {
            int numeroAleatorio = Random.Range(1, 8);
            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("Obstaculo"+numeroAleatorio), pivote[i]);
            obstaculo.transform.localPosition = new Vector3(0,0,0);
            obstaculosInstanciados.Add(obstaculo);
        }
    }

    public void DestruirObstaculos() {
        for (int i = 0; i < obstaculosInstanciados.Count; i++)
        {
            Destroy(obstaculosInstanciados[i]);
        }

        obstaculosInstanciados.Clear();
    }
}
