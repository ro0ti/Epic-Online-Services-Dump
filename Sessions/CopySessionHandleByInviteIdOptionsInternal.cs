using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	internal struct CopySessionHandleByInviteIdOptionsInternal : ISettable<CopySessionHandleByInviteIdOptions>, IDisposable
	{
		// Token: 0x170001B3 RID: 435
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B3")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x4BAF20", Offset = "0x4B9520", VA = "0x1804BAF20")]
			set
			{
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x4BAE20", Offset = "0x4B9420", VA = "0x1804BAE20", Slot = "4")]
		public void Set(ref CopySessionHandleByInviteIdOptions other)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4BAE80", Offset = "0x4B9480", VA = "0x1804BAE80", Slot = "5")]
		public void Set(ref CopySessionHandleByInviteIdOptions? other)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4BADD0", Offset = "0x4B93D0", VA = "0x1804BADD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;
	}
}
