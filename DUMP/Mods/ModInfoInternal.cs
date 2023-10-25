using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	internal struct ModInfoInternal : IGettable<ModInfo>, ISettable<ModInfo>, IDisposable
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000683")]
		public ModIdentifier[] Mods
		{
			[Token(Token = "0x600179A")]
			[Address(RVA = "0x518E10", Offset = "0x517410", VA = "0x180518E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600179B")]
			[Address(RVA = "0x518EA0", Offset = "0x5174A0", VA = "0x180518EA0")]
			set
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00006B6C File Offset: 0x00004D6C
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000684")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x600179C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x600179D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x518DD0", Offset = "0x5173D0", VA = "0x180518DD0", Slot = "5")]
		public void Set(ref ModInfo other)
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x518D40", Offset = "0x517340", VA = "0x180518D40", Slot = "6")]
		public void Set(ref ModInfo? other)
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x518CB0", Offset = "0x5172B0", VA = "0x180518CB0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x518D00", Offset = "0x517300", VA = "0x180518D00", Slot = "4")]
		public void Get(out ModInfo output)
		{
		}

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x4")]
		private int m_ModsCount;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Mods;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x10")]
		private ModEnumerationType m_Type;
	}
}
