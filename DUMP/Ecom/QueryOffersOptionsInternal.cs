using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	internal struct QueryOffersOptionsInternal : ISettable<QueryOffersOptions>, IDisposable
	{
		// Token: 0x17000A80 RID: 2688
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A80")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002442")]
			[Address(RVA = "0x54CFE0", Offset = "0x54B5E0", VA = "0x18054CFE0")]
			set
			{
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A81")]
		public Utf8String OverrideCatalogNamespace
		{
			[Token(Token = "0x6002443")]
			[Address(RVA = "0x54D040", Offset = "0x54B640", VA = "0x18054D040")]
			set
			{
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x54CE10", Offset = "0x54B410", VA = "0x18054CE10", Slot = "4")]
		public void Set(ref QueryOffersOptions other)
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x54CED0", Offset = "0x54B4D0", VA = "0x18054CED0", Slot = "5")]
		public void Set(ref QueryOffersOptions? other)
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x54CDB0", Offset = "0x54B3B0", VA = "0x18054CDB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OverrideCatalogNamespace;
	}
}
