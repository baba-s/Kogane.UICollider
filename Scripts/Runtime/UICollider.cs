using UnityEngine;
using UnityEngine.UI;

namespace KoganeUnityLib
{
	public sealed class UICollider : Graphic
	{
		protected override void Awake()
		{
			base.Awake();

			canvasRenderer.cullTransparentMesh = true;

			color = new Color( 1, 1, 1, 0 );
		}
	}
}