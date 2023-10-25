using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	internal struct LogPlayerTakeDamageOptionsInternal : ISettable<LogPlayerTakeDamageOptions>, IDisposable
	{
		// Token: 0x17000D23 RID: 3363
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D23")]
		public IntPtr VictimPlayerHandle
		{
			[Token(Token = "0x6002C95")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D24")]
		public Vec3f? VictimPlayerPosition
		{
			[Token(Token = "0x6002C96")]
			[Address(RVA = "0x575C40", Offset = "0x574240", VA = "0x180575C40")]
			set
			{
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D25")]
		public Quat? VictimPlayerViewRotation
		{
			[Token(Token = "0x6002C97")]
			[Address(RVA = "0x575CB0", Offset = "0x5742B0", VA = "0x180575CB0")]
			set
			{
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D26")]
		public IntPtr AttackerPlayerHandle
		{
			[Token(Token = "0x6002C98")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			set
			{
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D27")]
		public Vec3f? AttackerPlayerPosition
		{
			[Token(Token = "0x6002C99")]
			[Address(RVA = "0x575920", Offset = "0x573F20", VA = "0x180575920")]
			set
			{
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D28")]
		public Quat? AttackerPlayerViewRotation
		{
			[Token(Token = "0x6002C9A")]
			[Address(RVA = "0x575990", Offset = "0x573F90", VA = "0x180575990")]
			set
			{
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D29")]
		public bool IsHitscanAttack
		{
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x575B60", Offset = "0x574160", VA = "0x180575B60")]
			set
			{
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2A")]
		public bool HasLineOfSight
		{
			[Token(Token = "0x6002C9C")]
			[Address(RVA = "0x575A90", Offset = "0x574090", VA = "0x180575A90")]
			set
			{
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2B")]
		public bool IsCriticalHit
		{
			[Token(Token = "0x6002C9D")]
			[Address(RVA = "0x575B00", Offset = "0x574100", VA = "0x180575B00")]
			set
			{
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2C")]
		public uint HitBoneId_DEPRECATED
		{
			[Token(Token = "0x6002C9E")]
			[Address(RVA = "0x53BF60", Offset = "0x53A560", VA = "0x18053BF60")]
			set
			{
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2D")]
		public float DamageTaken
		{
			[Token(Token = "0x6002C9F")]
			[Address(RVA = "0x575A80", Offset = "0x574080", VA = "0x180575A80")]
			set
			{
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2E")]
		public float HealthRemaining
		{
			[Token(Token = "0x6002CA0")]
			[Address(RVA = "0x575AF0", Offset = "0x5740F0", VA = "0x180575AF0")]
			set
			{
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D2F")]
		public AntiCheatCommonPlayerTakeDamageSource DamageSource
		{
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x575A70", Offset = "0x574070", VA = "0x180575A70")]
			set
			{
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D30")]
		public AntiCheatCommonPlayerTakeDamageType DamageType
		{
			[Token(Token = "0x6002CA2")]
			[Address(RVA = "0x3E4610", Offset = "0x3E2C10", VA = "0x1803E4610")]
			set
			{
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D31")]
		public AntiCheatCommonPlayerTakeDamageResult DamageResult
		{
			[Token(Token = "0x6002CA3")]
			[Address(RVA = "0x3E45A0", Offset = "0x3E2BA0", VA = "0x1803E45A0")]
			set
			{
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D32")]
		public LogPlayerUseWeaponData? PlayerUseWeaponData
		{
			[Token(Token = "0x6002CA4")]
			[Address(RVA = "0x575BC0", Offset = "0x5741C0", VA = "0x180575BC0")]
			set
			{
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D33")]
		public uint TimeSincePlayerUseWeaponMs
		{
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x575C30", Offset = "0x574230", VA = "0x180575C30")]
			set
			{
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D34")]
		public Vec3f? DamagePosition
		{
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x575A00", Offset = "0x574000", VA = "0x180575A00")]
			set
			{
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x575040", Offset = "0x573640", VA = "0x180575040", Slot = "4")]
		public void Set(ref LogPlayerTakeDamageOptions other)
		{
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x5753E0", Offset = "0x5739E0", VA = "0x1805753E0", Slot = "5")]
		public void Set(ref LogPlayerTakeDamageOptions? other)
		{
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x574FA0", Offset = "0x5735A0", VA = "0x180574FA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013C1 RID: 5057
		[Token(Token = "0x40013C1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_VictimPlayerHandle;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_VictimPlayerPosition;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_VictimPlayerViewRotation;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_AttackerPlayerHandle;

		// Token: 0x040013C6 RID: 5062
		[Token(Token = "0x40013C6")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_AttackerPlayerPosition;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_AttackerPlayerViewRotation;

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0x38")]
		private int m_IsHitscanAttack;

		// Token: 0x040013C9 RID: 5065
		[Token(Token = "0x40013C9")]
		[FieldOffset(Offset = "0x3C")]
		private int m_HasLineOfSight;

		// Token: 0x040013CA RID: 5066
		[Token(Token = "0x40013CA")]
		[FieldOffset(Offset = "0x40")]
		private int m_IsCriticalHit;

		// Token: 0x040013CB RID: 5067
		[Token(Token = "0x40013CB")]
		[FieldOffset(Offset = "0x44")]
		private uint m_HitBoneId_DEPRECATED;

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x48")]
		private float m_DamageTaken;

		// Token: 0x040013CD RID: 5069
		[Token(Token = "0x40013CD")]
		[FieldOffset(Offset = "0x4C")]
		private float m_HealthRemaining;

		// Token: 0x040013CE RID: 5070
		[Token(Token = "0x40013CE")]
		[FieldOffset(Offset = "0x50")]
		private AntiCheatCommonPlayerTakeDamageSource m_DamageSource;

		// Token: 0x040013CF RID: 5071
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x54")]
		private AntiCheatCommonPlayerTakeDamageType m_DamageType;

		// Token: 0x040013D0 RID: 5072
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x58")]
		private AntiCheatCommonPlayerTakeDamageResult m_DamageResult;

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x60")]
		private IntPtr m_PlayerUseWeaponData;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x68")]
		private uint m_TimeSincePlayerUseWeaponMs;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x70")]
		private IntPtr m_DamagePosition;
	}
}
