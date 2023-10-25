using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	internal struct CopySessionHandleByUiEventIdOptionsInternal : ISettable<CopySessionHandleByUiEventIdOptions>, IDisposable
	{
		// Token: 0x170001B5 RID: 437
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B5")]
		public ulong UiEventId
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref CopySessionHandleByUiEventIdOptions other)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x4BAF80", Offset = "0x4B9580", VA = "0x1804BAF80", Slot = "5")]
		public void Set(ref CopySessionHandleByUiEventIdOptions? other)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_UiEventId;
	}
}
