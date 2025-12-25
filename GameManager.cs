using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("امتیاز کل: " + score);
        // اینجا می‌تونی UI رو آپدیت کنی
    }
}