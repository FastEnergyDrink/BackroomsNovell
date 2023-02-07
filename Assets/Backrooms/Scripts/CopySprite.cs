using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CopySprite : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _sourceSpriteRenderer;
    private SpriteRenderer _spriteRenderer;

    private Sprite _spriteTemp;
    private Color _defaultColor;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultColor = _spriteRenderer.color;
    }

    private void Update()
    {
        if(_spriteTemp != _sourceSpriteRenderer.sprite)
        {
            _spriteTemp = _sourceSpriteRenderer.sprite;
            _spriteRenderer.sprite = _spriteTemp;
        }
    }
}
