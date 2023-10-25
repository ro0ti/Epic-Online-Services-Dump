using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	internal struct SessionModificationSetHostAddressOptionsInternal : ISettable<SessionModificationSetHostAddressOptions>, IDisposable
	{
		// Token: 0x17000282 RID: 642
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000282")]
		public Utf8String HostAddress
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4CB300", Offset = "0x4C9900", VA = "0x1804CB300")]
			set
			{
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x4CB200", Offset = "0x4C9800", VA = "0x1804CB200", Slot = "4")]
		public void Set(ref SessionModificationSetHostAddressOptions other)
		{
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x4CB260", Offset = "0x4C9860", VA = "0x1804CB260", Slot = "5")]
		public void Set(ref SessionModificationSetHostAddressOptions? other)
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x4CB1B0", Offset = "0x4C97B0", VA = "0x1804CB1B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_HostAddress;
	}
}
