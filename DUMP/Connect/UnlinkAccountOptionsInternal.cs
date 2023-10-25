using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	internal struct UnlinkAccountOptionsInternal : ISettable<UnlinkAccountOptions>, IDisposable
	{
		// Token: 0x17000BE6 RID: 3046
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE6")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028F6")]
			[Address(RVA = "0x569600", Offset = "0x567C00", VA = "0x180569600")]
			set
			{
			}
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x569500", Offset = "0x567B00", VA = "0x180569500", Slot = "4")]
		public void Set(ref UnlinkAccountOptions other)
		{
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x569560", Offset = "0x567B60", VA = "0x180569560", Slot = "5")]
		public void Set(ref UnlinkAccountOptions? other)
		{
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x5694B0", Offset = "0x567AB0", VA = "0x1805694B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
