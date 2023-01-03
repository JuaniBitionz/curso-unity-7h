using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpBasics : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private BoxCollider2D boxCollider;
    private AudioSource audioSource;
    private Animator anim;
    private Transform transf;

    Player p = new Player();

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        transf = GetComponent<Transform>();

        transf.position = new Vector3(10, 20, 30);
    }
    //Warrior warrior;

    ////awake is the first function that is called
    //private void Awake()
    //{

    //}

    //// Start is called before the first frame update
    //void Start()
    //{
    //    //StartCoroutine(ExecuteSomething());
    //    //StartCoroutine("ExecuteSomething");
    //    //StopCoroutine("ExecuteSomething");

    //    //instanciar una clase
    //    //Player player = new Player(400, 200, "Warrior");
    //    //Debug.Log("player health is " + player.Health);

    //    warrior = new Warrior(20, 40, "warrior");
    //    warrior.Health = 40;
    //    warrior.Info();
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    ////Coroutine -> 
    //IEnumerator ExecuteSomething()
    //{
    //    yield return new WaitForSeconds(2f);

    //    Debug.Log("Something is executed");
    //}


}
