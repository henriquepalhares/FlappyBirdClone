using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    //criando a variavel game controller
    [SerializeField] private GameController game;
    //variavel velocidade
    [SerializeField] private float velocidade = 4f;
    //descobrindo quem e o objeto eu 
    [SerializeField] private GameObject eu;
    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

        velocidade = 4f + game.retornaLevel();
        //indo para a esquerda
        transform.position += Vector3.left * Time.deltaTime * velocidade;
        //destruindo
        Destroy(eu, 5f);
    }
}
