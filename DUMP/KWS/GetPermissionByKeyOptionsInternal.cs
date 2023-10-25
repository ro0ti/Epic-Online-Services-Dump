using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	internal struct GetPermissionByKeyOptionsInternal : ISettable<GetPermissionByKeyOptions>, IDisposable
	{
		// Token: 0x170008C9 RID: 2249
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008C9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x523EE0", Offset = "0x5224E0", VA = "0x180523EE0")]
			set
			{
			}
		}

		// Token: 0x170008CA RID: 2250
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008CA")]
		public Utf8String Key
		{
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x523E80", Offset = "0x522480", VA = "0x180523E80")]
			set
			{
			}
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x523CB0", Offset = "0x5222B0", VA = "0x180523CB0", Slot = "4")]
		public void Set(ref GetPermissionByKeyOptions other)
		{
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x523D70", Offset = "0x522370", VA = "0x180523D70", Slot = "5")]
		public void Set(ref GetPermissionByKeyOptions? other)
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x523C50", Offset = "0x522250", VA = "0x180523C50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Key;
	}
}
