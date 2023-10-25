using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	internal struct JoinSessionOptionsInternal : ISettable<JoinSessionOptions>, IDisposable
	{
		// Token: 0x170001F4 RID: 500
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F4")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x4BECF0", Offset = "0x4BD2F0", VA = "0x1804BECF0")]
			set
			{
			}
		}

		// Token: 0x170001F5 RID: 501
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F5")]
		public SessionDetails SessionHandle
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x4BEC90", Offset = "0x4BD290", VA = "0x1804BEC90")]
			set
			{
			}
		}

		// Token: 0x170001F6 RID: 502
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F6")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x4BEBD0", Offset = "0x4BD1D0", VA = "0x1804BEBD0")]
			set
			{
			}
		}

		// Token: 0x170001F7 RID: 503
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F7")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x4BEC30", Offset = "0x4BD230", VA = "0x1804BEC30")]
			set
			{
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x4BEA80", Offset = "0x4BD080", VA = "0x1804BEA80", Slot = "4")]
		public void Set(ref JoinSessionOptions other)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x4BE8C0", Offset = "0x4BCEC0", VA = "0x1804BE8C0", Slot = "5")]
		public void Set(ref JoinSessionOptions? other)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x4BE850", Offset = "0x4BCE50", VA = "0x1804BE850", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SessionHandle;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x20")]
		private int m_PresenceEnabled;
	}
}
