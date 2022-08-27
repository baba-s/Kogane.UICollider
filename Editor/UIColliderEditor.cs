using UnityEditor;

namespace Kogane.Internal
{
    [CanEditMultipleObjects]
    [CustomEditor( typeof( UICollider ) )]
    internal sealed class UIColliderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
        }
    }
}