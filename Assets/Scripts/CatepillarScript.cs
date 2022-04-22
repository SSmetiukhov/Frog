using UnityEngine;

public class CatepillarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var transform1 = transform;
        var transformPosition = transform1.position;
        transformPosition.y += 0.1f;
        transform1.position = transformPosition;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "FrogObject")
        {
            ScoreDisplay.AddScore(5);
        }  
        Destroy(gameObject);
    }
}
