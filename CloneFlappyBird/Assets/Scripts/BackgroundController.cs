using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]private float velocidade = 0.1f;
    //posiçao offset x
    private float xOffset = 0f;
    //posicao textura
    private Vector2 texturaOffset;
    //pegando o meu material 
    private Renderer meuFundo;
    // Start is called before the first frame update
    void Start()
    {
        //pegando o fundo
        meuFundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += Time.deltaTime * velocidade;
        //passando o x offset para o x do vetor
        texturaOffset.x = xOffset;
        // movendo o fundo offset x
        meuFundo.material.mainTextureOffset = texturaOffset;
    }
}
