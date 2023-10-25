using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	internal struct RegisterPlatformUserOptionsInternal : ISettable<RegisterPlatformUserOptions>, IDisposable
	{
		// Token: 0x17000377 RID: 887
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000377")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x4E4680", Offset = "0x4E2C80", VA = "0x1804E4680")]
			set
			{
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x4E4580", Offset = "0x4E2B80", VA = "0x1804E4580", Slot = "4")]
		public void Set(ref RegisterPlatformUserOptions other)
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x4E45E0", Offset = "0x4E2BE0", VA = "0x1804E45E0", Slot = "5")]
		public void Set(ref RegisterPlatformUserOptions? other)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x4E4530", Offset = "0x4E2B30", VA = "0x1804E4530", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformUserId;
	}
}
