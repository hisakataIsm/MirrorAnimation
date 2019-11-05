using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ism.MirrorAnimation
{
	public class AnimationProperty
	{
		public List<Keyframe> localPositionX = new List<Keyframe> ();
		public List<Keyframe> localRotationX = new List<Keyframe> ();
		public List<Keyframe> localRotationY = new List<Keyframe> ();
		public List<Keyframe> localRotationZ = new List<Keyframe> ();
		public List<Keyframe> localRotationW = new List<Keyframe> ();

		public Keyframe [] GetMirrorLocalPositionX ()
		{
			var keyframes = localPositionX.ToArray ();
			for (int i = 0, n = keyframes.Length; i < n; i++)
			{
				var keyframe = keyframes [i];
				keyframe.value *= -1f;
				keyframe.inTangent *= -1f;
				keyframe.outTangent *= -1f;
				keyframes [i] = keyframe;
			}
			return keyframes;
		}

		public Quaternion GetQuaternion (int index)
		{
			return new Quaternion (
					localRotationX [index].value,
					localRotationY [index].value * -1f,
					localRotationZ [index].value * -1f,
					localRotationW [index].value
				);
		}

		public Keyframe [] GetMirrorLocalRotationX ()
		{
			var keyframes = localRotationX.ToArray ();
			for (int i = 0, n = keyframes.Length; i < n; i++)
			{
				var keyframe = keyframes [i];
				keyframe.value = GetQuaternion (i).x;
				keyframes [i] = keyframe;
			}
			return keyframes;
		}

		public Keyframe [] GetMirrorLocalRotationY ()
		{
			var keyframes = localRotationY.ToArray ();
			for (int i = 0, n = keyframes.Length; i < n; i++)
			{
				var keyframe = keyframes [i];
				keyframe.value = GetQuaternion (i).y;
				keyframe.inTangent *= -1f;
				keyframe.outTangent *= -1f;
				keyframes [i] = keyframe;
			}
			return keyframes;
		}

		public Keyframe [] GetMirrorLocalRotationZ ()
		{
			var keyframes = localRotationZ.ToArray ();
			for (int i = 0, n = keyframes.Length; i < n; i++)
			{
				var keyframe = keyframes [i];
				keyframe.value = GetQuaternion (i).z;
				keyframe.inTangent *= -1f;
				keyframe.outTangent *= -1f;
				keyframes [i] = keyframe;
			}
			return keyframes;
		}

		public Keyframe [] GetMirrorLocalRotationW ()
		{
			var keyframes = localRotationW.ToArray ();
			for (int i = 0, n = keyframes.Length; i < n; i++)
			{
				var keyframe = keyframes [i];
				keyframe.value = GetQuaternion (i).w;
				keyframes [i] = keyframe;
			}
			return keyframes;
		}
	}
}
