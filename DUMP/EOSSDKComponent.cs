using System;
using System.Collections.Generic;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Platform;

using UnityEngine;

namespace Epic.OnlineServices
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class EOSSDKComponent : MonoBehaviour
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630")]
		private void Awake()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4A2C50", Offset = "0x4A1250", VA = "0x1804A2C50")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4A30C0", Offset = "0x4A16C0", VA = "0x1804A30C0")]
		private void Start()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4A2610", Offset = "0x4A0C10", VA = "0x1804A2610")]
		private void ConnectToServices()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4A3E80", Offset = "0x4A2480", VA = "0x1804A3E80")]
		private void UnlinkAccount()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4A29C0", Offset = "0x4A0FC0", VA = "0x1804A29C0")]
		private void LinkAccount(ContinuanceToken token, ProductUserId userId)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4A2540", Offset = "0x4A0B40", VA = "0x1804A2540")]
		private void ConnectAchievements()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4A4140", Offset = "0x4A2740", VA = "0x1804A4140")]
		private void Update()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4A2BF0", Offset = "0x4A11F0", VA = "0x1804A2BF0")]
		private WeakReference NewWeakThis()
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4A3BB0", Offset = "0x4A21B0", VA = "0x1804A3BB0")]
		private static EOSSDKComponent StrongThisFromClientData(object data)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4A2BA0", Offset = "0x4A11A0", VA = "0x1804A2BA0")]
		private QueryPlayerAchievementsOptions MakeQueryPlayerAchievementsOptions(ProductUserId productUserId)
		{
			return default(QueryPlayerAchievementsOptions);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4A2EB0", Offset = "0x4A14B0", VA = "0x1804A2EB0")]
		private void QueryPlayerAchievements(ProductUserId productUserId, OnQueryPlayerAchievementsCompleteCallback callback)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4A2B50", Offset = "0x4A1150", VA = "0x1804A2B50")]
		private static CopyPlayerAchievementByIndexOptions MakeCopyPlayerAchievementByIndexOptions(ProductUserId productUserId)
		{
			return default(CopyPlayerAchievementByIndexOptions);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4A1F70", Offset = "0x4A0570", VA = "0x1804A1F70")]
		private void CacheAllPlayerAchievements(ProductUserId productUserId)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4A3C90", Offset = "0x4A2290", VA = "0x1804A3C90")]
		private static Utf8String ToUtf8(string input)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4A2D30", Offset = "0x4A1330", VA = "0x1804A2D30")]
		public void QueryAchievementUnlocked(string achievementId, Action<bool> onComplete)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4A3FF0", Offset = "0x4A25F0", VA = "0x1804A3FF0")]
		public void UnlockAchievement(string achievementId, OnUnlockAchievementsCompleteCallback callback)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4A4200", Offset = "0x4A2800", VA = "0x1804A4200")]
		public EOSSDKComponent()
		{
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		private const string productId = "69319b4c02474716b0f75d8da63fed24";

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		private const string winClientCredentialsId = "xyza7891J2mdamtbGDM2o4Vgrj2ThVUz";

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		private const string macClientCredentialsId = "xyza78916t1YrmvHiAYLwiRx3v9o9vyo";

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		private const string winClientCredentialsSecret = "Pt0o0BuPGCNPjk/XdCq/oE1RKnZZw4/kIxrwlV7srhU";

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		private const string macClientCredientialsSecret = "SoFcZvC2Y3v9TuRmeUe+oOcMnu62mNuTrFHIagvLG7c";

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		private const string winApplicationId = "fghi4567G08NhtuVMW3ySZ5iOzi96Cqb";

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		private const string macApplicationId = "fghi4567pf1rlfCdJbsLIROgGsvRy0mt";

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		private const string devSandboxId = "p-957jn9l578f8ztmayvwp4vvq747ljb";

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		private const string stageSandboxId = "p-p82jx39uu43adkw5ww2dt7ca48dw7g";

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		private const string liveSandboxId = "c9340fb1d3984f4f8f5bbafaa0ea066d";

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		private const string devDeploymentId = "b5a3584032e44a8ea6e9a3cded1fa341";

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		private const string stageDeploymentId = "599d0d06394f4b26b5c093e06fa2e186";

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		private const string liveDeploymentId = "518f158b27f24c2e890cb97f2809b3fc";

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		public string m_ProductName;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		private string m_ProductVersion;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		public LoginCredentialType m_LoginCredentialType;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		private string m_LoginCredentialToken;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		private EpicAccountId m_LocalUserId;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		private ProductUserId m_ProductUserId;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x50")]
		private ContinuanceToken m_LoginContinuanceToken;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x58")]
		private List<PlayerAchievement> _playerAchievements;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		private static PlatformInterface s_PlatformInterface;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		private const float c_PlatformTickInterval = 0.1f;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x60")]
		private float m_PlatformTickTimer;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x68")]
		private AchievementsInterface _achievementsInterface;
	}
}
