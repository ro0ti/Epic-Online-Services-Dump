using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	internal struct CopyProductUserExternalAccountByAccountTypeOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountTypeOptions>, IDisposable
	{
		// Token: 0x17000B59 RID: 2905
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B59")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600272C")]
			[Address(RVA = "0x558050", Offset = "0x556650", VA = "0x180558050")]
			set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B5A")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600272D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x557F00", Offset = "0x556500", VA = "0x180557F00", Slot = "4")]
		public void Set(ref CopyProductUserExternalAccountByAccountTypeOptions other)
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x557F80", Offset = "0x556580", VA = "0x180557F80", Slot = "5")]
		public void Set(ref CopyProductUserExternalAccountByAccountTypeOptions? other)
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x557EB0", Offset = "0x5564B0", VA = "0x180557EB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x10")]
		private ExternalAccountType m_AccountIdType;
	}
}
