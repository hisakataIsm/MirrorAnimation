using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

namespace Ism.MirrorAnimation
{
	public class MirrorAnimationEditorWindow : EditorWindow
	{
		private MirrorAnimationSetting m_mirrorAnimationSetting;

		private AnimationClip m_animationClip;

		[MenuItem("Ism/MirrorAnimation")]
		static void Window()
		{
			var window = GetWindow<MirrorAnimationEditorWindow>("MirrorAnimation");
			window.Show();
		}

        private void Update()
		{
            if(m_mirrorAnimationSetting == null)
			{
				m_mirrorAnimationSetting = AssetDatabase.LoadAssetAtPath<MirrorAnimationSetting>("Assets/Ism/Editor/MirrorAnimation/MirrorAnimationSetting.asset");
			}
		}

		private void OnGUI()
		{
			if(m_mirrorAnimationSetting == null)
			{
				return;
			}

			EditorGUILayout.Space ();

			EditorGUILayout.LabelField ("変換するAnimationClipを設定する");
			m_animationClip = (AnimationClip)EditorGUILayout.ObjectField(m_animationClip, typeof(AnimationClip), true);

			if (m_animationClip != null)
			{
				if (GUILayout.Button("Mirror変換"))
				{
					MirrorAnimation(m_animationClip);
				}
			}
		}

		private void MirrorAnimation(AnimationClip animationClip)
		{
			// アニメーションクリップを生成
			var copyAnimationClip = CopyAnimationClip (animationClip);

			// プロパティを取得
			var animationProperties = GetAnimationProperties (copyAnimationClip);

			// 反転させる
			ApplyMirrorAnimation (copyAnimationClip, animationProperties);
		}

		private AnimationClip CopyAnimationClip(AnimationClip animationClip)
		{
			var copyAnimationClip = Instantiate (animationClip) as AnimationClip;

			var path = AssetDatabase.GetAssetPath (animationClip);
			var directoryName = System.IO.Path.GetDirectoryName (path);

			AssetDatabase.CreateAsset (copyAnimationClip, $"{directoryName}/mirror_{animationClip.name}.asset");
			return copyAnimationClip;
		}

		private void ApplyMirrorAnimation(AnimationClip animationClip, Dictionary<string, AnimationProperty> animationProperties)
		{
			var bindings = AnimationUtility.GetCurveBindings (animationClip);
			foreach (var binding in bindings)
			{
				var curve = AnimationUtility.GetEditorCurve (animationClip, binding);

				var boneName = System.IO.Path.GetFileName (binding.path);

				var mirrorBoneSetting = m_mirrorAnimationSetting.mirrorBoneSettings.FirstOrDefault (item => item.baseBoneName == boneName);
				if(mirrorBoneSetting != null)
				{
					if(animationProperties.ContainsKey(boneName))
					{
						if(animationProperties.ContainsKey(mirrorBoneSetting.mirrorBoneName))
						{
							boneName = mirrorBoneSetting.mirrorBoneName;
						}
						else
						{
							Debug.LogError ($"nothingMirrorBoneName={mirrorBoneSetting.mirrorBoneName}");
						}
					}
				}

				var animationProperty = animationProperties [boneName];

				switch (binding.propertyName)
				{
				case "m_LocalPosition.x":
					curve.keys = animationProperty.GetMirrorLocalPositionX ();
					AnimationUtility.SetEditorCurve (animationClip, binding, curve);
					break;
				case "m_LocalRotation.x":
					curve.keys = animationProperty.GetMirrorLocalRotationX ();
					AnimationUtility.SetEditorCurve (animationClip, binding, curve);
					break;
				case "m_LocalRotation.y":
					curve.keys = animationProperty.GetMirrorLocalRotationY ();
					AnimationUtility.SetEditorCurve (animationClip, binding, curve);
					break;
				case "m_LocalRotation.z":
					curve.keys = animationProperty.GetMirrorLocalRotationZ ();
					AnimationUtility.SetEditorCurve (animationClip, binding, curve);
					break;
				case "m_LocalRotation.w":
					curve.keys = animationProperty.GetMirrorLocalRotationW ();
					AnimationUtility.SetEditorCurve (animationClip, binding, curve);
					break;
				}
			}
		}

		private Dictionary<string, AnimationProperty> GetAnimationProperties (AnimationClip animationClip)
		{
			var animationProperties = new Dictionary<string, AnimationProperty> ();

			var bindings = AnimationUtility.GetCurveBindings (animationClip);
			foreach (var binding in bindings)
			{
				var curve = AnimationUtility.GetEditorCurve (animationClip, binding);

				var boneName = System.IO.Path.GetFileName (binding.path);

				if(!animationProperties.ContainsKey(boneName))
				{
					animationProperties.Add (boneName, new AnimationProperty ());
				}

				switch (binding.propertyName)
				{
				case "m_LocalPosition.x":
					animationProperties [boneName].localPositionX.AddRange (curve.keys);
					break;
				case "m_LocalRotation.x":
					animationProperties [boneName].localRotationX.AddRange (curve.keys);
					break;
				case "m_LocalRotation.y":
					animationProperties [boneName].localRotationY.AddRange (curve.keys);
					break;
				case "m_LocalRotation.z":
					animationProperties [boneName].localRotationZ.AddRange (curve.keys);
					break;
				case "m_LocalRotation.w":
					animationProperties [boneName].localRotationW.AddRange (curve.keys);
					break;
				}
			}

			return animationProperties;
		}
	}
}
