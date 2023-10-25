using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000774 RID: 1908
	[Token(Token = "0x2000774")]
	internal struct PlayerStatInfoInternal : IGettable<PlayerStatInfo>, ISettable<PlayerStatInfo>, IDisposable
	{
		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC8")]
		public Utf8String Name
		{
			[Token(Token = "0x600311F")]
			[Address(RVA = "0x58B9A0", Offset = "0x589FA0", VA = "0x18058B9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003120")]
			[Address(RVA = "0x58BA10", Offset = "0x58A010", VA = "0x18058BA10")]
			set
			{
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC9")]
		public int CurrentValue
		{
			[Token(Token = "0x6003121")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003122")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0000CA94 File Offset: 0x0000AC94
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECA")]
		public int ThresholdValue
		{
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x58B820", Offset = "0x589E20", VA = "0x18058B820", Slot = "5")]
		public void Set(ref PlayerStatInfo other)
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x58B8B0", Offset = "0x589EB0", VA = "0x18058B8B0", Slot = "6")]
		public void Set(ref PlayerStatInfo? other)
		{
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x58B7B0", Offset = "0x589DB0", VA = "0x18058B7B0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x58B800", Offset = "0x589E00", VA = "0x18058B800", Slot = "4")]
		public void Get(out PlayerStatInfo output)
		{
		}

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Name;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x10")]
		private int m_CurrentValue;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x14")]
		private int m_ThresholdValue;
	}
}
