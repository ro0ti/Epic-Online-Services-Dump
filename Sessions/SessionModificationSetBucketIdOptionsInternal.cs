using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	internal struct SessionModificationSetBucketIdOptionsInternal : ISettable<SessionModificationSetBucketIdOptions>, IDisposable
	{
		// Token: 0x17000280 RID: 640
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000280")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x4CB150", Offset = "0x4C9750", VA = "0x1804CB150")]
			set
			{
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x4CB050", Offset = "0x4C9650", VA = "0x1804CB050", Slot = "4")]
		public void Set(ref SessionModificationSetBucketIdOptions other)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x4CB0B0", Offset = "0x4C96B0", VA = "0x1804CB0B0", Slot = "5")]
		public void Set(ref SessionModificationSetBucketIdOptions? other)
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x4CB000", Offset = "0x4C9600", VA = "0x1804CB000", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_BucketId;
	}
}
