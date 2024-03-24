using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 60;
    public Text countdownText;
    void Start()
    {
        StartCoroutine((Countdown));
    }
    IEnumerator Countdown()
    {
        while(timeRemaining > 0)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
            countdownText.text="Time :" + timeRemaining.ToString();
        }
        countdownTetx.text = "Time' s up";
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Circle"))
        {
            //giả sử 6, 6 là vị trí ban đầu của vuông
            Vector2 firtPosition = new Vector2(x:6, y:6) ;
            transform.position =(Vector3)firtPosition ;
        }
        if (col.gameObject.name.Equals("Box"))
        {

        }
    }


    // Update is called once per frame
    void Update()
    {
        //Lấy giá trị trục ngang và trục đứng
        float Horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Tính toán hướng di chuyển
        Vector3 Movement = new Vector3(x: Horizontal, y: vertical, z: 0f);
        transform.Translate(translation: Movement*5f*Time.deltaTime);
    }
    
}
