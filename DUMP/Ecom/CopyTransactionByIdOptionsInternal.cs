using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	internal struct CopyTransactionByIdOptionsInternal : ISettable<CopyTransactionByIdOptions>, IDisposable
	{
		// Token: 0x17000A23 RID: 2595
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A23")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x53F790", Offset = "0x53DD90", VA = "0x18053F790")]
			set
			{
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A24")]
		public Utf8String TransactionId
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x53F7F0", Offset = "0x53DDF0", VA = "0x18053F7F0")]
			set
			{
			}
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x53F6D0", Offset = "0x53DCD0", VA = "0x18053F6D0", Slot = "4")]
		public void Set(ref CopyTransactionByIdOptions other)
		{
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x53F5C0", Offset = "0x53DBC0", VA = "0x18053F5C0", Slot = "5")]
		public void Set(ref CopyTransactionByIdOptions? other)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x53F560", Offset = "0x53DB60", VA = "0x18053F560", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TransactionId;
	}
}
