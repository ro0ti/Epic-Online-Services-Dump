using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	internal struct DeleteFileOptionsInternal : ISettable<DeleteFileOptions>, IDisposable
	{
		// Token: 0x17000549 RID: 1353
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000549")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013E9")]
			[Address(RVA = "0x4EFF40", Offset = "0x4EE540", VA = "0x1804EFF40")]
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054A")]
		public Utf8String Filename
		{
			[Token(Token = "0x60013EA")]
			[Address(RVA = "0x4EFEE0", Offset = "0x4EE4E0", VA = "0x1804EFEE0")]
			set
			{
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x4EFD10", Offset = "0x4EE310", VA = "0x1804EFD10", Slot = "4")]
		public void Set(ref DeleteFileOptions other)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x4EFDD0", Offset = "0x4EE3D0", VA = "0x1804EFDD0", Slot = "5")]
		public void Set(ref DeleteFileOptions? other)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x4EFCB0", Offset = "0x4EE2B0", VA = "0x1804EFCB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;
	}
}
