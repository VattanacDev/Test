using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;
    private int count;
    public Text CountText;
    public Text WinText;
	
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        setCountText();
        WinText.text = "";
	}
    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVerticaol = Input.GetAxis("Vertical");
        Vector2 movment = new Vector2(moveHorizontal,moveVerticaol);
        rb2d.AddForce(movment*speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            setCountText();
        } 
       
        
    }

    void setCountText()
    {
        CountText.text = "Count" + count.ToString();
        if (count >=12)
        {
            WinText.text = "F*K U";
        }
    }
}
