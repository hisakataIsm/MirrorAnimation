using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Ism.MirrorAnimation
{
	[CreateAssetMenu (fileName = "MirrorAnimationSetting", menuName = "ScriptableObject /MirrorAnimationSetting")]
	public class MirrorAnimationSetting : ScriptableObject
	{
		[System.Serializable]
		public class MirrorBoneSetting
		{
			public string baseBoneName;
			public string mirrorBoneName;

			public MirrorBoneSetting(string baseBoneName, string mirrorBoneName)
			{
				this.baseBoneName = baseBoneName;
				this.mirrorBoneName = mirrorBoneName;
			}
		}

		public List<MirrorBoneSetting> mirrorBoneSettings;

		public void Reset()
		{
			mirrorBoneSettings = new List<MirrorBoneSetting> ()
			{
				// Left
				new MirrorBoneSetting ("Character1_LeftUpLeg", "Character1_RightUpLeg"),
				new MirrorBoneSetting ("Character1_LeftLeg", "Character1_RightLeg"),
				new MirrorBoneSetting ("Character1_LeftFoot", "Character1_RightFoot"),
				new MirrorBoneSetting ("Character1_LeftToBase", "Character1_RightToBase"),

				new MirrorBoneSetting ("J_L_knee", "J_R_knee"),
				new MirrorBoneSetting ("J_L_Skirt_00", "J_R_Skirt_00"),
				new MirrorBoneSetting ("J_L_Skirt_01", "J_R_Skirt_01"),
				new MirrorBoneSetting ("J_L_Skirt_02", "J_R_Skirt_02"),
				new MirrorBoneSetting ("J_L_SkirtBack_01", "J_R_Skirt_01"),
				new MirrorBoneSetting ("J_L_SkirtBack_02", "J_R_Skirt_02"),

				new MirrorBoneSetting ("Character1_LeftShoulder", "Character1_RightShoulder"),
				new MirrorBoneSetting ("Character1_LeftArm", "Character1_RightArm"),
				new MirrorBoneSetting ("Character1_LeftForeArm", "Character1_RightForeArm"),
				new MirrorBoneSetting ("Character1_LeftHand", "Character1_RightHand"),
				new MirrorBoneSetting ("Character1_LeftHandIndex1", "Character1_RightHandIndex1"),
				new MirrorBoneSetting ("Character1_LeftHandIndex2", "Character1_RightHandIndex2"),
				new MirrorBoneSetting ("Character1_LeftHandIndex3", "Character1_RightHandIndex3"),
				new MirrorBoneSetting ("Character1_LeftHandMiddle1", "Character1_RightHandMiddle1"),
				new MirrorBoneSetting ("Character1_LeftHandMiddle2", "Character1_RightHandMiddle2"),
				new MirrorBoneSetting ("Character1_LeftHandMiddle3", "Character1_RightHandMiddle3"),
				new MirrorBoneSetting ("Character1_LeftHandPinky1", "Character1_RightHandPinky1"),
				new MirrorBoneSetting ("Character1_LeftHandPinky2", "Character1_RightHandPinky2"),
				new MirrorBoneSetting ("Character1_LeftHandPinky3", "Character1_RightHandPinky3"),
				new MirrorBoneSetting ("Character1_LeftHandRing1", "Character1_RightHandRing1"),
				new MirrorBoneSetting ("Character1_LeftHandRing2", "Character1_RightHandRing2"),
				new MirrorBoneSetting ("Character1_LeftHandRing3", "Character1_RightHandRing3"),
				new MirrorBoneSetting ("Character1_LeftHandThumb1", "Character1_RightHandThumb1"),
				new MirrorBoneSetting ("Character1_LeftHandThumb2", "Character1_RightHandThumb2"),
				new MirrorBoneSetting ("Character1_LeftHandThumb3", "Character1_RightHandThumb3"),
				new MirrorBoneSetting ("Character1_LeftHandThumb4", "Character1_RightHandThumb4"),

				new MirrorBoneSetting("bone_eye_L", "bone_eye_R"),

				new MirrorBoneSetting("J_L_Elbow", "J_R_Elbow"),
				new MirrorBoneSetting("J_L_ForeArm_00_tw", "J_R_ForeArm_00_tw"),
				new MirrorBoneSetting("J_L_Sode_A00", "J_R_Sode_A00"),
				new MirrorBoneSetting("J_L_Sode_A01", "J_R_Sode_A01"),
				new MirrorBoneSetting("J_L_Sode_B00", "J_R_Sode_B00"),
				new MirrorBoneSetting("J_L_Sode_B01", "J_R_Sode_B01"),
				new MirrorBoneSetting("J_L_Sode_C00", "J_R_Sode_C00"),
				new MirrorBoneSetting("J_L_Sode_C01", "J_R_Sode_C01"),
				new MirrorBoneSetting("J_L_Sode_D00", "J_R_Sode_D00"),
				new MirrorBoneSetting("J_L_Sode_D01", "J_R_Sode_D01"),
				new MirrorBoneSetting("J_L_Arm_00_tw", "J_R_Arm_00_tw"),
				new MirrorBoneSetting("J_L_Sode_E00", "J_R_Sode_E00"),

				new MirrorBoneSetting("J_L_HairFront_00", "J_R_HairFront_00"),
				new MirrorBoneSetting("J_L_HairFront_01", "J_R_HairFront_01"),
				new MirrorBoneSetting("J_L_HairSide2_00", "J_R_HairSide2_00"),
				new MirrorBoneSetting("J_L_HairSide2_01", "J_R_HairSide2_01"),
				new MirrorBoneSetting("J_L_HairSide_00", "J_R_HairSide_00"),
				new MirrorBoneSetting("J_L_HairSide_01", "J_R_HairSide_01"),
				new MirrorBoneSetting("J_L_HairSide_02", "J_R_HairSide_02"),
				new MirrorBoneSetting("J_L_HairTail_00", "J_R_HairTail_00"),
				new MirrorBoneSetting("J_L_HairTail_01", "J_R_HairTail_01"),
				new MirrorBoneSetting("J_L_HairTail_02", "J_R_HairTail_02"),
				new MirrorBoneSetting("J_L_HairTail_03", "J_R_HairTail_03"),
				new MirrorBoneSetting("J_L_HeadRibbon_00", "J_R_HeadRibbon_00"),
				new MirrorBoneSetting("J_L_HeadRibbon_01", "J_R_HeadRibbon_01"),
				new MirrorBoneSetting("J_L_HeadRibbon_02", "J_R_HeadRibbon_02"),
				new MirrorBoneSetting("J_L_HeadRibbon_03", "J_R_HeadRibbon_03"),

				// Rigjht
				new MirrorBoneSetting ("Character1_RightUpLeg", "Character1_LeftUpLeg"),
				new MirrorBoneSetting ("Character1_RightLeg", "Character1_LeftLeg"),
				new MirrorBoneSetting ("Character1_RightFoot", "Character1_LeftFoot"),
				new MirrorBoneSetting ("Character1_RightToBase", "Character1_LeftToBase"),

				new MirrorBoneSetting ("J_R_knee", "J_L_knee"),
				new MirrorBoneSetting ("J_R_Skirt_00", "J_L_Skirt_00"),
				new MirrorBoneSetting ("J_R_Skirt_01", "J_L_Skirt_01"),
				new MirrorBoneSetting ("J_R_Skirt_02", "J_L_Skirt_02"),
				new MirrorBoneSetting ("J_R_SkirtBack_01", "J_L_Skirt_01"),
				new MirrorBoneSetting ("J_R_SkirtBack_02", "J_L_Skirt_02"),

				new MirrorBoneSetting ("Character1_RightShoulder", "Character1_LeftShoulder"),
				new MirrorBoneSetting ("Character1_RightArm", "Character1_LeftArm"),
				new MirrorBoneSetting ("Character1_RightForeArm", "Character1_LeftForeArm"),
				new MirrorBoneSetting ("Character1_RightHand", "Character1_LeftHand"),
				new MirrorBoneSetting ("Character1_RightHandIndex1", "Character1_LeftHandIndex1"),
				new MirrorBoneSetting ("Character1_RightHandIndex2", "Character1_LeftHandIndex2"),
				new MirrorBoneSetting ("Character1_RightHandIndex3", "Character1_LeftHandIndex3"),
				new MirrorBoneSetting ("Character1_RightHandMiddle1", "Character1_LeftHandMiddle1"),
				new MirrorBoneSetting ("Character1_RightHandMiddle2", "Character1_LeftHandMiddle2"),
				new MirrorBoneSetting ("Character1_RightHandMiddle3", "Character1_LeftHandMiddle3"),
				new MirrorBoneSetting ("Character1_RightHandPinky1", "Character1_LeftHandPinky1"),
				new MirrorBoneSetting ("Character1_RightHandPinky2", "Character1_LeftHandPinky2"),
				new MirrorBoneSetting ("Character1_RightHandPinky3", "Character1_LeftHandPinky3"),
				new MirrorBoneSetting ("Character1_RightHandRing1", "Character1_LeftHandRing1"),
				new MirrorBoneSetting ("Character1_RightHandRing2", "Character1_LeftHandRing2"),
				new MirrorBoneSetting ("Character1_RightHandRing3", "Character1_LeftHandRing3"),
				new MirrorBoneSetting ("Character1_RightHandThumb1", "Character1_LeftHandThumb1"),
				new MirrorBoneSetting ("Character1_RightHandThumb2", "Character1_LeftHandThumb2"),
				new MirrorBoneSetting ("Character1_RightHandThumb3", "Character1_LeftHandThumb3"),
				new MirrorBoneSetting ("Character1_RightHandThumb4", "Character1_LeftHandThumb4"),

				new MirrorBoneSetting("bone_eye_R", "bone_eye_L"),

				new MirrorBoneSetting("J_R_Elbow", "J_L_Elbow"),
				new MirrorBoneSetting("J_R_ForeArm_00_tw", "J_L_ForeArm_00_tw"),
				new MirrorBoneSetting("J_R_Sode_A00", "J_L_Sode_A00"),
				new MirrorBoneSetting("J_R_Sode_A01", "J_L_Sode_A01"),
				new MirrorBoneSetting("J_R_Sode_B00", "J_L_Sode_B00"),
				new MirrorBoneSetting("J_R_Sode_B01", "J_L_Sode_B01"),
				new MirrorBoneSetting("J_R_Sode_C00", "J_L_Sode_C00"),
				new MirrorBoneSetting("J_R_Sode_C01", "J_L_Sode_C01"),
				new MirrorBoneSetting("J_R_Sode_D00", "J_L_Sode_D00"),
				new MirrorBoneSetting("J_R_Sode_D01", "J_L_Sode_D01"),
				new MirrorBoneSetting("J_R_Arm_00_tw", "J_L_Arm_00_tw"),
				new MirrorBoneSetting("J_R_Sode_E00", "J_L_Sode_E00"),

				new MirrorBoneSetting("J_R_HairFront_00", "J_L_HairFront_00"),
				new MirrorBoneSetting("J_R_HairFront_01", "J_L_HairFront_01"),
				new MirrorBoneSetting("J_R_HairSide2_00", "J_L_HairSide2_00"),
				new MirrorBoneSetting("J_R_HairSide2_01", "J_L_HairSide2_01"),
				new MirrorBoneSetting("J_R_HairSide_00", "J_L_HairSide_00"),
				new MirrorBoneSetting("J_R_HairSide_01", "J_L_HairSide_01"),
				new MirrorBoneSetting("J_R_HairSide_02", "J_L_HairSide_02"),
				new MirrorBoneSetting("J_R_HairTail_00", "J_L_HairTail_00"),
				new MirrorBoneSetting("J_R_HairTail_01", "J_L_HairTail_01"),
				new MirrorBoneSetting("J_R_HairTail_02", "J_L_HairTail_02"),
				new MirrorBoneSetting("J_R_HairTail_03", "J_L_HairTail_03"),
				new MirrorBoneSetting("J_R_HeadRibbon_00", "J_L_HeadRibbon_00"),
				new MirrorBoneSetting("J_R_HeadRibbon_01", "J_L_HeadRibbon_01"),
				new MirrorBoneSetting("J_R_HeadRibbon_02", "J_L_HeadRibbon_02"),
				new MirrorBoneSetting("J_R_HeadRibbon_03", "J_L_HeadRibbon_03"),
			};
		}
	}
}
