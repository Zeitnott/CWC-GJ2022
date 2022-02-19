using UnityEngine;

public static class Bezier
{
  public static Vector3 GetPosition(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);

        float oneMinusT = 1f - t;

        return Mathf.Pow(oneMinusT, 3) * p0 +
            3f * Mathf.Pow(oneMinusT, 2) * t * p1 +
            3f * oneMinusT * Mathf.Pow(t, 2) * p2 +
            Mathf.Pow(t, 3) * p3;
    }
    public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);
        float oneMinusT = 1f - t;
        return 3f * Mathf.Pow(oneMinusT, 2) * (p1 - p0) +
            6f * oneMinusT * t * (p2 - p1) +
            3f * Mathf.Pow(t, 2) * (p3 - p2);
    }
}
