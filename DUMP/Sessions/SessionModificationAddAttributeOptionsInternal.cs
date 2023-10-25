using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	internal struct SessionModificationAddAttributeOptionsInternal : ISettable<SessionModificationAddAttributeOptions>, IDisposable
	{
		// Token: 0x17000279 RID: 633
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000279")]
		public AttributeData? SessionAttribute
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x4CAC80", Offset = "0x4C9280", VA = "0x1804CAC80")]
			set
			{
			}
		}

		// Token: 0x1700027A RID: 634
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700027A")]
		public SessionAttributeAdvertisementType AdvertisementType
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x4CABD0", Offset = "0x4C91D0", VA = "0x1804CABD0", Slot = "4")]
		public void Set(ref SessionModificationAddAttributeOptions other)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x4CAAA0", Offset = "0x4C90A0", VA = "0x1804CAAA0", Slot = "5")]
		public void Set(ref SessionModificationAddAttributeOptions? other)
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x4CAA50", Offset = "0x4C9050", VA = "0x1804CAA50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionAttribute;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x10")]
		private SessionAttributeAdvertisementType m_AdvertisementType;
	}
}
