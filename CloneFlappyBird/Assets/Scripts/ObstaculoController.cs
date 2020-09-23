using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    //variavel velocidade
    [SerializeField] private float velocidade = 5f;
    //descobrindo quem e o objeto eu 
    [SerializeField] private GameObject eu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //indo para a esquerda
        transform.position += Vector3.left * Time.deltaTime * velocidade;
        //destruindo
        Destroy(eu, 5f);
    }
}
