using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    //posicao obstaculo
    [SerializeField] private Vector3 posicao;
    //posicao minima e maxima
    [SerializeField] private float posMin = -0.4f;
    [SerializeField] private float posMax = 2.3f;

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0) {
            posicao.y = Random.Range(posMin, posMax);
            timer = 1f;
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }

    }
}
