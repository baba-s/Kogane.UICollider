using UnityEditor;

namespace KoganeUnityLib
{
	[CanEditMultipleObjects]
	[CustomEditor( typeof( UICollider ) )]
	public sealed class UIColliderEditor : Editor
	{
		public override void OnInspectorGUI()
		{
		}
	}
}