using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D7 RID: 1751
	[Token(Token = "0x20006D7")]
	internal struct LogPlayerUseWeaponDataInternal : IGettable<LogPlayerUseWeaponData>, ISettable<LogPlayerUseWeaponData>, IDisposable
	{
		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x0000B7BC File Offset: 0x000099BC
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4F")]
		public IntPtr PlayerHandle
		{
			[Token(Token = "0x6002CDB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002CDC")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			set
			{
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x0000B7D4 File Offset: 0x000099D4
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D50")]
		public Vec3f? PlayerPosition
		{
			[Token(Token = "0x6002CDD")]
			[Address(RVA = "0x576B50", Offset = "0x575150", VA = "0x180576B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CDE")]
			[Address(RVA = "0x576D80", Offset = "0x575380", VA = "0x180576D80")]
			set
			{
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x0000B7EC File Offset: 0x000099EC
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D51")]
		public Quat? PlayerViewRotation
		{
			[Token(Token = "0x6002CDF")]
			[Address(RVA = "0x576BD0", Offset = "0x5751D0", VA = "0x180576BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x576DF0", Offset = "0x5753F0", VA = "0x180576DF0")]
			set
			{
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0000B804 File Offset: 0x00009A04
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D52")]
		public bool IsPlayerViewZoomed
		{
			[Token(Token = "0x6002CE1")]
			[Address(RVA = "0x576AF0", Offset = "0x5750F0", VA = "0x180576AF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CE2")]
			[Address(RVA = "0x576D20", Offset = "0x575320", VA = "0x180576D20")]
			set
			{
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x0000B81C File Offset: 0x00009A1C
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D53")]
		public bool IsMeleeAttack
		{
			[Token(Token = "0x6002CE3")]
			[Address(RVA = "0x576A90", Offset = "0x575090", VA = "0x180576A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CE4")]
			[Address(RVA = "0x576CC0", Offset = "0x5752C0", VA = "0x180576CC0")]
			set
			{
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D54")]
		public Utf8String WeaponName
		{
			[Token(Token = "0x6002CE5")]
			[Address(RVA = "0x576C50", Offset = "0x575250", VA = "0x180576C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CE6")]
			[Address(RVA = "0x576E60", Offset = "0x575460", VA = "0x180576E60")]
			set
			{
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x5768D0", Offset = "0x574ED0", VA = "0x1805768D0", Slot = "5")]
		public void Set(ref LogPlayerUseWeaponData other)
		{
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x576660", Offset = "0x574C60", VA = "0x180576660", Slot = "6")]
		public void Set(ref LogPlayerUseWeaponData? other)
		{
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x5765C0", Offset = "0x574BC0", VA = "0x1805765C0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x576630", Offset = "0x574C30", VA = "0x180576630", Slot = "4")]
		public void Get(out LogPlayerUseWeaponData output)
		{
		}

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_PlayerHandle;

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlayerPosition;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlayerViewRotation;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x18")]
		private int m_IsPlayerViewZoomed;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x1C")]
		private int m_IsMeleeAttack;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_WeaponName;
	}
}
