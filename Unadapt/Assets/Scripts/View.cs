using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(CanvasGroup))]
public class View<T> : MonoBehaviourSingleton<T>
	where T : View<T>
{
	private Animator _animator;

	public void Open()
	{
		Debug.Log(nameof(this.Close));

		this._animator.SetTrigger(nameof(this.Open));
	}

	public void Close()
	{
		this._animator.SetTrigger(nameof(this.Close));
	}

	[SerializeField] private bool _initiallyActive = true;
	public bool _InitiallyActive => this._initiallyActive;

	protected override void Awake()
	{
		base.Awake();

		this._animator = this.GetComponent<Animator>();

		if (!this._initiallyActive)
			this.Close();
	}
}

public class View : View<View>
{
}