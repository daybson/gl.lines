using UnityEngine;
using System.Collections;

public class GLDrawLine : MonoBehaviour
{
    public Material mat;
    public Transform[] points;

    void OnPostRender()
    {
        if (!mat)
        {
            Debug.LogError("Please Assign a material on the inspector");
            return;
        }

        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);
        for (var i = 1; i < this.points.Length; i++)
        {
            GL.Vertex(this.points[i].position);
            GL.Vertex(this.points[i - 1].position);
        }
        GL.End();
        GL.PopMatrix();
    }
}
