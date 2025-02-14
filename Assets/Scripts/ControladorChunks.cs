using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChunks : MonoBehaviour
{
    [SerializeField]List<Chunk> chunks = new List<Chunk>();
    [SerializeField]float velocidad = 0f;
    [SerializeField] Transform ultimoChunk;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left * velocidad *Time.deltaTime, Space.World);
            if (chunks[i].transform.position.x <= -7)
            {
                chunks[i].transform.position = ultimoChunk.position + (Vector3.right * 7);
                ultimoChunk = chunks[i].transform;
                chunks[i].GenerarObstaculos();
                //Destroy(chunks[i].gameObject);    
            }
        }
    }
    
}
