using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	internal struct CopyProductUserExternalAccountByAccountIdOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountIdOptions>, IDisposable
	{
		// Token: 0x17000B55 RID: 2901
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B55")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002723")]
			[Address(RVA = "0x557E50", Offset = "0x556450", VA = "0x180557E50")]
			set
			{
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B56")]
		public Utf8String AccountId
		{
			[Token(Token = "0x6002724")]
			[Address(RVA = "0x557DF0", Offset = "0x5563F0", VA = "0x180557DF0")]
			set
			{
			}
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x557C20", Offset = "0x556220", VA = "0x180557C20", Slot = "4")]
		public void Set(ref CopyProductUserExternalAccountByAccountIdOptions other)
		{
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x557CE0", Offset = "0x5562E0", VA = "0x180557CE0", Slot = "5")]
		public void Set(ref CopyProductUserExternalAccountByAccountIdOptions? other)
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x557BC0", Offset = "0x5561C0", VA = "0x180557BC0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AccountId;
	}
}
