using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	internal struct DesktopCrossplayStatusInfoInternal : IGettable<DesktopCrossplayStatusInfo>, ISettable<DesktopCrossplayStatusInfo>, IDisposable
	{
		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x0000C224 File Offset: 0x0000A424
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DE2")]
		public DesktopCrossplayStatus Status
		{
			[Token(Token = "0x6002ECD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return DesktopCrossplayStatus.Ok;
			}
			[Token(Token = "0x6002ECE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x0000C23C File Offset: 0x0000A43C
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DE3")]
		public int ServiceInitResult
		{
			[Token(Token = "0x6002ECF")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002ED0")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x570300", Offset = "0x56E900", VA = "0x180570300", Slot = "5")]
		public void Set(ref DesktopCrossplayStatusInfo other)
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x570290", Offset = "0x56E890", VA = "0x180570290", Slot = "6")]
		public void Set(ref DesktopCrossplayStatusInfo? other)
		{
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x570280", Offset = "0x56E880", VA = "0x180570280", Slot = "4")]
		public void Get(out DesktopCrossplayStatusInfo output)
		{
		}

		// Token: 0x040014E6 RID: 5350
		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x0")]
		private DesktopCrossplayStatus m_Status;

		// Token: 0x040014E7 RID: 5351
		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x4")]
		private int m_ServiceInitResult;
	}
}
