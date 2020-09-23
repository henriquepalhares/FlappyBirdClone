using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //criando as variaveis
    [SerializeField] private float velocidade = 5f;
    private Rigidbody2D meuRb;
    // Start is called before the first frame update
    void Start()
    {
        //pegando rb
        meuRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();
        Limitando();
    }
    //metodo subir
    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRb.velocity = Vector2.up * velocidade;
        }
    }
    public void Limitando() {
        //limitando queda
        if (meuRb.velocity.y < -velocidade)
        {
            meuRb.velocity = Vector2.down * velocidade;
        }
    }
}

