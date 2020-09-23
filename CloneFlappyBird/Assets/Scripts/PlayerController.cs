using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    //metodo para limitar velocidade de queda
    public void Limitando() {

        if (meuRb.velocity.y < -velocidade)
        {
            meuRb.velocity = Vector2.down * velocidade;
        }
    }
    //configurando a colisao do player

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Jogo");
    }
}

