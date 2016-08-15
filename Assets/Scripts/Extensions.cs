using UnityEngine;

public static class Extensions
{
    public static bool CompareTag(this GameObject gameObject, TagName tag)
    {
        return gameObject.CompareTag(tag.ToString());
    }
}