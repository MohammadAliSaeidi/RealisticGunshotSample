using UnityEngine;

namespace RealisticGunshotSample
{
	[RequireComponent(typeof(AudioSource))]
	public class GunSound : MonoBehaviour
	{
		[SerializeField] internal AudioClip[] sounds;

		private AudioSource _audioSource;

		private void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
		}

		internal void PlayRandomSound()
		{
			int rndIndex = UnityEngine.Random.Range(0, sounds.Length);

			_audioSource.clip = sounds[rndIndex];
			_audioSource.Play();
		}
	}
}
