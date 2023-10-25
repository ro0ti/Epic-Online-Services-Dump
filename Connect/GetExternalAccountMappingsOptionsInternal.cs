using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	internal struct GetExternalAccountMappingsOptionsInternal : ISettable<GetExternalAccountMappingsOptions>, IDisposable
	{
		// Token: 0x17000B87 RID: 2951
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B87")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027AC")]
			[Address(RVA = "0x55B0B0", Offset = "0x5596B0", VA = "0x18055B0B0")]
			set
			{
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B88")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x60027AD")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B89")]
		public Utf8String TargetExternalUserId
		{
			[Token(Token = "0x60027AE")]
			[Address(RVA = "0x55B110", Offset = "0x559710", VA = "0x18055B110")]
			set
			{
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x55AFE0", Offset = "0x5595E0", VA = "0x18055AFE0", Slot = "4")]
		public void Set(ref GetExternalAccountMappingsOptions other)
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x55AEB0", Offset = "0x5594B0", VA = "0x18055AEB0", Slot = "5")]
		public void Set(ref GetExternalAccountMappingsOptions? other)
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x55AE50", Offset = "0x559450", VA = "0x18055AE50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x10")]
		private ExternalAccountType m_AccountIdType;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetExternalUserId;
	}
}
