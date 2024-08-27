//Script para usar nos portais
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ALendaDoDragaoProject
{
    public class ScrollTexture : MonoBehaviour
    {
        public float scrollSpeed = 0.90f;
        public float scrollSpeed2 = 0.90f;

        void FixedUpdate()
        {
            float offset = Time.time * scrollSpeed;
            float offset2 = Time.time * scrollSpeed2;
            
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTextureOffset = new Vector2(offset2, -offset);
        }
    }
}