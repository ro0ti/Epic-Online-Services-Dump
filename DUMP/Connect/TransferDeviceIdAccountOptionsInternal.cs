using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	internal struct TransferDeviceIdAccountOptionsInternal : ISettable<TransferDeviceIdAccountOptions>, IDisposable
	{
		// Token: 0x17000BDB RID: 3035
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDB")]
		public ProductUserId PrimaryLocalUserId
		{
			[Token(Token = "0x60028DB")]
			[Address(RVA = "0x568EE0", Offset = "0x5674E0", VA = "0x180568EE0")]
			set
			{
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDC")]
		public ProductUserId LocalDeviceUserId
		{
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0x568E80", Offset = "0x567480", VA = "0x180568E80")]
			set
			{
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDD")]
		public ProductUserId ProductUserIdToPreserve
		{
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0x568F40", Offset = "0x567540", VA = "0x180568F40")]
			set
			{
			}
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x568D80", Offset = "0x567380", VA = "0x180568D80", Slot = "4")]
		public void Set(ref TransferDeviceIdAccountOptions other)
		{
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x568C20", Offset = "0x567220", VA = "0x180568C20", Slot = "5")]
		public void Set(ref TransferDeviceIdAccountOptions? other)
		{
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x568BB0", Offset = "0x5671B0", VA = "0x180568BB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PrimaryLocalUserId;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalDeviceUserId;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ProductUserIdToPreserve;
	}
}
