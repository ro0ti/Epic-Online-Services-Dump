using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	internal struct RegisterEventParamDefInternal : IGettable<RegisterEventParamDef>, ISettable<RegisterEventParamDef>, IDisposable
	{
		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D82")]
		public Utf8String ParamName
		{
			[Token(Token = "0x6002D5B")]
			[Address(RVA = "0x57E600", Offset = "0x57CC00", VA = "0x18057E600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D5C")]
			[Address(RVA = "0x57E670", Offset = "0x57CC70", VA = "0x18057E670")]
			set
			{
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x0000BB34 File Offset: 0x00009D34
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D83")]
		public AntiCheatCommonEventParamType ParamType
		{
			[Token(Token = "0x6002D5D")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			get
			{
				return AntiCheatCommonEventParamType.Invalid;
			}
			[Token(Token = "0x6002D5E")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x57E4D0", Offset = "0x57CAD0", VA = "0x18057E4D0", Slot = "5")]
		public void Set(ref RegisterEventParamDef other)
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x57E540", Offset = "0x57CB40", VA = "0x18057E540", Slot = "6")]
		public void Set(ref RegisterEventParamDef? other)
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x57E460", Offset = "0x57CA60", VA = "0x18057E460", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x57E4B0", Offset = "0x57CAB0", VA = "0x18057E4B0", Slot = "4")]
		public void Get(out RegisterEventParamDef output)
		{
		}

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ParamName;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x8")]
		private AntiCheatCommonEventParamType m_ParamType;
	}
}
