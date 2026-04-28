using UnityEngine;
public class AnimationController : MonoBehaviour {
    public Animator animator;
    public ParticleSystem ps;
    void Start () {
        animator=GetComponent<Animator>();
        ps=GetComponentInChildren<ParticleSystem>();
    }
    void Update() {

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            animator.SetBool("a", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2)) {
            animator.SetBool("a", false);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            if (ps.isPlaying) {
                ps.Stop();
            } else {
                ps.Play();
            }
        }
    }
}