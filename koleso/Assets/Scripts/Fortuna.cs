using UnityEngine;
using UnityEngine.UI;


public class Fortuna : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject Whell;
    
    

    private void Update(){
        if(speed > 0){
            Whell.transform.Rotate (transform.forward * -speed);
            speed -= Time.deltaTime;
            
        }
        else {
            speed = 0f;
        }
    }
    
    private void OnTriggerStay2D(Collider2D other){
        if(speed < 0){
            print (other.gameObject.GetComponent<Text>().text);
        }
    }
}
