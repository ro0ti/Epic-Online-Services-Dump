using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E7 RID: 1511
	[Token(Token = "0x20005E7")]
	internal struct SetCustomInviteOptionsInternal : ISettable<SetCustomInviteOptions>, IDisposable
	{
		// Token: 0x17000B4A RID: 2890
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B4A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026D8")]
			[Address(RVA = "0x5685E0", Offset = "0x566BE0", VA = "0x1805685E0")]
			set
			{
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B4B")]
		public Utf8String Payload
		{
			[Token(Token = "0x60026D9")]
			[Address(RVA = "0x568640", Offset = "0x566C40", VA = "0x180568640")]
			set
			{
			}
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x568520", Offset = "0x566B20", VA = "0x180568520", Slot = "4")]
		public void Set(ref SetCustomInviteOptions other)
		{
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x568410", Offset = "0x566A10", VA = "0x180568410", Slot = "5")]
		public void Set(ref SetCustomInviteOptions? other)
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x5683B0", Offset = "0x5669B0", VA = "0x1805683B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Payload;
	}
}
