using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public struct SessionDetailsAttribute
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00003C8C File Offset: 0x00001E8C
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000236")]
		public AttributeData? Data
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00003CA4 File Offset: 0x00001EA4
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000237")]
		public SessionAttributeAdvertisementType AdvertisementType
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return SessionAttributeAdvertisementType.DontAdvertise;
			}
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x4C7120", Offset = "0x4C5720", VA = "0x1804C7120")]
		internal void Set(ref SessionDetailsAttributeInternal other)
		{
		}
	}
}
