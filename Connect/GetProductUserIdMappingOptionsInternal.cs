using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	internal struct GetProductUserIdMappingOptionsInternal : ISettable<GetProductUserIdMappingOptions>, IDisposable
	{
		// Token: 0x17000B8F RID: 2959
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027BE")]
			[Address(RVA = "0x55B580", Offset = "0x559B80", VA = "0x18055B580")]
			set
			{
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B90")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x60027BF")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B91")]
		public ProductUserId TargetProductUserId
		{
			[Token(Token = "0x60027C0")]
			[Address(RVA = "0x55B5E0", Offset = "0x559BE0", VA = "0x18055B5E0")]
			set
			{
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x55B4B0", Offset = "0x559AB0", VA = "0x18055B4B0", Slot = "4")]
		public void Set(ref GetProductUserIdMappingOptions other)
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x55B380", Offset = "0x559980", VA = "0x18055B380", Slot = "5")]
		public void Set(ref GetProductUserIdMappingOptions? other)
		{
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x55B320", Offset = "0x559920", VA = "0x18055B320", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x10")]
		private ExternalAccountType m_AccountIdType;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetProductUserId;
	}
}
