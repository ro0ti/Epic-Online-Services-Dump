using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public struct SessionModificationAddAttributeOptions
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000277")]
		public AttributeData? SessionAttribute
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00003FD4 File Offset: 0x000021D4
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000278")]
		public SessionAttributeAdvertisementType AdvertisementType
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return SessionAttributeAdvertisementType.DontAdvertise;
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
