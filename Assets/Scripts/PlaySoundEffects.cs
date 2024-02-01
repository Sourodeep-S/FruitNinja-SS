using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
  public AudioSource src;
  public AudioClip bomb, slice, start;

  public void playbombSound()
  {
    src.clip = bomb;
    src.Play();
  }

  public void playslice()
  {
    src.clip = slice;
    src.Play();
  }

  public void playStartSound()
  {
    src.clip = start;
    src.Play();
  }
}
