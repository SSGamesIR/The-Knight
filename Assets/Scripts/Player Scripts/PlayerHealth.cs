using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    
public class PlayerHealth : MonoBehaviour {

    public float health = 100f;

    private bool isShielded;

    private Animator anim;

   




    public bool Shielded
   

    {
        get { return isShielded; }
        set { isShielded = value; }
    }

    private Image health_Img;

	// Use this for initialization
	void Awake () {

        anim = GetComponent<Animator>();
        health_Img = GameObject.Find("Health Icon").GetComponent<Image>();

		
	}
	
    public void TakeDamage(float amount)
    {
        if (!isShielded)
        {
            health -= amount;

            health_Img.fillAmount = health / 100f;

            //print("zadan" + health);

            if (health <= 0f)
            {
                anim.SetBool("Death", true);

                 
                if(!anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Death")
                    && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= .95f)
                {
                    //reload scene
                    SceneManager.LoadScene("Game");
                    
                }
            }

        }
    }

	public void HealPlayer(float healAmount)
    {
        health += healAmount;

        if (health > 100f)
            health = 100f;

        health_Img.fillAmount = health / 100f;
    }

   


}
