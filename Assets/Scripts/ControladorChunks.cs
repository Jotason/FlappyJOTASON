using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChunks : MonoBehaviour
{
    [SerializeField]List<Transform> chunks = new List<Transform>();
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
            chunks[i].Translate(Vector3.left * velocidad *Time.deltaTime, Space.World);
            if (chunks[i].position.x <= -7)
            {
                chunks[i].position = ultimoChunk.position + (Vector3.right * 7);
                ultimoChunk = chunks[i];

                //Destroy(chunks[i].gameObject);    
            }
        }
    }
    
}
