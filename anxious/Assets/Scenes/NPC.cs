using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 0;

    public Animator ani;
    public Transform tra;

    public void Start()
    {
        ani = GetComponent<Animator>();
    }

    public void Move()
    {
        
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        
        transform.Translate(speed * Time.deltaTime * h, 0, Time.deltaTime * v);
        
    }

    public void unit()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("JOMP");
        }
    }


    private void Update()
    {
        Move();

        unit();
    }
}
