using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator), typeof(CanvasGroup))]
public class View<T> : MonoBehaviour
	where T : View<T>
{
	private Animator _animator;
	private CanvasGroup _canvasGroup;

	public bool Active_ { get; private set; }

	[SerializeField] private UnityEvent _onOpen;
	public UnityEvent _OnOpen => this._onOpen;

	public virtual void Open()
	{
		this.Active_ = true;

		this._animator.SetTrigger(nameof(this.Open));

		this._onOpen.Invoke();
	}

	[SerializeField] private UnityEvent _onClose;
	public UnityEvent _OnClose => this._onClose;

	public virtual void Close()
	{
		this.Active_ = false;

		this._animator.SetTrigger(nameof(this.Close));

		this._onClose.Invoke();
	}

	[SerializeField] private bool _initiallyActive = true;
	public bool _InitiallyActive => this._initiallyActive;

	protected virtual void Awake()
	{
		this._animator = this.GetComponent<Animator>();
		this._canvasGroup = this.GetComponent<CanvasGroup>();

		this._canvasGroup.alpha = 0.0f;

		if (!this._initiallyActive)
			this.Close();
		else
			this.Open();
	}
}

public class View : View<View>
{
}