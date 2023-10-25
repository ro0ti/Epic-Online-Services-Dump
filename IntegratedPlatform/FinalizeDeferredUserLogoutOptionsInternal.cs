using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	internal struct FinalizeDeferredUserLogoutOptionsInternal : ISettable<FinalizeDeferredUserLogoutOptions>, IDisposable
	{
		// Token: 0x17000911 RID: 2321
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000911")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x5239A0", Offset = "0x521FA0", VA = "0x1805239A0")]
			set
			{
			}
		}

		// Token: 0x17000912 RID: 2322
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000912")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x523940", Offset = "0x521F40", VA = "0x180523940")]
			set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000913")]
		public LoginStatus ExpectedLoginStatus
		{
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x523870", Offset = "0x521E70", VA = "0x180523870", Slot = "4")]
		public void Set(ref FinalizeDeferredUserLogoutOptions other)
		{
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x523740", Offset = "0x521D40", VA = "0x180523740", Slot = "5")]
		public void Set(ref FinalizeDeferredUserLogoutOptions? other)
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x5236E0", Offset = "0x521CE0", VA = "0x1805236E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformType;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalPlatformUserId;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x18")]
		private LoginStatus m_ExpectedLoginStatus;
	}
}
