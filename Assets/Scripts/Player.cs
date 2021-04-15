using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private AudioSource audioSource;
    //velocidade
	private float speed = 5f;

	private bool facingRight = true;
	public static bool direita = true;
	private Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public static int karma = 0;
	public static int questProgresso = 0;

	public Quest quest;
	public static Quest questAtual;

	//pulo ajuste
	[SerializeField]
	private float jumpForce = 300f;

    public AudioClip clip;

	public Rigidbody2D rb { get; set; }

	void Start () {
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();
        audioSource = GetComponent<AudioSource>();

		if((questAtual != null)&&(questAtual.estaCompleta==false))
		{
			quest = questAtual;
		}
	}

	void Update()
	{
		HandleInput ();
	}

	//movimento
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		float horizontal = Input.GetAxis("Horizontal");
		anim.SetFloat ("vSpeed", rb.velocity.y);
		anim.SetFloat ("Speed", Mathf.Abs (horizontal));
		rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);

		if (horizontal > 0 && !facingRight ) {
			Flip (horizontal);
			direita=true;
		}

		else if (horizontal < 0 && facingRight ){
			Flip (horizontal);
			direita=false;
		}
		if (CenaCorrecao.virarPedido==true) {
			Flip (horizontal);
			CenaCorrecao.virarPedido=false;
			direita=false;
		}
	}

	//pulo ação
	private void HandleInput()
	{
		if (grounded && Input.GetKeyDown(KeyCode.Space) )
		{
			anim.SetBool ("Ground", false);
			rb.AddForce (new Vector2 (0,jumpForce));
			audioSource.volume=AudioMaster.volumeAtual;
            audioSource.PlayOneShot(clip);
		}
	}
		
	private void Flip (float horizontal)
	{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
	}

	public void coletarItemDeQuest()
	{
		if(quest.emProgresso==true)
		{
			quest.objetivo.itemColetado();
			questAtual = quest;
			if(NPC.listaQuest.Exists(e => e.id==questAtual.id))
            {
                foreach(Quest q in NPC.listaQuest)
				{
   					if(q.id == questAtual.id)
   					{
						q.objetivo.quantidadePedida=questAtual.objetivo.quantidadePedida;
						q.objetivo.quantidadeAtual=questAtual.objetivo.quantidadeAtual;
     					break;
   					}
				}
            }
		}
		
	}
}
