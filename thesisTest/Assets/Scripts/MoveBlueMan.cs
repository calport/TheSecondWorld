using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveBlueMan : MonoBehaviour
{
    [SerializeField]
    private Vector3 _targetLocation = Vector3.zero;

    [Range(1.0f, 10.0f), SerializeField] private float _moveDuration = 10.0f;
        
    [SerializeField]

    private Ease _moveEase = Ease.Linear; 
    
    private Animator anim;
        
    private enum DoTweenType
    {
        MovementOneWay
    }
    
    [SerializeField]
    private DoTweenType _doTweenType = DoTweenType.MovementOneWay;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
//        StartCoroutine(MoveMan());
        Physics2D.gravity = new Vector2(-9.8f,0f);

    }

    

    public IEnumerator MoveMan()
    {
        print("moved");    
        if (_doTweenType == DoTweenType.MovementOneWay)
        {
            Tween moveTween = transform.DOMove(_targetLocation, _moveDuration).SetEase(_moveEase);
            anim.SetFloat("Speed", 1);
            yield return moveTween.WaitForCompletion();
            anim.SetFloat("Speed", 0);

        }
    }
    
}
