using UnityEngine;

public class FadeButton : MonoBehaviour
{
	public float duration = 1f;

	float mStart = 0f;
	UIWidget[] mWidgets;

	void Start ()
	{
		mStart = Time.realtimeSinceStartup;
		mWidgets = GetComponentsInChildren<UIWidget>();
	}

	void Update ()
	{
		float alpha = (duration > 0f) ? 1f - Mathf.Clamp01((Time.realtimeSinceStartup - mStart) / duration) : 0f;

		foreach (UIWidget w in mWidgets)
		{
			Color c = w.color;
			c.a = alpha;
			w.color = c;
		}
		if (alpha == 0f) Destroy(this);
	}
}