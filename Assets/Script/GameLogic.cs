using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public Lhand lhand;
    public Rhand rhand;
    public RFoot rFoot;
    public LFoot lFoot;
    public Animator animator;

    public GameObject nextLevCan;



    public GameObject confetti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rhand.rightHandBool)
        {
            Debug.Log("Right");
        }
        if (lhand.leftHandBool)
        {
            Debug.Log("Left");
        }
        if(lhand.leftHandBool && rhand.rightHandBool && rFoot.rightFootBool && lFoot.leftFootBool)
        {

            confetti.SetActive(true);
       
            animator.SetBool("Win", true);
            Debug.Log("LEVEL COMPLETED YAAAAAY!!");
            //Invoke("NextLevCanvas", 2f);
            NextLevCanvas();
        }
  
    }

    private void FixedUpdate()
    {
       
    }
    //UI
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NextLevCanvas()
    {
        nextLevCan.SetActive(true);
    }

}
