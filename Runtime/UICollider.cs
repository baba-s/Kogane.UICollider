﻿using UnityEngine;
using UnityEngine.UI;

namespace Kogane
{
    [RequireComponent( typeof( CanvasRenderer ) )]
    public sealed class UICollider : Graphic
    {
        protected override void Awake()
        {
            base.Awake();

            canvasRenderer.cullTransparentMesh = true;

            color = new( 1, 1, 1, 0 );
        }
    }
}