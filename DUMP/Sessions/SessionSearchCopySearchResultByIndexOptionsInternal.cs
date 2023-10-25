using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	internal struct SessionSearchCopySearchResultByIndexOptionsInternal : ISettable<SessionSearchCopySearchResultByIndexOptions>, IDisposable
	{
		// Token: 0x1700028C RID: 652
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700028C")]
		public uint SessionIndex
		{
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SessionSearchCopySearchResultByIndexOptions other)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x4CBEB0", Offset = "0x4CA4B0", VA = "0x1804CBEB0", Slot = "5")]
		public void Set(ref SessionSearchCopySearchResultByIndexOptions? other)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x4")]
		private uint m_SessionIndex;
	}
}
