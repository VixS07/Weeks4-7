using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is it inside the sprite?, are they clicking?
        if (player.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Y: reduce health
            health--;
            if (health == 0) {
                gameObject.SetActive(false);
            }
        }

        //update the health bar with our new health value
        healthBar.value = health;
    }

    public void resetHealth()
    {
        //turrn on the player game object
        gameObject.SetActive(true);

        //reset health to 5
        health = (int)healthBar.maxValue;

        //set the value of th slider to our health
        healthBar.value = health;
       
    }
}
