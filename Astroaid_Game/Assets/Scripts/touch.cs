
using UnityEngine;

public class touch : MonoBehaviour
{
    public float MovementSpeed_1;
    public float MovementSpeed_2;
    public Animator anim;

    void Start()
    {
       anim = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.4f, 7.29f), transform.position.y, Mathf.Clamp(transform.position.z, -13.08f, 6.32f));

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchposition = Input.GetTouch(0).deltaPosition;

            transform.Translate(touchposition.x * MovementSpeed_1 * Time.deltaTime, 0, touchposition.y * MovementSpeed_2 * Time.deltaTime);

        }
    }

    public void Douch()
    {
        anim.Play("douchani");
    }
}
