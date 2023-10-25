using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	internal struct GetPlayerSanctionCountOptionsInternal : ISettable<GetPlayerSanctionCountOptions>, IDisposable
	{
		// Token: 0x170002C6 RID: 710
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C6")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x4D9790", Offset = "0x4D7D90", VA = "0x1804D9790")]
			set
			{
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x4D9730", Offset = "0x4D7D30", VA = "0x1804D9730", Slot = "4")]
		public void Set(ref GetPlayerSanctionCountOptions other)
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x4D9690", Offset = "0x4D7C90", VA = "0x1804D9690", Slot = "5")]
		public void Set(ref GetPlayerSanctionCountOptions? other)
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x4D9640", Offset = "0x4D7C40", VA = "0x1804D9640", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
