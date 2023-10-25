using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public struct LogPlayerTakeDamageOptions
	{
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x0000B4A4 File Offset: 0x000096A4
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D11")]
		public IntPtr VictimPlayerHandle
		{
			[Token(Token = "0x6002C71")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002C72")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x0000B4BC File Offset: 0x000096BC
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D12")]
		public Vec3f? VictimPlayerPosition
		{
			[Token(Token = "0x6002C73")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C74")]
			[Address(RVA = "0x575F60", Offset = "0x574560", VA = "0x180575F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x0000B4D4 File Offset: 0x000096D4
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D13")]
		public Quat? VictimPlayerViewRotation
		{
			[Token(Token = "0x6002C75")]
			[Address(RVA = "0x575E30", Offset = "0x574430", VA = "0x180575E30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x575F70", Offset = "0x574570", VA = "0x180575F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x0000B4EC File Offset: 0x000096EC
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D14")]
		public IntPtr AttackerPlayerHandle
		{
			[Token(Token = "0x6002C77")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x56BE20", Offset = "0x56A420", VA = "0x18056BE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0000B504 File Offset: 0x00009704
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D15")]
		public Vec3f? AttackerPlayerPosition
		{
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x575D20", Offset = "0x574320", VA = "0x180575D20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0x575E50", Offset = "0x574450", VA = "0x180575E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x0000B51C File Offset: 0x0000971C
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D16")]
		public Quat? AttackerPlayerViewRotation
		{
			[Token(Token = "0x6002C7B")]
			[Address(RVA = "0x575D30", Offset = "0x574330", VA = "0x180575D30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0x575E60", Offset = "0x574460", VA = "0x180575E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x0000B534 File Offset: 0x00009734
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D17")]
		public bool IsHitscanAttack
		{
			[Token(Token = "0x6002C7D")]
			[Address(RVA = "0x575DE0", Offset = "0x5743E0", VA = "0x180575DE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x575F00", Offset = "0x574500", VA = "0x180575F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x0000B54C File Offset: 0x0000974C
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D18")]
		public bool HasLineOfSight
		{
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x575DA0", Offset = "0x5743A0", VA = "0x180575DA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C80")]
			[Address(RVA = "0x575EC0", Offset = "0x5744C0", VA = "0x180575EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0000B564 File Offset: 0x00009764
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D19")]
		public bool IsCriticalHit
		{
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0x575DD0", Offset = "0x5743D0", VA = "0x180575DD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0x575EF0", Offset = "0x5744F0", VA = "0x180575EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x0000B57C File Offset: 0x0000977C
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1A")]
		public uint HitBoneId_DEPRECATED
		{
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0x575DC0", Offset = "0x5743C0", VA = "0x180575DC0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x575EE0", Offset = "0x5744E0", VA = "0x180575EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x0000B594 File Offset: 0x00009794
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1B")]
		public float DamageTaken
		{
			[Token(Token = "0x6002C85")]
			[Address(RVA = "0x575D80", Offset = "0x574380", VA = "0x180575D80")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x575EA0", Offset = "0x5744A0", VA = "0x180575EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x0000B5AC File Offset: 0x000097AC
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1C")]
		public float HealthRemaining
		{
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0x575DB0", Offset = "0x5743B0", VA = "0x180575DB0")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6002C88")]
			[Address(RVA = "0x575ED0", Offset = "0x5744D0", VA = "0x180575ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x0000B5C4 File Offset: 0x000097C4
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1D")]
		public AntiCheatCommonPlayerTakeDamageSource DamageSource
		{
			[Token(Token = "0x6002C89")]
			[Address(RVA = "0x575D70", Offset = "0x574370", VA = "0x180575D70")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonPlayerTakeDamageSource.None;
			}
			[Token(Token = "0x6002C8A")]
			[Address(RVA = "0x575E90", Offset = "0x574490", VA = "0x180575E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0000B5DC File Offset: 0x000097DC
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1E")]
		public AntiCheatCommonPlayerTakeDamageType DamageType
		{
			[Token(Token = "0x6002C8B")]
			[Address(RVA = "0x575D90", Offset = "0x574390", VA = "0x180575D90")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonPlayerTakeDamageType.None;
			}
			[Token(Token = "0x6002C8C")]
			[Address(RVA = "0x575EB0", Offset = "0x5744B0", VA = "0x180575EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x0000B5F4 File Offset: 0x000097F4
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D1F")]
		public AntiCheatCommonPlayerTakeDamageResult DamageResult
		{
			[Token(Token = "0x6002C8D")]
			[Address(RVA = "0x575D60", Offset = "0x574360", VA = "0x180575D60")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonPlayerTakeDamageResult.None;
			}
			[Token(Token = "0x6002C8E")]
			[Address(RVA = "0x575E80", Offset = "0x574480", VA = "0x180575E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x0000B60C File Offset: 0x0000980C
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D20")]
		public LogPlayerUseWeaponData? PlayerUseWeaponData
		{
			[Token(Token = "0x6002C8F")]
			[Address(RVA = "0x575DF0", Offset = "0x5743F0", VA = "0x180575DF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C90")]
			[Address(RVA = "0x575F10", Offset = "0x574510", VA = "0x180575F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x0000B624 File Offset: 0x00009824
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D21")]
		public uint TimeSincePlayerUseWeaponMs
		{
			[Token(Token = "0x6002C91")]
			[Address(RVA = "0x575E20", Offset = "0x574420", VA = "0x180575E20")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002C92")]
			[Address(RVA = "0x575F50", Offset = "0x574550", VA = "0x180575F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x0000B63C File Offset: 0x0000983C
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D22")]
		public Vec3f? DamagePosition
		{
			[Token(Token = "0x6002C93")]
			[Address(RVA = "0x575D50", Offset = "0x574350", VA = "0x180575D50")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C94")]
			[Address(RVA = "0x575E70", Offset = "0x574470", VA = "0x180575E70")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
