using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class TrailCollider : MonoBehaviour
{
    EdgeCollider2D edgeCollider;
    TrailRenderer myLine;



    // Start is called before the first frame update
    void Start()
    {
        edgeCollider = this.GetComponent<EdgeCollider2D>();
        myLine = this.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SetEdgeCollider(myLine);
    }

    void SetEdgeCollider(TrailRenderer trailRenderer)
    {
        List<Vector2> edges = new List<Vector2>();

        for (int point = 0; point < trailRenderer.positionCount; point++)
        {
            Vector3 lineRendererPoint = trailRenderer.GetPosition(point);
            edges.Add(new Vector2(trailRendererPoint.x, trailRendererPoint.y));
        }

        edgeCollider.SetPoints(edges);
    }
}