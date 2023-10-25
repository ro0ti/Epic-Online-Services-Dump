using System;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	internal struct CopyModInfoOptionsInternal : ISettable<CopyModInfoOptions>, IDisposable
	{
		// Token: 0x17000659 RID: 1625
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000659")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001734")]
			[Address(RVA = "0x508AE0", Offset = "0x5070E0", VA = "0x180508AE0")]
			set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065A")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x6001735")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x508A60", Offset = "0x507060", VA = "0x180508A60", Slot = "4")]
		public void Set(ref CopyModInfoOptions other)
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x508990", Offset = "0x506F90", VA = "0x180508990", Slot = "5")]
		public void Set(ref CopyModInfoOptions? other)
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x508940", Offset = "0x506F40", VA = "0x180508940", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x10")]
		private ModEnumerationType m_Type;
	}
}
