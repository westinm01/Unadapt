using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnter2DEvent : MonoBehaviour
{
	[SerializeField] private UnityEvent<Collider2D> _onTriggerEnter;
	public UnityEvent<Collider2D> _OnTriggerEnter => this._onTriggerEnter;

	[Cinemachine.TagField]
	[SerializeField] private string _tag;
	public string _Tag => this._tag;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		this._onTriggerEnter.Invoke(collision);
	}
}