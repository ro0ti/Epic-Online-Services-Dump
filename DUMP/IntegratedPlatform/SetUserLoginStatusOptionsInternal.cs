using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	internal struct SetUserLoginStatusOptionsInternal : ISettable<SetUserLoginStatusOptions>, IDisposable
	{
		// Token: 0x1700091F RID: 2335
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091F")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x5510C0", Offset = "0x54F6C0", VA = "0x1805510C0")]
			set
			{
			}
		}

		// Token: 0x17000920 RID: 2336
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000920")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x551060", Offset = "0x54F660", VA = "0x180551060")]
			set
			{
			}
		}

		// Token: 0x17000921 RID: 2337
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000921")]
		public LoginStatus CurrentLoginStatus
		{
			[Token(Token = "0x6002046")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x550F90", Offset = "0x54F590", VA = "0x180550F90", Slot = "4")]
		public void Set(ref SetUserLoginStatusOptions other)
		{
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x550E60", Offset = "0x54F460", VA = "0x180550E60", Slot = "5")]
		public void Set(ref SetUserLoginStatusOptions? other)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x550E00", Offset = "0x54F400", VA = "0x180550E00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformType;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalPlatformUserId;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x18")]
		private LoginStatus m_CurrentLoginStatus;
	}
}
