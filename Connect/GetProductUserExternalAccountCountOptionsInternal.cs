using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	internal struct GetProductUserExternalAccountCountOptionsInternal : ISettable<GetProductUserExternalAccountCountOptions>, IDisposable
	{
		// Token: 0x17000B8B RID: 2955
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8B")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60027B4")]
			[Address(RVA = "0x55B2C0", Offset = "0x5598C0", VA = "0x18055B2C0")]
			set
			{
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x55B260", Offset = "0x559860", VA = "0x18055B260", Slot = "4")]
		public void Set(ref GetProductUserExternalAccountCountOptions other)
		{
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x55B1C0", Offset = "0x5597C0", VA = "0x18055B1C0", Slot = "5")]
		public void Set(ref GetProductUserExternalAccountCountOptions? other)
		{
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x55B170", Offset = "0x559770", VA = "0x18055B170", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
