using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator), typeof(CanvasGroup))]
public class View<T> : MonoBehaviourSingleton<T>
	where T : View<T>
{
	private Animator _animator;

	[SerializeField] private UnityEvent _onOpen;
	public UnityEvent _OnOpen => this._onOpen;

	public void Open()
	{
		this._animator.SetTrigger(nameof(this.Open));

		this._onOpen.Invoke();
	}

	[SerializeField] private UnityEvent _onClose;
	public UnityEvent _OnClose => this._onClose;

	public void Close()
	{
		this._animator.SetTrigger(nameof(this.Close));

		this._onClose.Invoke();
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