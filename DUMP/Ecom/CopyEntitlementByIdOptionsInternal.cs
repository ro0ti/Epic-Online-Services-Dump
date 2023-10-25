using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	internal struct CopyEntitlementByIdOptionsInternal : ISettable<CopyEntitlementByIdOptions>, IDisposable
	{
		// Token: 0x170009ED RID: 2541
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009ED")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x53D980", Offset = "0x53BF80", VA = "0x18053D980")]
			set
			{
			}
		}

		// Token: 0x170009EE RID: 2542
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009EE")]
		public Utf8String EntitlementId
		{
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x53D920", Offset = "0x53BF20", VA = "0x18053D920")]
			set
			{
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x53D860", Offset = "0x53BE60", VA = "0x18053D860", Slot = "4")]
		public void Set(ref CopyEntitlementByIdOptions other)
		{
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x53D750", Offset = "0x53BD50", VA = "0x18053D750", Slot = "5")]
		public void Set(ref CopyEntitlementByIdOptions? other)
		{
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x53D6F0", Offset = "0x53BCF0", VA = "0x18053D6F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementId;
	}
}
