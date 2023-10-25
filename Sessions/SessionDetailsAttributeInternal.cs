using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	internal struct SessionDetailsAttributeInternal : IGettable<SessionDetailsAttribute>, ISettable<SessionDetailsAttribute>, IDisposable
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00003CBC File Offset: 0x00001EBC
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000238")]
		public AttributeData? Data
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x4C7020", Offset = "0x4C5620", VA = "0x1804C7020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x4C70B0", Offset = "0x4C56B0", VA = "0x1804C70B0")]
			set
			{
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00003CD4 File Offset: 0x00001ED4
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000239")]
		public SessionAttributeAdvertisementType AdvertisementType
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return SessionAttributeAdvertisementType.DontAdvertise;
			}
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x4C6E40", Offset = "0x4C5440", VA = "0x1804C6E40", Slot = "5")]
		public void Set(ref SessionDetailsAttribute other)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x4C6EF0", Offset = "0x4C54F0", VA = "0x1804C6EF0", Slot = "6")]
		public void Set(ref SessionDetailsAttribute? other)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x4C6DC0", Offset = "0x4C53C0", VA = "0x1804C6DC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x4C6E10", Offset = "0x4C5410", VA = "0x1804C6E10", Slot = "4")]
		public void Get(out SessionDetailsAttribute output)
		{
		}

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Data;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x10")]
		private SessionAttributeAdvertisementType m_AdvertisementType;
	}
}
