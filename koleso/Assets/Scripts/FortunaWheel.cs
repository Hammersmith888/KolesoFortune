using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortunaWheel : MonoBehaviour
{
   private int numberOfTurns;
   private int whatWeWin;
   private float speed;
   private bool canWeTurn;
   public Text winnigText;


   void Start(){
       canWeTurn = true;
   }
   void Update(){
       if(Input.GetKeyDown(KeyCode.Space) && canWeTurn == true){
           StartCoroutine(TurnTheWheel());

       }

   }
   private IEnumerator TurnTheWheel(){
       canWeTurn = false;
       numberOfTurns = Random.Range(50, 70);
       speed = 0.01f;
       for(int i = 0; i < numberOfTurns; i++){
           transform.Rotate(0, 0, 22.5f);
           if(i > Mathf.RoundToInt(numberOfTurns * 0.5f)){
               speed = 0.02f;
           }
           if(i > Mathf.RoundToInt(numberOfTurns * 0.5f)){
               speed = 0.03f;
           }
           if(i > Mathf.RoundToInt(numberOfTurns * 0.5f)){
               speed = 0.04f;
           }
           yield return new WaitForSeconds(speed);
       }
       if (Mathf.RoundToInt(transform.eulerAngles.z) % 45 !=0){
           transform.Rotate(0, 0, 22.5f);
       }
       whatWeWin = Mathf.RoundToInt(transform.eulerAngles.z);

       switch (whatWeWin)
       {
           case 0:
               winnigText.text = "berry";
               break;

               case 60:
               winnigText.text = "reload";
               break;

               case 120:
               winnigText.text = "JackPot";
               break;

               case 180:
               winnigText.text = "health";
               break;

               case 240:
               winnigText.text = "money";
               break;

               case 300:
               winnigText.text = "prize";
               break;

         
       }
       canWeTurn = true;

       

    
    }  

       

       

   

   
}


