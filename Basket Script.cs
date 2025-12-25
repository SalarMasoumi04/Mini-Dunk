using UnityEngine;

public class BasketScore : MonoBehaviour
{
    public int scoreValue = 1; // امتیاز هر گل
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) // توپ باید تگ "Ball" داشته باشه
        {
            // اینجا امتیاز اضافه کن
            GameManager.instance.AddScore(scoreValue);

            Debug.Log("امتیاز! توپ وارد سبد شد.");
        }
    }
}