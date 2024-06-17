using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Start is called before the first frame update
    private const string isDieParaname = "die";
    [SerializeField] private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Die()
    {
        // Xử lý cái chết của nhân vật, ví dụ tải lại cảnh hiện tại
        //Time.timeScale = 0f;
        animator.SetTrigger(isDieParaname);
        rb.velocity = new Vector2(0, 5f);
        GetComponent<Collider2D>().enabled = false;
        Invoke("LoadGameOverScene", 1f);
    }
    private void LoadGameOverScene()
    {
        Time.timeScale = 0f;
        //SceneManager.LoadScene("GameOverScenes");
    }
}
