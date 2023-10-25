using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	internal struct RequestPermissionsOptionsInternal : ISettable<RequestPermissionsOptions>, IDisposable
	{
		// Token: 0x17000901 RID: 2305
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000901")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0x5360D0", Offset = "0x5346D0", VA = "0x1805360D0")]
			set
			{
			}
		}

		// Token: 0x17000902 RID: 2306
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000902")]
		public Utf8String[] PermissionKeys
		{
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x536130", Offset = "0x534730", VA = "0x180536130")]
			set
			{
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x536040", Offset = "0x534640", VA = "0x180536040", Slot = "4")]
		public void Set(ref RequestPermissionsOptions other)
		{
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x535F60", Offset = "0x534560", VA = "0x180535F60", Slot = "5")]
		public void Set(ref RequestPermissionsOptions? other)
		{
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x535F00", Offset = "0x534500", VA = "0x180535F00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x10")]
		private uint m_PermissionKeyCount;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_PermissionKeys;
	}
}
