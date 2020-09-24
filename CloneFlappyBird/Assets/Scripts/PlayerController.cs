using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //puf
    //distancia puf em relaçao ao player
    private float distPuf = 0.5f;
    private Vector3 vectorPuf;
    [SerializeField] private GameObject puf;
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
        vectorPuf.x = transform.position.x - distPuf;
        vectorPuf.y = transform.position.y - distPuf;
        Subir();
        Limitando();
        LimiteY();
    }

    private void LimiteY()
    {
        if (transform.position.y >= 4.8f || transform.position.y <= -4.8)
        {
            SceneManager.LoadScene("Jogo");
        }
    }

    //metodo subir
    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            meuRb.velocity = Vector2.up * velocidade;
            //salvando puf em uma variavel
            GameObject meuPuf = Instantiate(puf, vectorPuf, Quaternion.identity);
            Destroy(meuPuf, 2f);
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

